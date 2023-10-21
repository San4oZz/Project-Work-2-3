using DAL;
using DALEntity;
using ModelLayer;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class SimpleConfigModule: NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository<Student>>().To<EntityFrameworkRepository<Student>>().InSingletonScope();
        }
    }
}
