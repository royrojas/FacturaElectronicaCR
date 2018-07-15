using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaElectronicaCR_CS.ClasesDatos
{
    public class Receptor
    {
        public string Nombre { get; set; }
        public string Identificacion_Tipo { get; set; }
        public string Identificacion_Numero { get; set; }
        public string Telefono_CodigoPais { get; set; }
        public int Telefono_Numero { get; set; }
        public string CorreoElectronico { get; set; }

        public Receptor(string pNombre, string pIdentificacion_Tipo, 
                        string pIdentificacion_Numero, string pUbicacion_Provincia, 
                        string pUbicacion_Canton, string pUbicacion_Distrito, 
                        string pUbicacion_Barrio, string pUbicacion_OtrasSenas, 
                        string pTelefono_CodigoPais, int pTelefono_Numero, 
                        string pCorreoElectronico)
        {
            Nombre = pNombre;
            Identificacion_Tipo = pIdentificacion_Tipo;
            Identificacion_Numero = pIdentificacion_Numero;
            Telefono_CodigoPais = pTelefono_CodigoPais;
            Telefono_Numero = pTelefono_Numero;
            CorreoElectronico = pCorreoElectronico;
        }
    }

}
