
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
            If objRecepcion.receptor.sinReceptor = False Then
                JsonObject.Add(New JProperty("receptor", New JObject(New JProperty("tipoIdentificacion", objRecepcion.receptor.TipoIdentificacion),
                                                                     New JProperty("numeroIdentificacion", objRecepcion.receptor.numeroIdentificacion))))
            End If
            JsonObject.Add(New JProperty("comprobanteXml", objRecepcion.comprobanteXml))

            jsonEnvio = JsonObject.ToString

            Dim oString As StringContent = New StringContent(JsonObject.ToString)

            http.DefaultRequestHeaders.Add("authorization", "Bearer " + TK)

            Dim response As HttpResponseMessage = http.PostAsync(URL_RECEPCION + "recepcion", oString).Result

            If response.StatusCode >= 200 And response.StatusCode < 300 Then
                ''Aqui se puede salir del metodo.
                ''Otros Status Code como 400 o 500 serían error
                ''400 son errores en el envio de datos
                ''500 errores en el servidor remoto
            End If

            Dim res As String = response.Content.ReadAsStringAsync.Result

            mensajeRespuesta = "Recibido: " & response.StatusCode & vbCrLf & vbCrLf

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

            mensajeRespuesta += "Confirmación: " & statusCode & vbCrLf
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
