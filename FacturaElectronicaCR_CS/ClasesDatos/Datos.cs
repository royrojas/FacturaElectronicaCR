using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaElectronicaCR_CS.ClasesDatos
{
    public class Datos
    {

        public string CreaNumeroSecuencia(string CasaMatriz, string TerminalPOS, string TipoComprobante, string NumeroFactura)
        {
            // 'CasaMatriz debe de se de tres caracteres m�ximo
            // 'Terminal debe ser máximo 5 cataracteres
            // 'Tipo comprobante dos caracteres
            // 'NumeroFactura diez caracteres, si se llega al numero máximo, comienza de 1 nuevamente
            try
            {
                if ((CasaMatriz.Trim().Length > 3))
                {
                    throw new Exception("Casa Matiz no debe de superar los 3 caracteres");
                }

                if ((TerminalPOS.Trim().Length > 5))
                {
                    throw new Exception("Numero de terminal no debe de superar los 5 caracteres");
                }

                if ((TipoComprobante.Trim().Length > 2))
                {
                    throw new Exception("Tipo Comprobante no debe de superar los 2 caracteres");
                }

                if ((NumeroFactura.Trim().Length > 10))
                {
                    throw new Exception("Numero Factura no debe de superar los 10 caracteres");
                }

                string NumeroSecuencia = "";
                NumeroSecuencia = CasaMatriz.Trim().PadLeft(3, '0');
                NumeroSecuencia = (NumeroSecuencia + TerminalPOS.Trim().PadLeft(5, '0'));
                NumeroSecuencia = (NumeroSecuencia + TipoComprobante.Trim().PadLeft(2, '0'));
                NumeroSecuencia = (NumeroSecuencia + NumeroFactura.Trim().PadLeft(10, '0'));
                if ((NumeroSecuencia.Trim().Length < 20))
                {
                    throw new Exception("Numero de secuencia inválido, debe tener 20 caracteres");
                }

                return NumeroSecuencia;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public string CreaClave(string CodigoPais, string Dia, string Mes, string Anno, string NumeroIdentifiaccion, string NumeracionConsecutiva, string SituacionComprobante, string CodigoSeguridad)
        {
            // 'CodigoPais tres caracteres 
            // 'Dia y Mes dos caracteres
            // 'A�o dos caracteres
            // 'Numero idenficacion es el numero de cedula del emisor, 12 caracteres máximo
            // 'Numero consecutivo 20 caracteres, generados en la funcion CreaNumeroSecuencia
            // 'Situacion comprobante un caracter, 1.Normal 2.Contingencia 3.Sin Internet
            // 'Codigo Seguridad 8 caracteres generado con la funci�n CreaCodigoSeguridad
            try
            {
                if ((CodigoPais.Trim().Length != 3))
                {
                    throw new Exception("Codigo país  debe tener 3 caracteres");
                }

                if ((Dia.Trim().Length > 2))
                {
                    throw new Exception("Día no debe de superar los 2 caracteres");
                }

                if ((Mes.Trim().Length > 2))
                {
                    throw new Exception("Mes no debe de superar los 2 caracteres");
                }

                if ((Anno.Trim().Length > 2))
                {
                    throw new Exception("Año no debe de superar los 2 caracteres");
                }

                if ((NumeroIdentifiaccion.Trim().Length > 12))
                {
                    throw new Exception("Número Identifiacción de superar los 12 caracteres");
                }

                if ((NumeracionConsecutiva.Trim().Length != 20))
                {
                    throw new Exception("Numero Consecutivo  debe tener 20 caracteres");
                }

                if ((SituacionComprobante.Trim().Length > 1))
                {
                    throw new Exception("Situacion Comprobante debe tener un caracter");
                }

                if ((CodigoSeguridad.Trim().Length > 3))
                {
                    throw new Exception("Código seguridad no debe de superar los 8 caracteres");
                }

                string Clave = "";
                Clave = CodigoPais;
                Clave = (Clave + Dia.PadLeft(2, '0'));
                Clave = (Clave + Mes.PadLeft(2, '2'));
                Clave = (Clave + Anno.PadLeft(2, '0'));
                Clave = (Clave + NumeroIdentifiaccion.PadLeft(12, '0'));
                Clave = (Clave + NumeracionConsecutiva);
                Clave = (Clave + SituacionComprobante);
                Clave = (Clave + CodigoSeguridad);
                if ((Clave.Length != 50))
                {
                    throw new Exception("Clave inválida, debe de tener 50 caracteres");
                }

                return Clave;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public string CreaCodigoSeguridad(string CodigoCompania, string Localidad, string CodigoPuntoVenta, DateTime Fecha, string NumeroFactura)
        {
            // 'Los parametros CodigoCompania, Localidad y CodigoPuntoVenta pueden modificarse por otros valores, siempre manteniendo la longitud
            // 'Código Compañía debe tener 2 caracteres máximo
            // 'Localidad debe tener 3 caracteres máximo
            // 'Punto de Venta debe de tener 5 caracteres máximo
            // 'Fecha es un campo datetime, debe ser la fecha de la factura
            // 'Número Factura debe tener máximo 10 caracteres y debe ser el mismo parámetro que se usa en la funcion GeneraNumeroSecuencia
            try
            {
                if ((CodigoCompania.Trim().Length > 2))
                {
                    throw new Exception("Código Compañia debe tener 2 caracteres");
                }

                if ((Localidad.Trim().Length > 3))
                {
                    throw new Exception("Localidad no debe de superar los 3 caracteres");
                }

                if ((CodigoPuntoVenta.Trim().Length > 5))
                {
                    throw new Exception("Codigo Punto Venta no debe de superar los 5 caracteres");
                }

                if ((NumeroFactura.Trim().Length > 10))
                {
                    throw new Exception("Numero Factura no de superar los 10 caracteres");
                }

                string concatenado = "";
                concatenado = (concatenado + CodigoCompania.PadLeft(2, '0'));
                concatenado = (concatenado + Localidad.PadLeft(3, '0'));
                concatenado = (concatenado + CodigoPuntoVenta.PadLeft(5, '0'));
                concatenado = (concatenado + Fecha.ToString("yyyyMMddHHmmss"));
                concatenado = (concatenado + NumeroFactura.PadLeft(10, '0'));
                if ((concatenado.Length != 34))
                {
                    throw new Exception("El concatenado debe de ser de 34 caracteres para poder calcular el código de seguridad");
                }

                int calculo = 0;
                calculo = (calculo
                            + (int.Parse(concatenado.Substring(0, 1)) * 3));
                calculo = (calculo
                            + (int.Parse(concatenado.Substring(1, 1)) * 2));
                calculo = (calculo
                            + (int.Parse(concatenado.Substring(2, 1)) * 9));
                calculo = (calculo
                            + (int.Parse(concatenado.Substring(3, 1)) * 8));
                calculo = (calculo
                            + (int.Parse(concatenado.Substring(4, 1)) * 7));
                calculo = (calculo
                            + (int.Parse(concatenado.Substring(5, 1)) * 6));
                calculo = (calculo
                            + (int.Parse(concatenado.Substring(6, 1)) * 5));
                calculo = (calculo
                            + (int.Parse(concatenado.Substring(7, 1)) * 4));
                calculo = (calculo
                            + (int.Parse(concatenado.Substring(8, 1)) * 3));
                calculo = (calculo
                            + (int.Parse(concatenado.Substring(9, 1)) * 2));
                calculo = (calculo
                            + (int.Parse(concatenado.Substring(10, 1)) * 9));
                calculo = (calculo
                            + (int.Parse(concatenado.Substring(11, 1)) * 8));
                calculo = (calculo
                            + (int.Parse(concatenado.Substring(12, 1)) * 7));
                calculo = (calculo
                            + (int.Parse(concatenado.Substring(13, 1)) * 6));
                calculo = (calculo
                            + (int.Parse(concatenado.Substring(14, 1)) * 5));
                calculo = (calculo
                            + (int.Parse(concatenado.Substring(15, 1)) * 4));
                calculo = (calculo
                            + (int.Parse(concatenado.Substring(16, 1)) * 3));
                calculo = (calculo
                            + (int.Parse(concatenado.Substring(17, 1)) * 2));
                calculo = (calculo
                            + (int.Parse(concatenado.Substring(18, 1)) * 9));
                calculo = (calculo
                            + (int.Parse(concatenado.Substring(19, 1)) * 8));
                calculo = (calculo
                            + (int.Parse(concatenado.Substring(20, 1)) * 7));
                calculo = (calculo
                            + (int.Parse(concatenado.Substring(21, 1)) * 6));
                calculo = (calculo
                            + (int.Parse(concatenado.Substring(22, 1)) * 5));
                calculo = (calculo
                            + (int.Parse(concatenado.Substring(23, 1)) * 4));
                calculo = (calculo
                            + (int.Parse(concatenado.Substring(24, 1)) * 3));
                calculo = (calculo
                            + (int.Parse(concatenado.Substring(25, 1)) * 2));
                calculo = (calculo
                            + (int.Parse(concatenado.Substring(26, 1)) * 9));
                calculo = (calculo
                            + (int.Parse(concatenado.Substring(27, 1)) * 8));
                calculo = (calculo
                            + (int.Parse(concatenado.Substring(28, 1)) * 7));
                calculo = (calculo
                            + (int.Parse(concatenado.Substring(29, 1)) * 6));
                calculo = (calculo
                            + (int.Parse(concatenado.Substring(30, 1)) * 5));
                calculo = (calculo
                            + (int.Parse(concatenado.Substring(31, 1)) * 4));
                calculo = (calculo
                            + (int.Parse(concatenado.Substring(32, 1)) * 3));
                calculo = (calculo
                            + (int.Parse(concatenado.Substring(33, 1)) * 2));
                int mDV = 0;
                int digitoMod = 0;
                digitoMod = (calculo % 11);
                if (((digitoMod == 0)
                            || (digitoMod == 1)))
                {
                    mDV = 0;
                }
                else
                {
                    mDV = (11 - digitoMod);
                }

                return (CodigoCompania.PadLeft(2, '0')
                            + (calculo.ToString().PadLeft(5, '0') + mDV.ToString()));
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
