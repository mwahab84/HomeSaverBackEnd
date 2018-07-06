using System;
using System.Collections.Generic;
using HomeSaverBackEnd.Models.Domain;

namespace HomeSaverBackEnd.ViewModels
{
    public class HomeViewModel
    {
        public string ItemsListTitle;
        public List<Item> _Items;
        public string VendorsListTitle;
        public List<Vendor> _Vendors;
    }
}
