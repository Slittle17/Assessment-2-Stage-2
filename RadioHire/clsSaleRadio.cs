using System;

namespace RadioHire
{
    [Serializable()]
    public class clsSaleRadio : clsInventory
    {
        private DateTime _Warranty;

        public delegate void LoadSaleRadioFormDelegate(clsSaleRadio prSculpture);
        public static LoadSaleRadioFormDelegate LoadSaleRadioForm;

        public override void EditDetails()
        {
            LoadSaleRadioForm(this);
        }

        public DateTime Weight
        {
            get { return _Warranty; }
            set { _Warranty = value; }
        }        
    }
}
