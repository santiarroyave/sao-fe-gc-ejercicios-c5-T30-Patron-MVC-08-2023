# C5-T30 Patrón MVC

> Estos pasos registran el intento para conectar el programa a la base de datos y al final no se han aplicado ya que es un tema que se toca más adelante en las API.
> El CRUD se aplica de manera local guardando los datos en variables en tiempo de ejecución.

## ORM
### ¿Qué es un ORM?
Un ORM (Mapeo Objeto-Relacional) es una herramienta de programación que permite interactuar con bases de datos relacionales utilizando objetos y métodos en lenguajes de programación, facilitando la manipulación de datos sin necesidad de escribir consultas SQL directamente.

### ORM Populares
- [Entity Framework (EF)](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore/7.0.10) para *.NET*
- [NHibernate](https://nhibernate.info/) para *.NET*
- [Dapper](https://www.learndapper.com/) para *.NET*
- [Hibernate](https://hibernate.org/) para *Java*
- [Django ORM](https://docs.djangoproject.com/en/4.2/topics/db/queries/) para *Python*

### Otras herramientas
- [EntityFrameworkCore.InMemory](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.InMemory/7.0.10): Este paquete nos va a ayudar a crear una BBDD en memoria y poder probar el modelo que estamos creando dentro de nuestro proyecto .NET.
- [EntityFrameworkCore.SqlServer](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer/7.0.10): Este paquete nos va a permitir conectarnos especificamente al motor con el que vamos a estar trabajando (SQL Server).<br>
PD: Para *PostfreSQL* se usaria este: [EntityFrameworkCore.PostgreSQL](https://www.nuget.org/packages/Npgsql.EntityFrameworkCore.PostgreSQL/)

## Ejercicio 1

### Pasos
1. Crear proyecto Windows Forms.
2. Importar los 3 paquetes necesarios. (EF, EF InMemory, EF SqlServer)
3. Estructurar las carpetas
    - Models
    - Views
    - Controllers
4. Añade el modelo *Clientes.cs*
5. Configuración de Entity Framework
    - Crear *Data* > *ClientesContext.cs*
    - Hacer que la clase herede de *DbContext*. `public class ClientesContext: DbContext`
    - Importar librerias de Entity Framework. `using Microsoft.EntityFrameworkCore;`
    - Crear un set de datos. Esto va a representar una tabla dentro del contexto de EF. `public DbSet<Cliente> Clientes { get; set; }`
    - Para que detecte la clase *Clientes* tendremos que importarla. `using T30_Ejercicio01.Models;`
    - Creamos el constructor.
    ```csharp
    using Microsoft.EntityFrameworkCore;
    using T30_Ejercicio01.Models;
    // using ...;

    namespace T30_Ejercicio01.Data
    {
        public class ClientesContext: DbContext
        {
            public DbSet<Cliente> Clientes { get; set; }
            public ClientesContext(DbContextOptions<ClientesContext> options) :base(options) { }
        }
    }
    ```
6. Hacer mapeo de modelos usando atributos.<br>Se necesita importar: `using System.ComponentModel.DataAnnotations;`. *(Más info en Notas)*

## Notas
- Tipo de dato [Guid](https://learn.microsoft.com/es-es/dotnet/api/system.guid?view=net-7.0):
    - Se utiliza para almacenar identificadores únicos a nivel global.
    - Están compuestos por una combinación de caracteres alfanuméricos y guiones.
    - Están diseñados para ser únicos y aleatorios, y se generan utilizando algoritmos especiales para minimizar la probabilidad de colisiones.
    ```csharp
    // Crear un nuevo GUID aleatorio
    Guid newGuid = Guid.NewGuid();
    ```
- Uso de **:base()** *[Visto en C4-T27 C# Herencia](https://github.com/santiarroyave/sao-fe-gc-ejercicios-c4-T27-c-sharp-herencia-08-2023)*
    - Cuando una subclase hereda de una clase base, el uso de :base() en su constructor llama al constructor específico de la clase base antes de continuar con la inicialización de la subclase.
    - Si no usas :base() en el constructor de la subclase, automáticamente se llama al constructor sin parámetros de la clase base.
    - Para llamar a un constructor específico de la clase base con parámetros, utiliza :base() y proporciona los argumentos necesarios.
- Mapeo de modelos usando atributos<br>
Estas etiquetas se ponen encima del atributo:<br>
[Documentación Data Notations](https://learn.microsoft.com/en-us/ef/ef6/modeling/code-first/data-annotations)
    - [Key]: Hace referencia al id.
    - [Required]: Para campos que tengan que ser requeridos.
    - [MaxLength(250)]: Para poner maximo de caracteres.
    - [ForeignKey("Nombre")]: Para la clave foranea.
    - [NotMapped]: Evita que al hacerse el mapeo del contexto, omita este campo.
- [ASP.NET MVC Pattern](https://dotnet.microsoft.com/en-us/apps/aspnet/mvc)