# C5-T30 Patrón MVC
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