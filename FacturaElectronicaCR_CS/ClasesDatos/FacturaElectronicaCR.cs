using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Data;

namespace FacturaElectronicaCR_CS.ClasesDatos
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Security;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.VisualBasic;

    public class FacturaElectronicaCR
    {
        private XmlDocument _xml_factura;
        private System.IO.MemoryStream mXML;

        private string _numeroConsecutivo = "";
        private string _numeroClave = "";
        private Emisor _emisor;
        private Receptor _receptor;
        private string _condicionVenta = "";
        private string _plazoCredito = "";
        private string _medioPago = "";
        private DataSet _dsDetalle;
        private string _codigoMoneda = "";
        private decimal _tipoCambio;

        public FacturaElectronicaCR(string numeroConsecutivo, string numeroClave, Emisor emisor, Receptor receptor, 
                                    string condicionVenta, string plazoCredito, string medioPago, 
                                    DataSet dsDetalle, string codigoMoneda, decimal tipoCambio)
        {
            _numeroConsecutivo = numeroConsecutivo;
            _numeroClave = numeroClave;
            _emisor = emisor;
            _receptor = receptor;
            _condicionVenta = condicionVenta;
            _plazoCredito = plazoCredito;
            _medioPago = medioPago;
            _dsDetalle = dsDetalle;
            _codigoMoneda = codigoMoneda;
            _tipoCambio = tipoCambio;
        }

        // 'Este documento esta para la factura electronica, 
        // 'Para la nota de credito es un documento similar pero cambia algunos nodos.
        // 'Lo vemos luego.

        // 'Segun la normativa, estos son los datos basicos que seguramente van a ocupar,
        // 'Es posible que algunos no los ocupen y requieran otros, es normal y los veremos conforme vayamos 
        // 'desarrollando la factura. Cuando se envien los datos a Hacienda, ahi seguramente nos daremos cuenta en las pruebas

        public XmlDocument CreaXMLFacturaElectronica()
        {
            try
            {
                mXML = new System.IO.MemoryStream();

                System.Xml.XmlTextWriter writer = new System.Xml.XmlTextWriter(mXML, System.Text.Encoding.UTF8);

                XmlDocument docXML = new XmlDocument();

                GeneraXML(writer);

                mXML.Seek(0, System.IO.SeekOrigin.Begin);

                docXML.Load(mXML);

                writer.Close();

                // Retorna el documento xml y ahi se puede salvar docXML.Save
                return docXML;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void GeneraXML(System.Xml.XmlTextWriter writer) // As System.Xml.XmlTextWriter
        {
            try
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("FacturaElectronica");

                writer.WriteAttributeString("xmlns", "https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/facturaElectronica");
                writer.WriteAttributeString("xmlns:ds", "http://www.w3.org/2000/09/xmldsig#");
                writer.WriteAttributeString("xmlns:vc", "http://www.w3.org/2007/XMLSchema-versioning");
                writer.WriteAttributeString("xmlns:xs", "http://www.w3.org/2001/XMLSchema");

                // La clave se crea con la función CreaClave de la clase Datos
                writer.WriteElementString("Clave", _numeroClave);

                // 'El numero de secuencia es de 20 caracteres, 
                // 'Se debe de crear con la función CreaNumeroSecuencia de la clase Datos
                writer.WriteElementString("NumeroConsecutivo", _numeroConsecutivo);

                // 'El formato de la fecha es yyyy-MM-ddTHH:mm:sszzz
                writer.WriteElementString("FechaEmision", DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz"));

                writer.WriteStartElement("Emisor");

                writer.WriteElementString("Nombre", _emisor.Nombre);
                writer.WriteStartElement("Identificacion");
                writer.WriteElementString("Tipo", _emisor.Identificacion_Tipo);
                writer.WriteElementString("Numero", _emisor.Identificacion_Numero);
                writer.WriteEndElement(); // 'Identificacion

                // '-----------------------------------
                // 'Los datos de las ubicaciones los puede tomar de las tablas de datos, 
                // 'Debe ser exacto al que hacienda tiene registrado para su compañia
                writer.WriteStartElement("Ubicacion");
                writer.WriteElementString("Provincia", _emisor.Ubicacion_Provincia);
                writer.WriteElementString("Canton", _emisor.Ubicacion_Canton);
                writer.WriteElementString("Distrito", _emisor.Ubicacion_Distrito);
                writer.WriteElementString("Barrio", _emisor.Ubicacion_Barrio);
                writer.WriteElementString("OtrasSenas", _emisor.Ubicacion_OtrasSenas);
                writer.WriteEndElement(); // 'Ubicacion

                writer.WriteStartElement("Telefono");
                writer.WriteElementString("CodigoPais", _emisor.Telefono_CodigoPais);
                writer.WriteElementString("NumTelefono", _emisor.Telefono_Numero.ToString());
                writer.WriteEndElement(); // 'Telefono

                writer.WriteElementString("CorreoElectronico", _emisor.CorreoElectronico);

                writer.WriteEndElement(); // Emisor
                                          // '------------------------------------
                                          // 'Receptor es similar con emisor, los datos opcionales siempre siempre siempre omitirlos.
                                          // 'La ubicacion para el receptor es opcional por ejemplo
                writer.WriteStartElement("Receptor");
                writer.WriteElementString("Nombre", _receptor.Nombre);
                writer.WriteStartElement("Identificacion");
                // 'Los tipos de identificacion los puede ver en la tabla de datos
                writer.WriteElementString("Tipo", _receptor.Identificacion_Tipo);
                writer.WriteElementString("Numero", _receptor.Identificacion_Numero);
                writer.WriteEndElement(); // 'Identificacion

                writer.WriteStartElement("Telefono");
                writer.WriteElementString("CodigoPais", _receptor.Telefono_CodigoPais);
                writer.WriteElementString("NumTelefono", _receptor.Telefono_Numero.ToString());
                writer.WriteEndElement(); // 'Telefono

                writer.WriteElementString("CorreoElectronico", _receptor.CorreoElectronico);

                writer.WriteEndElement(); // Receptor
                                          // '------------------------------------

                // 'Loa datos estan en la tabla correspondiente
                writer.WriteElementString("CondicionVenta", _condicionVenta);
                // '01: Contado
                // '02: Credito
                // '03: Consignación
                // '04: Apartado
                // '05: Arrendamiento con opcion de compra
                // '06: Arrendamiento con función financiera
                // '99: Otros

                // 'Este dato se muestra si la condicion venta es credito
                writer.WriteElementString("PlazoCredito", _plazoCredito);

                writer.WriteElementString("MedioPago", _medioPago);
                // '01: Efectivo
                // '02: Tarjeta
                // '03: Cheque
                // '04: Transferecia - deposito bancario
                // '05: Recaudado por terceros            
                // '99: Otros

                writer.WriteStartElement("DetalleServicio");

                // '-------------------------------------
                foreach (DataRow dr in _dsDetalle.Tables["detalle"].Rows)
                {
                    writer.WriteStartElement("LineaDetalle");

                    writer.WriteElementString("NumeropLinea", dr["numero_linea"].ToString());

                    writer.WriteStartElement("Codigo");
                    writer.WriteElementString("Tipo", dr["articulo_tipo"].ToString());
                    writer.WriteElementString("Codigo", dr["articulo_codigo"].ToString());
                    writer.WriteEndElement(); // 'Codigo

                    writer.WriteElementString("Cantidad", dr["cantidad"].ToString());
                    // 'Para las unidades de medida ver la tabla correspondiente
                    writer.WriteElementString("UnidadMedida", dr["unidad_medida"].ToString());
                    writer.WriteElementString("Detalle", dr["detalle_articulo"].ToString());
                    writer.WriteElementString("PrecioUnitario", String.Format("{0:N3}", dr["precio_unitario"].ToString()));
                    writer.WriteElementString("MontoTotal", String.Format("{0:N3}", dr["monto_total"].ToString()));
                    writer.WriteElementString("MontoDescuento", String.Format("{0:N3}", dr["nonto_descuento"].ToString()));
                    writer.WriteElementString("NaturalezaDescuento", dr["naturaleza_descuento"].ToString());
                    writer.WriteElementString("SubTotal", String.Format("{0:N3}", dr["sub_total"].ToString()));

                    writer.WriteStartElement("Impuesto");
                    writer.WriteElementString("Codigo", dr["impuesto_codigo"].ToString());
                    writer.WriteElementString("Tarifa", dr["impuesto_tarifa"].ToString());
                    writer.WriteElementString("Monto", dr["impuesto_monto"].ToString());
                    writer.WriteEndElement(); // Impuesto

                    writer.WriteElementString("MontoTotalLinea", String.Format("{0:N3}", dr["monto_linea"].ToString()));

                    writer.WriteEndElement(); // LineaDetalle
                }
                // '-------------------------------------

                writer.WriteEndElement(); // DetalleServicio


                writer.WriteStartElement("ResumenFactura");

                // Estos campos son opcionales, solo fin desea facturar en dólares
                writer.WriteElementString("CodigoMoneda", _codigoMoneda);
                writer.WriteElementString("TipoCambio", "aqui_tipo_cambio");
                // =================

                // 'En esta parte los totales se pueden ir sumando linea a linea cuando se carga el detalle
                // 'ó se pasa como parametros al inicio
                writer.WriteElementString("TotalServGravados", "");
                writer.WriteElementString("TotalServExentos", "");
                writer.WriteElementString("TotalMercanciasGravadas", "");
                writer.WriteElementString("TotalMercanciasExentas", "");

                writer.WriteElementString("TotalGravado", "");
                writer.WriteElementString("TotalExento", "");

                writer.WriteElementString("TotalVenta", "");
                writer.WriteElementString("TotalDescuentos", "");
                writer.WriteElementString("TotalVentaNeta", "");
                writer.WriteElementString("TotalImpuesto", "");
                writer.WriteElementString("TotalComprobante", "");
                writer.WriteEndElement(); // ResumenFactura

                // 'Estos datos te los tiene que brindar los encargados del area financiera
                writer.WriteStartElement("Normativa");
                writer.WriteElementString("NumeroResolucion", "");
                writer.WriteElementString("FechaResolucion", "");
                writer.WriteEndElement(); // Normativa

                // 'Aqui va la firma, despues la agregamos.

                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}
