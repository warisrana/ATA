using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com_war_air.com.WARPRO.Glob.CustomersAndAgents
{
    partial class Glob_Passport : CustomersAndAgents_class
    {

        internal static void Passport_Table_Load()
        {

            if (dataSet_CustomersAndAgents_appdata.Passport.Rows.Count <= 0)
            {
                Table_Adapter_Passport.Fill(dataSet_CustomersAndAgents_appdata.Passport);
            }
            else if (dataSet_CustomersAndAgents_appdata.Passport.Rows.Count >= 1)
            {

            }

        }
        //

        internal static void Passport_Table_Load_Update()
        {


            Table_Adapter_Passport.Fill(dataSet_CustomersAndAgents_appdata.Passport);

        }



        internal static DB.CustomersAndAgents_DataSet_appData.PassportRow Get_Select_Row_Passport(long Orignal_iD)
        {
            DB.CustomersAndAgents_DataSet_appData ds = new DB.CustomersAndAgents_DataSet_appData();


            Table_Adapter_Passport.FillBy_Passport_Row_ByCustomerid_StoreProcedure(ds.Passport, Orignal_iD);

            var CustrowQuery = (from o in ds.Passport
                                where (o.CUSTOMER_ID == Orignal_iD)
                                select o).FirstOrDefault();


            return CustrowQuery;
        }




        internal static DB.CustomersAndAgents_DataSet_appData.PassportRow Get_Select_FOrWidgetRowByPassportNo_Passport(string OrignalPassportNo)
        {
            DB.CustomersAndAgents_DataSet_appData ds = new DB.CustomersAndAgents_DataSet_appData();


            Table_Adapter_Passport.FillBy_PassportRowByPassportNoForWidgetStoreProcedure(ds.Passport, OrignalPassportNo);

            var CustrowQuery = (from o in ds.Passport
                                where (o.PASSPORT_NO.ToLower() == OrignalPassportNo.ToLower())
                                select o).FirstOrDefault();


            return CustrowQuery;
        }

    }
}
