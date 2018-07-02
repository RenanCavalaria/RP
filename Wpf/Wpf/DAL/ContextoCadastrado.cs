using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf.Modelo;

namespace Wpf.DAL
{
    class ContextoCadastrado : DbContext
    {

        public ContextoCadastrado() : base("strConn")
        {

        }

        public DbSet<Cadastrado> Cadastrados { get; set; }

    }
}
