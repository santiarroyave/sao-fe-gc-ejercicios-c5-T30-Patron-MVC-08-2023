# Recursos utilizados en los ejercicios

```sql
CREATE DATABASE t30_patron_mvc;
use t30_patron_mvc;
```

## Base de datos del Ejercicio 1
```sql
CREATE TABLE cliente(
    id int(11) NOT NULL AUTO_INCREMENT,
    nombre varchar(250) DEFAULT NULL,
    apellido varchar(250) DEFAULT NULL,
    direccion varchar(250) DEFAULT NULL,
    dni int(11) DEFAULT NULL,
    fecha date DEFAULT NULL,
    PRIMARY KEY(id)
);
```