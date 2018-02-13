Imports System.Security
Imports System.Security.Cryptography.X509Certificates
Imports System.Security.Cryptography

Public Class Certificado

    Private dsCertificados As New DataSet
    Public Property thumbprint As String

    Private Sub Certificado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CreaDSCertificados()

            Dim store As New X509Store("My", StoreLocation.CurrentUser)
            store.Open(OpenFlags.ReadOnly Or OpenFlags.OpenExistingOnly)

            Dim CertCol As X509Certificate2Collection = store.Certificates

            Dim dr As DataRow
            For Each c As X509Certificate2 In CertCol
                dr = dsCertificados.Tables(0).NewRow
                dr("NombreCertificado") = c.IssuerName.Name
                dr("Thumbprint") = c.Thumbprint
                dsCertificados.Tables(0).Rows.Add(dr)
            Next

            dsCertificados.AcceptChanges()
            grdCertificados.DataSource = dsCertificados
            grdCertificados.DataMember = "Certificados"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CreaDSCertificados()
        Try
            dsCertificados.Tables.Add(New DataTable("Certificados"))
            dsCertificados.Tables(0).Columns.Add("NombreCertificado", GetType(String))
            dsCertificados.Tables(0).Columns.Add("Thumbprint", GetType(String))
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub grdCertificados_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdCertificados.CellContentDoubleClick
        Try
            thumbprint = grdCertificados.Rows(e.RowIndex).Cells(1).Value
            Me.Close()
        Catch ex As Exception
            Throw
        End Try
    End Sub

End Class