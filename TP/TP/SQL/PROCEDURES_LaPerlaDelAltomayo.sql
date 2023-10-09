USE DB_PerlaAltomayo
SELECT * FROM usuario;


-- PROCEDIMIENTO ALMACENADO PARA REGISTRAR UN USUARIO

CREATE PROC SP_RegistrarUsuario(
    @dni varchar(50),
    @nombre varchar(50),
    @apellido varchar(50),
    @clave varchar(50),
    @correo varchar(50),
    @idResultado int output,
    @mensaje varchar(200) output
)
AS
BEGIN
            SET @idResultado = 0
            SET @Mensaje = ''

            IF NOT EXISTS(SELECT  * FROM usuario WHERE dni = @dni)
            BEGIN
                    INSERT INTO  usuario(dni, nombre, apellido, clave, correo)
                    VALUES  (@dni, @nombre, @apellido, @clave, @correo)

                    SET @idResultado = SCOPE_IDENTITY()
            END
            ELSE
                    SET @mensaje = 'No se puede registrar un usuario con el mismo número de DNI'
END

DECLARE @idresultado int
DECLARE @mensaje  varchar(200)

EXEC  SP_RegistrarUsuario '72363738','Alvaro','Patricio',
                                                'gochifa','alvaropa@gmail.com',@idresultado OUTPUT, @mensaje output

SELECT @idresultado
SELECT  @mensaje

-- PROCEDIMIENTO ALMACENADO PARA REGISTRAR UN CHOFER
SELECT * FROM chofer;
CREATE PROC  SP_RegistrarChofer(
    @dni varchar(50),
    @nombre varchar(50),
    @apellido varchar(50),
    @fecha_nacimiento varchar(50),
    @celular varchar(50),
    @correo varchar(50),
    @idResultado int output,
    @mensaje varchar(200) output
)
AS
BEGIN
        SET @idResultado = 0
        SET @mensaje = ''

        IF NOT EXISTS(SELECT  * FROM chofer WHERE dni = @dni OR correo = @correo)
            BEGIN
                    INSERT INTO  chofer(dni, nombre, apellido, fecha_nacimiento, celular, correo)
                    VALUES  (@dni, @nombre, @apellido, CONVERT(date,@fecha_nacimiento,103),@celular,@correo)

                    SET @idResultado = SCOPE_IDENTITY()
            END
            ELSE
                    SET @mensaje = 'No se puede registrar un usuario con los mismos datos de DNI o correo'
END

DECLARE @idresultado int
DECLARE @mensaje  varchar(200)

EXEC SP_RegistrarChofer '01234567','Manuel', 'Manrique','12/10/1995','987654321','manrique230@gmail.com',@idresultado OUTPUT, @mensaje OUTPUT

SELECT @idresultado
SELECT  @mensaje

SELECT * FROM chofer
---------------------
CREATE PROC SP_EditarUsuario(
    @dni varchar(50),
    @correo varchar(50),
    @celular varchar(50),
    @respuesta bit output,
    @mensaje varchar(200) output
)
AS
BEGIN
        SET @respuesta = 0
        SET @mensaje = ''

        IF NOT EXISTS(SELECT  * FROM chofer WHERE correo = @correo and dni != @dni)
        BEGIN
                UPDATE chofer SET
                correo = @correo,
                celular = @celular
                WHERE dni = @dni

                SET @respuesta = 1
        END
        ELSE
                SET @mensaje = 'No se puede actualizar al usuario con un correo existente'
END

DECLARE  @respuesta bit
DECLARE  @mensaje varchar(200)

EXEC  SP_EditarUsuario '98765432', 'manuelitopkmz@gmail.com', '123456789', @respuesta output , @mensaje output

SELECT @respuesta
SELECT @mensaje

SELECT  * FROM chofer

DROP PROC SP_EditarUsuario

