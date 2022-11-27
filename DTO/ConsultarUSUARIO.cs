using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ConsultarUSUARIO
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string APaterno { get; set; }
        public string AMaterno { get; set; }
        public string Usuario { get; set; }
        public string Contra { get; set; }
        public bool IsActivo { get; set; }
        public DateTime FecRegistro { get; set; }
    }
}
