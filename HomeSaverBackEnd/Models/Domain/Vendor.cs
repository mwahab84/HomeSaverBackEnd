using System;
using System.Collections.Generic;

namespace HomeSaverBackEnd.Models.Domain
{
    public class Vendor
    {
        public string Id
        {
            get;
            set;
        }
        public string Title
        {
            get;
            set;
        }
        public string Desc
        {
            get;
            set;
        }
        public string VendorLogoPath
        {
            get;
            set;
        }
        //public string[] Locations
        //{
        //    get;
        //    set;
        //}
        public List<Item> Items { get; set; }
    }
}
