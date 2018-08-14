<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TestFacturaXMLCR
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtXMLSinFirma = New System.Windows.Forms.RichTextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtXMLFirmado = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtTokenHacienda = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.txtJSONEnvio = New System.Windows.Forms.TextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.txtJSONRespuesta = New System.Windows.Forms.TextBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.txtRespuestaHacienda = New System.Windows.Forms.TextBox()
        Me.txtConsecutivo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmisorNumero = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmisorTipo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtReceptorTipo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtReceptorNumero = New System.Windows.Forms.TextBox()
        Me.txtFolderSalida = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Certificado = New System.Windows.Forms.Label()
        Me.txtThumbprint = New System.Windows.Forms.TextBox()
        Me.btnCargaCertificado = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAPIUsuario = New System.Windows.Forms.TextBox()
        Me.txtAPIClave = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnConsultaClave = New System.Windows.Forms.Button()
        Me.btnFolderSalida = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnRutaCertificado = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPathCertificado = New System.Windows.Forms.TextBox()
        Me.rbCertInstalado = New System.Windows.Forms.RadioButton()
        Me.rbArchivo = New System.Windows.Forms.RadioButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCertificadoPIN = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnPrecargar = New System.Windows.Forms.Button()
        Me.btnConsecutivo_Clave = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(815, 384)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtXMLSinFirma)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(807, 358)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "XML Sin Firmar"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtXMLSinFirma
        '
        Me.txtXMLSinFirma.Location = New System.Drawing.Point(0, 0)
        Me.txtXMLSinFirma.Name = "txtXMLSinFirma"
        Me.txtXMLSinFirma.Size = New System.Drawing.Size(807, 358)
        Me.txtXMLSinFirma.TabIndex = 29
        Me.txtXMLSinFirma.Text = ""
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtXMLFirmado)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(807, 358)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "XML Firmado"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtXMLFirmado
        '
        Me.txtXMLFirmado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtXMLFirmado.Location = New System.Drawing.Point(3, 3)
        Me.txtXMLFirmado.Multiline = True
        Me.txtXMLFirmado.Name = "txtXMLFirmado"
        Me.txtXMLFirmado.ReadOnly = True
        Me.txtXMLFirmado.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtXMLFirmado.Size = New System.Drawing.Size(805, 352)
        Me.txtXMLFirmado.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txtTokenHacienda)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(807, 358)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Token Hacienda"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txtTokenHacienda
        '
        Me.txtTokenHacienda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTokenHacienda.Location = New System.Drawing.Point(3, 3)
        Me.txtTokenHacienda.Multiline = True
        Me.txtTokenHacienda.Name = "txtTokenHacienda"
        Me.txtTokenHacienda.ReadOnly = True
        Me.txtTokenHacienda.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtTokenHacienda.Size = New System.Drawing.Size(801, 352)
        Me.txtTokenHacienda.TabIndex = 1
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.txtJSONEnvio)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(807, 358)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "JSON Envio"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'txtJSONEnvio
        '
        Me.txtJSONEnvio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtJSONEnvio.Location = New System.Drawing.Point(3, 3)
        Me.txtJSONEnvio.Multiline = True
        Me.txtJSONEnvio.Name = "txtJSONEnvio"
        Me.txtJSONEnvio.ReadOnly = True
        Me.txtJSONEnvio.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtJSONEnvio.Size = New System.Drawing.Size(801, 352)
        Me.txtJSONEnvio.TabIndex = 1
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.txtJSONRespuesta)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(807, 358)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "JSON Respuesta"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'txtJSONRespuesta
        '
        Me.txtJSONRespuesta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtJSONRespuesta.Location = New System.Drawing.Point(3, 3)
        Me.txtJSONRespuesta.Multiline = True
        Me.txtJSONRespuesta.Name = "txtJSONRespuesta"
        Me.txtJSONRespuesta.ReadOnly = True
        Me.txtJSONRespuesta.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtJSONRespuesta.Size = New System.Drawing.Size(801, 352)
        Me.txtJSONRespuesta.TabIndex = 1
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.txtRespuestaHacienda)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(807, 358)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "XML Respuesta Hacienda"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'txtRespuestaHacienda
        '
        Me.txtRespuestaHacienda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRespuestaHacienda.Location = New System.Drawing.Point(3, 3)
        Me.txtRespuestaHacienda.Multiline = True
        Me.txtRespuestaHacienda.Name = "txtRespuestaHacienda"
        Me.txtRespuestaHacienda.ReadOnly = True
        Me.txtRespuestaHacienda.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtRespuestaHacienda.Size = New System.Drawing.Size(801, 352)
        Me.txtRespuestaHacienda.TabIndex = 1
        '
        'txtConsecutivo
        '
        Me.txtConsecutivo.Location = New System.Drawing.Point(85, 399)
        Me.txtConsecutivo.Name = "txtConsecutivo"
        Me.txtConsecutivo.ReadOnly = True
        Me.txtConsecutivo.Size = New System.Drawing.Size(166, 20)
        Me.txtConsecutivo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 402)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Consecutivo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(263, 402)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Clave"
        '
        'txtClave
        '
        Me.txtClave.Location = New System.Drawing.Point(304, 399)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Size = New System.Drawing.Size(338, 20)
        Me.txtClave.TabIndex = 3
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(159, 451)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(141, 23)
        Me.btnProcesar.TabIndex = 5
        Me.btnProcesar.Text = "Procesar Factura"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 428)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Emisor Número"
        '
        'txtEmisorNumero
        '
        Me.txtEmisorNumero.Location = New System.Drawing.Point(108, 425)
        Me.txtEmisorNumero.Name = "txtEmisorNumero"
        Me.txtEmisorNumero.ReadOnly = True
        Me.txtEmisorNumero.Size = New System.Drawing.Size(143, 20)
        Me.txtEmisorNumero.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(263, 428)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Tipo"
        '
        'txtEmisorTipo
        '
        Me.txtEmisorTipo.Location = New System.Drawing.Point(304, 425)
        Me.txtEmisorTipo.Name = "txtEmisorTipo"
        Me.txtEmisorTipo.ReadOnly = True
        Me.txtEmisorTipo.Size = New System.Drawing.Size(42, 20)
        Me.txtEmisorTipo.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(617, 428)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Tipo"
        '
        'txtReceptorTipo
        '
        Me.txtReceptorTipo.Location = New System.Drawing.Point(658, 425)
        Me.txtReceptorTipo.Name = "txtReceptorTipo"
        Me.txtReceptorTipo.ReadOnly = True
        Me.txtReceptorTipo.Size = New System.Drawing.Size(42, 20)
        Me.txtReceptorTipo.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(364, 428)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Receptor Número"
        '
        'txtReceptorNumero
        '
        Me.txtReceptorNumero.Location = New System.Drawing.Point(459, 425)
        Me.txtReceptorNumero.Name = "txtReceptorNumero"
        Me.txtReceptorNumero.ReadOnly = True
        Me.txtReceptorNumero.Size = New System.Drawing.Size(143, 20)
        Me.txtReceptorNumero.TabIndex = 10
        '
        'txtFolderSalida
        '
        Me.txtFolderSalida.Location = New System.Drawing.Point(833, 56)
        Me.txtFolderSalida.Name = "txtFolderSalida"
        Me.txtFolderSalida.Size = New System.Drawing.Size(264, 20)
        Me.txtFolderSalida.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(833, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Folder archivos de salida"
        '
        'Certificado
        '
        Me.Certificado.AutoSize = True
        Me.Certificado.Location = New System.Drawing.Point(833, 85)
        Me.Certificado.Name = "Certificado"
        Me.Certificado.Size = New System.Drawing.Size(57, 13)
        Me.Certificado.TabIndex = 17
        Me.Certificado.Text = "Certificado"
        '
        'txtThumbprint
        '
        Me.txtThumbprint.Enabled = False
        Me.txtThumbprint.Location = New System.Drawing.Point(833, 124)
        Me.txtThumbprint.Name = "txtThumbprint"
        Me.txtThumbprint.Size = New System.Drawing.Size(264, 20)
        Me.txtThumbprint.TabIndex = 18
        '
        'btnCargaCertificado
        '
        Me.btnCargaCertificado.Enabled = False
        Me.btnCargaCertificado.Location = New System.Drawing.Point(1097, 123)
        Me.btnCargaCertificado.Name = "btnCargaCertificado"
        Me.btnCargaCertificado.Size = New System.Drawing.Size(27, 22)
        Me.btnCargaCertificado.TabIndex = 19
        Me.btnCargaCertificado.Text = "..."
        Me.btnCargaCertificado.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(833, 196)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Usuario API Hacienda"
        '
        'txtAPIUsuario
        '
        Me.txtAPIUsuario.Location = New System.Drawing.Point(833, 212)
        Me.txtAPIUsuario.Name = "txtAPIUsuario"
        Me.txtAPIUsuario.Size = New System.Drawing.Size(264, 20)
        Me.txtAPIUsuario.TabIndex = 21
        '
        'txtAPIClave
        '
        Me.txtAPIClave.Location = New System.Drawing.Point(833, 255)
        Me.txtAPIClave.Name = "txtAPIClave"
        Me.txtAPIClave.Size = New System.Drawing.Size(264, 20)
        Me.txtAPIClave.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(833, 239)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Clave API Hacienda"
        '
        'btnConsultaClave
        '
        Me.btnConsultaClave.Location = New System.Drawing.Point(306, 451)
        Me.btnConsultaClave.Name = "btnConsultaClave"
        Me.btnConsultaClave.Size = New System.Drawing.Size(141, 23)
        Me.btnConsultaClave.TabIndex = 24
        Me.btnConsultaClave.Text = "Consultar por Clave"
        Me.btnConsultaClave.UseVisualStyleBackColor = True
        '
        'btnFolderSalida
        '
        Me.btnFolderSalida.Location = New System.Drawing.Point(1097, 55)
        Me.btnFolderSalida.Name = "btnFolderSalida"
        Me.btnFolderSalida.Size = New System.Drawing.Size(27, 22)
        Me.btnFolderSalida.TabIndex = 25
        Me.btnFolderSalida.Text = "..."
        Me.btnFolderSalida.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(660, 402)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Fecha"
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(703, 399)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(120, 20)
        Me.txtFecha.TabIndex = 26
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(453, 451)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(141, 23)
        Me.btnLimpiar.TabIndex = 28
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnRutaCertificado
        '
        Me.btnRutaCertificado.Location = New System.Drawing.Point(1097, 167)
        Me.btnRutaCertificado.Name = "btnRutaCertificado"
        Me.btnRutaCertificado.Size = New System.Drawing.Size(27, 22)
        Me.btnRutaCertificado.TabIndex = 31
        Me.btnRutaCertificado.Text = "..."
        Me.btnRutaCertificado.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(833, 152)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 13)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Ruta certificado"
        '
        'txtPathCertificado
        '
        Me.txtPathCertificado.Location = New System.Drawing.Point(833, 168)
        Me.txtPathCertificado.Name = "txtPathCertificado"
        Me.txtPathCertificado.Size = New System.Drawing.Size(210, 20)
        Me.txtPathCertificado.TabIndex = 29
        '
        'rbCertInstalado
        '
        Me.rbCertInstalado.AutoSize = True
        Me.rbCertInstalado.Location = New System.Drawing.Point(903, 83)
        Me.rbCertInstalado.Name = "rbCertInstalado"
        Me.rbCertInstalado.Size = New System.Drawing.Size(119, 17)
        Me.rbCertInstalado.TabIndex = 32
        Me.rbCertInstalado.Text = "Instalado repositorio"
        Me.rbCertInstalado.UseVisualStyleBackColor = True
        '
        'rbArchivo
        '
        Me.rbArchivo.AutoSize = True
        Me.rbArchivo.Checked = True
        Me.rbArchivo.Location = New System.Drawing.Point(1030, 83)
        Me.rbArchivo.Name = "rbArchivo"
        Me.rbArchivo.Size = New System.Drawing.Size(61, 17)
        Me.rbArchivo.TabIndex = 33
        Me.rbArchivo.TabStop = True
        Me.rbArchivo.Text = "Archivo"
        Me.rbArchivo.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(833, 108)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 13)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Certificado instalado"
        '
        'txtCertificadoPIN
        '
        Me.txtCertificadoPIN.Location = New System.Drawing.Point(1045, 168)
        Me.txtCertificadoPIN.Name = "txtCertificadoPIN"
        Me.txtCertificadoPIN.Size = New System.Drawing.Size(52, 20)
        Me.txtCertificadoPIN.TabIndex = 35
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(1045, 151)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(25, 13)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "PIN"
        '
        'btnPrecargar
        '
        Me.btnPrecargar.Location = New System.Drawing.Point(12, 451)
        Me.btnPrecargar.Name = "btnPrecargar"
        Me.btnPrecargar.Size = New System.Drawing.Size(141, 23)
        Me.btnPrecargar.TabIndex = 37
        Me.btnPrecargar.Text = "Precargar Datos"
        Me.btnPrecargar.UseVisualStyleBackColor = True
        '
        'btnConsecutivo_Clave
        '
        Me.btnConsecutivo_Clave.Location = New System.Drawing.Point(845, 451)
        Me.btnConsecutivo_Clave.Name = "btnConsecutivo_Clave"
        Me.btnConsecutivo_Clave.Size = New System.Drawing.Size(283, 23)
        Me.btnConsecutivo_Clave.TabIndex = 38
        Me.btnConsecutivo_Clave.Text = "Crea Número Consecutivo y Clave"
        Me.btnConsecutivo_Clave.UseVisualStyleBackColor = True
        '
        'TestFacturaXMLCR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1140, 484)
        Me.Controls.Add(Me.btnConsecutivo_Clave)
        Me.Controls.Add(Me.btnPrecargar)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtCertificadoPIN)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.rbArchivo)
        Me.Controls.Add(Me.rbCertInstalado)
        Me.Controls.Add(Me.btnRutaCertificado)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtPathCertificado)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.btnFolderSalida)
        Me.Controls.Add(Me.btnConsultaClave)
        Me.Controls.Add(Me.txtAPIClave)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtAPIUsuario)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnCargaCertificado)
        Me.Controls.Add(Me.txtThumbprint)
        Me.Controls.Add(Me.Certificado)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtFolderSalida)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtReceptorTipo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtReceptorNumero)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtEmisorTipo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEmisorNumero)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtConsecutivo)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "TestFacturaXMLCR"
        Me.Text = "Factura Electronica CR"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtXMLFirmado As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents txtTokenHacienda As TextBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents txtJSONEnvio As TextBox
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents txtJSONRespuesta As TextBox
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents txtRespuestaHacienda As TextBox
    Friend WithEvents txtConsecutivo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtClave As TextBox
    Friend WithEvents btnProcesar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEmisorNumero As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmisorTipo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtReceptorTipo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtReceptorNumero As TextBox
    Friend WithEvents txtFolderSalida As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Certificado As Label
    Friend WithEvents txtThumbprint As TextBox
    Friend WithEvents btnCargaCertificado As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtAPIUsuario As TextBox
    Friend WithEvents txtAPIClave As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnConsultaClave As Button
    Friend WithEvents btnFolderSalida As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents txtXMLSinFirma As RichTextBox
    Friend WithEvents btnRutaCertificado As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txtPathCertificado As TextBox
    Friend WithEvents rbCertInstalado As RadioButton
    Friend WithEvents rbArchivo As RadioButton
    Friend WithEvents Label12 As Label
    Friend WithEvents txtCertificadoPIN As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnPrecargar As Button
    Friend WithEvents btnConsecutivo_Clave As Button
End Class
