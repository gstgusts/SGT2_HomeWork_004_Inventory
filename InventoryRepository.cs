using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGT2_HomeWork_004_Inventory
{
    internal class InventoryRepository
    {
        private List<InventoryItem> _items = new List<InventoryItem>();

        public void Add(InventoryItem item)
        {
            _items.Add(item);
        }

        public void Remove(InventoryItem item)
        {
            _items.Remove(item);
        }

        public IEnumerable<InventoryItem> InventoryItems => _items;

        public bool CheckAvailability(int id, int amount) {
            var item = _items.FirstOrDefault(i => i.Id == id);

            if(item == null) { return false; }

            return item.AmountLeft >= amount;
        }

        public bool OrderItem(int id, int amount)
        {
            var result = CheckAvailability(id, amount);

            if(!result)
            {
                return false;
            }

            var item = _items.FirstOrDefault(i => i.Id == id);

            if(item != null)
            {
                item.UpdateAmountLeft(amount);
                return true;
            }

            return false;
        }

    }
}
