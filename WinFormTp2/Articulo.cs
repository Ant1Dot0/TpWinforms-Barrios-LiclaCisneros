using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormTp2
{
    class Articulo
    {
        public string codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca id { get; set; }
        public Categoria cod { get; set; }
        public string UrlImagen { get; set; }
        public float Precio { get; set; }

    }
}
