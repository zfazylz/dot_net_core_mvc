using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PCShop.Models;

namespace PCShop.ViewModels
{
    public class HardwareListViewModel
    {
        public IEnumerable<Hardware> Hardwares { get; set; }
        public string CurrentCategory { get; set; }
    }
}
