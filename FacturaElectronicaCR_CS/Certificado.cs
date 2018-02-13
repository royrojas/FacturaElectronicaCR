using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;

namespace FacturaElectronicaCR_CS
{
    public partial class Certificado : Form
    {
        private DataSet dsCertificados = new DataSet();
        public string thumbprint { get; set; }

        public Certificado()
        {
            InitializeComponent();
        }

        private void Certificado_Load(object sender, EventArgs e)
        {
            try
            {
                
                CreaDSCertificados();
                X509Store store = new X509Store("My", StoreLocation.CurrentUser);
                store.Open((OpenFlags.ReadOnly | OpenFlags.OpenExistingOnly));
                X509Certificate2Collection CertCol = store.Certificates;
                DataRow dr;
                foreach (X509Certificate2 c in CertCol)
                {
                    dr = dsCertificados.Tables[0].NewRow();
                    dr["NombreCertificado"] = c.IssuerName.Name;
                    dr["Thumbprint"] = c.Thumbprint;
                    dsCertificados.Tables[0].Rows.Add(dr);
                }

                dsCertificados.AcceptChanges();
                grdCertificados.DataSource = dsCertificados;
                grdCertificados.DataMember = "Certificados";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CreaDSCertificados()
        {
            try
            {
                dsCertificados.Tables.Add(new DataTable("Certificados"));
                dsCertificados.Tables[0].Columns.Add("NombreCertificado", typeof(string));
                dsCertificados.Tables[0].Columns.Add("Thumbprint", typeof(string));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void grdCertificados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                thumbprint = grdCertificados.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}