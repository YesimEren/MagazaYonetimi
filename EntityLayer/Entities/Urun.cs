using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Urun:IEntity
    {
        [Key]
        public int UrunId { get; set; }
        public string UrunAd { get; set; }
        public string KatedoriAd { get; set; }
        public decimal Fiyat { get; set; }
    }
}
