USE DB_PerlaAltomayo
SELECT * FROM Usuario

DROP PROC  SP_RegistrarUsuario
DROP PROC  SP_RegistrarChofer

-- PROCEDIMIENTO ALMACENADO PARA REGISTRAR UN USUARIO

CREATE PROC SP_RegistrarUsuario(
    @Dni varchar(50),
    @Nombre varchar(50),
    @Apellido varchar(50),
    @Clave varchar(50),
    @Correo varchar(50),
    @IdResultado int output,
    @Mensaje varchar(200) output
)
AS
BEGIN
            SET @IdResultado = 0
            SET @Mensaje = ''

            IF NOT EXISTS(SELECT  * FROM Usuario WHERE Dni = @Dni OR Correo = @Correo)
            BEGIN
                    INSERT INTO  Usuario(Dni, Nombre, Apellido, Clave, Correo)
                    VALUES  (@Dni, @Nombre, @Apellido, @Clave, @Correo)

                    SET @IdResultado = SCOPE_IDENTITY()
            END
            ELSE
                    SET @Mensaje = 'No se puede registrar un usuario con los mismos datos de DNI o correo'
END

DECLARE @idresultado int
DECLARE @mensaje  varchar(200)

EXEC  SP_RegistrarUsuario '72363738','Alvaro','Patricio',
                                                'gochifa','alvaropa@gmail.com',@idresultado OUTPUT, @mensaje output

SELECT @idresultado
SELECT  @mensaje

-- PROCEDIMIENTO ALMACENADO PARA REGISTRAR UN CHOFER
CREATE PROC  SP_RegistrarChofer(
    @Dni varchar(50),
    @Nombre varchar(50),
    @Apellido varchar(50),
    @FechaNacimiento varchar(50),
    @Celular varchar(50),
    @Correo varchar(50),
    @IdResultado int output,
    @Mensaje varchar(200) output
)
AS
BEGIN
        SET @IdResultado = 0
        SET @Mensaje = ''

        IF NOT EXISTS(SELECT  * FROM Chofer WHERE Dni = @Dni OR Correo = @Correo)
            BEGIN
                    INSERT INTO  Chofer(Dni, Nombre, Apellido, FechaNacimiento, Celular, Correo)
                    VALUES  (@Dni, @Nombre, @Apellido, CONVERT(date,@FechaNacimiento,103),@Celular,@Correo)

                    SET @IdResultado = SCOPE_IDENTITY()
            END
            ELSE
                    SET @Mensaje = 'No se puede registrar un chofer con los mismos datos de DNI o correo'
END

DECLARE @idresultado int
DECLARE @mensaje  varchar(200)

EXEC SP_RegistrarChofer '01234567','Manuel', 'Manrique','12/10/1995','987654321','manrique230@gmail.com',@idresultado OUTPUT, @mensaje OUTPUT

SELECT @idresultado
SELECT  @mensaje

SELECT * FROM chofer

-- PROCEDIMIENTO ALMACENADO PARA EDITAR UN CHOFER
CREATE PROC SP_EditarChofer(
    @Id int,
    @Correo varchar(50),
    @Celular varchar(50),
    @Respuesta bit output,
    @Mensaje varchar(200) output
)
AS
BEGIN
        SET @Respuesta = 0
        SET @Mensaje = ''

        IF NOT EXISTS(SELECT  * FROM Chofer WHERE Correo = @Correo AND Id != @Id)
        BEGIN
                UPDATE Chofer SET
                Correo = @Correo,
                Celular = @Celular
                WHERE Id = @Id

                SET @Respuesta = 1
        END
        ELSE
                SET @Mensaje = 'No se puede actualizar al usuario con un correo existente'
END

DECLARE  @respuesta bit
DECLARE  @mensaje varchar(200)

EXEC  SP_EditarChofer '3', 'javicho23@gmail.com', '987653948', @respuesta output , @mensaje output

