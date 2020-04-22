using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PCShop.Models;
using PCShop.ViewModels;

namespace PCShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IHardwareRepository _hardwareRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IHardwareRepository hardwareRepository, ShoppingCart shoppingCart)
        {
            _hardwareRepository = hardwareRepository;
            _shoppingCart = shoppingCart;
        }
        public IActionResult Index()
        {
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int hardwareId)
        {
            var selectedHardware = _hardwareRepository.GetAllHardware.FirstOrDefault(c => c.HardwareId == hardwareId);

            if (selectedHardware != null)
            {
                _shoppingCart.AddToCart(selectedHardware, 1);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int hardwareId)
        {
            var selectedHardware = _hardwareRepository.GetAllHardware.FirstOrDefault(c => c.HardwareId == hardwareId);

            if (selectedHardware != null)
            {
                _shoppingCart.RemoveFromCart(selectedHardware);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult ClearCart()
        {
            _shoppingCart.ClearCart();
            return RedirectToAction("Index");
        }
    }
}