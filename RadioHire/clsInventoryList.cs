using System;
using System.Collections.Generic;

namespace RadioHire
{
    [Serializable()]
    public class clsInventoryList : List<clsInventory>
    {
        private byte _SortOrder;

        public void AddInventory(char prSelection)
        {
            clsInventory lcInventory = clsInventory.NewInventory(prSelection);
            if (lcInventory != null)
            {
                Add(lcInventory);
            }
        }

        public void EditInventory(int prIndex)
        {
            if (prIndex >= 0 && prIndex < this.Count)
            {
                clsInventory lcInventory = (clsInventory)this[prIndex];
                lcInventory.EditDetails();
            }
            else
                throw new Exception("Sorry no inventory selected #" + Convert.ToString(prIndex));
        }

        public decimal GetTotalValue()
        {
            decimal lcTotal = 0;
            foreach (clsInventory lcInventory in this)
            {
                lcTotal += lcInventory.Price;
            }
            return lcTotal;
        }

        public void SortByName()
        {
            Sort(clsModelComparer.Instance);
            _SortOrder = 0;
        }
                
        public byte SortOrder
        {
            get { return _SortOrder; }
            set { _SortOrder = value; }
        }    
    }
}
