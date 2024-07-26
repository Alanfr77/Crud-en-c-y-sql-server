Este sistema permite:

Registrar un nuevo usuario en la db.
Modificiar la informacion de un usuario en la db
Consultar la informacion especifica de un usuario de la db
Eliminar la informacion de un usuario en la db
Consulta general de usuarios

Procedimientos:

/* create procedure SP_RegistrarEstudiante
	@paramNombre varchar(50),
	@paramDireccion varchar(150)
as
begin
	insert into estudiantes(nombre,direccion) values (@paramNombre,@paramDireccion)
end */



/* create procedure SP_ConsultaGeneral
as
begin
	select * from estudiantes
end */





/* create procedure SP_actualizarDatos
	@paramCarnet int,
	@paramNombre varchar(50),
	@paramDireccion varchar(150)
as
begin
	update estudiantes
	set nombre = @paramNombre,
		direccion = @paramDireccion
	where carnet = @paramCarnet
end */


/* create procedure SP_editarDatos
	@paramCarnet int,
	@paramNombre varchar(50),
	@paramDireccion varchar(150)
as
begin
	update estudiantes
	set nombre = @paramNombre,
		direccion = @paramDireccion
	where carnet = @paramCarnet
end */





/* create procedure SP_EliminarEstudiante
	@paramCarnet int
as
begin
	delete from estudiantes
	where carnet = @paramCarnet
end */





/*create procedure SP_ConsultarEstudiante
	@paramCarnet int
as
begin
	SELECT * FROM estudiantes WHERE carnet = @paramCarnet
end */
