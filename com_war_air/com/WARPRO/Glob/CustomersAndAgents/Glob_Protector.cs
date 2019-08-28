using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com_war_air.com.WARPRO.DB;

namespace com_war_air.com.WARPRO.Glob.CustomersAndAgents
{
    partial class Glob_Protector : CustomersAndAgents_class
    {



        internal static void NewProtectorInsert(long customerid, string profession, string country, decimal charges, decimal payable, DateTime PassportSendingDate, DateTime PassportRecievingDate, decimal profit)
        {
            Table_Adapter_Protector.Insert( customerid,  profession,  country,  charges,  payable,  PassportSendingDate,  PassportRecievingDate,  profit);
        }

        internal static void Update_ProtectorInfo(long customerid, string profession, string country, decimal charges, decimal payable, DateTime PassportSendingDate, DateTime PassportRecievingDate, decimal profit, long OrignalProtectorId)
        {
            Table_Adapter_Protector.UpdateQuery_Protector_Info_By_ProtectoriD_Func(customerid, profession, country, charges, payable, PassportSendingDate, PassportRecievingDate, profit, OrignalProtectorId );
        }


        internal static string GetLastID()
        {
            long rr =(long) Table_Adapter_Protector.ScalarQuery_GetLast_ProtectorID_Func();

            string id = rr.ToString();

            return id;
            
        }
        internal static CustomersAndAgents_DataSet_appData.ProtectorRow Get_Protector_Row(long OrignalProtectoriD)
        {
            CustomersAndAgents_DataSet_appData ds = new CustomersAndAgents_DataSet_appData();


            Table_Adapter_Protector.FillBy_Protector_RowBy_Protectorid_StoreProcedure(ds.Protector, OrignalProtectoriD);

            var gg = (from o in ds.Protector
                      where (o.PROTECTOR_ID == OrignalProtectoriD)
                      select o).FirstOrDefault();
            return gg;
        }


        internal static DataView Get_Protector_Table_DataFOrGrid(string _ProtectoriD = "",
                                                                      string _CustomeriD = ""

                                                               )
        {

            Protector_Table_Load_Update();
            var Getquery = from o in dataSet_CustomersAndAgents_appdata.Protector
                           where
                           (o.PROTECTOR_ID.ToString().ToLower().StartsWith(_ProtectoriD.ToLower())) &&
                           (o.CUSTOMER_ID.ToString().ToLower().StartsWith(_CustomeriD.ToLower()))


                           select o;


            DataView d = Getquery.AsDataView();



            return d;



        }
    }
}
