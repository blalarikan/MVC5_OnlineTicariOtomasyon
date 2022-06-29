using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MvcOnlineTicariOtomasyon.Models.Entities;

namespace MvcOnlineTicariOtomasyon.Models.Context
{
    public class Context:DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Cari> Cariler { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Departman> Departmanlar { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<Fatura> Faturalar { get; set; }
        public DbSet<FaturaKalem> FaturaKalemler { get; set; }
        public DbSet<Gider> Giderler { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SatisHareket> SatisHareketler { get; set; }
    }
}