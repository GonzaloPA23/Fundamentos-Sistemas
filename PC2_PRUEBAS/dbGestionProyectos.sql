-- Crear la base de datos
CREATE DATABASE dbGestionProyectos;
GO

DROP TABLE AsignacionProyectosProgramadores
DROP TABLE Programadores
DROP TABLE Proyectos

USE dbGestionProyectos;
GO

-- Crear la tabla Proyectos
CREATE TABLE Proyectos (
    CodigoProyecto INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(255),
    FechaInicio DATE,
    FechaFinalizacionEstimada DATE
);
GO

-- Crear la tabla Programadores
CREATE TABLE Programadores (
    CodigoProgramador INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(255),
    Especializacion VARCHAR(50),
    ExperienciaEnAnios INT
);
GO

-- Crear la tabla intermedia AsignacionProyectosProgramadores
CREATE TABLE AsignacionProyectosProgramadores (
    CodigoProyecto INT,
    CodigoProgramador INT,
    FOREIGN KEY (CodigoProyecto) REFERENCES Proyectos(CodigoProyecto),
    FOREIGN KEY (CodigoProgramador) REFERENCES Programadores(CodigoProgramador)
);
GO

-- Insertar datos de ejemplo en la tabla Proyectos
INSERT INTO Proyectos (Nombre, FechaInicio, FechaFinalizacionEstimada)
VALUES
    ('ProyectoA', '2023-01-01', '2023-06-30'),
    ('ProyectoB', '2023-02-15', '2023-08-31'),
    ('ProyectoC', '2023-03-20', '2023-10-15'),
    ('ProyectoD', '2023-04-10', '2023-11-15'),
    ('ProyectoE', '2023-05-05', '2023-12-20'),
    ('ProyectoF', '2023-06-20', '2024-01-31'),
    ('ProyectoG', '2023-07-15', '2024-02-28'),
    ('ProyectoH', '2023-08-01', '2024-03-15'),
    ('ProyectoI', '2023-09-10', '2024-04-30');
GO

-- Insertar datos de ejemplo en la tabla Programadores
INSERT INTO Programadores (Nombre, Especializacion, ExperienciaEnAnios)
VALUES
    ('Juan Pérez', 'Front-end', 5),
    ('Ana Rodriguez', 'Back-end', 7),
    ('Carlos Gutierrez', 'Full-stack', 8),
    ('Maria Lopez', 'Back-end', 6),
    ('Pedro Ramirez', 'Front-end', 4),
    ('Laura Martinez', 'Full-stack', 9),
    ('Andres Gutierrez', 'Full-stack', 6),
    ('Isabel Torres', 'Back-end', 3),
    ('Javier Rodriguez', 'Front-end', 5);
GO

-- Insertar datos de ejemplo en la tabla AsignacionProyectosProgramadores
INSERT INTO AsignacionProyectosProgramadores (CodigoProyecto, CodigoProgramador)
VALUES
    (1, 1), (2, 2), (3, 3), (1, 2), (2, 3),
    (4, 4), (5, 5), (6, 6), (4, 5), (5, 6),
    (7, 7), (8, 8), (9, 9), (7, 8), (8, 9);
GO

SELECT * FROM Proyectos
SELECT  * FROM Programadores
SELECT * FROM AsignacionProyectosProgramadores

SELECT  * FROM Programadores
JOIN AsignacionProyectosProgramadores APP on Programadores.CodigoProgramador = APP.CodigoProgramador
JOIN Proyectos P on P.CodigoProyecto = APP.CodigoProyecto
