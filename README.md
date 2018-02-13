# Factura Electrónica Costa Rica
Ejemplo desarrollado en VB.NET y C# para la Factura Electrónica de Costa Rica.

Este proyecto realiza la firma del documento XML, solicita el Token y envía los datos a los servidores del Ministerio de Hacienda.

En la carpeta COMPONENTES estan los dlls necesarios para realizar la firma electrónica XadesEpes en .NET.

FirmaXadesNet es una librería desarrollada en C# para la generación de firmas XAdES realizada por el Dpto. de Nuevas Tecnologías de la Concejalía de Urbanismo del Ayuntamiento de Cartagena en España, la cual está basada en una modificación del XAdES starter kit desarrollado por Microsoft Francia. Los cambios necesarios para la implementacion en Costa Rica las realizó Roy Rojas (royrojas[at]dotnetcr.com).

# Estructura
En la solucion estan dos proyectos <b>FacturaElectrónica_CS</b> y <b>FacturaElectronica_VB</b>, una para CSharp y otra para Visual Basic .NET. Ambas soluciones hacen lo mismo.

En la carpeta 'Clases' está toda la funcionalidad de la aplicación, y son las que deberías de copiar a tu solución.

- <b>ClasesJson: </b>Contiene las estructuras de los datos que se envian y reciben por parte del API de Hacienda.
  Tiene 5 clases, Recepcion, Emisor, Receptor, Token y RespuestaHacienda.
- <b>Comunicacion: </b>Contiene el procedimieto para el envío de los datos al API de Hacienda y el procedimiento para consultar el estado de una factura por la clave.
- <b>Firma: </b>Contiene las funciones necesarias para la firma del documento electrónico. Utiliza los dlls BouncyCastle.dll, Microsoft.Xades.dll y FirmaXadesNet.dll, que se encuentra en la carpeta COMPONENTES.
- <b>Funciones: </b>Esta clase contiene unas funciones básicas para convertir de string a Base64 y de Base64 a string, necesario para enviar y recibir los datos en los JSON con el API de Hacienda.
- <b>TokenHacienda: </b>Esta clase se comunica con el API proporcionado por hacienda para generar el Token necesario para poder entablar la comunicación con el API de Hacienda y poder enviar y recibir información.

# Funcionamiento del ejemplo
En la pantalla se muestran varios campos distribuidos en varios tabs. XML Sin Firmar, XML Firmado, Token Hacienda, JSON Envio, JSON Respuesta, XML Respuesta Hacienda. 

Debes ingresar unicamente el XML Sin Firmar, el programa se encarga de leerlo y llenar los datos en la parte inferior como consecutivo, clave, datos de emisor y receptor.

Al lado derecho se debe indicar la ruta donde se guardarán los archivos, paso a paso. También debe indicar con cual certificado vas a firmar el xml. Este certificado debe de estar instalado en el repositorio del usuario en la computadora. Los campos de Usuario y Clave son los proporcionados por Hacienda en el ATV.

# Firma XAdES-EPES
Puede descargar los fuentes originales del dll para la Firma en el sitio web y GIT del Dpto. de Nuevas Tecnologías de la Concejalía de Urbanismo del Ayuntamiento de Cartagena en España. Para Costa Rica se le realizó unos cambios menores para que funcione correctamente.
- https://github.com/ctt-gob-es/FirmaXadesNet45 
- https://administracionelectronica.gob.es/ctt/firmaxadesnet