SELECT @respuesta
SELECT @mensaje

-- PROCEDIMIENTO ALMACENADO PARA  REGISTRAR UN BUS
DROP PROCEDURE  SP_RegistrarBus

CREATE PROC SP_RegistrarBus(
    @ChoferId int,
    @Matricula varchar(50),
    @Tipo varchar(50),
    @CantidadAsiento int,
    @PuntoSalida varchar(50),
    @Destino varchar(50),
    @FechaSalida datetime,
    @FechaLlegada datetime,
    @PrecioAsiento money,
    @AsientosDisponibles int,
    @IdResultado int output,
    @Mensaje varchar(200) output
)
AS
BEGIN
    SET @IdResultado = 0
    SET @Mensaje = ''

    -- Verificar si la matrícula ya está registrada con otro tipo diferente
    IF NOT EXISTS(
        SELECT *
        FROM Bus
        WHERE (Matricula = @Matricula AND Tipo <> @Tipo AND CantidadAsiento = @CantidadAsiento)
        OR (ChoferId = @ChoferId AND ((FechaSalida BETWEEN @FechaSalida AND @FechaLlegada) OR (FechaLlegada BETWEEN @FechaSalida AND @FechaLlegada)))
    )
    BEGIN
        -- Verificar si hay conflicto de fechas para el mismo bus
        IF NOT EXISTS(
            SELECT *
            FROM Bus
            WHERE Matricula = @Matricula
                AND ((FechaSalida BETWEEN @FechaSalida AND @FechaLlegada)
                    OR (FechaLlegada BETWEEN @FechaSalida AND @FechaLlegada)
                    OR (@FechaSalida BETWEEN FechaSalida AND FechaLlegada)
                    OR (@FechaLlegada BETWEEN FechaSalida AND FechaLlegada))
        )
        BEGIN
            -- Realizar la inserción
            INSERT INTO Bus (
                ChoferId,
                Matricula,
                Tipo,
                CantidadAsiento,
                PuntoSalida,
                Destino,
                FechaSalida,
                FechaLlegada,
                PrecioAsiento,
                AsientosDisponibles
            )
            VALUES (
                @ChoferId,
                @Matricula,
                @Tipo,
                @CantidadAsiento,
                @PuntoSalida,
                @Destino,
                CONVERT(datetime, @FechaSalida, 103),
                CONVERT(datetime, @FechaLlegada, 103),
                @PrecioAsiento,
                @AsientosDisponibles
            )

            SET @IdResultado = SCOPE_IDENTITY()
        END
        ELSE
            SET @Mensaje = 'Conflicto de fechas para el mismo bus.'
    END
    ELSE
        SET @Mensaje = 'La matrícula ya está registrada con otro tipo, diferente cantidad de asientos disponibles o el chofer ya tiene un bus registrado en la misma fecha'
END


DECLARE @idresultado int
DECLARE @mensaje  varchar(200)

EXEC SP_RegistrarBus '5','M3X-230','Economico',56,'Piura','Lambayeque','2023-12-25 10:00:00','2023-12-31 04:30:00',80, @idresultado output, @mensaje output

SELECT @idresultado
SELECT  @mensaje


 -- PROCEDIMIENTO ALMACENADO PARA REGISTRAR UNA ENCOMIENDA
DROP PROCEDURE SP_RegistrarEncomienda

CREATE PROC  SP_RegistrarEncomienda(
    @UsuarioId varchar(50),
    @Destino varchar(50),
    @PuntoSalida varchar(50),
    @FechaEnvio varchar(50),
    @FechaLlegada varchar(50),
    @TipoProducto varchar(50),
    @Peso float(4) ,
    @Largo float(4),
    @Alto float(4) ,
    @Ancho float(4),
    @Precio money,
    @IdResultado int output,
    @Mensaje varchar(200) output
)
AS
BEGIN
        SET @IdResultado = 0
        SET @Mensaje = ''
            BEGIN
                    INSERT INTO  Encomienda(UsuarioId, Destino, PuntoSalida, FechaEnvio, FechaLlegada, TipoProducto, Peso, Largo, Alto, Ancho, Precio)
                    VALUES  (@UsuarioId, @Destino, @PuntoSalida, @FechaEnvio, @FechaLlegada, @TipoProducto, @Peso, @Largo, @Alto, @Ancho, @Precio)

                    SET @IdResultado = SCOPE_IDENTITY()
            END
