# Proyecto Final Modulo 6 - Arquitectura de Software

_Autor: Jose G Solano Romero - Alvaro Valdivia Calizaya_

_Proyecto final para el modulo 6 Arquitectura de Software_

_Implementar Arquitectura Limpia para el proyecto de Agencia de viajes_

* AgenciaViajes.Presentacion.API - Asp.net API Core 3.0
* AgenciaViajes.Domain - Biblioteca de clases Core 3.0
* AgenciaViajes.Infraestruture  - Biblioteca de clases Core 3.0
* AgenciaViajes.Application  - Biblioteca de clases Core 3.0

## Pre-requisitos e Instalacion 📋

Para poder ejecutar el proyecto diferentes herramientas (las mas recomendadas):

* Visual Studio 2019
* Visual Studio Code

Para ambas herramientas es necesario tener ciertos paquetes y librerias instaladas

### Visual Studio 
_2019, Visual studio solo soporta Windows y Mac_

Para poder ejecutar correctamente el proyecto en el IDE [Visual Studio](https://visualstudio.microsoft.com/es/downloads/), este debe ser instalado con las siguientes herramientas de desarrollo

![image](https://user-images.githubusercontent.com/43735720/64465903-f139f280-d0dc-11e9-9deb-014da2f7a541.png)

Tambien debemos tener instalado el SDK de Core 3.0 (Esto suele venir incluido en la version 2019)

[.NET Core 3.0 SDK](https://dotnet.microsoft.com/download)

para verificar que el Core 3.0 SDK se haya instalado correctamente solo debemos ejecutar en la consola (cmd, powershell, bash, etc..) la siguiente linea

```
dotnet --version
```
La version debe ser 3.X.X

### Visual Studio Code

Debe instalarse el Editor de texto [Visual Studio Code](https://visualstudio.microsoft.com/es/downloads/)

Tambien debemos tener instalado el SDK de Core 3.0

[.NET Core 3.0 SDK](https://dotnet.microsoft.com/download)


## Cargando el proyecto 🔧

Se debe clonar el proyecto del repositorio [Github](https://github.com/josesolanor/AgenciaViajes) y ser abierto por un IDE o Editor de texto

La solucion cuenta con 1 proyecto: Web services.

## Ejecutando API y Cliente 🚀

### Visual Studio

Ejecutar el proyecto Apretando la tecla F5 o el Boton "Iniciar"

### Visual Studio Code

```
cd AgenciaViajes/
```

Y para inicializar cada proyecto debemos ejecutar el siguiente comando en cada terminal
```
dotnet run
```
## Arquitectura del sistema

### Application

* Interfaces
* Models
* Services

### Domain

* Entities
* Value Objects

### Infrastructure

* Data
* Migration
* _Dependency Injection_

### Presentation.API

* Controllers
* _Program_
* _Startup_

### Probando servicios con Postman
Se debe importar el archivo json que postman requiere para probar los servicios, el archivo se encuentra en la raiz con el nombre "TravelAgency.postman_collection.json". https://github.com/josesolanor/AgenciaViajes. 


