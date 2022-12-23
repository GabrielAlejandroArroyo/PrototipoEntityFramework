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





