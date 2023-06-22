using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IUrunServices
    {
        void Ekle(Urun urun);
        void Sil(Urun urun);
        void Güncelle(Urun urun);
        List<Urun> GetAll();
    }
}
