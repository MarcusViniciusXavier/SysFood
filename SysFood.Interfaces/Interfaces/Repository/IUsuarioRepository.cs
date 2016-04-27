using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysFood.Interfaces.Repository
{
    public interface IUsuarioRepository
    {
         Boolean Logar(string usuario, string senha);
    }
}
