using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        [DisplayName("Codigo")] 
        public string codigo { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }

        [DisplayName("Marca")]
        public Marca marca { get; set; }

        [DisplayName("Categoría")]
        public Categoria categoria { get; set; }

        [DisplayName("URL imagen")]
        public string UrlImagen { get; set; }
        public decimal Precio { get; set; }


        public override string ToString()
        {
            return Nombre;
        }
    }
}
