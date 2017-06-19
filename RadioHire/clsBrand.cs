using System;

namespace RadioHire
{
    [Serializable()]
    public class clsBrand
    {
        private string _Brand;
        private string _CountryOfOrigin;
        private string _Manufacturer;

        private clsInventoryList _InventoryList;
        private clsBrandList _BrandList;

        public clsBrand() { }

        public clsBrand(clsBrandList prBrandList)
        {
            _InventoryList = new clsInventoryList();
            _BrandList = prBrandList;
        }

        public bool IsDuplicate(string prBrandName)
        {
            return _BrandList.ContainsKey(prBrandName);
        }

        public void NewBrand()
        {
            if (!string.IsNullOrEmpty(Brand))
                _BrandList.Add(Brand, this);
            else
                throw new Exception("No brand name entered");
        }

        public string Brand
        {
            get { return _Brand; }
            set { _Brand = value; }
        }

        public string CountryOfOrigin
        {
            get { return _CountryOfOrigin; }
            set { _CountryOfOrigin = value; }
        }

        public string Manufacturer
        {
            get { return _Manufacturer; }
            set { _Manufacturer = value; }
        }

        public decimal TotalValue
        {
            get { return _InventoryList.GetTotalValue();}
        }

        public clsBrandList BrandList
        {
            get { return _BrandList; }
        }

        public clsInventoryList InventoryList
        {
            get { return _InventoryList; }
        }
    }
}
