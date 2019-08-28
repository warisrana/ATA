using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com_war_air.com.WARPRO.DB;

namespace com_war_air.com.WARPRO.Glob.CustomersAndAgents
{
    partial class Glob_OtherPayables : CustomersAndAgents_class
    {

        internal static void NewOtherPayableInsert(string category, decimal paid,   string toName, string extrainfo)
        {
            Table_Adapter_OtherPayable.Insert( category,  paid,  DateTime.Today,  toName,  extrainfo);
        }


        internal static CustomersAndAgents_DataSet_appData.OtherPayableRow Get_OtherPayable_Row(long OtherPayableiD)
        {
            CustomersAndAgents_DataSet_appData ds = new CustomersAndAgents_DataSet_appData();


            Table_Adapter_OtherPayable.FillBy_OtherPayAbleRow_By_id_StoreProcedure(ds.OtherPayable, OtherPayableiD);

            var gg = (from o in ds.OtherPayable
                      where (o.ID == OtherPayableiD)
                      select o).FirstOrDefault();
            return gg;
        }



        internal static DataView Get_OtherPayable_Table_DataFOrGrid(string __ToName = "",
                                                                      string _DateLongString = ""

                                                               )
        {

            OtherPayable_Table_Load_Update();
            var Getquery = from o in dataSet_CustomersAndAgents_appdata.OtherPayable
                           where
                           (o.TO.ToLower().Contains(__ToName.ToLower())) &&
                           (o.DATE.ToLongDateString().ToLower().Contains(_DateLongString.ToLower()))


                           select o;


            DataView d = Getquery.AsDataView();



            return d;

        }


        internal static string[] GetCategories_Coloumn()
        {
            DB.CustomersAndAgents_DataSet_appData aa = new DB.CustomersAndAgents_DataSet_appData();



            // var aa =   Table_Adapter_Packages.SelectQuery_Packages_Names_Coloumn_StoreProcedure_Func();
            Table_Adapter_OtherPayable.FillBy_OtherPayable_CategoryColoum_StoreProcedure(aa.OtherPayable);

            var PackagerowQuery = (from o in aa.OtherPayable

                                   select o.CATEGORY).ToArray();


            return PackagerowQuery;

        }



    }
}
