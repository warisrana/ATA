using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com_war_air.com.WARPRO;
using System.Data;
using com_war_air.com.WARPRO.DB.CustomersAndAgents_DataSet_appDataTableAdapters;
using System.Windows.Forms;

namespace com_war_air.com.WARPRO.Glob.CustomersAndAgents
{
    class CustomersAndAgents_class
    {



        internal static DB.CustomersAndAgents_DataSet_appData dataSet_CustomersAndAgents_appdata = new DB.CustomersAndAgents_DataSet_appData();

        internal static CustomersTableAdapter Table_Adapter_Cust = new CustomersTableAdapter();

        internal static AgentsTableAdapter Table_Adapter_Agent = new AgentsTableAdapter();

        internal static MainCompanyTableAdapter Table_Adapter_Main_comp = new MainCompanyTableAdapter();

        internal static PassportTableAdapter Table_Adapter_Passport = new PassportTableAdapter();

        internal static TicketsTableAdapter Table_Adapter_Ticket = new TicketsTableAdapter();

        internal static SaudiViasStampTableAdapter Table_Adapter_SaudiVisaStamp = new SaudiViasStampTableAdapter();

        internal static DubaiVisitTableAdapter Table_Adapter_DubaiVisit = new DubaiVisitTableAdapter();

        internal static ProtectorTableAdapter Table_Adapter_Protector = new ProtectorTableAdapter();

        internal static OurComoanyProfileTableAdapter Table_Adapter_OUrCompProfile = new OurComoanyProfileTableAdapter();

        internal static OtherPayableTableAdapter Table_Adapter_OtherPayable = new OtherPayableTableAdapter();

        internal static LedgerTableAdapter Table_Adapter_Ledger = new LedgerTableAdapter();

        //"""""""""""""""""""""""""""""""""""""""""""""""""



        



        //"""""""""""""""""""""""""""""""""""""""""""""""""



        internal static void OtherPayable_Table_Load()
        {

            if (dataSet_CustomersAndAgents_appdata.OtherPayable.Rows.Count <= 0)
            {
                Table_Adapter_OtherPayable.Fill(dataSet_CustomersAndAgents_appdata.OtherPayable);

            }
            else if (dataSet_CustomersAndAgents_appdata.OtherPayable.Rows.Count >= 1)
            {

            }

        }
        //

        internal static void OtherPayable_Table_Load_Update()
        {


            Table_Adapter_OtherPayable.Fill(dataSet_CustomersAndAgents_appdata.OtherPayable);

        }

        //"""""""""




        internal static void DubaiVisit_Table_Load()
        {

            if (dataSet_CustomersAndAgents_appdata.DubaiVisit.Rows.Count <= 0)
            {
                Table_Adapter_DubaiVisit.Fill(dataSet_CustomersAndAgents_appdata.DubaiVisit);

            }
            else if (dataSet_CustomersAndAgents_appdata.DubaiVisit.Rows.Count >= 1)
            {

            }

        }
        //

        internal static void DubaiVisit_Table_Load_Update()
        {


            Table_Adapter_DubaiVisit.Fill(dataSet_CustomersAndAgents_appdata.DubaiVisit);

        }

        //"""""""""


        internal static void Protector_Table_Load()
        {

            if (dataSet_CustomersAndAgents_appdata.Protector.Rows.Count <= 0)
            {
                Table_Adapter_Protector.Fill(dataSet_CustomersAndAgents_appdata.Protector);

            }
            else if (dataSet_CustomersAndAgents_appdata.Protector.Rows.Count >= 1)
            {

            }

        }
        //

        internal static void Protector_Table_Load_Update()
        {


            Table_Adapter_Protector.Fill(dataSet_CustomersAndAgents_appdata.Protector);

        }

        //"""""""""




