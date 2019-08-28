using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com_war_air.com.WARPRO.Glob.Bookings_And_Payments
{
    partial class Glob_Bill_Payments : Glob_Bookings
    {


        internal static DB.Bookings_And_payments_DataSet_appData.BillsRow Select_Row_Bill_Payment(long Orignal_Bill_iD)
        {
            DB.Bookings_And_payments_DataSet_appData ds = new DB.Bookings_And_payments_DataSet_appData();


            Table_Adapter_Bill_Payments.FillBy_Row_Bill_by_Id(ds.Bills, Orignal_Bill_iD);

            var BillRowQuery = (from o in ds.Bills
                                   where (o.BILL_ID == Orignal_Bill_iD)
                                   select o).FirstOrDefault();


            return BillRowQuery;
        }


        internal static void update_Remaining_Bill(decimal NewPaid_amount, decimal NewRemaining_amount, bool isPaidFull, long Orignal_bill_iD)
        {
            Table_Adapter_Bill_Payments.UpdateQuery_Remaining_amount_StoreProcedure_Func( NewPaid_amount, NewRemaining_amount,  isPaidFull,  Orignal_bill_iD);


        }

        internal static long Get_LastAdded_Bill_ID()
        {
          long bid = (long)   Table_Adapter_Bill_Payments.ScalarQuery_Get_Last_Added_Bill_ID_Store_Procedure_Func();
            return bid;

        }


        //?////////////////////////////////////////////////////////////////////////




        internal static DataView Get_Bill_Table_DataFOrGrid(
                                                                string _billId = "",
                                                                string _ReferenceType = "",
                                                                string _ReferenceNo = "",
                                                                string _BookingID = "",
                                                                string _BillDate = "",
                                                                string _TotalOrignalAmount = "",
                                                                string _Special_offerAmount = "",
                                                                string _ExtraDIscount = "",
                                                                string _TotalDiscount = "",
                                                                string _PaidAmount = "",
                                                                string _RemainingAmount = "",
                                                                string _IspaidFull = "",
                                                                string _IsRefunded = ""
            
                                                          )
        {

            Bills_Table_Load_Update();
            var Getquery = from o in dataSet_Bookings_And_Payments_appdata.Bills
                           where
                           (o.BILL_ID.ToString().ToLower().StartsWith(_billId.ToLower())) &&
                           (o.REFERENCE_TYPE.ToString().ToLower().Contains(_ReferenceType.ToLower())) &&
                           (o.REFERENCE_CODE.ToString().ToLower().StartsWith(_ReferenceNo.ToLower())) &&
                           (o.BOOKING_ID_NO.ToString().ToLower().StartsWith(_BookingID.ToLower())) &&
                           (o.BILL_DATE.ToLongDateString().ToLower().Contains(_BillDate.ToLower())) &&
                           (o.TOTAL_ORIGNAL_AMOUNT.ToString().ToLower().EndsWith(_TotalOrignalAmount.ToLower())) &&
                           (o.SPECIAL_OFFER_DISCOUNT.ToString().ToLower().EndsWith(_Special_offerAmount.ToLower())) &&
                           (o.EXTRA_DISCOUNT.ToString().ToLower().EndsWith(_ExtraDIscount.ToLower())) &&
                           (o.TOTAL_DISCOUNT.ToString().ToLower().EndsWith(_TotalDiscount.ToLower())) &&
                           (o.PAID_AMOUNT.ToString().ToLower().EndsWith(_PaidAmount.ToLower())) &&
                           (o.REMAINING_AMOUNT.ToString().ToLower().EndsWith(_RemainingAmount.ToLower())) &&
                           
                           (o.IsPAID_FULL.ToString().ToLower().Contains(_IspaidFull.ToLower()))&&
                           (o.IsREFUNDED.ToString().ToLower().Contains(_IsRefunded.ToLower()))


                           select o;


            DataView d = Getquery.AsDataView();
            return d;

        }


        /////





    }
}
