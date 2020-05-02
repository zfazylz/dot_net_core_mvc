using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PCShop.Models
{
    public interface IHardwareRepository
    {
        IEnumerable<Hardware> GetAllHardware { get; }
        IEnumerable<Hardware> GetHardwareOnSale { get; }
        Hardware GetHardwareById(int hardwareId);
        AppDbContext _appDbContext { get; set; }
    }
}
