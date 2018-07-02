using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf.Modelo
{
    public class Ocorrencia
    {
        [Key]
        public int OcorrenciaID { get; set; }

        public string Bairro { get; set; }
        public string Natureza { get; set; }
        public double Hora { get; set; }
        
    }
}
