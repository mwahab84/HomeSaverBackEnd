using System;
using System.Collections.Generic;
using HomeSaverBackEnd.Models.Domain;

namespace HomeSaverBackEnd.Models.Repositories
{
    public interface IVendorRepository
    {
        IEnumerable<Vendor> GetAllVendors();

        IEnumerable<Item> GetItemsByVendor(Vendor vendor);

        Vendor GetVendorById(string Id);

        bool DeleteVendor(Vendor vendor);

        bool UpdateVendor(Vendor vendor);

        bool AddVendor(Vendor vendor);
    }
}
