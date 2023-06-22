using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAL.BaseDAL
{
    public interface IBaseDal<TEntity> where TEntity:class,IEntity,new()
    {
        void Ekle(TEntity entity);
        void Sil(TEntity entity);
        void Güncelle (TEntity entity);
        void Getir( Expression<Func<TEntity,bool>>filter);
        List<TEntity> GetAll();
    }
}
