using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGT2_HomeWork_004_Inventory
{
    public abstract class InventoryItem
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int AmountLeft { get; set; }

        private int _amountLeft;

        internal void UpdateAmountLeft(int amount)
        {
            AmountLeft -= amount;
        }

    }

}