        internal static void SaudiViasStamp_Table_Load()
        {

            if (dataSet_CustomersAndAgents_appdata.SaudiViasStamp.Rows.Count <= 0)
            {
                Table_Adapter_SaudiVisaStamp.Fill(dataSet_CustomersAndAgents_appdata.SaudiViasStamp);
            }
            else if (dataSet_CustomersAndAgents_appdata.SaudiViasStamp.Rows.Count >= 1)
            {

            }

        }
        //

        internal static void SaudiViasStamp_Table_Load_Update()
        {


            Table_Adapter_SaudiVisaStamp.Fill(dataSet_CustomersAndAgents_appdata.SaudiViasStamp);

        }

        //"""""""""

        internal static void Tickets_Table_Load()
        {

            if (dataSet_CustomersAndAgents_appdata.Tickets.Rows.Count <= 0)
            {
                Table_Adapter_Ticket.Fill(dataSet_CustomersAndAgents_appdata.Tickets);
            }
            else if (dataSet_CustomersAndAgents_appdata.Tickets.Rows.Count >= 1)
            {

            }

        }
        //

        internal static void Tickets_Table_Load_Update()
        {


            Table_Adapter_Ticket.Fill(dataSet_CustomersAndAgents_appdata.Tickets);

        }

        //"""""""""
        internal static void MainCompany_Table_Load()
        {

            if (dataSet_CustomersAndAgents_appdata.MainCompany.Rows.Count <= 0)
            {
                Table_Adapter_Main_comp.Fill(dataSet_CustomersAndAgents_appdata.MainCompany);
            }
            else if (dataSet_CustomersAndAgents_appdata.MainCompany.Rows.Count >= 1)
            {

            }

        }
        //

        internal static void MainCompany_Table_Load_Update()
        {


            Table_Adapter_Main_comp.Fill(dataSet_CustomersAndAgents_appdata.MainCompany);

        }

        //??????????????       2



        //????????????????????????????????????????????????????????????? LOADs

        internal static void Customers_Table_Load()
        {

            if (dataSet_CustomersAndAgents_appdata.Customers.Rows.Count <= 0)
            {
                Table_Adapter_Cust.Fill(dataSet_CustomersAndAgents_appdata.Customers);
            }
            else if (dataSet_CustomersAndAgents_appdata.Customers.Rows.Count >= 1)
            {

            }

        }
        //

        internal static void Customers_Table_Load_Update()
        {
            

            Table_Adapter_Cust.Fill(dataSet_CustomersAndAgents_appdata.Customers);

        }

        //??????????????       2

        //????????????????????????????????????????????????????????????? LOADs

        internal static void Agents_Table_Load()
        {

            if (dataSet_CustomersAndAgents_appdata.Agents.Rows.Count <= 0)
            {
                Table_Adapter_Agent.Fill(dataSet_CustomersAndAgents_appdata.Agents);
            }
            else if (dataSet_CustomersAndAgents_appdata.Agents.Rows.Count >= 1)
            {

            }

        }
        //

        internal static void Agents_Table_Load_Update()
        {
           

            Table_Adapter_Agent.Fill(dataSet_CustomersAndAgents_appdata.Agents);

        }

        //??????????????       3


        //????????????????????????????????????????????????????????????? LOADs

        




        internal static void NewCustomer( string FirstName,
                                           string LastName,
                                           string address,
                                           
                                           string email, 
                                           string details,
                                           byte[] pic,
                                           string PassportNo,
                                           long RefferdbyAgentid,
                                           bool isRefferedby,
                                           string   SrNo            , 
                                           DateTime Date            ,
                                           string   Name            ,
                                           // string    PassportNo  ,
                                           DateTime DateOfbirth     ,
                                           DateTime DateOfIssue     ,
                                           DateTime dateOfExpiry    ,
                                           string   CnicNo          ,
                                           string   Contactno1      ,
                                           string   ContactNo2

                                         )
        {
            Table_Adapter_Cust.InsertNew_CustomerAndPassPort_StoreProcedure_Func(
                                                                                  FirstName,
                                                                                  LastName,
                                                                                  address,
                                                                                  email,  
                                                                                  details, 
                                                                                  pic,
                                                                                  DateTime.Today,
                                                                                  PassportNo,
                                                                                  RefferdbyAgentid,
                                                                                  isRefferedby,

                                                                                  SrNo,
                                                                                  Date,
                                                                                  Name,

                                                                                  
                                                                                  DateOfbirth,
                                                                                  DateOfIssue,
                                                                                  dateOfExpiry,
                                                                                  CnicNo,
                                                                                  Contactno1,
                                                                                  ContactNo2
                                                                                  );


        }

