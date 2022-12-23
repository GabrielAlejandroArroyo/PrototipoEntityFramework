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

### Como hacer las configuraciones de EntiyFrameworkCore

Por convencion (Evitan escribir codigo de configuracion)

    Por Convencion cuando un campo en la clase de define como Id, de define como primary Key

    problema por convencion tiene limitantes
        no permiten definir el valor custom de los campor por ejemplo maximo de un campo

        



Por Annotation (Ventajas, no se necesita enviar al servidor para hacer la validacion)
    Para ser especifico en Annotation
    [Key]
    public Int Id {get; set} 



Por APIFluent define las relaciones fuera de la entidad, fuera de la declaracion de la entidad y se aplica en el xxxxdbcontext (Desventajas, se necesita enviar al servidor para hacer la validacion
ApiFluent es el modo que permite la mayor flexibilidad al momento de definir un campo de una entidad
Es el que mas flexibiliad tiene al moneto de definir una entidad, el mismo impacta directamente en la definicion del los schemas opendapi, muy importantes en la definicon del estandar (el apifluent permite autodocumental el opendapi)


    Para ser especifico en APIFuent

    En ApplicationDbContext sobreescribo el metodo OnModelCreating

    Protected override void OnModelCreating ()
    public Int Id {get; set} 


