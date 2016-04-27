using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysFood.Interfaces.Repository;

namespace SysFood.Data
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly UsuarioContext _db;

        public UsuarioRepository()
        {
            _db = new UsuarioContext();
        }

        public Boolean Logar(string usuario, string senha)
        {
            //var usuarios = _db.Usuarios.Where(c => c.usuario == usuario && c.senha == senha).ToList();

            return true;
        }
    }
}
