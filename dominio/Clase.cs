using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Clase
    {
        public int Id { get; set; }
        public string Codigo { get; set; }        
        public string Nombre { get; set; } 
        public int Cupos { get; set; }
        public int Inscriptos { get; set; }
        public int Nivel { get; set; }
        public DateTime Fecha { get; set; } 
        public decimal Precio { get; set; }
        public bool Estado { get; set; }
    }
}
