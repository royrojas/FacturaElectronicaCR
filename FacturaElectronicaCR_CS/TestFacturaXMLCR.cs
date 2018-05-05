using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace FacturaElectronicaCR_CS
{
    public partial class TestFacturaXMLCR : Form
    {
        public TestFacturaXMLCR()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtXMLSinFirma.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Debe ingresar el XML Sin Firmar");
                    this.txtXMLSinFirma.Focus();
                    return;
                }

                if ((this.txtThumbprint.Text.Trim().Length == 0) & (rbCertInstalado.Checked))
                {
                    MessageBox.Show("Debe indicar el certificado a usar en la firma");
                    CargaCertificado();
                }
                else if ((this.txtPathCertificado.Text.Trim().Length == 0))
                {
                    MessageBox.Show("Debe indicar la ruta del certificado a usar en la firma");
                    BuscaCertificado();
                }

                if ((this.txtFolderSalida.Text.Trim().Length == 0))
                {
                    MessageBox.Show("Debe indicar la ruta del folder donde grabar los archivos");
                    CargaFolderSalida();
                }

                CargaDatosXML();

                Procesa(this.txtXMLSinFirma.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargaDatosXML()
        {
            try
            {
                XmlDocument xmlEnvia = new XmlDocument();
                xmlEnvia.LoadXml(this.txtXMLSinFirma.Text);
                this.txtConsecutivo.Text = xmlEnvia.GetElementsByTagName("NumeroConsecutivo")[0].InnerText;
                this.txtClave.Text = xmlEnvia.GetElementsByTagName("Clave")[0].InnerText;
                this.txtEmisorNumero.Text = xmlEnvia.GetElementsByTagName("Emisor")[0]["Identificacion"]["Numero"].InnerText;
                this.txtEmisorTipo.Text = xmlEnvia.GetElementsByTagName("Emisor")[0]["Identificacion"]["Tipo"].InnerText;

                if (xmlEnvia.GetElementsByTagName("Receptor").Count == 0)
                {
                    if (!(xmlEnvia.GetElementsByTagName("Receptor")[0]["Identificacion"] == null))
                    {
                        this.txtReceptorNumero.Text = xmlEnvia.GetElementsByTagName("Receptor")[0]["Identificacion"]["Numero"].InnerText;
                        this.txtReceptorTipo.Text = xmlEnvia.GetElementsByTagName("Receptor")[0]["Identificacion"]["Tipo"].InnerText;
                    }
                }

                this.txtFecha.Text = xmlEnvia.GetElementsByTagName("FechaEmision")[0].InnerText;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LimpiaDatos()
        {
            this.txtConsecutivo.ResetText();
            this.txtClave.ResetText();
            this.txtEmisorNumero.ResetText();
            this.txtEmisorTipo.ResetText();
            this.txtReceptorNumero.ResetText();
            this.txtReceptorTipo.ResetText();
            this.txtXMLFirmado.ResetText();
            this.txtJSONEnvio.ResetText();
            this.txtJSONRespuesta.ResetText();
            this.txtRespuestaHacienda.ResetText();
            this.txtTokenHacienda.ResetText();
        }

        public void Procesa(string xmlFactura)
        {
            if (!this.txtFolderSalida.Text.EndsWith("\\"))
            {
                this.txtFolderSalida.Text += "\\";
            }

            string directorio = this.txtFolderSalida.Text;
            string nombreArchivo = this.txtConsecutivo.Text;

            XmlDocument xmlDocSF = new XmlDocument();
            xmlDocSF.LoadXml(xmlFactura);
            xmlDocSF.Save((directorio + (nombreArchivo + "_01_SF.xml")));
            XmlTextWriter xmlTextWriter = new XmlTextWriter((directorio + (nombreArchivo + "_01_SF.xml")), new System.Text.UTF8Encoding(false));
            xmlDocSF.WriteTo(xmlTextWriter);
            xmlTextWriter.Close();
            xmlDocSF = null;
            
            Firma _firma = new Firma();
            _firma.FirmaXML_Xades((directorio + nombreArchivo), this.txtThumbprint.Text);

            XmlDocument xmlElectronica = new XmlDocument();
            xmlElectronica.Load((directorio + (nombreArchivo + "_02_Firmado.xml")));

            this.txtXMLFirmado.Text = xmlElectronica.OuterXml;

            Emisor myEmisor = new Emisor();
            myEmisor.numeroIdentificacion = this.txtEmisorNumero.Text;
            myEmisor.TipoIdentificacion = this.txtEmisorTipo.Text;

            Receptor myReceptor = new Receptor();
            if ((this.txtReceptorNumero.Text.Trim().Length > 0))
            {
                myReceptor.sinReceptor = false;
                myReceptor.numeroIdentificacion = this.txtReceptorNumero.Text;
                myReceptor.TipoIdentificacion = this.txtReceptorTipo.Text;
            }
            else
            {
                myReceptor.sinReceptor = true;
            }
            
            Recepcion myRecepcion = new Recepcion();
            myRecepcion.emisor = myEmisor;
            myRecepcion.receptor = myReceptor;

            myRecepcion.clave = this.txtClave.Text;
            myRecepcion.fecha = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz");
            myRecepcion.comprobanteXml = Funciones.EncodeStrToBase64(xmlElectronica.OuterXml);

            xmlElectronica = null;

            string Token = "";
            Token = getToken();
            this.txtTokenHacienda.Text = Token;

            Comunicacion enviaFactura = new Comunicacion();
            enviaFactura.EnvioDatos(Token, myRecepcion);
            string jsonEnvio = "";
            jsonEnvio = enviaFactura.jsonEnvio;
            string jsonRespuesta = "";
            jsonRespuesta = enviaFactura.jsonRespuesta;
            txtJSONEnvio.Text = jsonEnvio;
            txtJSONRespuesta.Text = jsonRespuesta;
            System.IO.StreamWriter outputFile = new System.IO.StreamWriter((directorio
                            + (nombreArchivo + "_03_jsonEnvio.txt")));
            outputFile.Write(jsonEnvio);
            outputFile.Close();
            outputFile = new System.IO.StreamWriter((directorio
                            + (nombreArchivo + "_04_jsonRespuesta.txt")));
            outputFile.Write(jsonRespuesta);
            outputFile.Close();
            if (!(enviaFactura.xmlRespuesta == null))
            {
                this.txtRespuestaHacienda.Text = enviaFactura.xmlRespuesta.OuterXml;
                enviaFactura.xmlRespuesta.Save((directorio
                                + (nombreArchivo + "_05_RESP.xml")));
            }
            else
            {
                outputFile = new System.IO.StreamWriter((directorio
                                + (nombreArchivo + "_05_RESP_SinRespuesta.txt")));
                outputFile.Write("");
                outputFile.Close();
                this.txtRespuestaHacienda.Text = "Consulte en unos minutos, factura se est� procesando.";
                this.txtRespuestaHacienda.Text = (this.txtRespuestaHacienda.Text + ("\r\n" + ("\r\n" + "Consulte por Clave")));
                this.txtRespuestaHacienda.Text = (this.txtRespuestaHacienda.Text + ("\r\n" + ("\r\n" + enviaFactura.mensajeRespuesta)));
            }
            MessageBox.Show(enviaFactura.mensajeRespuesta);
        }

        private void btnConsultaClave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.txtFolderSalida.Text.EndsWith("\\"))
                {
                    this.txtFolderSalida.Text += "\\";
                }

                if ((this.txtClave.Text.Trim().Length == 0))
                {
                    MessageBox.Show("Indique la clave a consultar");
                    this.txtClave.Focus();
                    return;
                }

                string directorio = this.txtFolderSalida.Text;
                string nombreArchivo;
                if ((txtConsecutivo.Text.Trim().Length == 0))
                {
                    nombreArchivo = this.txtClave.Text;
                }
                else
                {
                    nombreArchivo = this.txtConsecutivo.Text;
                }

                string Token = "";
                Token = getToken();
                this.txtTokenHacienda.Text = Token;

                Comunicacion enviaFactura = new Comunicacion();
                enviaFactura.ConsultaEstatus(Token, this.txtClave.Text);

                string jsonRespuesta = "";
                jsonRespuesta = enviaFactura.jsonRespuesta;
                txtJSONRespuesta.Text = jsonRespuesta;
                System.IO.StreamWriter outputFile = new System.IO.StreamWriter((directorio
                                + (nombreArchivo + "_06_jsonRespuestaClave.txt")));
                outputFile.Write(jsonRespuesta);
                outputFile.Close();
                if (!(enviaFactura.xmlRespuesta == null))
                {
                    this.txtRespuestaHacienda.Text = enviaFactura.xmlRespuesta.OuterXml;
                    enviaFactura.xmlRespuesta.Save((directorio
                                    + (nombreArchivo + "_07_RespuestaClave.xml")));
                }
                else
                {
                    this.txtRespuestaHacienda.Text = "Consulte en unos minutos, factura se est� procesando.";
                    this.txtRespuestaHacienda.Text = (this.txtRespuestaHacienda.Text + ("\r\n" + ("\r\n" + "Consulte por Clave")));
                    this.txtRespuestaHacienda.Text = (this.txtRespuestaHacienda.Text + ("\r\n" + ("\r\n" + enviaFactura.mensajeRespuesta)));
                }

                MessageBox.Show(enviaFactura.mensajeRespuesta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string getToken()
        {
            try
            {
                TokenHacienda iTokenHacienda = new TokenHacienda();
                iTokenHacienda.GetTokenHacienda(this.txtAPIUsuario.Text, this.txtAPIClave.Text);
                return iTokenHacienda.accessToken;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnCargaCertificado_Click(object sender, EventArgs e)
        {
            try
            {
                CargaCertificado();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargaCertificado()
        {
            try
            {
                Certificado iCertificados = new Certificado();
                iCertificados.ShowDialog();
                txtThumbprint.Text = iCertificados.thumbprint;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnFolderSalida_Click(object sender, EventArgs e)
        {
            try
            {
                CargaFolderSalida();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargaFolderSalida()
        {
            try
            {
                FolderBrowserDialog iFolder = new FolderBrowserDialog();
                iFolder.ShowDialog();
                this.txtFolderSalida.Text = iFolder.SelectedPath;
                if (!this.txtFolderSalida.Text.EndsWith("\\"))
                {
                    this.txtFolderSalida.Text += "\\";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.LimpiaDatos();
        }

        private void btnRutaCertificado_Click(object sender, EventArgs e)
        {
            try
            {
                BuscaCertificado();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BuscaCertificado()
        {
            try
            {
                OpenFileDialog iFile = new OpenFileDialog();
                iFile.ShowDialog();
                this.txtPathCertificado.Text = iFile.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbCertInstalado_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                ValidaCamposHabilitados();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ValidaCamposHabilitados()
        {
            try
            {
                if (rbCertInstalado.Checked)
                {
                    txtThumbprint.Enabled = true;
                    btnCargaCertificado.Enabled = true;
                    txtPathCertificado.Enabled = false;
                    btnRutaCertificado.Enabled = false;
                    txtCertificadoPIN.Enabled = false;
                }
                else
                {
                    txtThumbprint.Enabled = false;
                    btnCargaCertificado.Enabled = false;
                    txtPathCertificado.Enabled = true;
                    btnRutaCertificado.Enabled = true;
                    txtCertificadoPIN.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
