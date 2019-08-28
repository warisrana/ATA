using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com_war_air.com.WARPRO.Glob.CustomersAndAgents
{
    partial class Glob_OurCompanyProfile : CustomersAndAgents_class
    {



        internal static DB.CustomersAndAgents_DataSet_appData.OurComoanyProfileRow Get_Select_Row_OurCompanyProfile()
        {
            DB.CustomersAndAgents_DataSet_appData ds = new DB.CustomersAndAgents_DataSet_appData();
            
            Table_Adapter_OUrCompProfile.FillBy_OurCompanyProfile_Row_StoreProcedure(ds.OurComoanyProfile, 1);

            var CustrowQuery = (from o in ds.OurComoanyProfile
                                where (o.ID == 1)
                                select o).FirstOrDefault();


            return CustrowQuery;
        }



        internal static void UpdateOurCompany_Info(string CompanyName, string ownerName, string address, string company_mobile, string ownerMobile, string extraMobile, string email, string extraEmail, string extraDetails, byte[] image )
        {
            Table_Adapter_OUrCompProfile.UpdateQuery_OurCompanyProfile_Info_StoreProcedure_Func(CompanyName, ownerName, address, company_mobile, ownerMobile, extraMobile, email, extraEmail,DateTime.Today, extraDetails, image , 1);
        }
    }
}
