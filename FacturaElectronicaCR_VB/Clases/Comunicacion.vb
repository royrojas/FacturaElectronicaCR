'' FirmaElectronicaCR es un programa para la firma y envio de documentos XML para la Factura Electrónica de Costa Rica
''
'' Comunicacion es la clase para el envío del documento XML para la Factura Electrónica de Costa Rica
''
'' Esta clase de Firma fue realizado tomando como base el trabajo realizado por:
'' - Departamento de Nuevas Tecnologías - Dirección General de Urbanismo Ayuntamiento de Cartagena
'' - XAdES Starter Kit desarrollado por Microsoft Francia
'' - Cambios y funcionalidad para Costa Rica - Roy Rojas - royrojas@dotnetcr.com
''
'' La clase comunicación fue creada en conjunto con Cristhian Sancho
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

Imports System.Net.Http
Imports Newtonsoft.Json.Linq

Public Class Comunicacion

    Public Property xmlRespuesta As Xml.XmlDocument
    Public Property jsonEnvio As String = ""
    Public Property jsonRespuesta As String = ""
    Public Property mensajeRespuesta As String = ""
    Public Property estadoFactura As String = ""
    Public Property statusCode As String = ""

    ''' <summary>
    ''' Envia los datos a los servidores de Hacienda y obtiene las respuestas necesarias
    ''' </summary>
    ''' <param name="TK">Token que generó Hacienda</param>
    ''' <param name="objRecepcion">Objeto que contiene todos las variables de comunicación</param>
    Public Sub EnvioDatos(TK As String, ByVal objRecepcion As Recepcion)
        Try
            Dim URL_RECEPCION As String = "https://api.comprobanteselectronicos.go.cr/recepcion-sandbox/v1/"

            Dim http As HttpClient = New HttpClient

            Dim JsonObject As Newtonsoft.Json.Linq.JObject = New Newtonsoft.Json.Linq.JObject()
            JsonObject.Add(New JProperty("clave", objRecepcion.clave))
            JsonObject.Add(New JProperty("fecha", objRecepcion.fecha))
            JsonObject.Add(New JProperty("emisor", New JObject(New JProperty("tipoIdentificacion", objRecepcion.emisor.TipoIdentificacion),
                                                               New JProperty("numeroIdentificacion", objRecepcion.emisor.numeroIdentificacion))))
            JsonObject.Add(New JProperty("receptor", New JObject(New JProperty("tipoIdentificacion", objRecepcion.receptor.TipoIdentificacion),
                                                                 New JProperty("numeroIdentificacion", objRecepcion.receptor.numeroIdentificacion))))
            JsonObject.Add(New JProperty("comprobanteXml", objRecepcion.comprobanteXml))

            jsonEnvio = JsonObject.ToString

            Dim oString As StringContent = New StringContent(JsonObject.ToString)

            http.DefaultRequestHeaders.Add("authorization", "Bearer " + TK)

            Dim response As HttpResponseMessage = http.PostAsync(URL_RECEPCION + "recepcion", oString).Result
            Dim res As String = response.Content.ReadAsStringAsync.Result

            Dim Localizacion = response.StatusCode
            ''mensajeRespuesta = Localizacion

            http = New HttpClient
            http.DefaultRequestHeaders.Add("authorization", "Bearer " + TK)
            response = http.GetAsync(URL_RECEPCION + "recepcion/" + objRecepcion.clave).Result
            res = response.Content.ReadAsStringAsync.Result

            jsonRespuesta = res.ToString

            Dim RH As RespuestaHacienda = Newtonsoft.Json.JsonConvert.DeserializeObject(Of RespuestaHacienda)(res)

            If RH.respuesta_xml <> "" Then
                xmlRespuesta = Funciones.DecodeBase64ToXML(RH.respuesta_xml)
            End If

            estadoFactura = RH.ind_estado
            statusCode = response.StatusCode

            mensajeRespuesta = "Confirmación: " & statusCode & vbCrLf
            mensajeRespuesta += "Estado: " & estadoFactura
        Catch e As Exception
            Throw
        End Try
    End Sub

    Public Sub ConsultaEstatus(TK As String, claveConsultar As String)
        Try
            Dim URL_RECEPCION As String = "https://api.comprobanteselectronicos.go.cr/recepcion-sandbox/v1/"
            Dim http As HttpClient = New HttpClient

            http.DefaultRequestHeaders.Add("authorization", "Bearer " + TK)

            Dim response As HttpResponseMessage = http.GetAsync(URL_RECEPCION & "recepcion/" & claveConsultar).Result
            Dim res As String = response.Content.ReadAsStringAsync.Result

            Dim Localizacion = response.StatusCode

            jsonRespuesta = res.ToString

            Dim RH As RespuestaHacienda = Newtonsoft.Json.JsonConvert.DeserializeObject(Of RespuestaHacienda)(res)

            If RH.respuesta_xml <> "" Then
                xmlRespuesta = Funciones.DecodeBase64ToXML(RH.respuesta_xml)
            End If

            estadoFactura = RH.ind_estado
            statusCode = response.StatusCode

            mensajeRespuesta = "Confirmación: " & statusCode & vbCrLf
            mensajeRespuesta += "Estado: " & estadoFactura

        Catch ex As Exception
            Throw
        End Try
    End Sub

End Class