END

DECLARE @idresultado int
DECLARE @mensaje  varchar(200)

EXEC SP_RegistrarEncomienda '3', 'Piura', 'Lima', '2023-11-21 12:00:00', '2023-11-28 12:00:00', 'Ropa', 10,10,10,10,  '50.00',@idresultado output, @mensaje output

SELECT @idresultado
SELECT @mensaje

SELECT * FROM Encomienda



INSERT INTO Encomienda(UsuarioId, Destino, PuntoSalida, FechaEnvio, FechaLlegada, TipoProducto, Peso, Largo, Alto, Ancho,Precio)
VALUES
    ('2','Piura','Lima','2023-12-20 10:00:00','2023-12-27 10:00:00','Fragil',10,20,20,20,'40')


SELECT * FROM Encomienda

SELECT * FROM Usuario









INSERT INTO Bus(ChoferId, Matricula, Tipo, AsientosDisponibles, PuntoSalida, Destino, FechaSalida, FechaLlegada, PrecioAsiento)
VALUES
    ('3','TAS-230','Vip',64,'Lima','Piura','2023-11-18 14:30:00','2023-11-22 04:30:00',120)





SELECT  * FROM Chofer
SELECT  * FROM Bus


DROP PROC SP_RegistrarBus
DROP PROC SP_EditarChofer





SELECT * FROM Usuario
SELECT * FROM Bus
SELECT * FROM chofer
SELECT * FROM rol
SELECT * FROM permiso
SELECT * FROM Pasaje

UPDATE Usuario
SET Foto = null
WHERE Id = 1

ALTER TABLE Bus
ADD AsientosDisponibles int;

-- PROCEDIMIENTO ALMACENADO PARA REGISTRAR UN PASAJE

CREATE PROC  SP_RegistrarPasaje
(
    @UsuarioId int,
    @BusId int,
    @Asiento varchar(50),
    @Piso int,
    @IdResultado int output,
    @Mensaje varchar(200) output
)
AS
BEGIN
        SET @IdResultado = 0
        SET @Mensaje = ''

        IF NOT EXISTS(SELECT  * FROM Pasaje
            WHERE Asiento = @Asiento
                AND Piso = @Piso
                AND BusId = @BusId
                AND UsuarioId = @UsuarioId)
            BEGIN
                    INSERT INTO  Pasaje(UsuarioId, BusId, Asiento, Piso)
                    VALUES  (@UsuarioId,@BusId,@Asiento,@Piso)

                    SET @IdResultado = SCOPE_IDENTITY()
            END
            ELSE
                    SET @Mensaje = 'El asiento ya está ocupado para ese bus o por otro pasajero'
END

DECLARE @idresultado int
DECLARE @mensaje  varchar(200)

EXEC SP_RegistrarPasaje '2', '6','A2',2, @idresultado output, @mensaje output

SELECT @idresultado
SELECT @mensaje

SELECT * FROM Usuario
SELECT * FROM Bus
SELECT * FROM Pasaje
DROP PROCEDURE SP_RegistrarPasaje

SELECT Pasaje.Id, Matricula,Tipo,FechaSalida,PuntoSalida,Destino,PrecioAsiento, Asiento, Piso, FechaCompra FROM Pasaje
JOIN Bus B on Pasaje.BusId = B.Id
JOIN Usuario U on Pasaje.UsuarioId = U.Id
WHERE U.Id = 2