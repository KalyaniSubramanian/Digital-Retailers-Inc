using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace LaptopApplication.Models
{
    public class LaptopDBContext : DbContext
    {
        public LaptopDBContext(DbContextOptions<LaptopDBContext> options)
            : base(options)
        {

        }
        public DbSet<LaptopModel> Laptops { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<LaptopModel>().HasData(
                new LaptopModel { SNo = 1, Image = "/HP.jpg", ModelName = "HP Pavilion", Specification = "10th Gen Core i3-10110U/8GB/512GB SSD", color = "Mineral Silver", Price = 52000.00 },
                new LaptopModel { SNo = 2, Image = "/Lenovo.jpg", ModelName = "Lenovo IdeaPad S540", Specification = "10th Gen Intel Core i5 /8GB/1TB HDD + 256GB", color = "Mineral Grey", Price = 62000.00 },
                new LaptopModel { SNo = 3, Image = "/Dell.jpg", ModelName = "Dell XPS 9570", Specification = "8th Gen Core i7-8750H/16GB/512 GB", color = "Silver", Price = 130000.00 },
                new LaptopModel { SNo = 4, Image = "/Apple.jpg", ModelName = "New Apple MacBook Air ", Specification = "13-inch, 1.1GHz Quad-core 10th-Generation Intel Core i5 Processor, 8GB RAM, 512GB Storage", color = "Gold", Price = 119000.00 },
                new LaptopModel { SNo = 5, Image = "/LG.jpg", ModelName = "LG Gram", Specification = "10th Gen Intel Core i7/8GB/512GB SSD", color = "Dark Silver", Price = 99000.00 },
                new LaptopModel { SNo = 6, Image = "/Acer.jpg", ModelName = "Acer Swift 3", Specification = "Intel i5 - 11th Gen/8 GB Ram/512GB SSD", color = "Pure Silver", Price = 65000.00 },
                new LaptopModel { SNo = 7, Image = "/MI.jpg", ModelName = "Mi Notebook 14", Specification = "Intel core i3/10th Gen Thin and Light Laptop (8GB/256GB SSD)", color = "Silver", Price = 37000.00 },
                new LaptopModel { SNo = 8, Image = "/Asus.jpg", ModelName = "ASUS VivoBook 14", Specification = "4GB RAM/1TB HDD", color = "Slate Grey", Price = 26000.00 }
               
               );
        }
    }
}
