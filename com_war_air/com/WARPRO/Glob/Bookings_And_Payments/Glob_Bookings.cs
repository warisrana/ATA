using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com_war_air.com.WARPRO.DB.Bookings_And_payments_DataSet_appDataTableAdapters;
using System.Data;

namespace com_war_air.com.WARPRO.Glob.Bookings_And_Payments
{
    class Glob_Bookings
    {


        internal static DB.Bookings_And_payments_DataSet_appData dataSet_Bookings_And_Payments_appdata = new DB.Bookings_And_payments_DataSet_appData();

        internal static BookingsTableAdapter Table_Adapter_bookings = new BookingsTableAdapter();

        internal static BillsTableAdapter Table_Adapter_Bill_Payments = new BillsTableAdapter();
        internal static PayableToCompanyTableAdapter Table_AdapterPayable = new PayableToCompanyTableAdapter();
        internal static TransecTableAdapter Table_AdapterTransec = new TransecTableAdapter();


        internal static LedgerFromPayableTableAdapter Table_Adapter_LedgerCustomerBill = new LedgerFromPayableTableAdapter();





        //????????????????????????????????????????????????????????????? LOADs
        internal static void Transec_Table_Load()
        {

            if (dataSet_Bookings_And_Payments_appdata.Transec.Rows.Count <= 0)
            {
                Table_AdapterTransec.Fill(dataSet_Bookings_And_Payments_appdata.Transec);
            }
            else if (dataSet_Bookings_And_Payments_appdata.PayableToCompany.Rows.Count >= 1)
            {

            }

        }
        //

        internal static void Transec_Table_Load_Update()
        {


            Table_AdapterTransec.Fill(dataSet_Bookings_And_Payments_appdata.Transec);

        }
        //????????????????????????????????????????????????????????????? LOADs

        //????????????????????????????????????????????????????????????? LOADs
        internal static void PayableToCompany_Table_Load()
        {

            if (dataSet_Bookings_And_Payments_appdata.PayableToCompany.Rows.Count <= 0)
            {
                Table_AdapterPayable.Fill(dataSet_Bookings_And_Payments_appdata.PayableToCompany);
            }
            else if (dataSet_Bookings_And_Payments_appdata.PayableToCompany.Rows.Count >= 1)
            {

            }

        }
        //

        internal static void PayableToCompany_Table_Load_Update()
        {


            Table_AdapterPayable.Fill(dataSet_Bookings_And_Payments_appdata.PayableToCompany);

        }
        //????????????????????????????????????????????????????????????? LOADs

        internal static void Bookings_Table_Load()
        {

            if (dataSet_Bookings_And_Payments_appdata.Bookings.Rows.Count <= 0)
            {
                Table_Adapter_bookings.Fill(dataSet_Bookings_And_Payments_appdata.Bookings);
            }
            else if (dataSet_Bookings_And_Payments_appdata.Bookings.Rows.Count >= 1)
            {

            }

        }
        //

        internal static void Bookings_Table_Load_Update()
        {


            Table_Adapter_bookings.Fill(dataSet_Bookings_And_Payments_appdata.Bookings);

        }
        
        internal static void Bills_Table_Load()
        {

            if (dataSet_Bookings_And_Payments_appdata.Bills.Rows.Count <= 0)
            {
                Table_Adapter_Bill_Payments.Fill(dataSet_Bookings_And_Payments_appdata.Bills);
            }
            else if (dataSet_Bookings_And_Payments_appdata.Bills.Rows.Count >= 1)
            {

            }

        }
        //

        internal static void Bills_Table_Load_Update()
        {


            Table_Adapter_Bill_Payments.Fill(dataSet_Bookings_And_Payments_appdata.Bills);

        }

        //??????????????       2


        internal static void NewBookingAndBill(int referenceType, long referenceCode,  long packageCode, int forNoOfPersons, decimal TotalOrignalAmount, decimal SpecialOfferDiscount, decimal ExtraDiscount, decimal TotalDiscount, decimal PaidAmount, decimal RemainingAmountx, bool IsPaidFull , long Companyid, decimal PayableAmount)
        {
            Table_Adapter_bookings.insertQuery_AddNew_Bookings_Bill_StoreProcedure_Func( referenceType, referenceCode ,DateTime.Today,  packageCode,  forNoOfPersons, DateTime.Today,  TotalOrignalAmount,  SpecialOfferDiscount,  ExtraDiscount,  TotalDiscount, PaidAmount ,  RemainingAmountx,  IsPaidFull , false, true, Companyid,  false, true, PayableAmount);


        }

        internal static DB.Bookings_And_payments_DataSet_appData.BookingsRow Select_Row_Booking(long Orignal_Booking_iD)
        {
            DB.Bookings_And_payments_DataSet_appData ds = new DB.Bookings_And_payments_DataSet_appData();


            Table_Adapter_bookings.FillBy_Row_Booking_ID(ds.Bookings, Orignal_Booking_iD);

            var BookingrowQuery = (from o in ds.Bookings
                                where (o.BOOKING_ID == Orignal_Booking_iD)
                                select o).FirstOrDefault();


            return BookingrowQuery;
        }




        internal static string GetLastID()
        {
            long rr = (long)Table_Adapter_bookings.ScalarQuery_GetLast_BookingID_Func();

            string id = rr.ToString();

            return id;

        }



        internal static  void CancelPackageRefundbillAndCancelPayable(long _OrignalBookingnoId)
        {
            Table_Adapter_bookings.UpdateQuery_booking_Status_Update_StoreProcedure_Func(false,_OrignalBookingnoId);
            Table_Adapter_Bill_Payments.UpdateQuery_Bill_Status_IsRfunded_StoreProcedure_Func(true,_OrignalBookingnoId);
            Table_AdapterPayable.UpdateQuery_Payable_Deal_Status_StoreProcedure_Func(false,_OrignalBookingnoId);
        }

        //?////////////////////////////////////////////////////////////////////////

        internal static DataView Get_Booking_Table_DataFOrGrid( 
                                                                string _BookingID = "",
                                                                
                                                                string _ReferenceType = "",
                                                                string _ReferenceNo = "",
                                                                
                                                                string _BookingDate = "",
                                                                string _PackageCode = "",
                                                                
                                                                string _ForNoOfPersons = "",
                                                                string _BillId = "",
                                                                string _bookingStatus = ""
                                                                
                                                                )
        {

            Bookings_Table_Load_Update();
            var Getquery = from o in dataSet_Bookings_And_Payments_appdata.Bookings
                           where
                           (o.BOOKING_ID.ToString().ToLower().StartsWith(_BookingID.ToLower())) &&
                           
                           (o.REFERENCE_TYPE.ToString().ToLower().Contains(_ReferenceType.ToLower())) &&
                           (o.REFERENCE_CODE.ToString().ToLower().StartsWith(_ReferenceNo.ToLower())) &&
                           
                           (o.BOOKING_DATE.ToLongDateString().ToLower().Contains(_BookingDate.ToLower())) &&
                           (o.PACKAGE_CODE.ToString().ToLower().EndsWith(_PackageCode.ToLower())) &&
                           (o.FOR_NO_OF_PERSONS.ToString().ToLower().EndsWith(_ForNoOfPersons.ToLower())) &&
                           (o.BILL_ID.ToString().ToLower().StartsWith(_BillId.ToLower())) &&
                           (o.BOOKING_STATUS.ToString().ToLower().Contains(_bookingStatus.ToLower()))


                           select o;

            DataView d = Getquery.AsDataView();
            
            return d;
            
        }
        
        /////
        
    }
}
