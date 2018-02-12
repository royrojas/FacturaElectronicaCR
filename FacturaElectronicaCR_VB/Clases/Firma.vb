'' FirmaElectronicaCR es un programa para la firma y envio de documentos XML para la Factura Electrónica de Costa Rica
''
'' FirmaXML_Xades es la clase para la firma del documento XML para la Factura Electrónica de Costa Rica
''
'' Esta clase de Firma fue realizado tomando como base el trabajo realizado por:
'' - Departamento de Nuevas Tecnologías - Dirección General de Urbanismo Ayuntamiento de Cartagena
'' - XAdES Starter Kit desarrollado por Microsoft Francia
'' - Cambios y funcionalidad para Costa Rica - Roy Rojas - royrojas@dotnetcr.com
''
'' Este programa es software libre: puede redistribuirlo y / o modificarlo
'' bajo los + términos de la Licencia Pública General Reducida de GNU publicada por
'' la Free Software Foundation, ya sea la versión 3 de la licencia, o
'' (a su opción) cualquier versión posterior.

'' Este programa se distribuye con la esperanza de que sea útil,
'' pero SIN NINGUNA GARANTÍA; sin siquiera la garantía implícita de
'' COMERCIABILIDAD O IDONEIDAD PARA UN PROPÓSITO PARTICULAR. Ver el
'' Licencia pública general menor de GNU para más detalles.
''
'' Deberías haber recibido una copia de la Licencia Pública General Reducida de GNU
'' junto con este programa. Si no, vea http://www.gnu.org/licenses/.
''
'' This program Is distributed in the hope that it will be useful,
'' but WITHOUT ANY WARRANTY; without even the implied warranty of
'' MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE.  See the
'' GNU Lesser General Public License for more details.
''
'' You should have received a copy of the GNU Lesser General Public License
'' along with this program.  If Not, see http://www.gnu.org/licenses/. 

Imports System.Xml
Imports System.IO
Imports System.Security
Imports System.Security.Cryptography.X509Certificates
Imports System.Security.Cryptography
Imports FirmaXadesNet
Imports FirmaXadesNet.Crypto
Imports FirmaXadesNet.Signature.Parameters

Public Class Firma

    ''' <summary>
    ''' Firma XAdES EPES para la Factura Electrónica de Costa Rica
    ''' </summary>
    ''' <param name="pathXML">Ruta del folder donde se va a escribir el documento firmado</param>
    Public Sub FirmaXML_Xades(pathXML As String, thumbprintCertificado As String)
        Try
            Dim cert As X509Certificate2 = GetCertificateByThumbprint(thumbprintCertificado)

            ''Ejemplo de un valor Thumbprint: C2E8D9DA714C98ED14B88ECBC4C3E5F3BD64F125
            ''Si no se quiere leer el certificado del repositorio, se puede cargar el certificado directamente
            ''Dim cert As X509Certificate2 = New X509Certificate2("rutaArchivoCertificado", "clave")

            Dim xadesService As XadesService = New XadesService
            Dim parametros As SignatureParameters = New SignatureParameters

            parametros.SignaturePolicyInfo = New SignaturePolicyInfo()

            parametros.SignaturePolicyInfo.PolicyIdentifier = "https://tribunet.hacienda.go.cr/docs/esquemas/2016/v4.1/Resolucion_Comprobantes_Electronicos_DGT-R-48-2016.pdf"
            ''La propiedad PolicyHash es la misma para todos, es un cálculo en base al archivo pdf indicado en PolicyIdentifier
            parametros.SignaturePolicyInfo.PolicyHash = "Ohixl6upD6av8N7pEvDABhEL6hM="
            parametros.SignaturePackaging = SignaturePackaging.ENVELOPED
            parametros.DataFormat = New DataFormat()

            parametros.Signer = New FirmaXadesNet.Crypto.Signer(cert)
            Dim fs As FileStream = New FileStream(pathXML & "_01_SF.xml", FileMode.Open)

            Dim docFirmado As FirmaXadesNet.Signature.SignatureDocument = xadesService.Sign(fs, parametros)
            docFirmado.Save(pathXML & "_02_Firmado.xml")

            'El documento se firma con el dll FirmaXadesNet
            'Esta libreria fue creada por Departamento de Nuevas Tecnologías - Dirección General de Urbanismo Ayuntamiento de Cartagena
            ''Fuente original se puede descargar en administracionelectronica.gob.es/ctt/firmaxadesnet
            ''La libreria se modificó levemente para que pueda funcionar para Costa Rica.
            ''Cambios por Roy Rojas - royrojas@dotnetcr.com - 06/Febrero/2018

            fs.Close()
            docFirmado = Nothing
        Catch ex As Exception
            Throw
        End Try
    End Sub

    ''' <summary>
    ''' El Certificado debe de estar instalado en la computadora o servidor.
    ''' El valor Thumbprint lo encuentras en el tab Details, al final de las propiedades. 
    ''' </summary>
    ''' <param name="thumbprintCertificado">Debe estar en mayúscula y sin espacios en blanco</param>
    ''' <returns></returns>
    Public Function GetCertificateByThumbprint(ByVal thumbprintCertificado As String) As X509Certificate2
        Dim cert As X509Certificate2 = Nothing
        Dim store As New X509Store("My", StoreLocation.CurrentUser)

        Try
            store.Open(OpenFlags.ReadOnly Or OpenFlags.OpenExistingOnly)

            Dim CertCol As X509Certificate2Collection = store.Certificates

            For Each c As X509Certificate2 In CertCol
                If c.Thumbprint = thumbprintCertificado Then
                    cert = c
                    Exit For
                End If
            Next

            If IsNothing(cert) Then
                store = New X509Store("My", StoreLocation.LocalMachine)
                CertCol = store.Certificates
                For Each c As X509Certificate2 In CertCol
                    If c.Thumbprint = thumbprintCertificado Then
                        cert = c
                        Exit For
                    End If
                Next
            End If

            If IsNothing(cert) Then
                Throw New CryptographicException("El certificado no se encuentra registrado")
            End If
        Finally
            store.Close()
        End Try

        Return cert
    End Function

End Class
