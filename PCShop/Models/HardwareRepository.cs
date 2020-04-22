using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PCShop.Models
{
    public class HardwareRepository : IHardwareRepository
    {
        private readonly AppDbContext _appDbContext;

        public HardwareRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Hardware> GetAllHardware 
        {
            get
            {
                return _appDbContext.Hardwares.Include(c => c.Category);
            }
        }

        public IEnumerable<Hardware> GetHardwareOnSale
        {
            get
            {
                return _appDbContext.Hardwares.Include(c => c.Category).Where(p => p.IsOnSale);
            }
        }

        public Hardware GetHardwareById(int hardwareId)
        {
            return _appDbContext.Hardwares.FirstOrDefault(c => c.HardwareId == hardwareId);
        }
    }
}
