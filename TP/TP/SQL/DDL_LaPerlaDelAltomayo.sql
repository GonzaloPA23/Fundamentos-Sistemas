CREATE DATABASE  DB_PerlaAltomayo;
GO

--DROP TABLE usuario;
--DROP TABLE  permiso;
--DROP TABLE  rol;
--DROP TABLE chofer

USE DB_PerlaAltomayo;

CREATE TABLE  rol (
    id int IDENTITY ,
    nombre varchar(50)
    CONSTRAINT  rol_pk PRIMARY KEY  (id)
)

CREATE TABLE permiso(
    id int IDENTITY,
    rol_id int NOT NULL,
    nombre_menu varchar(50),
    CONSTRAINT  permiso_pk PRIMARY KEY (id),
    CONSTRAINT  p_rol_fk FOREIGN KEY  (rol_id) REFERENCES  rol(id)
)

CREATE TABLE usuario(
    id int IDENTITY,
    rol_id int DEFAULT  2,
    dni varchar(50),
    nombre varchar(50),
    apellido varchar(50),
    clave varchar(50),
    correo varchar(50)
    CONSTRAINT  usuario_pk PRIMARY KEY (id),
    CONSTRAINT  u_rol_fk FOREIGN KEY (rol_id) REFERENCES rol(id)
)

CREATE TABLE chofer (
    id int IDENTITY,
    dni varchar(50),
    nombre varchar(50),
    apellido varchar(50),
    fecha_nacimiento date,
    celular varchar(50),
    correo varchar(50)
    CONSTRAINT  chofer_pk PRIMARY KEY (id)
)

SELECT * FROM chofer;

