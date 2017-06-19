using System;

namespace RadioHire
{
    [Serializable()]
    public abstract class clsInventory
    {
        private string _InventoryID;
        private string _Model;
        private string _Description;
        private decimal _Price;
        private DateTime _DateTimeMod = DateTime.Now;
        private int _QuantityInStock;
        private string _SaleType;
         
        public clsInventory()
        {
            EditDetails();
        }

        public static readonly string FACTORY_PROMPT = "Enter H to add a radio for hire, or type S to add a radio for sale";

        

        public static clsInventory NewInventory(char prSelect)
        {
            switch (char.ToUpper(prSelect))
            {
                case 'H': return new clsHireRadio();
                case 'S': return new clsSaleRadio();      
                default: return null;
            }
        }

        public abstract void EditDetails();

        public override string ToString()
        {
            return Model + "\t" + DateTimeMod.ToShortDateString();
        }
                
        public string InventoryID
        {
            get { return _InventoryID; }
            set { _InventoryID = value; }
        }

        public string Model
        {
            get { return _Model; }
            set { _Model = value;}
        }

        public string Description
        {
            get { return _Description; }
            set { _Description = value;}
        }

        public decimal Price
        {
            get { return _Price; }
            set { _Price = value; }
        }

        public DateTime DateTimeMod
        {
            get { return _DateTimeMod; }
            set { _DateTimeMod = value; }
        }

        public int QuantityInStock
        {
            get { return _QuantityInStock; }
            set { _QuantityInStock = value; }
        }

        public string SaleType
        {
            get { return _SaleType; }
            set { _SaleType = value; }
        }

    }
}
