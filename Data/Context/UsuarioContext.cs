using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SysFood.Data.DataBase;

namespace SysFood.Data
{
    public class UsuarioContext : DbContext
    {
        public UsuarioContext()
            : base("DefaultConnection")
        { }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
