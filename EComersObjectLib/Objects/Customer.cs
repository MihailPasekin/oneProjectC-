using EComersObjectLib.SapObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib.Objects
{
    public class Customer
    {
        public Customer() 
        {
        }

        public Customer(OCRD ocrd, int id)
        {
            CustomerId = id;
            CardCode = ocrd.CardCode;
            CardName = ocrd.CardName;
            Phone1 = ocrd.Phone1;
            Free_Text = ocrd.Free_Text;
            Notes = ocrd.Notes;
            U_lat = ocrd.U_lat;
            U_lng = ocrd.U_lng;
            U_RouteID = ocrd.U_RouteID;
        }

        public int CustomerId { get; set; }
        public string CardCode { get; set; }
        public string CardName { get; set; }
        public string Phone1 { get; set; }
        public string Free_Text { get; set; }
        public string Notes { get; set; }
        public string U_lat { get; set; }
        public string U_lng { get; set; }
        public string U_RouteID { get; set; }

        public List<MerchVisit> MerchVisits { get; set; }

        public bool EqulsOcrd (OCRD ocrd)
        {
            if (ocrd == null) return false;
            if (CardName == ocrd.CardName 
                && Phone1 == ocrd.Phone1 
                && Free_Text == ocrd.Free_Text 
                && Notes == ocrd.Notes 
                && U_lat == ocrd.U_lat 
                && U_lng == ocrd.U_lng
                && U_RouteID == ocrd.U_RouteID) 
            { 
                return true; 
            }
            else
            {
                return false;
            }
        }
    }
}
