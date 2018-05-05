namespace FacturaElectronicaCR_CS
{
    partial class TestFacturaXMLCR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConsultaClave = new System.Windows.Forms.Button();
            this.txtAPIClave = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtAPIUsuario = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.btnCargaCertificado = new System.Windows.Forms.Button();
            this.txtThumbprint = new System.Windows.Forms.TextBox();
            this.Certificado = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtFolderSalida = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtReceptorTipo = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtReceptorNumero = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtEmisorTipo = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtEmisorNumero = new System.Windows.Forms.TextBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtConsecutivo = new System.Windows.Forms.TextBox();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.txtXMLSinFirma = new System.Windows.Forms.TextBox();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.txtXMLFirmado = new System.Windows.Forms.TextBox();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.txtTokenHacienda = new System.Windows.Forms.TextBox();
            this.TabPage4 = new System.Windows.Forms.TabPage();
            this.txtJSONEnvio = new System.Windows.Forms.TextBox();
            this.TabPage5 = new System.Windows.Forms.TabPage();
            this.txtJSONRespuesta = new System.Windows.Forms.TextBox();
            this.TabPage6 = new System.Windows.Forms.TabPage();
            this.txtRespuestaHacienda = new System.Windows.Forms.TextBox();
            this.btnFolderSalida = new System.Windows.Forms.Button();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.rbArchivo = new System.Windows.Forms.RadioButton();
            this.rbCertInstalado = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.txtCertificadoPIN = new System.Windows.Forms.TextBox();
            this.btnRutaCertificado = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPathCertificado = new System.Windows.Forms.TextBox();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.TabPage4.SuspendLayout();
            this.TabPage5.SuspendLayout();
            this.TabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConsultaClave
            // 
            this.btnConsultaClave.Location = new System.Drawing.Point(160, 451);
            this.btnConsultaClave.Name = "btnConsultaClave";
            this.btnConsultaClave.Size = new System.Drawing.Size(141, 23);
            this.btnConsultaClave.TabIndex = 49;
            this.btnConsultaClave.Text = "Consultar por Clave";
            this.btnConsultaClave.UseVisualStyleBackColor = true;
            this.btnConsultaClave.Click += new System.EventHandler(this.btnConsultaClave_Click);
            // 
            // txtAPIClave
            // 
            this.txtAPIClave.Location = new System.Drawing.Point(833, 255);
            this.txtAPIClave.Name = "txtAPIClave";
            this.txtAPIClave.Size = new System.Drawing.Size(264, 20);
            this.txtAPIClave.TabIndex = 48;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(833, 239);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(103, 13);
            this.Label9.TabIndex = 47;
            this.Label9.Text = "Clave API Hacienda";
            // 
            // txtAPIUsuario
            // 
            this.txtAPIUsuario.Location = new System.Drawing.Point(833, 212);
            this.txtAPIUsuario.Name = "txtAPIUsuario";
            this.txtAPIUsuario.Size = new System.Drawing.Size(264, 20);
            this.txtAPIUsuario.TabIndex = 46;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(833, 196);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(112, 13);
            this.Label8.TabIndex = 45;
            this.Label8.Text = "Usuario API Hacienda";
            // 
            // btnCargaCertificado
            // 
            this.btnCargaCertificado.Enabled = false;
            this.btnCargaCertificado.Location = new System.Drawing.Point(1097, 123);
            this.btnCargaCertificado.Name = "btnCargaCertificado";
            this.btnCargaCertificado.Size = new System.Drawing.Size(27, 22);
            this.btnCargaCertificado.TabIndex = 44;
            this.btnCargaCertificado.Text = "...";
            this.btnCargaCertificado.UseVisualStyleBackColor = true;
            this.btnCargaCertificado.Click += new System.EventHandler(this.btnCargaCertificado_Click);
            // 
            // txtThumbprint
            // 
            this.txtThumbprint.Enabled = false;
            this.txtThumbprint.Location = new System.Drawing.Point(833, 124);
            this.txtThumbprint.Name = "txtThumbprint";
            this.txtThumbprint.Size = new System.Drawing.Size(264, 20);
            this.txtThumbprint.TabIndex = 43;
            // 
            // Certificado
            // 
            this.Certificado.AutoSize = true;
            this.Certificado.Location = new System.Drawing.Point(833, 108);
            this.Certificado.Name = "Certificado";
            this.Certificado.Size = new System.Drawing.Size(102, 13);
            this.Certificado.TabIndex = 42;
            this.Certificado.Text = "Certificado instalado";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(833, 40);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(124, 13);
            this.Label7.TabIndex = 40;
            this.Label7.Text = "Folder archivos de salida";
            // 
            // txtFolderSalida
            // 
            this.txtFolderSalida.Location = new System.Drawing.Point(833, 56);
            this.txtFolderSalida.Name = "txtFolderSalida";
            this.txtFolderSalida.Size = new System.Drawing.Size(264, 20);
            this.txtFolderSalida.TabIndex = 39;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(617, 428);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(28, 13);
            this.Label5.TabIndex = 38;
            this.Label5.Text = "Tipo";
            // 
            // txtReceptorTipo
            // 
            this.txtReceptorTipo.Location = new System.Drawing.Point(658, 425);
            this.txtReceptorTipo.Name = "txtReceptorTipo";
            this.txtReceptorTipo.ReadOnly = true;
            this.txtReceptorTipo.Size = new System.Drawing.Size(42, 20);
            this.txtReceptorTipo.TabIndex = 37;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(364, 428);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(91, 13);
            this.Label6.TabIndex = 36;
            this.Label6.Text = "Receptor Número";
            // 
            // txtReceptorNumero
            // 
            this.txtReceptorNumero.Location = new System.Drawing.Point(459, 425);
            this.txtReceptorNumero.Name = "txtReceptorNumero";
            this.txtReceptorNumero.ReadOnly = true;
            this.txtReceptorNumero.Size = new System.Drawing.Size(143, 20);
            this.txtReceptorNumero.TabIndex = 35;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(263, 428);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(28, 13);
            this.Label4.TabIndex = 34;
            this.Label4.Text = "Tipo";
            // 
            // txtEmisorTipo
            // 
            this.txtEmisorTipo.Location = new System.Drawing.Point(304, 425);
            this.txtEmisorTipo.Name = "txtEmisorTipo";
            this.txtEmisorTipo.ReadOnly = true;
            this.txtEmisorTipo.Size = new System.Drawing.Size(42, 20);
            this.txtEmisorTipo.TabIndex = 33;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(13, 428);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(78, 13);
            this.Label3.TabIndex = 32;
            this.Label3.Text = "Emisor Número";
            // 
            // txtEmisorNumero
            // 
            this.txtEmisorNumero.Location = new System.Drawing.Point(108, 425);
            this.txtEmisorNumero.Name = "txtEmisorNumero";
            this.txtEmisorNumero.ReadOnly = true;
            this.txtEmisorNumero.Size = new System.Drawing.Size(143, 20);
            this.txtEmisorNumero.TabIndex = 31;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(13, 451);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(141, 23);
            this.btnProcesar.TabIndex = 30;
            this.btnProcesar.Text = "Procesar Factura";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(263, 402);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(34, 13);
            this.Label2.TabIndex = 29;
            this.Label2.Text = "Clave";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(304, 399);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(338, 20);
            this.txtClave.TabIndex = 28;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(13, 402);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(66, 13);
            this.Label1.TabIndex = 27;
            this.Label1.Text = "Consecutivo";
            // 
            // txtConsecutivo
            // 
            this.txtConsecutivo.Location = new System.Drawing.Point(85, 399);
            this.txtConsecutivo.Name = "txtConsecutivo";
            this.txtConsecutivo.ReadOnly = true;
            this.txtConsecutivo.Size = new System.Drawing.Size(166, 20);
            this.txtConsecutivo.TabIndex = 26;
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Controls.Add(this.TabPage4);
            this.TabControl1.Controls.Add(this.TabPage5);
            this.TabControl1.Controls.Add(this.TabPage6);
            this.TabControl1.Location = new System.Drawing.Point(12, 12);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(815, 384);
            this.TabControl1.TabIndex = 25;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.txtXMLSinFirma);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(807, 358);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "XML Sin Firmar";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // txtXMLSinFirma
            // 
            this.txtXMLSinFirma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtXMLSinFirma.Location = new System.Drawing.Point(3, 3);
            this.txtXMLSinFirma.Multiline = true;
            this.txtXMLSinFirma.Name = "txtXMLSinFirma";
            this.txtXMLSinFirma.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtXMLSinFirma.Size = new System.Drawing.Size(801, 352);
            this.txtXMLSinFirma.TabIndex = 0;
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.txtXMLFirmado);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(807, 358);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "XML Firmado";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // txtXMLFirmado
            // 
            this.txtXMLFirmado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtXMLFirmado.Location = new System.Drawing.Point(3, 3);
            this.txtXMLFirmado.Multiline = true;
            this.txtXMLFirmado.Name = "txtXMLFirmado";
            this.txtXMLFirmado.ReadOnly = true;
            this.txtXMLFirmado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtXMLFirmado.Size = new System.Drawing.Size(805, 352);
            this.txtXMLFirmado.TabIndex = 1;
            // 
            // TabPage3
            // 
            this.TabPage3.Controls.Add(this.txtTokenHacienda);
            this.TabPage3.Location = new System.Drawing.Point(4, 22);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new System.Drawing.Size(807, 358);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "Token Hacienda";
            this.TabPage3.UseVisualStyleBackColor = true;
            // 
            // txtTokenHacienda
            // 
            this.txtTokenHacienda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTokenHacienda.Location = new System.Drawing.Point(3, 3);
            this.txtTokenHacienda.Multiline = true;
            this.txtTokenHacienda.Name = "txtTokenHacienda";
            this.txtTokenHacienda.ReadOnly = true;
            this.txtTokenHacienda.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTokenHacienda.Size = new System.Drawing.Size(801, 352);
            this.txtTokenHacienda.TabIndex = 1;
            // 
            // TabPage4
            // 
            this.TabPage4.Controls.Add(this.txtJSONEnvio);
            this.TabPage4.Location = new System.Drawing.Point(4, 22);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Size = new System.Drawing.Size(807, 358);
            this.TabPage4.TabIndex = 3;
            this.TabPage4.Text = "JSON Envio";
            this.TabPage4.UseVisualStyleBackColor = true;
            // 
            // txtJSONEnvio
            // 
            this.txtJSONEnvio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJSONEnvio.Location = new System.Drawing.Point(3, 3);
            this.txtJSONEnvio.Multiline = true;
            this.txtJSONEnvio.Name = "txtJSONEnvio";
            this.txtJSONEnvio.ReadOnly = true;
            this.txtJSONEnvio.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtJSONEnvio.Size = new System.Drawing.Size(801, 352);
            this.txtJSONEnvio.TabIndex = 1;
            // 
            // TabPage5
            // 
            this.TabPage5.Controls.Add(this.txtJSONRespuesta);
            this.TabPage5.Location = new System.Drawing.Point(4, 22);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Size = new System.Drawing.Size(807, 358);
            this.TabPage5.TabIndex = 4;
            this.TabPage5.Text = "JSON Respuesta";
            this.TabPage5.UseVisualStyleBackColor = true;
            // 
            // txtJSONRespuesta
            // 
            this.txtJSONRespuesta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJSONRespuesta.Location = new System.Drawing.Point(3, 3);
            this.txtJSONRespuesta.Multiline = true;
            this.txtJSONRespuesta.Name = "txtJSONRespuesta";
            this.txtJSONRespuesta.ReadOnly = true;
            this.txtJSONRespuesta.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtJSONRespuesta.Size = new System.Drawing.Size(801, 352);
            this.txtJSONRespuesta.TabIndex = 1;
            // 
            // TabPage6
            // 
            this.TabPage6.Controls.Add(this.txtRespuestaHacienda);
            this.TabPage6.Location = new System.Drawing.Point(4, 22);
            this.TabPage6.Name = "TabPage6";
            this.TabPage6.Size = new System.Drawing.Size(807, 358);
            this.TabPage6.TabIndex = 5;
            this.TabPage6.Text = "XML Respuesta Hacienda";
            this.TabPage6.UseVisualStyleBackColor = true;
            // 
            // txtRespuestaHacienda
            // 
            this.txtRespuestaHacienda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRespuestaHacienda.Location = new System.Drawing.Point(3, 3);
            this.txtRespuestaHacienda.Multiline = true;
            this.txtRespuestaHacienda.Name = "txtRespuestaHacienda";
            this.txtRespuestaHacienda.ReadOnly = true;
            this.txtRespuestaHacienda.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRespuestaHacienda.Size = new System.Drawing.Size(801, 352);
            this.txtRespuestaHacienda.TabIndex = 1;
            // 
            // btnFolderSalida
            // 
            this.btnFolderSalida.Location = new System.Drawing.Point(1097, 55);
            this.btnFolderSalida.Name = "btnFolderSalida";
            this.btnFolderSalida.Size = new System.Drawing.Size(27, 22);
            this.btnFolderSalida.TabIndex = 50;
            this.btnFolderSalida.Text = "...";
            this.btnFolderSalida.UseVisualStyleBackColor = true;
            this.btnFolderSalida.Click += new System.EventHandler(this.btnFolderSalida_Click);
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(660, 402);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(37, 13);
            this.Label10.TabIndex = 52;
            this.Label10.Text = "Fecha";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(703, 399);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(120, 20);
            this.txtFecha.TabIndex = 51;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(307, 451);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(141, 23);
            this.btnLimpiar.TabIndex = 53;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // rbArchivo
            // 
            this.rbArchivo.AutoSize = true;
            this.rbArchivo.Checked = true;
            this.rbArchivo.Location = new System.Drawing.Point(1030, 83);
            this.rbArchivo.Name = "rbArchivo";
            this.rbArchivo.Size = new System.Drawing.Size(61, 17);
            this.rbArchivo.TabIndex = 56;
            this.rbArchivo.TabStop = true;
            this.rbArchivo.Text = "Archivo";
            this.rbArchivo.UseVisualStyleBackColor = true;
            // 
            // rbCertInstalado
            // 
            this.rbCertInstalado.AutoSize = true;
            this.rbCertInstalado.Location = new System.Drawing.Point(903, 83);
            this.rbCertInstalado.Name = "rbCertInstalado";
            this.rbCertInstalado.Size = new System.Drawing.Size(119, 17);
            this.rbCertInstalado.TabIndex = 55;
            this.rbCertInstalado.Text = "Instalado repositorio";
            this.rbCertInstalado.UseVisualStyleBackColor = true;
            this.rbCertInstalado.CheckedChanged += new System.EventHandler(this.rbCertInstalado_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(833, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 54;
            this.label11.Text = "Certificado";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(1045, 151);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(25, 13);
            this.Label13.TabIndex = 61;
            this.Label13.Text = "PIN";
            // 
            // txtCertificadoPIN
            // 
            this.txtCertificadoPIN.Location = new System.Drawing.Point(1045, 168);
            this.txtCertificadoPIN.Name = "txtCertificadoPIN";
            this.txtCertificadoPIN.Size = new System.Drawing.Size(52, 20);
            this.txtCertificadoPIN.TabIndex = 60;
            // 
            // btnRutaCertificado
            // 
            this.btnRutaCertificado.Location = new System.Drawing.Point(1097, 167);
            this.btnRutaCertificado.Name = "btnRutaCertificado";
            this.btnRutaCertificado.Size = new System.Drawing.Size(27, 22);
            this.btnRutaCertificado.TabIndex = 59;
            this.btnRutaCertificado.Text = "...";
            this.btnRutaCertificado.UseVisualStyleBackColor = true;
            this.btnRutaCertificado.Click += new System.EventHandler(this.btnRutaCertificado_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(833, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 58;
            this.label12.Text = "Ruta certificado";
            // 
            // txtPathCertificado
            // 
            this.txtPathCertificado.Location = new System.Drawing.Point(833, 168);
            this.txtPathCertificado.Name = "txtPathCertificado";
            this.txtPathCertificado.Size = new System.Drawing.Size(210, 20);
            this.txtPathCertificado.TabIndex = 57;
            // 
            // TestFacturaXMLCR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 484);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.txtCertificadoPIN);
            this.Controls.Add(this.btnRutaCertificado);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPathCertificado);
            this.Controls.Add(this.rbArchivo);
            this.Controls.Add(this.rbCertInstalado);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.btnFolderSalida);
            this.Controls.Add(this.btnConsultaClave);
            this.Controls.Add(this.txtAPIClave);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.txtAPIUsuario);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.btnCargaCertificado);
            this.Controls.Add(this.txtThumbprint);
            this.Controls.Add(this.Certificado);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.txtFolderSalida);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtReceptorTipo);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txtReceptorNumero);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtEmisorTipo);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtEmisorNumero);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtConsecutivo);
            this.Controls.Add(this.TabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TestFacturaXMLCR";
            this.Text = "TestFacturaXMLCR";
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            this.TabPage3.ResumeLayout(false);
            this.TabPage3.PerformLayout();
            this.TabPage4.ResumeLayout(false);
            this.TabPage4.PerformLayout();
            this.TabPage5.ResumeLayout(false);
            this.TabPage5.PerformLayout();
            this.TabPage6.ResumeLayout(false);
            this.TabPage6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnConsultaClave;
        internal System.Windows.Forms.TextBox txtAPIClave;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox txtAPIUsuario;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Button btnCargaCertificado;
        internal System.Windows.Forms.TextBox txtThumbprint;
        internal System.Windows.Forms.Label Certificado;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtFolderSalida;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtReceptorTipo;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtReceptorNumero;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtEmisorTipo;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtEmisorNumero;
        internal System.Windows.Forms.Button btnProcesar;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtClave;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtConsecutivo;
        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.TextBox txtXMLSinFirma;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.TextBox txtXMLFirmado;
        internal System.Windows.Forms.TabPage TabPage3;
        internal System.Windows.Forms.TextBox txtTokenHacienda;
        internal System.Windows.Forms.TabPage TabPage4;
        internal System.Windows.Forms.TextBox txtJSONEnvio;
        internal System.Windows.Forms.TabPage TabPage5;
        internal System.Windows.Forms.TextBox txtJSONRespuesta;
        internal System.Windows.Forms.TabPage TabPage6;
        internal System.Windows.Forms.TextBox txtRespuestaHacienda;
        private System.Windows.Forms.Button btnFolderSalida;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox txtFecha;
        internal System.Windows.Forms.Button btnLimpiar;
        internal System.Windows.Forms.RadioButton rbArchivo;
        internal System.Windows.Forms.RadioButton rbCertInstalado;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.TextBox txtCertificadoPIN;
        internal System.Windows.Forms.Button btnRutaCertificado;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.TextBox txtPathCertificado;
    }
}