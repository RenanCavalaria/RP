using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf.Modelo;

namespace Wpf.DAL
{
    class ContextoOcorrencia : DbContext
    {

        public ContextoOcorrencia() : base("strConn")
        {

        }

        public DbSet<Ocorrencia> Ocorrencias { get; set; }
    }
    
    
}
