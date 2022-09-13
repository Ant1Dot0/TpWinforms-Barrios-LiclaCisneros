using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormTp2
{
    class Categoria
    {
        public int cod { get; set; }

        public string descripcion { get; set; }

        public override string ToString()
        {
            return descripcion;
        }
    }
}
