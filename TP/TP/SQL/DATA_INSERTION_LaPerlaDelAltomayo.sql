USE DB_PerlaAltomayo;
GO

-- TABLA ROL
INSERT INTO rol(nombre)
VALUES
    ('Admin'),
    ('Cliente')
GO

SELECT * FROM rol;

-- TABLA usuario
INSERT INTO usuario(rol_id, dni, nombre, apellido, clave , correo)
VALUES
    (1,'12345678','Deyvid','Guevara','tupapi','deyvid@gmail.com')
GO
INSERT INTO  usuario (dni, nombre, apellido, clave, correo)
VALUES
    ('87654321','Gwyneth','Segura','hola23','gwyneth@gmail.com')
GO

SELECT * FROM  usuario;


-- TABLA permiso
INSERT INTO permiso(rol_id, nombre_menu)
VALUES
    (1,'menubuses'),
    (1,'menuchoferes'),
    (2,'menupasajes'),
    (2,'menuencomiendas'),
    (2,'menureportes')

SELECT  * FROM permiso;

SELECT  permiso.rol_id,nombre_menu FROM permiso
    JOIN rol r2 ON r2.id = permiso.rol_id
    JOIN usuario u ON r2.id = u.rol_id
WHERE  u.id = 1;

-- TABLA chofer
SELECT  * FROM chofer
INSERT INTO chofer(dni,nombre,apellido,fecha_nacimiento,celular,correo)
VALUES
    (12345678,'Guillermo','Guzman',CONVERT(date,'13/10/2000',103),'9999999','@gmail.com')

