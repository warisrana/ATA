using com_war_air.com.WARPRO.DB;
using com_war_air.com.WARPRO.Glob.Bookings_And_Payments;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com_war_air.com.WARPRO.Glob.CustomersAndAgents
{
    partial class Glob_Ledger : CustomersAndAgents_class
    {


        internal static DataView Get_CustomerLedger_Table_DataFOrGrid(long _CustomerId
                                                                     

                                                               )
        {

            ////Old
            //CustomersAndAgents_DataSet_appData ds = new CustomersAndAgents_DataSet_appData();

            //Table_Adapter_Ledger.FillBy_CustomerLedgerByCustomerId(ds.Ledger, _CustomerId);



            //var Getquery = (from o in ds.Ledger



            //               select o);



            //New
            Bookings_And_payments_DataSet_appData.TransecDataTable ds = new Bookings_And_payments_DataSet_appData.TransecDataTable();

            WARPRO.Glob.Bookings_And_Payments.Glob_Transec.Table_AdapterTransec.FillBy_TransecForLedgCustomer_StoreProcedure(ds, _CustomerId, true);



            var Getquery = (from o in ds



                            select o);


            DataView d = Getquery.AsDataView();



            return d;



        }

        internal static DataView Get_AgentLedger_Table_DataFOrGrid(long _AgentId


                                                               )
        {

            ////Old
            //CustomersAndAgents_DataSet_appData ds = new CustomersAndAgents_DataSet_appData();

            //Table_Adapter_Ledger.FillBy_AgentLedgerByAgentId(ds.Ledger, _AgentId, true);



            //var Getquery = from o in ds.Ledger
            //                   //where
            //                   //(o.CUSTOMER_ID == _CustomerId) 


            //               select o;




            //New
            Bookings_And_payments_DataSet_appData.TransecDataTable ds = new Bookings_And_payments_DataSet_appData.TransecDataTable();

            WARPRO.Glob.Bookings_And_Payments.Glob_Transec.Table_AdapterTransec.FillByFillBy_TransecForLedgAgent_StoreProcedure(ds, _AgentId, true, true);



            var Getquery = (from o in ds



                            select o);

            DataView d = Getquery.AsDataView();



            return d;



        }



    }
}
