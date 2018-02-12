<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Certificado
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
        Me.grdCertificados = New System.Windows.Forms.DataGridView()
        Me.NombreCertificadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThumbprintDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataSet1 = New System.Data.DataSet()
        Me.DataTable1 = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        CType(Me.grdCertificados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdCertificados
        '
        Me.grdCertificados.AllowUserToAddRows = False
        Me.grdCertificados.AllowUserToDeleteRows = False
        Me.grdCertificados.AllowUserToResizeRows = False
        Me.grdCertificados.AutoGenerateColumns = False
        Me.grdCertificados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCertificados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreCertificadoDataGridViewTextBoxColumn, Me.ThumbprintDataGridViewTextBoxColumn})
        Me.grdCertificados.DataMember = "Certificados"
        Me.grdCertificados.DataSource = Me.DataSet1
        Me.grdCertificados.Location = New System.Drawing.Point(12, 12)
        Me.grdCertificados.Name = "grdCertificados"
        Me.grdCertificados.Size = New System.Drawing.Size(625, 245)
        Me.grdCertificados.TabIndex = 0
        '
        'NombreCertificadoDataGridViewTextBoxColumn
        '
        Me.NombreCertificadoDataGridViewTextBoxColumn.DataPropertyName = "NombreCertificado"
        Me.NombreCertificadoDataGridViewTextBoxColumn.HeaderText = "NombreCertificado"
        Me.NombreCertificadoDataGridViewTextBoxColumn.Name = "NombreCertificadoDataGridViewTextBoxColumn"
        Me.NombreCertificadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreCertificadoDataGridViewTextBoxColumn.Width = 300
        '
        'ThumbprintDataGridViewTextBoxColumn
        '
        Me.ThumbprintDataGridViewTextBoxColumn.DataPropertyName = "Thumbprint"
        Me.ThumbprintDataGridViewTextBoxColumn.HeaderText = "Thumbprint"
        Me.ThumbprintDataGridViewTextBoxColumn.Name = "ThumbprintDataGridViewTextBoxColumn"
        Me.ThumbprintDataGridViewTextBoxColumn.ReadOnly = True
        Me.ThumbprintDataGridViewTextBoxColumn.Width = 250
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2})
        Me.DataTable1.TableName = "Certificados"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "NombreCertificado"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Thumbprint"
        '
        'Certificado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 269)
        Me.Controls.Add(Me.grdCertificados)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Certificado"
        Me.Text = "Certificado"
        CType(Me.grdCertificados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdCertificados As DataGridView
    Friend WithEvents DataSet1 As DataSet
    Friend WithEvents DataTable1 As DataTable
    Friend WithEvents DataColumn1 As DataColumn
    Friend WithEvents DataColumn2 As DataColumn
    Friend WithEvents NombreCertificadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ThumbprintDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
