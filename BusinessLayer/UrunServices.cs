using DataAccess.DAL;
using DataAccess.DAL.BaseDAL;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class UrunServices : IUrunServices
    {
        private IUrunDAL _urundal;
        public UrunServices(IUrunDAL urunDAL)
        {
            _urundal = urunDAL;
        }
        public void Ekle(Urun urun)
        {
            _urundal.Ekle(urun);
        }

        public List<Urun> GetAll()
        {
            return _urundal.GetAll().ToList();
        }
        //depencie injecitiom
        public void Güncelle(Urun urun)
        {
            _urundal.Güncelle(urun);
        }

        public void Sil(Urun urun)
        {
            _urundal.Sil(urun);
        }
    }
}
