using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PCShop.Models;
using PCShop.ViewModels;

namespace PCShop.Controllers
{
    public class HardwareController : Controller
    {
        //fields
        private readonly IHardwareRepository _hardwareRepository;
        private readonly ICategoryRepository _categoryRepository;

        public HardwareController(IHardwareRepository hardwareRepository, ICategoryRepository categoryRepository)
        {
            _hardwareRepository = hardwareRepository;
            _categoryRepository = categoryRepository;
        }


        //pass everything to view
        public ViewResult List(string category)
        {
            IEnumerable<Hardware> hardwares;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                hardwares = _hardwareRepository.GetAllHardware.OrderBy(c => c.HardwareId);
                currentCategory = "All Hardware";
            }
            else
            {
                hardwares = _hardwareRepository.GetAllHardware.Where(c => c.Category.CategoryName == category);

                currentCategory = _categoryRepository.GetAllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }
            
            return View(new HardwareListViewModel
            {
                Hardwares = hardwares,
                CurrentCategory = currentCategory
            });
        }

        public IActionResult Details(int id)
        {
            var hardware = _hardwareRepository.GetHardwareById(id);
            if (hardware == null)
            {
                return NotFound();
            }

            return View(hardware);
        }
        
        [AcceptVerbs("GET", "POST")]
        public IActionResult ValidateName(string name)
        {
            Hardware hardware = _hardwareRepository._appDbContext.Hardwares.SingleOrDefault(h => h.Name == name);

            if (hardware != null)
                return Json($"Hardware {name} is already in use.");

            return Json(data: true);
        }
    }
}
