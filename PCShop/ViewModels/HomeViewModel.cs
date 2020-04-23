using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PCShop.Models;

namespace PCShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Hardware> HardwareOnSale { get; set; }
    }
}