        internal static void update_Customer_And_Passport_info(
                                           string FirstName,
                                           string LastName,
                                           string address,
                                           
                                           string email,
                                           string details,
                                           byte[] pic,
                                           string PassportNo,
                                           long RefferdbyAgentid,
                                           bool isRefferedby,
                                           string SrNo,
                                           DateTime Date,
                                           string Name,
                                           // string    PassportNo  ,
                                           DateTime DateOfbirth,
                                           DateTime DateOfIssue,
                                           DateTime dateOfExpiry,
                                           string CnicNo,
                                           string Contactno1,
                                           string ContactNo2,
                                           long orignalCustomerID
                                         )

        {
            Table_Adapter_Cust.UpdateQuery_Customer_And_Passport_Info_StoreProcedure_Func
                                                                                          (
FirstName,
LastName,
address,
email,
details,
pic,

PassportNo,
RefferdbyAgentid,
isRefferedby,

SrNo,
Date,
Name,


DateOfbirth,
DateOfIssue,
dateOfExpiry,
CnicNo,
Contactno1,
ContactNo2,
orignalCustomerID
);
            
        }


        internal static void Delete_Customer(int Orignal_iD)
        {
            Table_Adapter_Cust.DeleteQuery_Customer_StoreProcedure_Func(Orignal_iD);


        }


        internal static DB.CustomersAndAgents_DataSet_appData.CustomersRow Select_Row_Customer(long Orignal_iD)
        {
            DB.CustomersAndAgents_DataSet_appData ds = new DB.CustomersAndAgents_DataSet_appData();


             Table_Adapter_Cust.FillBy_Customer_ID(ds.Customers,Orignal_iD);

            var CustrowQuery = (from o in ds.Customers
                                where (o.ID == Orignal_iD)
                                select o).FirstOrDefault();
             
           
            return CustrowQuery;
        }



        //?////////////////////////////////////////////////////////////////////////




        internal static DataView Get_Customer_Table_DataFOrGrid(string  _ID= "",
                                                                string  _FirstNAME = "",
                                                                string _LasttNAME = "",
                                                                string _Address= "",
                                                                string _MobileNo = "",
                                                                string _Email = "",
                                                                string _DetailsExtra = "",
                                                                string _CustomerFrom = "",
                                                                string _PassportNo = ""
                                                                )
        {
            
            Customers_Table_Load_Update();
            var Getquery = from o in dataSet_CustomersAndAgents_appdata.Customers
                            where
                            (o.ID.ToString().ToLower().StartsWith(_ID.ToLower())) &&
                            (o.FIRST_NAME.ToLower().Contains(_FirstNAME.ToLower())) &&
                            (o.LAST_NAME.ToString().ToLower().StartsWith(_LasttNAME.ToLower())) &&
                            (o.ADDRESS.ToLower().Contains(_Address.ToLower())) &&
                            (o.MOBILE_NO.ToLower().StartsWith(_MobileNo.ToLower())) &&
                            (o.EMAIL.ToLower().Contains(_Email.ToLower())) &&
                            (o.DETAILS.ToLower().Contains(_DetailsExtra.ToLower())) &&
                            (o.CUSTOMER_FROM.ToLongDateString().ToLower().Contains(_CustomerFrom.ToLower())) &&
                            (o.PASSPORT_NO.ToLower().StartsWith(_PassportNo.ToLower()))


                            select o;


            DataView d = Getquery.AsDataView();
            
            return d;



        }




    }
}
