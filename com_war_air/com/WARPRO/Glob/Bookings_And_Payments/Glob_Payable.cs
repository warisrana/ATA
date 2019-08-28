using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com_war_air.com.WARPRO.Glob.Bookings_And_Payments
{
   partial class Glob_Payable : Glob_Bookings
    {





        internal static void UpdateDealStatus(bool NewdaelStatus, long OrignalBookingNo)
        {
            Table_AdapterPayable.UpdateQuery_Payable_Deal_Status_StoreProcedure_Func(  NewdaelStatus,  OrignalBookingNo);
        }

        internal static void UpdatePayablePayments(decimal paidAmount, decimal remainingAmount, bool isPaidFull, long OrignalbookingNo)
        {
            Table_AdapterPayable.UpdateQuery_Payable_Pay_By_BookingID_StoreProcedure_Func( paidAmount,  remainingAmount,  isPaidFull, OrignalbookingNo);
        }

        internal static DB.Bookings_And_payments_DataSet_appData.PayableToCompanyRow Get_SelectPayableRow(long OrignalbookingNo)
        {

            DB.Bookings_And_payments_DataSet_appData ds = new DB.Bookings_And_payments_DataSet_appData();

            Table_AdapterPayable.FillBy_PayableRowBy_BookingId_StoreProcedure(ds.PayableToCompany, OrignalbookingNo);

            var rr = (from o in ds.PayableToCompany
                      where (o.BOOKING_ID == OrignalbookingNo)
                      select o).FirstOrDefault();
            return rr;

        }


        //?////////////////////////////////////////////////////////////////////////




        internal static DataView Get_Payable_Table_DataFOrGrid(
                                                                string _PayableId = "",
                                                                string _CompanyId = "",
                                                                string _BookingID = "",
                                                                string _date = "",
                                                                string _PayableAmount = "",
                                                                string _PaidAmount = "",
                                                                string _RemainingAmount = "",
                                                                string _IsPAidFull = "",
                                                                string _DealStatus = ""
                                                                
                                                                )
        {

            PayableToCompany_Table_Load_Update();
            var Getquery = from o in dataSet_Bookings_And_Payments_appdata.PayableToCompany
                           where
                           (o.PAYABLE_ID.ToString().ToLower().StartsWith(_PayableId.ToLower())) &&
                           (o.COMPANY_ID.ToString().ToLower().StartsWith(_CompanyId.ToLower())) &&
                           (o.BOOKING_ID.ToString().ToLower().StartsWith(_BookingID.ToLower())) &&
                           (o.DATE.ToLongDateString().ToLower().Contains(_date.ToLower())) &&
                           (o.PAYABLE_AMOUNT.ToString().ToLower().EndsWith(_PayableAmount.ToLower())) &&
                           (o.PAID_AMOUNT.ToString().ToLower().EndsWith(_PaidAmount.ToLower())) &&
                           (o.REMAINING_AMOUNT.ToString().ToLower().EndsWith(_RemainingAmount.ToLower())) &&
                           (o.IsPAID_FULL.ToString().ToLower().Contains(_IsPAidFull.ToLower())) &&
                           (o.DEAL_STATUS.ToString().ToLower().Contains(_DealStatus.ToLower())) 


                           select o;


            DataView d = Getquery.AsDataView();



            return d;



        }


        /////


    }
}
