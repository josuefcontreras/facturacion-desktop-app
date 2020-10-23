using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facturacionApp.BLL
{
    class clienteBLL
    {
        public clienteBLL()
        {

        }

        public clienteBLL(Dictionary<string, object> personalData)
        {
            this.nombre = personalData["nombre"] as string;
            this.apellido = personalData["apellido"] as string;
            this.cedula = personalData["cedula"] as string;
            this.telefono = personalData["telefono"] as string;
        }

        public int codigo_cliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string cedula { get; set; }
        public string telefono { get; set; }
        public string activo { get; set; }
        public DateTime fecha_creacion { get; set; }
    }
}
