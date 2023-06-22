using DataAccess.DAL;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class PersonelServices : IPersonelServices
    {
        private IPersonelDAL _personelDAL;
        public PersonelServices(IPersonelDAL personelDAL) //ctor bu
        {
            _personelDAL = personelDAL;
        }

        public void Ekle(Personel personel)
        {
            _personelDAL.Ekle(personel);
        }

        public List<Personel> GetAll()
        {
            return _personelDAL.GetAll().ToList();
        }

        public void Güncelle(Personel personel)
        {
            _personelDAL.Güncelle(personel);
        }

        public void Sil(Personel personel)
        {
            _personelDAL.Sil(personel);
        }
    }
}
