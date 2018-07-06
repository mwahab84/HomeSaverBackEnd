using System;
using System.Collections.Generic;
using HomeSaverBackEnd.Models.Domain;

namespace HomeSaverBackEnd.Models.Repositories
{
    public interface IItemRepository
    {
        IEnumerable<Item> GetAllItems();

        IEnumerable<Item> GetItemsByVendor(Vendor vendor);

        Item GetItemById(string Id);

        bool DeleteItem(Item item);

        bool UpdateItem(Item item);

        bool AddItem(Item item);
    }
}
