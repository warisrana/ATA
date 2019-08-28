using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com_war_air.com.WARPRO.DB;

namespace com_war_air.com.WARPRO.Glob.CustomersAndAgents
{
    partial class Glob_mainCompany : CustomersAndAgents_class
    {

       internal static void NewCompany(string CompanyName, string ownerName, string address, string company_mobile, string ownerMobile, string extraMobile, string email, string extraEmail,  string extraDetails )
        {
            Table_Adapter_Main_comp.Insert( CompanyName,  ownerName,  address,  company_mobile,  ownerMobile,  extraMobile,  email,  extraEmail, DateTime.Today,  extraDetails, true);
        }


        internal static void UpdateCompany_Info(string CompanyName, string ownerName, string address, string company_mobile, string ownerMobile, string extraMobile, string email, string extraEmail, string extraDetails, long orignalId)
        {
            Table_Adapter_Main_comp.UpdateQuery_Company_info_StoreProcedure_Func(CompanyName, ownerName, address, company_mobile, ownerMobile, extraMobile, email, extraEmail, extraDetails, orignalId);
        }


        internal static void UpdateCompanyStatus(bool newstatus, long orignalId)
        {
            Table_Adapter_Main_comp.UpdateQuery_Company_Status_StoreProcedure_Func(newstatus, orignalId);

        }

        internal static bool Get_CompanyStatus( long orignalId)
        {
         bool status = (bool)   Table_Adapter_Main_comp.ScalarQuery_Get_Company_Status_By_Id_StoreProcedure_Func( orignalId);
            return status;
        }


        internal static CustomersAndAgents_DataSet_appData.MainCompanyRow Get_CompanyRow(long companyid )
        {
            CustomersAndAgents_DataSet_appData ds = new CustomersAndAgents_DataSet_appData();


            Table_Adapter_Main_comp.FillBy_CompanyRow_By_Id_StoreProcedure(ds.MainCompany, companyid );

            var gg = (from o in ds.MainCompany
                     where (o.ID == companyid)
                     select o).FirstOrDefault();
            return gg;
        }

        internal static  string[]  Get_CompanyName_And_ID_Coloumn( bool _origNalStatus)
        {

            DB.CustomersAndAgents_DataSet_appData aa = new CustomersAndAgents_DataSet_appData();

            Table_Adapter_Main_comp.FillBy_ID_andCompanyName_Column_by_Status(aa.MainCompany, _origNalStatus);

            var gg =( from o in aa.MainCompany
                    
                     select  string.Concat(o.COMPANY_NAME,'-', o.ID)).ToArray();

            return gg;
        }


        //?////////////////////////////////////////////////////////////////////////




        internal static DataView Get_Company_Table_DataFOrGrid( string _CompanyID = "",
                                                                string _CompanyName = "",
                                                                string _ownerName = "",
                                                                string _Address = "",
                                                                string _CompanyMobileNo = "",
                                                                string _OwnerMobileNo = "",
                                                                string _ExtraMobileNo = "",
                                                                string _Email = "",
                                                                string _ExtraEmail = "",
                                                                string _date = "",
                                                                string _ExtraDetails = "",
                                                                string _Status = ""
                                                                )
        {

            MainCompany_Table_Load_Update();
            var Getquery = from o in dataSet_CustomersAndAgents_appdata.MainCompany
                           where
                           (o.ID.ToString().ToLower().StartsWith(_CompanyID.ToLower())) &&
                           (o.COMPANY_NAME.ToLower().Contains(_CompanyName.ToLower())) &&
                           (o.OWNER_NAME.ToString().ToLower().Contains(_ownerName.ToLower())) &&
                           (o.ADDRESS.ToLower().Contains(_Address.ToLower())) &&
                           (o.COMPANY_MOBILE_NO.ToLower().StartsWith(_CompanyMobileNo.ToLower())) &&
                           (o.OWNER_MOBILE_NO.ToLower().StartsWith(_OwnerMobileNo.ToLower())) &&
                           (o.EXTRA_MOBILE_NO.ToLower().StartsWith(_ExtraMobileNo.ToLower())) &&

                           (o.EMAIL.ToString().ToLower().Contains(_Email.ToLower())) &&
                           (o.EXTRA_EMAIL.ToString().ToLower().Contains(_ExtraEmail.ToLower())) &&

                           (o.CONNECTION_DATE.ToLongDateString().ToLower().Contains(_date.ToLower())) &&
                           (o.EXTRA_DETAILS.ToString().ToLower().Contains(_ExtraDetails.ToLower()))&&
                           (o.STATUS.ToString().ToLower().Contains(_Status.ToLower()))


                           select o;


            DataView d = Getquery.AsDataView();



            return d;



        }


    }
}
