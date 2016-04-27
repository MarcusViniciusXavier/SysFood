using SimpleInjector;
using SysFood.Data;
using SysFood.Domain;
using SysFood.Interfaces.Repository;
using SysFood.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysFood.Domain
{
    public class Domain
    {
        public static Container Container;

        public static void Start()
        {
            Container = new Container();
            Container.Register<IUsuarioService, UsuarioService>(Lifestyle.Singleton);
            Container.Register<IUsuarioRepository, UsuarioRepository>(Lifestyle.Singleton);
           
            // Optionally verify the _container.
            Container.Verify();
        }

        public static IUsuarioService Usuario()
        {
            return Domain.Container.GetInstance<IUsuarioService>();
        }
    }
}
