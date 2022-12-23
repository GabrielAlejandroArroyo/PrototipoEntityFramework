# PrototipoEntityFramework
# Version Original


## Instalacion EntityFramework

### Instalar .NET CLI

dotnet tool install --global dotnet-ef

### Actulizar 

dotnet tool update --global dotnet-ef

Buscar los siguientes paquetes en  https://www.nuget.org/


### Creamos el proyectos 
dotnet new webapi -o PrototipoEntityFramework

Buscamos estos dot nuget

Microsoft.EntityFrameworkCore.SqlServer 



### Comnando de instalacion libreria 

Desde dentro del proyecto

instalamos Microsoft.EntityFrameworkCore.SqlServer

dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 7.0.0

Si utilizamos Visual studio comunity

dotnet add package Microsoft.EntityFrameworkCore.Tools --version 7.0.0

Si utilizamos Visual studio code

dotnet add package Microsoft.EntityFrameworkCore.Design --version 7.0.0


### Aplicacion de Migraciones, para actualizar la base de datos esto crea la carpeta Migratiosn, con el historico de cambios

En visual Stdudio Comunity

Add-Migration Incial

En visual studio Code

dotnet ef migrations add Inical

### Aplicacion de las migraciones en Base de datos

En visual Stdudio Comunity

update-database

En visual studio Code

dotnet ef database update



