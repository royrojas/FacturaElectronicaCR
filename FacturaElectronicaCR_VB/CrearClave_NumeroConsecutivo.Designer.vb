<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrearClave_NumeroConsecutivo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrearClave_NumeroConsecutivo))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSucursal = New System.Windows.Forms.TextBox()
        Me.txtPOS = New System.Windows.Forms.TextBox()
        Me.txtTipoComprobante = New System.Windows.Forms.TextBox()
        Me.txtNumeroComprobante = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNumeroConsecutivo01 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNumeroConsecutivo02 = New System.Windows.Forms.TextBox()
        Me.txtIdentificacion = New System.Windows.Forms.TextBox()
        Me.txtCodigoPais = New System.Windows.Forms.TextBox()
        Me.txtCodigoSeguridad = New System.Windows.Forms.TextBox()
        Me.txtSituacionComprobante = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnGeneraDatos = New System.Windows.Forms.Button()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Casa Matriz o Sucursal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Terminal o Punto de Venta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tipo de Comprobante"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Número de Comprobante Electrónico"
        '
        'txtSucursal
        '
        Me.txtSucursal.Location = New System.Drawing.Point(200, 43)
        Me.txtSucursal.MaxLength = 3
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.Size = New System.Drawing.Size(110, 20)
        Me.txtSucursal.TabIndex = 4
        '
        'txtPOS
        '
        Me.txtPOS.Location = New System.Drawing.Point(200, 69)
        Me.txtPOS.MaxLength = 5
        Me.txtPOS.Name = "txtPOS"
        Me.txtPOS.Size = New System.Drawing.Size(110, 20)
        Me.txtPOS.TabIndex = 5
        '
        'txtTipoComprobante
        '
        Me.txtTipoComprobante.Location = New System.Drawing.Point(200, 95)
        Me.txtTipoComprobante.MaxLength = 2
        Me.txtTipoComprobante.Name = "txtTipoComprobante"
        Me.txtTipoComprobante.Size = New System.Drawing.Size(110, 20)
        Me.txtTipoComprobante.TabIndex = 6
        '
        'txtNumeroComprobante
        '
        Me.txtNumeroComprobante.Location = New System.Drawing.Point(200, 121)
        Me.txtNumeroComprobante.MaxLength = 10
        Me.txtNumeroComprobante.Name = "txtNumeroComprobante"
        Me.txtNumeroComprobante.Size = New System.Drawing.Size(110, 20)
        Me.txtNumeroComprobante.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(346, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(306, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Número Consecutivo"
        '
        'txtNumeroConsecutivo01
        '
        Me.txtNumeroConsecutivo01.Location = New System.Drawing.Point(200, 148)
        Me.txtNumeroConsecutivo01.Name = "txtNumeroConsecutivo01"
        Me.txtNumeroConsecutivo01.ReadOnly = True
        Me.txtNumeroConsecutivo01.Size = New System.Drawing.Size(140, 20)
        Me.txtNumeroConsecutivo01.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(206, 24)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Número Consecutivo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 24)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Clave"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 228)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Código País"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 254)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Fecha Factura"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 280)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Número Identificacion Emisor"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 306)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Número Consecutivo"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 332)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 13)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Situación Comprobante"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(13, 358)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 13)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Código Seguridad"
        '
        'txtNumeroConsecutivo02
        '
        Me.txtNumeroConsecutivo02.Location = New System.Drawing.Point(200, 303)
        Me.txtNumeroConsecutivo02.Name = "txtNumeroConsecutivo02"
        Me.txtNumeroConsecutivo02.ReadOnly = True
        Me.txtNumeroConsecutivo02.Size = New System.Drawing.Size(140, 20)
        Me.txtNumeroConsecutivo02.TabIndex = 22
        '
        'txtIdentificacion
        '
        Me.txtIdentificacion.Location = New System.Drawing.Point(200, 277)
        Me.txtIdentificacion.MaxLength = 12
        Me.txtIdentificacion.Name = "txtIdentificacion"
        Me.txtIdentificacion.Size = New System.Drawing.Size(110, 20)
        Me.txtIdentificacion.TabIndex = 21
        '
        'txtCodigoPais
        '
        Me.txtCodigoPais.Location = New System.Drawing.Point(200, 225)
        Me.txtCodigoPais.MaxLength = 3
        Me.txtCodigoPais.Name = "txtCodigoPais"
        Me.txtCodigoPais.Size = New System.Drawing.Size(110, 20)
        Me.txtCodigoPais.TabIndex = 19
        '
        'txtCodigoSeguridad
        '
        Me.txtCodigoSeguridad.Location = New System.Drawing.Point(200, 355)
        Me.txtCodigoSeguridad.Name = "txtCodigoSeguridad"
        Me.txtCodigoSeguridad.ReadOnly = True
        Me.txtCodigoSeguridad.Size = New System.Drawing.Size(110, 20)
        Me.txtCodigoSeguridad.TabIndex = 24
        '
        'txtSituacionComprobante
        '
        Me.txtSituacionComprobante.Location = New System.Drawing.Point(200, 329)
        Me.txtSituacionComprobante.MaxLength = 1
        Me.txtSituacionComprobante.Name = "txtSituacionComprobante"
        Me.txtSituacionComprobante.Size = New System.Drawing.Size(110, 20)
        Me.txtSituacionComprobante.TabIndex = 23
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(346, 225)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(458, 100)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'btnGeneraDatos
        '
        Me.btnGeneraDatos.Location = New System.Drawing.Point(16, 426)
        Me.btnGeneraDatos.Name = "btnGeneraDatos"
        Me.btnGeneraDatos.Size = New System.Drawing.Size(178, 23)
        Me.btnGeneraDatos.TabIndex = 26
        Me.btnGeneraDatos.Text = "Genera Datos"
        Me.btnGeneraDatos.UseVisualStyleBackColor = True
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(200, 251)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(110, 20)
        Me.dtpFecha.TabIndex = 27
        '
        'txtClave
        '
        Me.txtClave.Location = New System.Drawing.Point(199, 382)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.ReadOnly = True
        Me.txtClave.Size = New System.Drawing.Size(321, 20)
        Me.txtClave.TabIndex = 29
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 385)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 13)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Clave"
        '
        'CrearClave_NumeroConsecutivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 462)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.btnGeneraDatos)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtCodigoSeguridad)
        Me.Controls.Add(Me.txtSituacionComprobante)
        Me.Controls.Add(Me.txtNumeroConsecutivo02)
        Me.Controls.Add(Me.txtIdentificacion)
        Me.Controls.Add(Me.txtCodigoPais)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNumeroConsecutivo01)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtNumeroComprobante)
        Me.Controls.Add(Me.txtTipoComprobante)
        Me.Controls.Add(Me.txtPOS)
        Me.Controls.Add(Me.txtSucursal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CrearClave_NumeroConsecutivo"
        Me.Text = "Generar Número Consecutivo y Clave"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSucursal As TextBox
    Friend WithEvents txtPOS As TextBox
    Friend WithEvents txtTipoComprobante As TextBox
    Friend WithEvents txtNumeroComprobante As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNumeroConsecutivo01 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtNumeroConsecutivo02 As TextBox
    Friend WithEvents txtIdentificacion As TextBox
    Friend WithEvents txtCodigoPais As TextBox
    Friend WithEvents txtCodigoSeguridad As TextBox
    Friend WithEvents txtSituacionComprobante As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnGeneraDatos As Button
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents txtClave As TextBox
    Friend WithEvents Label14 As Label
End Class
