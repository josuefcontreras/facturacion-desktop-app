using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facturacionApp.BLL
{
    class productoBLL
    {
        public productoBLL()
        {

        }
        public productoBLL(Dictionary<string, object> productData)
        {
            this.nombre = productData["nombre"] as string;
            this.descripcion = productData["descripcion"] as string;
            this.precio = Convert.ToDouble(productData["precio"]);
            this.costo = Convert.ToDouble(productData["costo"]);
            this.existencia = Convert.ToInt32(productData["existencia"]);
            this.tipo_producto = Convert.ToInt32(productData["tipo_producto"]);
        }

        public int codigo_producto { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public double precio { get; set; }
        public double costo { get; set; }
        public int existencia { get; set; }
        public string activo { get; set; }
        public int tipo_producto { get; set; }
        public DateTime fecha_creacion { get; set; }
    }
}
