using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Entities
{
    public class SatisHareket
    {
        [Key]
        public int SatisId { get; set; }
        //ürün
        //kime sattım
        //kim sattı
        public DateTime Tarih { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }
        public decimal ToplamTutar { get; set; }

        public int ProductId { get; set;}
        public int CariId { get; set; }
        public int EmployerId { get; set; }
        public virtual Product Product { get; set; }
        public virtual Cari Cari { get; set; }
        public virtual Employer Employer { get; set; }


    }
}