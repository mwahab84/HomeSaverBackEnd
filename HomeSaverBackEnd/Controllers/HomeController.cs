using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HomeSaverBackEnd.Models;
using HomeSaverBackEnd.Models.Repositories;
using HomeSaverBackEnd.ViewModels;

namespace HomeSaverBackEnd.Controllers
{
    public class HomeController : Controller
    {
        IItemRepository _itemRepository;
        IVendorRepository _vendorReository;
        public HomeController(IItemRepository itemRepository, IVendorRepository vendorRepository){
            _itemRepository = itemRepository;
            _vendorReository = vendorRepository;
        }
        public IActionResult Index()
        {
            var items = _itemRepository.GetAllItems().OrderBy(i => i.UnitPrice);
            var vendors = _vendorReository.GetAllVendors();

            var homeViewModel = new HomeViewModel();
            homeViewModel.ItemsListTitle = "Products List";
            homeViewModel._Items = items.ToList();

            homeViewModel.VendorsListTitle = "Registered Vendors";
            homeViewModel._Vendors = vendors.ToList();

            return View(homeViewModel);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
