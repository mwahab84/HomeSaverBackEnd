using System;
using System.Collections.Generic;
using System.Linq;
using HomeSaverBackEnd.Models.Domain;

namespace HomeSaverBackEnd.Models.Repositories
{
    public class MockItemRepository: IItemRepository
    {
        private List<Item> _itemsList;

        public MockItemRepository()
        {
            if (_itemsList == null)
            {
                InitializeItems();
            }
        }

        private void InitializeItems(){
            _itemsList = new List<Item> {
                new Item { },
                new Item { },
                new Item { },
                new Item { }
            };
        }

        public bool AddItem(Item item)
        {
            throw new NotImplementedException();
        }

        public bool DeleteItem(Item item)
        {
            return _itemsList.Remove(item);
        }

        public IEnumerable<Item> GetAllItems()
        {
            return _itemsList;
        }

        public Item GetItemById(string Id)
        {
            return _itemsList.SingleOrDefault(i => i.Id == Id);
        }

        public IEnumerable<Item> GetItemsByVendor(Vendor vendor)
        {
            return _itemsList.Where(v => v.Vendor == vendor);
        }

        public bool UpdateItem(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
