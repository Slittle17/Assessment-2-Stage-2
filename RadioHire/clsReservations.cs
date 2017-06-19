using System;

namespace RadioHire
{
    [Serializable()]
    public class clsReservations
    {
        private int _ReservationID;
        private string _CustomerName;
        private int _CustomerPhone;
        private string _QuantityOrdered;
        private Decimal _UnitPrice;
        private DateTime _ReservationDateTime;

        public int ReservationID
        {
            get { return _ReservationID; }
            set { _ReservationID = value; }
        }

        public string CustomerName
        {
            get { return _CustomerName; }
            set { _CustomerName = value; }
        }

        public int CustomerPhone
        {
            get { return _CustomerPhone; }
            set { _CustomerPhone = value; }
        }

        public string QuantityOrdered
        {
            get { return _QuantityOrdered; }
            set { _QuantityOrdered = value; }
        }

        public decimal UnitPrice
        {
            get { return _UnitPrice; }
            set { _UnitPrice = value; }
        }

        public DateTime ReservationDateTime
        {
            get { return _ReservationDateTime; }
            set { _ReservationDateTime = value; }
        }
    }
}
