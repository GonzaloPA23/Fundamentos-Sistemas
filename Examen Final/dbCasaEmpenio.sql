CREATE DATABASE dbCasaEmpenio
USE dbCasaEmpenio

GO

DROP TABLE CLIENTE
DROP  TABLE ARTICULO

CREATE TABLE CLIENTE (
    dni char(8),
    nombrecompleto varchar(50),
    sexo varchar(10),
    ncelular varchar(15),
    distrito varchar(30),
    financiamiento date,
    email varchar(50)
    CONSTRAINT CLIENTE_PK PRIMARY KEY (dni)
)
GO

CREATE TABLE ARTICULO (
    codarticulo char(7),
    descripcion varchar(50),
    pais varchar(50),
    fecharegistro date,
    precio money,
    tipo varchar(50),
    paraofrecer varchar(10),
    CONSTRAINT ARTICULO_PK PRIMARY KEY (codarticulo)
)
GO

CREATE TABLE  CLIENTEXARTICULO(
    dni char(8) FOREIGN KEY REFERENCES CLIENTE(dni) ON DELETE CASCADE  ON UPDATE CASCADE NOT NULL,
    codarticulo char(7) FOREIGN KEY REFERENCES ARTICULO(codarticulo) ON DELETE CASCADE ON UPDATE CASCADE  NOT NULL,
    fventa date,
    CONSTRAINT CLIENTEXARTICULO_FK PRIMARY KEY (dni,codarticulo)
)
GO

SELECT * FROM CLIENTE
SELECT * FROM ARTICULO
SELECT * FROM CLIENTEXARTICULO