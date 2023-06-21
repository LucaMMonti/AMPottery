﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        public int Id { get; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; } 
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public int IdCategoria { get; set; }
        public bool Estado { get; set; }

    }
}
