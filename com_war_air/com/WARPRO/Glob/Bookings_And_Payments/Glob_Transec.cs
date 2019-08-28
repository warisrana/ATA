using com_war_air.com.WARPRO.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com_war_air.com.WARPRO.Glob.Bookings_And_Payments
{
    partial class Glob_Transec : Glob_Bookings
    {
        
        /// <summary>
        /// Services Names "PROTECTOR", "DUBAI VISIT" ,"SAUDI VISA STAMP"  , "TICKET BOOKED",  "BOOKING"
        /// </summary>
        /// <param name="serviceID"></param>
        /// <param name="Customerid"></param>
        /// <param name="OrignalRecieveable"></param>
        /// <param name="t_Recieved"></param>
        /// <param name="remaining"></param>
        /// <param name="serviceName"></param>
        internal static  void NewTransec(string serviceID, string Customerid, string OrignalRecieveable, string t_Recieved, string remaining, string serviceName)
        {
            Table_AdapterTransec.Insert( serviceID , long.Parse(  Customerid)  ,DateTime.Now , decimal.Parse( OrignalRecieveable), decimal.Parse(t_Recieved) , decimal.Parse(remaining),  serviceName, true);
        }

        internal static Bookings_And_payments_DataSet_appData.TransecRow Get_Transec_Row(string OrignalServiceID)
        {
            Bookings_And_payments_DataSet_appData.TransecDataTable ds = new Bookings_And_payments_DataSet_appData.TransecDataTable();


            Table_AdapterTransec.FillBy_Transec_RowByServiceID(ds, OrignalServiceID);

            var gg = (from o in ds
                      where (o.SERVICE_ID == OrignalServiceID)
                      select o).FirstOrDefault();
            return gg;
        }


        internal static decimal Get_TotalRecieveableCustomer(long OrignalCustomerID )
        {
            decimal d = 0;
            var a =  Table_AdapterTransec.ScalarQuery_TransecRecieveableTotal_StoreProcedure_Func(OrignalCustomerID);
            if (a != null)
            {
                d = (decimal)a;
            }
            return d;
        }


        internal static decimal Get_TotalRecieveableAgent(long OrignalAgentID)
        {
            decimal d = 0;
            var a = Table_AdapterTransec.ScalarQuery_TransecAgentRecieveableTotal_StoreProcedure_Func(OrignalAgentID);
            if (a != null)
            {
                d = (decimal)a;
            }
            return d;
        }


        internal static decimal Get_TotalPaidCustomer(long OrignalCustomerID)
        {
            decimal d = 0;
            var a = Table_AdapterTransec.ScalarQuery_TransecT_ReceivedSum_StoreProcedure_Func(OrignalCustomerID);
            if (a != null)
            {
                d = (decimal)a;
            }
            return d;
        }

        internal static decimal Get_TotalPaidAgent(long OrignalAgentID)
        {
            decimal d = 0;
            var a = Table_AdapterTransec.ScalarQuery_TransecAgent_T_ReceivedSum_StoreProcedure_Func(OrignalAgentID);
            if (a != null)
            {
                d = (decimal)a;
            }
            return d;
        }




        internal static void UpdateStatus(bool status, string Orignalserviceid)
        {
            Table_AdapterTransec.UpdateQuery_Transec_Status_by_ServiceID_StoreProcedure_Func(status, Orignalserviceid);
        }

        internal static DataView Get_Transec_Table_DataFOrGrid(
                                                                      string _CustomeriD = ""

                                                               )
        {

            Transec_Table_Load_Update();
            var Getquery = from o in dataSet_Bookings_And_Payments_appdata.Transec
                           where
                          
                           (o.CUSTOMER_ID.ToString().ToLower().StartsWith(_CustomeriD.ToLower())) &&
                           (o.STATUS == true )



                           select o;


            DataView d = Getquery.AsDataView();



            return d;



        }
    }
}
