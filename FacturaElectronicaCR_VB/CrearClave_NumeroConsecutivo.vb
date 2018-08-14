Public Class CrearClave_NumeroConsecutivo
    Private Sub btnGeneraDatos_Click(sender As Object, e As EventArgs) Handles btnGeneraDatos.Click
        Try
            Dim numeroConsecutivo As String = CreaNumeroConsecutivo(Me.txtSucursal.Text,
                                                                    Me.txtPOS.Text,
                                                                    Me.txtTipoComprobante.Text,
                                                                    Me.txtNumeroComprobante.Text)

            Me.txtNumeroConsecutivo01.Text = numeroConsecutivo
            Me.txtNumeroConsecutivo02.Text = numeroConsecutivo

            Me.txtCodigoSeguridad.Text = CreaCodigoSeguridad(Me.txtTipoComprobante.Text,
                                                             Me.txtSucursal.Text,
                                                             Me.txtPOS.Text,
                                                             Me.dtpFecha.Value,
                                                             Me.txtNumeroComprobante.Text)

            Dim clave As String = CrearClave(Me.txtCodigoPais.Text,
                                             Me.dtpFecha.Value.Day,
                                             Me.dtpFecha.Value.Month,
                                             Me.dtpFecha.Value.Year,
                                             Me.txtIdentificacion.Text,
                                             numeroConsecutivo,
                                             Me.txtSituacionComprobante.Text,
                                             Me.txtCodigoSeguridad.Text)

            Me.txtClave.Text = clave

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function CreaNumeroConsecutivo(CasaMatriz As String, TerminalPOS As String,
                                          TipoComprobante As String, NumeroFactura As String) As String
        ''CasaMatriz debe de se de tres caracteres máximo
        ''Terminal debe ser máximo 5 cataracteres
        ''Tipo comprobante dos caracteres
        ''NumeroFactura diez caracteres, si se llega al numero máximo, comienza de 1 nuevamente
        Try
            If CasaMatriz.Trim.Length > 3 Then Throw New Exception("Casa Matiz no debe de superar los 3 caracteres")
            If TerminalPOS.Trim.Length > 5 Then Throw New Exception("Número de terminal no debe de superar los 5 caracteres")
            If TipoComprobante.Trim.Length > 2 Then Throw New Exception("Tipo Comprobante no debe de superar los 2 caracteres")
            If NumeroFactura.Trim.Length > 10 Then Throw New Exception("Número Factura no debe de superar los 10 caracteres")

            Dim NumeroSecuencia As String = ""
            NumeroSecuencia = CasaMatriz.Trim.PadLeft(3, "0")
            NumeroSecuencia += TerminalPOS.Trim.PadLeft(5, "0")
            NumeroSecuencia += TipoComprobante.Trim.PadLeft(2, "0")
            NumeroSecuencia += NumeroFactura.Trim.PadLeft(10, "0")

            If NumeroSecuencia.Trim.Length < 20 Then Throw New Exception("Número de secuencia inválido, debe tener 20 caracteres")

            Return NumeroSecuencia

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CrearClave(CodigoPais As String, Dia As String, Mes As String, Anno As String,
                              NumeroIdentifiaccion As String, NumeracionConsecutiva As String,
                              SituacionComprobante As String, CodigoSeguridad As String) As String
        ''CodigoPais tres caracteres 
        ''Dia y Mes dos caracteres
        ''Año dos caracteres
        ''Numero idenficacion es el numero de cedula del emisor, 12 caracteres máximo
        ''Numero consecutivo 20 caracteres, generados en la funcion CreaNumeroSecuencia
        ''Situacion comprobante un caracter, 1.Normal 2.Contingencia 3.Sin Internet
        ''Codigo Seguridad 8 caracteres generado con la función CreaCodigoSeguridad
        Try
            If Anno.Trim.Length = 4 Then Anno = Anno.Substring(2, 2)

            If CodigoPais.Trim.Length <> 3 Then Throw New Exception("Código país debe tener 3 caracteres")
            If Dia.Trim.Length > 2 Then Throw New Exception("Día no debe de superar los 2 caracteres")
            If Mes.Trim.Length > 2 Then Throw New Exception("Mes no debe de superar los 2 caracteres")
            If Anno.Trim.Length > 2 Then Throw New Exception("Año no debe de superar los 2 caracteres")
            If NumeroIdentifiaccion.Trim.Length > 12 Then Throw New Exception("Número Identifiaccion de superar los 12 caracteres")
            If NumeracionConsecutiva.Trim.Length <> 20 Then Throw New Exception("Número Consecutivo debe tener 20 caracteres")
            If SituacionComprobante.Trim.Length > 1 Then Throw New Exception("Situacion Comprobante debe tener un caracter")
            If CodigoSeguridad.Trim.Length > 8 Then Throw New Exception("Codigo seguridad no debe de superar los 8 caracteres")

            Dim Clave As String = ""
            Clave = CodigoPais
            Clave += Dia.PadLeft(2, "0")
            Clave += Mes.PadLeft(2, "2")
            Clave += Anno.PadLeft(2, "0")
            Clave += NumeroIdentifiaccion.PadLeft(12, "0")
            Clave += NumeracionConsecutiva
            Clave += SituacionComprobante
            Clave += CodigoSeguridad

            If Clave.Length <> 50 Then Throw New Exception("Clave inválida, debe de tener 50 caracteres")

            Return Clave

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function CreaCodigoSeguridad(TipoComprobante As String, Localidad As String,
                                        CodigoPuntoVenta As String, Fecha As Date,
                                        NumeroFactura As String) As String

        ''Los parametros TipoComprobante, Localidad y CodigoPuntoVenta pueden modificarse por otros valores, siempre manteniendo la longitud
        ''Tipo Comprobante debe tener 2 caracteres máximo
        ''Localidad debe tener 3 caracteres máximo
        ''Punto de Venta debe de tener 5 caracteres máximo
        ''Fecha es un campo datetime, debe ser la fecha de la factura
        ''Numero Factura debe tener máximo 10 caracteres y debe ser el mismo parámetro que se usa en la funcion CreaNumeroSecuencia
        Try
            If TipoComprobante.Trim.Length > 2 Then Throw New Exception("Tipo Comprobante debe tener 2 caracteres")
            If Localidad.Trim.Length > 3 Then Throw New Exception("Localidad no debe de superar los 3 caracteres")
            If CodigoPuntoVenta.Trim.Length > 5 Then Throw New Exception("Codigo Punto Venta no debe de superar los 5 caracteres")
            If NumeroFactura.Trim.Length > 10 Then Throw New Exception("Numero Factura no de superar los 10 caracteres")

            ''Concatenamos los valores para poder calcular el valor con la fórmula más adelante.
            Dim concatenado As String = ""
            concatenado += TipoComprobante.PadLeft(2, "0")
            concatenado += Localidad.PadLeft(3, "0")
            concatenado += CodigoPuntoVenta.PadLeft(5, "0")
            concatenado += Fecha.ToString("yyyyMMddHHmmss")
            concatenado += NumeroFactura.PadLeft(10, "10")

            If concatenado.Length <> 34 Then Throw New Exception("El concatenado debe de ser de 34 caracteres para poder calcular el código de seguridad")

            Dim calculo As Integer = 0

            calculo += CInt(concatenado.Substring(0, 1)) * 3
            calculo += CInt(concatenado.Substring(1, 1)) * 2
            calculo += CInt(concatenado.Substring(2, 1)) * 9
            calculo += CInt(concatenado.Substring(3, 1)) * 8
            calculo += CInt(concatenado.Substring(4, 1)) * 7
            calculo += CInt(concatenado.Substring(5, 1)) * 6
            calculo += CInt(concatenado.Substring(6, 1)) * 5
            calculo += CInt(concatenado.Substring(7, 1)) * 4
            calculo += CInt(concatenado.Substring(8, 1)) * 3
            calculo += CInt(concatenado.Substring(9, 1)) * 2
            calculo += CInt(concatenado.Substring(10, 1)) * 9
            calculo += CInt(concatenado.Substring(11, 1)) * 8
            calculo += CInt(concatenado.Substring(12, 1)) * 7
            calculo += CInt(concatenado.Substring(13, 1)) * 6
            calculo += CInt(concatenado.Substring(14, 1)) * 5
            calculo += CInt(concatenado.Substring(15, 1)) * 4
            calculo += CInt(concatenado.Substring(16, 1)) * 3
            calculo += CInt(concatenado.Substring(17, 1)) * 2
            calculo += CInt(concatenado.Substring(18, 1)) * 9
            calculo += CInt(concatenado.Substring(19, 1)) * 8
            calculo += CInt(concatenado.Substring(20, 1)) * 7
            calculo += CInt(concatenado.Substring(21, 1)) * 6
            calculo += CInt(concatenado.Substring(22, 1)) * 5
            calculo += CInt(concatenado.Substring(23, 1)) * 4
            calculo += CInt(concatenado.Substring(24, 1)) * 3
            calculo += CInt(concatenado.Substring(25, 1)) * 2
            calculo += CInt(concatenado.Substring(26, 1)) * 9
            calculo += CInt(concatenado.Substring(27, 1)) * 8
            calculo += CInt(concatenado.Substring(28, 1)) * 7
            calculo += CInt(concatenado.Substring(29, 1)) * 6
            calculo += CInt(concatenado.Substring(30, 1)) * 5
            calculo += CInt(concatenado.Substring(31, 1)) * 4
            calculo += CInt(concatenado.Substring(32, 1)) * 3
            calculo += CInt(concatenado.Substring(33, 1)) * 2

            ''Después de calcular el valor, obtenemos el dígito verificador.
            Dim mDV As Integer = 0
            Dim digitoMod As Integer = 0

            digitoMod = calculo Mod 11

            If digitoMod = 0 Or digitoMod = 1 Then
                mDV = 0
            Else
                mDV = 11 - digitoMod
            End If

            ''Retornamos el valor compuesto del tipo de documento, el valor calculado y el digito verificador.
            ''Esto nos retorna un valor congruente y estandarizado.
            Return TipoComprobante.PadLeft(2, "0") & calculo.ToString.PadLeft(5, "0") & mDV.ToString
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class