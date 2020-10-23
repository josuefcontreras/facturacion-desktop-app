using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facturacionApp.BLL
{
    class factura_productoBLL
    {
        public int codigo_factura { get; set; }
        public int codigo_producto { get; set; }
        public int cantidad { get; set; }
        public decimal precio_unitario { get; set; }
        public decimal total { get; set; }
    }
}
