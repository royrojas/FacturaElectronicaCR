Imports Newtonsoft.Json
Imports System

Public Class ClasesJson
End Class

Public Class RespuestaHacienda
    <JsonProperty("clave")>
    Public Property clave As String

    <JsonProperty("fecha")>
    Public Property fecha As String

    <JsonProperty("ind-estado")>
    Public Property ind_estado As String

    <JsonProperty("respuesta-xml")>
    Public Property respuesta_xml As String
End Class

Public Class Token
    <JsonProperty("access_token")>
    Public Property access_token As String

    <JsonProperty("refresh_token")>
    Public Property refresh_token As String
End Class

Public Class Recepcion
    <JsonProperty("clave")>
    Public Property clave As String

    <JsonProperty("fecha")>
    Public Property fecha As String

    <JsonProperty("emisor")>
    Public Property emisor As Emisor

    <JsonProperty("receptor")>
    Public Property receptor As Receptor

    <JsonProperty("comprobanteXml")>
    Public Property comprobanteXml As String
End Class

Public Class Emisor
    <JsonProperty("TipoIdentificacion")>
    Public Property TipoIdentificacion As String
    <JsonProperty("numeroIdentificacion")>
    Public Property numeroIdentificacion As String
End Class

Public Class Receptor
    <JsonProperty("TipoIdentificacion")>
    Public Property TipoIdentificacion As String
    <JsonProperty("numeroIdentificacion")>
    Public Property numeroIdentificacion As String
    Public Property sinReceptor As Boolean = False
End Class