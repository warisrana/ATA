using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com_war_air.com.WARPRO.DB;

namespace com_war_air.com.WARPRO.Glob.CustomersAndAgents
{
    partial  class Glob_Tickets :CustomersAndAgents_class
    {




        internal static void New_TicketInsert(long customerid, string pnr, string carrierAirline, string sector, DateTime travellingDate, string issuedFrom, decimal faceValue, decimal payable, decimal profit, bool okToBoard, string type, DateTime departuredate, string ReturnDateLongstring , string visaType, string  PaymentType , string Travellingfrom, string destination    )
        {
           

            if (string.IsNullOrWhiteSpace( ReturnDateLongstring) == true )
            {
                Table_Adapter_Ticket.Insert(customerid, pnr, carrierAirline, sector, travellingDate, issuedFrom, faceValue, payable, profit, okToBoard, type, departuredate, null, visaType, PaymentType, true, Travellingfrom, destination);

            }


            if (string.IsNullOrWhiteSpace(ReturnDateLongstring) == false)
            {


                Table_Adapter_Ticket.Insert(customerid, pnr, carrierAirline, sector, travellingDate, issuedFrom, faceValue, payable, profit, okToBoard, type, departuredate,  DateTime.Parse(ReturnDateLongstring), visaType, PaymentType, true, Travellingfrom, destination);

            }

            //Table_Adapter_Ticket.Insert( customerid,  pnr,  carrierAirline,  sector,  travellingDate,  issuedFrom,  faceValue,  payable, profit,  okToBoard,  type,  departuredate,  ReturnDateLongstring,  visaType,   PaymentType, true,  Travellingfrom,  destination);

        }



        internal static string GetLastID()
        {
            string rr = (string)Table_Adapter_Ticket.ScalarQuery_GetLast_TicketID_Func();

            string id = rr.ToString();

            return id;

        }




        internal static  void  Update_Ticketinfo(long customerid, string pnr, string carrierAirline, string sector, DateTime travellingDate, string issuedFrom, decimal faceValue, decimal payable, decimal profit, bool okToBoard, string type, DateTime departuredate, string ReturnDateLongstring, string visaType, string PaymentType, string Travellingfrom, string destination , string OrignalPnr)
        {

            if (string.IsNullOrWhiteSpace(ReturnDateLongstring) == true)
            {
                Table_Adapter_Ticket.UpdateQuery_Ticket_Information_StoreProcedure_Func(customerid, pnr, carrierAirline, sector, travellingDate, issuedFrom, faceValue, payable, profit, okToBoard, type, departuredate, null, visaType, PaymentType,  Travellingfrom, destination, OrignalPnr);

            }


            if (string.IsNullOrWhiteSpace(ReturnDateLongstring) == false)
            {

                Table_Adapter_Ticket.UpdateQuery_Ticket_Information_StoreProcedure_Func(customerid, pnr, carrierAirline, sector, travellingDate, issuedFrom, faceValue, payable, profit, okToBoard, type, departuredate, DateTime.Parse(ReturnDateLongstring), visaType, PaymentType, Travellingfrom, destination, OrignalPnr);

            }

        }

        internal static CustomersAndAgents_DataSet_appData.TicketsRow Get_TicketRow(string OrignalPnr)
        {
            CustomersAndAgents_DataSet_appData ds = new CustomersAndAgents_DataSet_appData();


            Table_Adapter_Ticket.FillBy_Ticket_Row_by_PNR_StoreProcedure(ds.Tickets, OrignalPnr );

            var gg = (from o in ds.Tickets
                      where (o.PNR == OrignalPnr)
                      select o).FirstOrDefault();
            return gg;
        }


        internal static void update_Ticket__Deal_Activation_Status(bool status, string _orignalPnr)
        {
            Table_Adapter_Ticket.UpdateQuery_Ticket_Deal_Status_StoreProcedure_Func(status, _orignalPnr);


        }

        internal static DataView Get_Tickets_Table_DataFOrGrid( string _Pnr = "",
                                                                string _CustomerID = ""
                                                                
                                                                )
        {

            Tickets_Table_Load_Update();
            var Getquery = from o in dataSet_CustomersAndAgents_appdata.Tickets
                           where
                           (o.PNR.ToLower().StartsWith(_Pnr.ToLower())) &&
                           (o.CUSTOMER_ID.ToString().ToLower().StartsWith(_CustomerID.ToLower()))
                           

                           select o;


            DataView d = Getquery.AsDataView();



            return d;



        }

    }
}
