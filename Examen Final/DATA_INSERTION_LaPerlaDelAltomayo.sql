USE DB_PerlaAltomayo;
GO

-- TABLA ROL
INSERT INTO Rol(nombre)
VALUES
    ('Admin'),
    ('Cliente')
GO

-- TABLA usuario
INSERT INTO Usuario(RolId, Dni, Nombre, Apellido, Clave , Correo)
VALUES
    (1,'12345678','Deyvid','Guevara','tupapi','deyvid@gmail.com')
GO
INSERT INTO  Usuario (Dni, Nombre, Apellido, Clave , Correo)
VALUES
    ('87654321','Gwyneth','Segura','hola23','gwyneth@gmail.com')
GO

-- TABLA permiso
INSERT INTO Permiso(RolId, NombreMenu)
VALUES
    (1,'menubuses'),
    (1,'menuchoferes'),
    (2,'menupasajes'),
    (2,'menuencomiendas'),
    (2,'menureportes')

SELECT  Permiso.RolId,NombreMenu FROM Permiso
    JOIN Rol r2 ON r2.id = Permiso.RolId
    JOIN Usuario u ON r2.id = u.RolId
WHERE  u.id = 1;

SELECT Permiso.Id, Permiso.RolId, NombreMenu FROM Permiso
JOIN Rol r2 ON r2.id = Permiso.RolId
JOIN Usuario u ON r2.id = u.RolId
WHERE u.id = 1;


-- TABLA chofer
INSERT INTO Chofer(Dni,Nombre,Apellido,FechaNacimiento,Celular,Correo)
VALUES
    (12345678,'Guillermo','Guzman',CONVERT(date,'13/10/2000',103),'9999999','@gmail.com')



-- ===================================================================
SELECT Permiso.RolId, NombreMenu FROM Permiso

SELECT * FROM Usuario
SELECT * FROM Permiso
SELECT * FROM Chofer