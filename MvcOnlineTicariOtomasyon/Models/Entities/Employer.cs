﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Entities
{
    public class Employer
    {
        [Key]
        public int EmployerId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string FirstName { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string LastName { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public  string Image { get; set; }

        public ICollection<SatisHareket> SatisHarekets { get; set; }
        public int DepartmanId { get; set; }
        public virtual Departman departman { get; set; }

    }
}