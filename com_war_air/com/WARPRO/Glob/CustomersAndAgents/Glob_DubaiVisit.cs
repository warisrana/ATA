using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com_war_air.com.WARPRO.DB;

namespace com_war_air.com.WARPRO.Glob.CustomersAndAgents
{
     partial class Glob_DubaiVisit : CustomersAndAgents_class
    {



        internal static void NewDubaiVisaInsert(long customerid, int  visaDurationDays,string IssuedFrom , DateTime PassportSendingDate, DateTime PassportRecievingDate, decimal charges, decimal payable, decimal profit)
        {
            Table_Adapter_DubaiVisit.Insert( customerid,   visaDurationDays,  IssuedFrom,  PassportSendingDate,  PassportRecievingDate,  charges,  payable,  profit);
        }

        internal static void Update_DubaiVisitInfo(long customerid, int visaDurationDays, string IssuedFrom, DateTime PassportSendingDate, DateTime PassportRecievingDate, decimal charges, decimal payable, decimal profit , long OrignalVisitId)
        {
            Table_Adapter_DubaiVisit.UpdateQuery_DubaiVisit_By_visitiD_StoreProcedure_Func(customerid, visaDurationDays, IssuedFrom, PassportSendingDate, PassportRecievingDate, charges, payable, profit, OrignalVisitId);
        }


        internal static string GetLastID()
        {
            long rr = (long)Table_Adapter_DubaiVisit.ScalarQuery_GetLast_DubaiVisitID_Func();

            string id = rr.ToString();

            return id;

        }




        internal static CustomersAndAgents_DataSet_appData.DubaiVisitRow Get_DubaiVisit_Row(long OrignalVisitiD)
        {
            CustomersAndAgents_DataSet_appData ds = new CustomersAndAgents_DataSet_appData();


            Table_Adapter_DubaiVisit.FillBy_DubaiVisit_Row_By_visitiD_StoreProcedure(ds.DubaiVisit, OrignalVisitiD);

            var gg = (from o in ds.DubaiVisit
                      where (o.VISIT_ID == OrignalVisitiD)
                      select o).FirstOrDefault();
            return gg;
        }


        internal static DataView Get_DubaiVisit_Table_DataFOrGrid(string _VisitiD = "",
                                                                      string _CustomeriD = ""

                                                               )
        {

            DubaiVisit_Table_Load_Update();
            var Getquery = from o in dataSet_CustomersAndAgents_appdata.DubaiVisit
                           where
                           (o.VISIT_ID.ToString().ToLower().StartsWith(_VisitiD.ToLower())) &&
                           (o.CUSTOMER_ID.ToString().ToLower().StartsWith(_CustomeriD.ToLower()))


                           select o;


            DataView d = Getquery.AsDataView();



            return d;



        }

    }
}
