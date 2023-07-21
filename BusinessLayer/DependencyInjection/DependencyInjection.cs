using DataAccess.DAL;
using DataAccess.DAL.BaseDAL;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DependencyInjection
{
    public class DependencyInjection : NinjectModule
    {
        public override void Load()
        {
            Bind<IPersonelDAL>().To<PersonelDAL>(); 
            Bind<IUrunDAL>().To<UrunDAL>();
            Bind<PersonelServices>().To<PersonelServices>();

            Bind<IUrunDAL>().To<UrunDAL>();
            Bind<IUrunServices>().To<UrunServices>();
        }
    }
}
