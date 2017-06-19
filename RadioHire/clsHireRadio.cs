using System;

namespace RadioHire
{
    [Serializable()]
    public class clsHireRadio : clsInventory
    {
        private string _Condition;
        private DateTime _AcqDate;

        public delegate void LoadHireRadioFormDelegate(clsHireRadio prPainting);
        public static LoadHireRadioFormDelegate LoadHireRadioForm;

        

        public override void EditDetails()
        {
            LoadHireRadioForm(this);
        }

        public string Condition
        {
            get{ return _Condition; }
            set{ _Condition = value; }
        }

        public DateTime AcqDate
        {
            get{ return _AcqDate;}
            set{_AcqDate = value;}
        }
    }
}
