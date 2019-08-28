using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com_war_air.com.WARPRO.Glob.CustomersAndAgents
{
    partial class  Agents_Partial : CustomersAndAgents_class
    {

        internal static void NewAgent(string FirstName, string LastName, string address, string mobileNo, string email,  byte[] pic)
        {
            Table_Adapter_Agent.Insert(FirstName, LastName, address, mobileNo, email, pic, DateTime.Today  , true);


        }
        internal static void update_Agent_info(string FirstName, string LastName, string address, string mobileNo, string email , byte[] pic, long Orignal_iD )
        {
            Table_Adapter_Agent.UpdateQuery_Agent_Info_StoreProcedure_Func(FirstName, LastName, address, mobileNo, email, pic , Orignal_iD );


        }

        internal static void update_Agent_Activation_Status(bool status, long _orignalAgentID)
        {
            Table_Adapter_Agent.UpdateQuery_Agent_Activation_Status_Change_StoreProcedure_Func(status, _orignalAgentID);


        }


        internal static void Delete_Agent(int Orignal_iD)
        {
            Table_Adapter_Agent.DeleteQuery_Agents_StoreProcedure_Func(Orignal_iD);


        }


        internal static DB.CustomersAndAgents_DataSet_appData.AgentsRow Select_Row_Agent(long Orignal_iD)
        {
            DB.CustomersAndAgents_DataSet_appData ds = new DB.CustomersAndAgents_DataSet_appData();

            Table_Adapter_Agent.FillBy_Agent_ID(ds.Agents, Orignal_iD);

            var AgenttrowQuery = (from o in ds.Agents
                                where (o.ID == Orignal_iD)
                                select o).FirstOrDefault();


            return AgenttrowQuery;
        }


        //?////////////////////////////////////////////////////////////////////////




        internal static DataView Get_Agent_Table_DataFOrGrid(   string _ID = "",
                                                                string _FirstNAME = "",
                                                                string _LasttNAME = "",
                                                                string _Address = "",
                                                                string _MobileNo = "",
                                                                string _Email = "",
                                                               
                                                                string _AgentFromDate = "",
                                                                string _Status = ""
                                                                )
        {

            Agents_Table_Load_Update();
            var Getquery = from o in dataSet_CustomersAndAgents_appdata.Agents
                           where
                           (o.ID.ToString().ToLower().StartsWith(_ID.ToLower())) &&
                           (o.FIRST_NAME.ToLower().Contains(_FirstNAME.ToLower())) &&
                           (o.LAST_NAME.ToString().ToLower().StartsWith(_LasttNAME.ToLower())) &&
                           (o.ADDRESS.ToLower().Contains(_Address.ToLower())) &&
                           (o.MOBILE_NO.ToLower().StartsWith(_MobileNo.ToLower())) &&
                           (o.EMAIL.ToLower().Contains(_Email.ToLower())) &&
                           
                           (o.AGENT_FROM.ToLongDateString().ToLower().Contains(_AgentFromDate.ToLower())) &&
                           (o.STATUS.ToString().ToLower().StartsWith(_Status.ToLower()))


                           select o;


            DataView d = Getquery.AsDataView();



            return d;



        }


        /////


    }
}
