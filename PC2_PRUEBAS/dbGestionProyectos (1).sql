-- Crear la base de datos
CREATE DATABASE dbGestionProyectos;
GO

USE dbGestionProyectos;
GO

-- Crear la tabla Proyectos
CREATE TABLE Proyectos (
    CodigoProyecto INT PRIMARY KEY,
    Nombre VARCHAR(255),
    FechaInicio DATE,
    FechaFinalizacionEstimada DATE
);
GO

-- Crear la tabla Programadores
CREATE TABLE Programadores (
    CodigoProgramador INT PRIMARY KEY,
    Nombre VARCHAR(255),
    Especializacion VARCHAR(50),
    ExperienciaEnAnios INT
);
GO

-- Crear la tabla intermedia AsignacionProyectosProgramadores
CREATE TABLE AsignacionProyectosProgramadores (
    CodigoProyecto INT,
    CodigoProgramador INT,
    PRIMARY KEY (CodigoProyecto, CodigoProgramador),
    FOREIGN KEY (CodigoProyecto) REFERENCES Proyectos(CodigoProyecto),
    FOREIGN KEY (CodigoProgramador) REFERENCES Programadores(CodigoProgramador)
);
GO

-- Insertar datos de ejemplo en la tabla Proyectos
INSERT INTO Proyectos (CodigoProyecto, Nombre, FechaInicio, FechaFinalizacionEstimada)
VALUES
    (1, 'ProyectoA', '2023-01-01', '2023-06-30'),
    (2, 'ProyectoB', '2023-02-15', '2023-08-31'),
    (3, 'ProyectoC', '2023-03-20', '2023-10-15'),
    (4, 'ProyectoD', '2023-04-10', '2023-11-15'),
    (5, 'ProyectoE', '2023-05-05', '2023-12-20'),
    (6, 'ProyectoF', '2023-06-20', '2024-01-31'),
    (7, 'ProyectoG', '2023-07-15', '2024-02-28'),
    (8, 'ProyectoH', '2023-08-01', '2024-03-15'),
    (9, 'ProyectoI', '2023-09-10', '2024-04-30');
GO

-- Insertar datos de ejemplo en la tabla Programadores
INSERT INTO Programadores (CodigoProgramador, Nombre, Especializacion, ExperienciaEnAnios)
VALUES
    (101, 'Juan Pérez', 'Front-end', 5),
    (102, 'Ana Rodriguez', 'Back-end', 7),
    (103, 'Carlos Gutierrez', 'Full-stack', 8),
    (104, 'Maria Lopez', 'Back-end', 6),
    (105, 'Pedro Ramirez', 'Front-end', 4),
    (106, 'Laura Martinez', 'Full-stack', 9),
    (107, 'Andres Gutierrez', 'Full-stack', 6),
    (108, 'Isabel Torres', 'Back-end', 3),
    (109, 'Javier Rodriguez', 'Front-end', 5);
GO

-- Insertar datos de ejemplo en la tabla AsignacionProyectosProgramadores
INSERT INTO AsignacionProyectosProgramadores (CodigoProyecto, CodigoProgramador)
VALUES
    (1, 101), (2, 102), (3, 103), (1, 102), (2, 103),
    (4, 104), (5, 105), (6, 106), (4, 105), (5, 106),
    (7, 107), (8, 108), (9, 109), (7, 108), (8, 109);
GO
