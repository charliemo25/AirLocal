using airbnb.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace airbnb.Entities
{
    public class Reservation
    {
        public int IdReservation { get; set; }
        public Hebergement hebergement{ get; set; }
        public DateTime DateReservation { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public int Reduction { get; set; }



        public Reservation()
        {
            
        }
    }
}