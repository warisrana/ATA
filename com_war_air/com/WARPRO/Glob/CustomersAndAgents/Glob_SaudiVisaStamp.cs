using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com_war_air.com.WARPRO.DB;

namespace com_war_air.com.WARPRO.Glob.CustomersAndAgents
{
    partial class Glob_SaudiVisaStamp : CustomersAndAgents_class
    {



        internal static void NewVisaInsert(long customerid, string visano, string ioNo, string eNo, DateTime eNoDate, DateTime PassportSendingDate, DateTime PassportRecievingDate, DateTime deliveryDate, decimal recieveableAmount, decimal payableAmount, DateTime paymentDate, string modeOfPayment )
        {
            Table_Adapter_SaudiVisaStamp.Insert( customerid,  visano,  ioNo,  eNo,  eNoDate,  PassportSendingDate,  PassportRecievingDate,  deliveryDate,  recieveableAmount,  payableAmount,  paymentDate,  modeOfPayment);
        }

        internal static void Update_SaudiVisaStampInfo(long customerid, string visano, string ioNo, string eNo, DateTime eNoDate, DateTime PassportSendingDate, DateTime PassportRecievingDate, DateTime deliveryDate, decimal recieveableAmount, decimal payableAmount, DateTime paymentDate, string modeOfPayment, string OrignalVisaNo)
        {
            Table_Adapter_SaudiVisaStamp.UpdateQuery_SaudiVisaStamp_Info_StoreProcedure_Func(customerid, visano, ioNo, eNo, eNoDate, PassportSendingDate, PassportRecievingDate, deliveryDate, recieveableAmount, payableAmount, paymentDate, modeOfPayment, OrignalVisaNo);
        }

        internal static DB.CustomersAndAgents_DataSet_appData.SaudiViasStampRow  Get_SaudiVisaStamp_Row(string OrignalVisaNo)
        {
            CustomersAndAgents_DataSet_appData ds = new CustomersAndAgents_DataSet_appData();


            Table_Adapter_SaudiVisaStamp.FillBy_Row_SaudiVisaStamp_StoreProcedure(ds.SaudiViasStamp, OrignalVisaNo);

            var gg = (from o in ds.SaudiViasStamp
                      where (o.VISA_NO == OrignalVisaNo)
                      select o).FirstOrDefault();
            return gg;
        }


        internal static string GetLastID()
        {
            string rr = (string)Table_Adapter_SaudiVisaStamp.ScalarQuery_GetLast_SaudiVisaStampID_Func();

            string id = rr.ToString();

            return id;

        }


        internal static DataView Get_SaudiVisaStamp_Table_DataFOrGrid(string _Visanumber = "",
                                                                      string _CustomeriD = ""

                                                               )
        {

            SaudiViasStamp_Table_Load_Update();
            var Getquery = from o in dataSet_CustomersAndAgents_appdata.SaudiViasStamp
                           where
                           (o.VISA_NO.ToLower().StartsWith(_Visanumber.ToLower())) &&
                           (o.CUSTOMER_ID.ToString().ToLower().StartsWith(_CustomeriD.ToLower()))


                           select o;


            DataView d = Getquery.AsDataView();



            return d;



        }
    }
}
