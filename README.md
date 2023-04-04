# VerificadorTLSNet
Este proyecto es una aplicación de consola desarrollada en C# que verifica si el sistema Windows tiene habilitada alguna versión de TLS y realiza una petición HTTP utilizando cada versión de TLS habilitada.

#Requisitos

.NET 6 SDK instalado en tu equipo.

#Cómo ejecutar la aplicación

Clona o descarga el repositorio.
Abre una terminal o línea de comandos en la carpeta raíz del proyecto.
Ejecuta el siguiente comando para compilar y publicar la aplicación:

dotnet publish -r win-x64 -c Release /p:PublishSingleFile=true /p:PublishTrimmed=true

Se generará un ejecutable en la carpeta /bin/Release/net6.0/win-x64/publish.
Abre una terminal o línea de comandos en la carpeta /bin/Release/net6.0/win-x64/publish.
Ejecuta el siguiente comando para ejecutar la aplicación:

./VerificadorTLSNet.exe

#Licencia
Este proyecto está licenciado bajo la licencia MIT.