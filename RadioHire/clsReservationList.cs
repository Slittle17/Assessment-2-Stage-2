using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RadioHire
{
    [Serializable()]
    public class clsReservationList : SortedDictionary<string, clsReservations>
    {
        private const string _FileName = "gallery.dat";

        public void NewReservation(clsReservations prReservation)
        {
            if (!string.IsNullOrEmpty(prReservation.ReservationID))
            {
                Add(prReservation.ReservationID, prReservation);
            }
            else
                throw new Exception("No artist name entered");
        }
    }
}
