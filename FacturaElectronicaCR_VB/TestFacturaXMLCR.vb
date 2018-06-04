Public Class TestFacturaXMLCR
    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Try
            If Me.txtXMLSinFirma.Text.Trim.Length = 0 Then
                MsgBox("Debe ingresar el XML Sin Firmar")
                Me.txtXMLSinFirma.Focus()
                Exit Sub
            End If

            If Me.txtThumbprint.Text.Trim.Length = 0 And rbCertInstalado.Checked Then
                MsgBox("Debe indicar el certificado a usar en la firma")
                CargaCertificado()
            End If

            If Me.txtFolderSalida.Text.Trim.Length = 0 Then
                MsgBox("Debe indicar la ruta del folder donde grabar los archivos")
                CargaFolderSalida()
            End If

            If Me.txtAPIUsuario.Text.Trim.Length = 0 Then
                MsgBox("Debe indicar el usuario de conexión")
                CargaFolderSalida()
            End If

            If Me.txtAPIClave.Text.Trim.Length = 0 Then
                MsgBox("Debe indicar la clave de conexión")
                CargaFolderSalida()
            End If

            CargaDatosXML()
            Procesa(Me.txtXMLSinFirma.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CargaDatosXML()
        Try
            Dim xmlEnvia As New Xml.XmlDocument
            xmlEnvia.LoadXml(Me.txtXMLSinFirma.Text)

            If TypeOf xmlEnvia.FirstChild Is System.Xml.XmlDeclaration Then
                xmlEnvia.RemoveChild(xmlEnvia.FirstChild)
            End If
            xmlEnvia.PreserveWhitespace = False

            Me.txtConsecutivo.Text = xmlEnvia.GetElementsByTagName("NumeroConsecutivo")(0).InnerText
            Me.txtClave.Text = xmlEnvia.GetElementsByTagName("Clave")(0).InnerText
            Me.txtEmisorNumero.Text = xmlEnvia.GetElementsByTagName("Emisor")(0)("Identificacion")("Numero").InnerText
            Me.txtEmisorTipo.Text = xmlEnvia.GetElementsByTagName("Emisor")(0)("Identificacion")("Tipo").InnerText

            If xmlEnvia.GetElementsByTagName("Receptor").Count > 0 Then
                If Not IsNothing(xmlEnvia.GetElementsByTagName("Receptor")(0)("Identificacion")) Then
                    Me.txtReceptorNumero.Text = xmlEnvia.GetElementsByTagName("Receptor")(0)("Identificacion")("Numero").InnerText
                    Me.txtReceptorTipo.Text = xmlEnvia.GetElementsByTagName("Receptor")(0)("Identificacion")("Tipo").InnerText
                End If
            End If

            Me.txtFecha.Text = xmlEnvia.GetElementsByTagName("FechaEmision")(0).InnerText
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub LimpiaDatos()
        Me.txtConsecutivo.ResetText()
        Me.txtClave.ResetText()
        Me.txtEmisorNumero.ResetText()
        Me.txtEmisorTipo.ResetText()
        Me.txtReceptorNumero.ResetText()
        Me.txtReceptorTipo.ResetText()
        Me.txtFecha.ResetText()
        Me.txtXMLFirmado.ResetText()
        Me.txtJSONEnvio.ResetText()
        Me.txtJSONRespuesta.ResetText()
        Me.txtRespuestaHacienda.ResetText()
        Me.txtTokenHacienda.ResetText()
    End Sub

    Public Sub Procesa(xmlFactura As String)

        If Not Me.txtFolderSalida.Text.EndsWith("\") Then
            Me.txtFolderSalida.Text += "\"
        End If

        Dim directorio As String = Me.txtFolderSalida.Text
        Dim nombreArchivo As String = Me.txtConsecutivo.Text

        Dim xmlDocSF As New Xml.XmlDocument
        xmlDocSF.LoadXml(xmlFactura)

        xmlDocSF.Save(directorio & nombreArchivo & "_01_SF.xml")

        Dim xmlTextWriter As New Xml.XmlTextWriter(directorio & nombreArchivo & "_01_SF.xml", New System.Text.UTF8Encoding(False))
        xmlDocSF.WriteTo(xmlTextWriter)
        xmlTextWriter.Close()
        xmlDocSF = Nothing

        Dim certificado As String = ""
        If rbCertInstalado.Checked Then
            certificado = txtThumbprint.Text
        Else
            certificado = txtPathCertificado.Text
        End If

        Dim _firma As New Firma
        _firma.FirmaXML_Xades(directorio & nombreArchivo, certificado, rbCertInstalado.Checked, txtCertificadoPIN.Text)

        Dim xmlElectronica As New Xml.XmlDocument
        xmlElectronica.Load(directorio & nombreArchivo & "_02_Firmado.xml")

        Me.txtXMLFirmado.Text = xmlElectronica.OuterXml

        Dim myEmisor As New Emisor With {.numeroIdentificacion = Me.txtEmisorNumero.Text, .TipoIdentificacion = Me.txtEmisorTipo.Text}

        Dim myReceptor As New Receptor
        If Me.txtReceptorNumero.Text.Trim.Length > 0 Then
            myReceptor = New Receptor With {.numeroIdentificacion = Me.txtReceptorNumero.Text, .TipoIdentificacion = Me.txtReceptorTipo.Text}
        Else
            myReceptor.sinReceptor = True
        End If

        Dim myRecepcion As New Recepcion
        myRecepcion.emisor = myEmisor
        myRecepcion.receptor = myReceptor

        myRecepcion.clave = Me.txtClave.Text
        myRecepcion.fecha = Me.txtFecha.Text
        ''Now.ToString("yyyy-MM-ddTHH:mm:sszzz")
        myRecepcion.comprobanteXml = Funciones.EncodeStrToBase64(xmlElectronica.OuterXml)

        xmlElectronica = Nothing

        Dim Token As String = ""
        Token = getToken()
        Me.txtTokenHacienda.Text = Token

        Dim enviaFactura As New Comunicacion
        enviaFactura.EnvioDatos(Token, myRecepcion)

        Dim jsonEnvio As String = ""
        jsonEnvio = enviaFactura.jsonEnvio
        Dim jsonRespuesta As String = ""
        jsonRespuesta = enviaFactura.jsonRespuesta

        txtJSONEnvio.Text = jsonEnvio
        txtJSONRespuesta.Text = jsonRespuesta

        Dim outputFile As New IO.StreamWriter(directorio & nombreArchivo & "_03_jsonEnvio.txt")
        outputFile.Write(jsonEnvio)
        outputFile.Close()

        outputFile = New IO.StreamWriter(directorio & nombreArchivo & "_04_jsonRespuesta.txt")
        outputFile.Write(jsonRespuesta)
        outputFile.Close()

        If Not IsNothing(enviaFactura.xmlRespuesta) Then
            Me.txtRespuestaHacienda.Text = enviaFactura.xmlRespuesta.OuterXml
            enviaFactura.xmlRespuesta.Save(directorio & nombreArchivo & "_05_RESP.xml")
        Else
            outputFile = New IO.StreamWriter(directorio & nombreArchivo & "_05_RESP_SinRespuesta.txt")
            outputFile.Write("")
            outputFile.Close()

            Me.txtRespuestaHacienda.Text = "Consulte en unos minutos, factura se está procesando."
            Me.txtRespuestaHacienda.Text += vbCrLf & vbCrLf & enviaFactura.mensajeRespuesta
            Me.txtRespuestaHacienda.Text += vbCrLf & vbCrLf & "Consulte por Clave"
        End If

        MsgBox(enviaFactura.mensajeRespuesta)
    End Sub

    Private Sub btnConsultaClave_Click(sender As Object, e As EventArgs) Handles btnConsultaClave.Click
        Try
            If Not Me.txtFolderSalida.Text.EndsWith("\") Then
                Me.txtFolderSalida.Text += "\"
            End If

            If Me.txtClave.Text.Trim.Length = 0 Then
                MsgBox("Indique la clave a consultar")
                Me.txtClave.Focus()
                Exit Sub
            End If

            Dim directorio As String = Me.txtFolderSalida.Text

            Dim nombreArchivo As String

            If txtConsecutivo.Text.Trim.Length = 0 Then
                nombreArchivo = Me.txtClave.Text
            Else
                nombreArchivo = Me.txtConsecutivo.Text
            End If

            Dim Token As String = ""
            Token = getToken()
            Me.txtTokenHacienda.Text = Token

            Dim enviaFactura As New Comunicacion
            enviaFactura.ConsultaEstatus(Token, Me.txtClave.Text)

            Dim jsonRespuesta As String = ""
            jsonRespuesta = enviaFactura.jsonRespuesta

            txtJSONRespuesta.Text = jsonRespuesta

            Dim outputFile As New IO.StreamWriter(directorio & nombreArchivo & "_06_jsonRespuestaClave.txt")
            outputFile.Write(jsonRespuesta)
            outputFile.Close()

            If Not IsNothing(enviaFactura.xmlRespuesta) Then
                Me.txtRespuestaHacienda.Text = enviaFactura.xmlRespuesta.OuterXml
                enviaFactura.xmlRespuesta.Save(directorio & nombreArchivo & "_07_RespuestaClave.xml")
            Else
                Me.txtRespuestaHacienda.Text = "Consulte en unos minutos, factura se está procesando."
                Me.txtRespuestaHacienda.Text += vbCrLf & vbCrLf & "Consulte por Clave"
                Me.txtRespuestaHacienda.Text += vbCrLf & vbCrLf & enviaFactura.mensajeRespuesta
            End If

            MsgBox(enviaFactura.mensajeRespuesta)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function getToken() As String
        Try
            Dim iTokenHacienda As New TokenHacienda
            iTokenHacienda.GetTokenHacienda(Me.txtAPIUsuario.Text, Me.txtAPIClave.Text)
            Return iTokenHacienda.accessToken
        Catch ex As Exception
            Throw
        End Try
    End Function

    Private Sub btnCargaCertificado_Click(sender As Object, e As EventArgs) Handles btnCargaCertificado.Click
        Try
            CargaCertificado()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CargaCertificado()
        Try
            Dim iCertificados As New Certificado
            iCertificados.ShowDialog()
            txtThumbprint.Text = iCertificados.thumbprint
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub btnFolderSalida_Click(sender As Object, e As EventArgs) Handles btnFolderSalida.Click
        Try
            CargaFolderSalida()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CargaFolderSalida()
        Try
            Dim iFolder As New FolderBrowserDialog
            iFolder.ShowDialog()
            Me.txtFolderSalida.Text = iFolder.SelectedPath

            If Not Me.txtFolderSalida.Text.EndsWith("\") Then
                Me.txtFolderSalida.Text += "\"
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiaDatos()
    End Sub

    Private Sub rbCertInstalado_CheckedChanged(sender As Object, e As EventArgs) Handles rbCertInstalado.CheckedChanged, rbArchivo.CheckedChanged
        Try
            If rbCertInstalado.Checked Then
                txtThumbprint.Enabled = True
                btnCargaCertificado.Enabled = True
                txtPathCertificado.Enabled = False
                btnRutaCertificado.Enabled = False
                txtCertificadoPIN.Enabled = False
            Else
                txtThumbprint.Enabled = False
                btnCargaCertificado.Enabled = False
                txtPathCertificado.Enabled = True
                btnRutaCertificado.Enabled = True
                txtCertificadoPIN.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnRutaCertificado_Click(sender As Object, e As EventArgs) Handles btnRutaCertificado.Click
        Try
            Dim iFile As New OpenFileDialog
            iFile.ShowDialog()
            Me.txtPathCertificado.Text = iFile.FileName
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnPrecargar_Click(sender As Object, e As EventArgs) Handles btnPrecargar.Click
        Try
            CargaDatosXML()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
