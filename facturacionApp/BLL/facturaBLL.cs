using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facturacionApp.BLL
{
    class facturaBLL
    {
        public int codigo_factura { get; set; }
        public DateTime fecha_creacion { get; set; }
        public decimal total_factura { get; set; }
        public int activa { get; set; }
        public int codigo_cliente { get; set; }
    }
}
