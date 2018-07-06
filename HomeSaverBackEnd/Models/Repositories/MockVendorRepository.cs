using System;
using System.Linq;
using System.Collections.Generic;
using HomeSaverBackEnd.Models.Domain;

namespace HomeSaverBackEnd.Models.Repositories
{
    public class MockVendorRepository:IVendorRepository
    {
        private List<Vendor> _vendorsList;

        public MockVendorRepository()
        {
            if (_vendorsList == null)
            {
                InitializeVendors();
            }
        }

        private void InitializeVendors(){
            _vendorsList = new List<Vendor> { 
                new Vendor { },
                new Vendor { }
            };
        }

        public bool AddVendor(Vendor vendor)
        {
            throw new NotImplementedException();
        }

        public bool DeleteVendor(Vendor vendor)
        {
            return _vendorsList.Remove(vendor);
        }

        public IEnumerable<Vendor> GetAllVendors()
        {
            return _vendorsList;
        }

        public IEnumerable<Item> GetItemsByVendor(Vendor vendor)
        {
            List<Item> _itemsList = new List<Item>();
            return _itemsList.Where(v => v.Vendor == vendor);
        }

        public Vendor GetVendorById(string Id)
        {
            return _vendorsList.SingleOrDefault(v => v.Id == Id);
        }

        public bool UpdateVendor(Vendor vendor)
        {
            throw new NotImplementedException();
        }
    }
}
