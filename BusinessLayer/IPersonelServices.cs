using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IPersonelServices
    {
        void Ekle(Personel personel);
        void Sil(Personel personel);
        void Güncelle(Personel personel);
        List<Personel>GetAll();
    }
}
