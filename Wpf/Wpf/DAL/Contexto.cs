using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf.Modelo;

namespace Wpf.DAL
{
    class Contexto : DbContext
    {
        
            public Contexto() : base("strConn")
            {

            }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
