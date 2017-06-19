using System;
using System.Collections.Generic;

namespace RadioHire
{
    sealed class clsModelComparer : IComparer<clsInventory>
    {    //Singleton
        public static readonly clsModelComparer Instance = new clsModelComparer();

        private clsModelComparer() { }

        public int Compare(clsInventory x, clsInventory y)
        {
            clsInventory InventoryClassX = x;
            clsInventory InventoryClassY = y;
            string lcModelX = InventoryClassX.Model;
            string lcModelY = InventoryClassY.Model;

            return lcModelX.CompareTo(lcModelY);
        }

    }
}
