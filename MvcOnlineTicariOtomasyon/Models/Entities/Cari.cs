using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Entities
{
    public class Cari
    {
        [Key]
        public int CariId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string CariName { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string CariLastName { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string CariTitle { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(13)]
        public string CariCity { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string CariMail { get; set; }

        public bool Status { get; set; }

        public ICollection<SatisHareket> SatisHarekets { get; set; }
    }
}