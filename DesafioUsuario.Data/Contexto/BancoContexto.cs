using DesafioUsuario.Dominio.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioUsuario.Data.Contexto
{
    public class BancoContexto : DbContext
    {
        public BancoContexto(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
