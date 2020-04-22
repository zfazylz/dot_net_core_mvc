using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PCShop.Models;
using PCShop.ViewModels;

namespace PCShop.Controllers
{
    public class HomeController : Controller
    {
        //in order to access the list of hardware
        private readonly IHardwareRepository _hardwareRepository;

        public HomeController(IHardwareRepository hardwareRepository)
        {
            _hardwareRepository = hardwareRepository;
        }
        
        //get the list of hardware on sale
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                HardwareOnSale = _hardwareRepository.GetHardwareOnSale
            };

            return View(homeViewModel);
        }
    }
}