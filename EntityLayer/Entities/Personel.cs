using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Personel:IEntity
    {
        [Key]  //personelıd primarykey var o yüzden
        public int PersonelId { get; set; }
        public int PersonelNo { get; set; }
        public string PersonelAd { get; set; }
        public string PersonelSoyad { get; set; }
        public decimal Mass { get; set; }
        public string Departman { get; set; }
    }
}
