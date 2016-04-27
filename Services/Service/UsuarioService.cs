using SysFood.Interfaces.Service;
using SysFood.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysFood.Domain
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public Boolean Logar(string usuario, string senha)
        {
           return _usuarioRepository.Logar(usuario, senha);
        }
    }
}
