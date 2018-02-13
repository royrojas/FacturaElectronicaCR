namespace FacturaElectronicaCR_CS
{
    partial class Certificado
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
            this.DataSet1 = new System.Data.DataSet();
            this.DataTable1 = new System.Data.DataTable();
            this.DataColumn1 = new System.Data.DataColumn();
            this.DataColumn2 = new System.Data.DataColumn();
            this.grdCertificados = new System.Windows.Forms.DataGridView();
            this.NombreCertificadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThumbprintDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCertificados)).BeginInit();
            this.SuspendLayout();
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "NewDataSet";
            this.DataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.DataTable1});
            // 
            // DataTable1
            // 
            this.DataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.DataColumn1,
            this.DataColumn2});
            this.DataTable1.TableName = "Certificados";
            // 
            // DataColumn1
            // 
            this.DataColumn1.ColumnName = "NombreCertificado";
            // 
            // DataColumn2
            // 
            this.DataColumn2.ColumnName = "Thumbprint";
            // 
            // grdCertificados
            // 
            this.grdCertificados.AllowUserToAddRows = false;
            this.grdCertificados.AllowUserToDeleteRows = false;
            this.grdCertificados.AllowUserToResizeRows = false;
            this.grdCertificados.AutoGenerateColumns = false;
            this.grdCertificados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCertificados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCertificadoDataGridViewTextBoxColumn,
            this.ThumbprintDataGridViewTextBoxColumn});
            this.grdCertificados.DataMember = "Certificados";
            this.grdCertificados.DataSource = this.DataSet1;
            this.grdCertificados.Location = new System.Drawing.Point(12, 12);
            this.grdCertificados.Name = "grdCertificados";
            this.grdCertificados.Size = new System.Drawing.Size(625, 245);
            this.grdCertificados.TabIndex = 1;            
            this.grdCertificados.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCertificados_CellContentDoubleClick);
            // 
            // NombreCertificadoDataGridViewTextBoxColumn
            // 
            this.NombreCertificadoDataGridViewTextBoxColumn.DataPropertyName = "NombreCertificado";
            this.NombreCertificadoDataGridViewTextBoxColumn.HeaderText = "NombreCertificado";
            this.NombreCertificadoDataGridViewTextBoxColumn.Name = "NombreCertificadoDataGridViewTextBoxColumn";
            this.NombreCertificadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.NombreCertificadoDataGridViewTextBoxColumn.Width = 300;
            // 
            // ThumbprintDataGridViewTextBoxColumn
            // 
            this.ThumbprintDataGridViewTextBoxColumn.DataPropertyName = "Thumbprint";
            this.ThumbprintDataGridViewTextBoxColumn.HeaderText = "Thumbprint";
            this.ThumbprintDataGridViewTextBoxColumn.Name = "ThumbprintDataGridViewTextBoxColumn";
            this.ThumbprintDataGridViewTextBoxColumn.ReadOnly = true;
            this.ThumbprintDataGridViewTextBoxColumn.Width = 250;
            // 
            // Certificado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 269);
            this.Controls.Add(this.grdCertificados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Certificado";
            this.Text = "Certificado";
            this.Load += new System.EventHandler(this.Certificado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCertificados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Data.DataSet DataSet1;
        internal System.Data.DataTable DataTable1;
        internal System.Data.DataColumn DataColumn1;
        internal System.Data.DataColumn DataColumn2;
        internal System.Windows.Forms.DataGridView grdCertificados;
        internal System.Windows.Forms.DataGridViewTextBoxColumn NombreCertificadoDataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridViewTextBoxColumn ThumbprintDataGridViewTextBoxColumn;
    }
}