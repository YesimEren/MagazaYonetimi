using DataAccess.Baglanti;
using EntityLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAL.BaseDAL
{
    public class BaseDAL <TEntity> : IBaseDal<TEntity>
        where TEntity:class,IEntity,new()
    {
        void IBaseDal<TEntity>.Ekle(TEntity entity)
        {
            using (var baglanti = new MagazaYonetimDB()) 
            {
                var eklenenEntity=baglanti.Entry(entity);
                eklenenEntity.State = EntityState.Added;
                baglanti.SaveChanges();
            }
        }

        List<TEntity> IBaseDal<TEntity>.GetAll()
        {
            using(var baglanti=new MagazaYonetimDB())
            {
                return baglanti.Set<TEntity>().ToList();
            }
        }

        void IBaseDal<TEntity>.Getir(Expression<Func<TEntity, bool>> filter) // filtreleme özelliği ya getir ya da boş dön.filtrele
        {
            using( var baglanti= new MagazaYonetimDB())
            {
                baglanti.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        void IBaseDal<TEntity>.Güncelle(TEntity entity)
        {
            using (var baglanti = new MagazaYonetimDB())
            {
                var güncellenenEntity = baglanti.Entry(entity);
                güncellenenEntity.State = EntityState.Modified;
                baglanti.SaveChanges();
            }
        }
       
        void IBaseDal<TEntity>.Sil(TEntity entity)
        {
            using(var baglanti=new MagazaYonetimDB())
            {
                var silinenEntity=baglanti.Entry(entity);
                silinenEntity.State = EntityState.Deleted;

            }
        }
    }
}
