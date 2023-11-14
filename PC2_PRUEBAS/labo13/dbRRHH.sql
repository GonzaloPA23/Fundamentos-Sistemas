-- Crear la base de datos dbRRHH
CREATE DATABASE dbRRHH;
GO

USE dbRRHH;
GO

-- Crear la tabla "Empleos"
CREATE TABLE Empleos (
    Código int IDENTITY(1,1) PRIMARY KEY,
    NombreDelEmpleo varchar(100) NOT NULL,
    SalarioMínimo money NOT NULL,
    SalarioMáximo money NOT NULL
);
GO

-- Crear la tabla "Empleados"
CREATE TABLE Empleados (
    CódigoEmpleado int PRIMARY KEY,
    DNI varchar(20) NOT NULL,
    Nombre varchar(100) NOT NULL,
    ApellidoPaterno varchar(100) NOT NULL,
    FechaDeNacimiento date NOT NULL,
    FechaDeContratación date NOT NULL,
    Salario money NOT NULL,
    CódigoEmpleo int,
    FOREIGN KEY (CódigoEmpleo) REFERENCES Empleos (Código)
);
GO

-- Crear la tabla "HistorialEmpleos"
CREATE TABLE HistorialEmpleos (
    CódigoEmpleado int,
    CódigoEmpleo int,
    FechaDeInicio datetime NOT NULL,
    FechaDeFin datetime,
    FOREIGN KEY (CódigoEmpleado) REFERENCES Empleados (CódigoEmpleado),
    FOREIGN KEY (CódigoEmpleo) REFERENCES Empleos (Código)
);
GO

-- Insertar datos de ejemplo
INSERT INTO Empleos (NombreDelEmpleo, SalarioMínimo, SalarioMáximo)
VALUES
    ('Programador', 30000.00, 60000.00),
    ('Diseñador Gráfico', 25000.00, 50000.00),
    ('Gerente de Proyecto', 40000.00, 80000.00),
    ('Analista de Datos', 35000.00, 70000.00),
    ('Asistente Administrativo', 20000.00, 40000.00),
    ('Técnico de Soporte', 22000.00, 45000.00),
    ('Recursos Humanos', 30000.00, 60000.00),
    ('Vendedor', 25000.00, 50000.00),
    ('Contador', 35000.00, 70000.00),
    ('Ingeniero de Sistemas', 40000.00, 80000.00);
GO

-- Insertar datos de ejemplo en Empleados
INSERT INTO Empleados (CódigoEmpleado, DNI, Nombre, ApellidoPaterno, FechaDeNacimiento, FechaDeContratación, Salario, CódigoEmpleo)
VALUES
    (1, '12345678', 'Juan', 'Pérez', '1980-05-15', '2021-03-20', 35000.00, 1),
    (2, '98765432', 'María', 'González', '1985-08-25', '2022-01-10', 28000.00, 2),
    (3, '55555555', 'Pedro', 'Sánchez', '1975-12-10', '2020-09-05', 42000.00, 3),
    (4, '11111111', 'Laura', 'Rodríguez', '1990-03-05', '2023-04-15', 32000.00, 1),
    (5, '44444444', 'Ana', 'Martínez', '1982-07-20', '2021-06-30', 36000.00, 4),
    (6, '66666666', 'José', 'López', '1978-11-02', '2020-11-15', 25000.00, 2);
GO

-- Insertar datos de ejemplo en HistorialEmpleos
INSERT INTO HistorialEmpleos (CódigoEmpleado, CódigoEmpleo, FechaDeInicio, FechaDeFin)
VALUES
    (1, 1, '2021-03-20', NULL),
    (2, 2, '2022-01-10', NULL),
    (3, 3, '2020-09-05', '2023-02-28'),
    (4, 1, '2023-04-15', NULL),
    (5, 4, '2021-06-30', NULL),
    (6, 2, '2020-11-15', '2023-01-31');
GO
