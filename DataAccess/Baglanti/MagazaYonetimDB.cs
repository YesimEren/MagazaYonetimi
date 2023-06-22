using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Baglanti
{
    public class MagazaYonetimDB:DbContext
         
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-6P5BF8B;Database=MagazaYonetimDB;User Id=sa;Password=1q2w3e4r+!;TrustServerCertificate=True");

        }

        public DbSet<Personel>Personeller { get; set; }
        public DbSet<Urun>Urunler { get; set; }
    }
}
