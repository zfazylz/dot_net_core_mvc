using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PCShop.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        //constructor
        public AppDbContext(DbContextOptions<AppDbContext> options) :
            base(options)
        {
        }

        public DbSet<Hardware> Hardwares { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        //seeding the database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //add data to category
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "CPU" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "GPU" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "RAM" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "ROM" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 5, CategoryName = "Cases" });

            //add data to hardware
            modelBuilder.Entity<Hardware>().HasData(new Hardware
            {
                HardwareId = 1,
                Name = "Intel Core i9-10900X Tray",
                Price = 990M,
                Description = "Threads	- 20, CPU Series - Intel Core i9, Graphics integrated - no integerated GPU, CPU Cores - 10, CPU Speed - 3.70 GHz, L3 Cache - 19.25 MB",
                CategoryId = 1,
                ImageUrl = "\\Images\\thumbnails\\cpu1.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\cpu1.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Hardware>().HasData(new Hardware
            {
                HardwareId = 2,
                Name = "Intel Core I5-4590 4 core",
                Price = 450M,
                Description = "High End Quad Core CPU, tray for Sockel 1150, 84 W TDP 4 Cores / 4 Threads, Intel® HD Graphics 4600 integrated Basistakt: 3.30 GHz, (up to 3.70 GHz) 6 MB L3 cache",
                CategoryId = 1,
                ImageUrl = "\\Images\\thumbnails\\cpu2.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\cpu2.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Hardware>().HasData(new Hardware
            {
                HardwareId = 3,
                Name = "Intel Core i7-6700K",
                Price = 630M,
                Description = "Enthusiast Quad Core CPU, Boxed (without heatsink) for Sockel 1151, 91 W TDP 4 Cores / 8 Threads, Intel® HD Graphics 530 integrated Basistakt: 4.00 GHz, (up to 4.20 GHz) 8 MB L3 cache, Unlocked multiplier",
                CategoryId = 1,
                ImageUrl = "\\Images\\thumbnails\\cpu3.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\cpu3.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Hardware>().HasData(new Hardware
            {
                HardwareId = 4,
                Name = "Radeon RX 5700 8.0 GB",
                Price = 750M,
                Description = "AMD Radeon™ RX 5700 XT 8.0 GB, 1840 MHz chip clock rate, 2035 MHz Boost, Connection via PCIe 4.0, Active Cooling (Tri-Slot), 2x HDMI, 2x DisplayPort, Crossfire",
                CategoryId = 2,
                ImageUrl = "\\Images\\thumbnails\\gpu1.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\gpu1.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Hardware>().HasData(new Hardware
            {
                HardwareId = 5,
                Name = "GeForce RTX 2070  8.0 GB",
                Price = 860M,
                Description = "NVIDIA® GeForce® RTX 2070 Super™ 8.0 GB, Overclocked, 1605 MHz chip clock rate, 1800 MHz Boost, Connection via 3.0, Active Cooling (Tri-Slot)",
                CategoryId = 2,
                ImageUrl = "\\Images\\thumbnails\\gpu2.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\gpu2.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Hardware>().HasData(new Hardware
            {
                HardwareId = 6,
                Name = "Radeon RX 4000 4.0 GB",
                Price = 320M,
                Description = "AMD Radeon™ RX 4000 XT 4.0 GB, Overclocked, 1605 MHz chip clock rate, 1905 MHz Boost, Connection via PCIe 4.0, Active Cooling (Dual-Slot) ",
                CategoryId = 2,
                ImageUrl = "\\Images\\thumbnails\\gpu3.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\gpu3.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Hardware>().HasData(new Hardware
            {
                HardwareId = 7,
                Name = "Crucial Black 16GB",
                Price = 210M,
                Description = "16 GB RAM, 2x 8 GB Kit, DDR4, 3200 MHz (PC4-25600), DIMM 288 Pin, CL16",
                CategoryId = 3,
                ImageUrl = "\\Images\\thumbnails\\ram1.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\ram1.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Hardware>().HasData(new Hardware
            {
                HardwareId = 8,
                Name = "G.Skill Aegis 16GB",
                Price = 150M,
                Description = "16 GB RAM, 2x 8 GB Kit, DDR4, 3200 MHz (PC4-25600), DIMM 288 Pin, CL1616 GB RAM, 2x 8 GB Kit, DDR4, 3200 MHz (PC4-25600), DIMM 288 Pin, CL16",
                CategoryId = 3,
                ImageUrl = "\\Images\\thumbnails\\ram2.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\ram2.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Hardware>().HasData(new Hardware
            {
                HardwareId = 9,
                Name = "Corsair XMS3 RAM 4GB",
                Price = 110M,
                Description = "4 GB RAM, 2x 2 GB Kit, DDR3, 1333 MHz (PC3-10600), DIMM 240 Pin, CL9",
                CategoryId = 3,
                ImageUrl = "\\Images\\thumbnails\\ram3.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\ram3.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Hardware>().HasData(new Hardware
            {
                HardwareId = 10,
                Name = "Samsung SSD 970 1TB",
                Price = 420M,
                Description = "1.0 TB SSD, Connection via PCI Express x4 (NVMe), Form factor M.2 (2280), Write speed up to 3300 MB/s, up to 3500 MB/s",
                CategoryId = 4,
                ImageUrl = "\\Images\\thumbnails\\rom1.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\rom1.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Hardware>().HasData(new Hardware
            {
                HardwareId = 11,
                Name = "Intel SSD S3500 480GB",
                Price = 375M,
                Description = "480 GB SSD, Connection via SATA3, Form factor 2.5, Installationa height 7 mm, Write speed up to 410 MB/s, upp to 500 MB/s",
                CategoryId = 4,
                ImageUrl = "\\Images\\thumbnails\\rom2.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\rom2.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Hardware>().HasData(new Hardware
            {
                HardwareId = 12,
                Name = "ADATA SU630 SDD 240GB",
                Price = 230M,
                Description = "240 GB SSD, Connection via SATA3, Form factor 2.5, Installation height 7 mm, Write speed up to 450 MB/s, up to 520 MB/s",
                CategoryId = 4,
                ImageUrl = "\\Images\\thumbnails\\rom3.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\rom3.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Hardware>().HasData(new Hardware
            {
                HardwareId = 13,
                Name = "Pure Base 600 Midi-Tower",
                Price = 110M,
                Description = "Midi-Tower (sound dampened), supports ATX, mATX Boards, Internal: 8x 2.5, 3x 3.5, External: 2x 5.25, 1x 140 mm fan, 1x 120 mm fan, 2x USB3.1 Gen 1",
                CategoryId = 5,
                ImageUrl = "\\Images\\thumbnails\\case1.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\case1.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Hardware>().HasData(new Hardware
            {
                HardwareId = 14,
                Name = "Cooler Master Mastercase H100",
                Price = 225M,
                Description = "Mini ITX Gehäuse, supports mini-ITX Boards, Internal: 4x 2.5, 1x 3.5",
                CategoryId = 5,
                ImageUrl = "\\Images\\thumbnails\\case2.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\case2.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Hardware>().HasData(new Hardware
            {
                HardwareId = 15,
                Name = "GIGABYTE GB-AC300G",
                Price = 350M,
                Description = "Midi-Tower mit plasticfenster, supports ATX Boards, Internal: 3x 2.5, 2x 3.5, 2x 120 mm fan",
                CategoryId = 5,
                ImageUrl = "\\Images\\thumbnails\\case3.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\case3.jpg",
                IsInStock = true,
                IsOnSale = false
            });
        }
    }
}
