
--Recorda que primero debes crear una base de datos para utilizarla
-- ve a base de datos en elmenu izquierdo->click derecho->nueva base de datosy lepones el mismo nombre
--que ya hemos descripto con anterioridad ,luego que la creaste ve y ejecuta use DB_pav1
--una vez posicionado sobre la base de datos , se puede ejecutar toda la base de datos o parte de ella segun necesites



USE [DB_pav1]

GO


--desde aca se puede ejecutar toda la DB,previamnete haber sido ejecutado la parte "USE DB_pav1"

CREATE TABLE [dbo].[Puesto](
	[id_puesto] [int] NOT NULL,
	[descripcion] [varchar](50) NULL,
	

)


CREATE TABLE [dbo].[Instalacion](
	[id_instalacion] [int] NOT NULL,
	[descripcion_instalacion] [varchar](50) NULL,
	[habilitada] [bit] NOT NULL,

)



CREATE TABLE [dbo].[Usuario](
	[id_user] [int] NOT NULL,
	[nombre_user] [varchar](50) NULL,
	[cuenta_user] [varchar](50) NULL,
	[pass_user] [varchar](50) NULL,
	[estado_user] [bit] NOT NULL,
)

  
CREATE TABLE TipoDocumento
(
id_tipoD  int NOT NULL,
descripcion_tipoDoc  varchar(50)
)


CREATE TABLE [dbo].[Huesped](
	[id_tipoDoc] [int] NOT NULL,
	[num_doc] [int] NOT NULL,
	[nombre_huesped] [varchar](50) NULL,
	[apellido_huesped] [varchar](50) NULL,
	[num_tarjeta] [int] NULL,
)




CREATE TABLE [dbo].[TipoServicio](
	[id_tipo_servicio] [int] NOT NULL,
	[desc_tipo_servicio] [varchar](50) NULL,
	[costo][int]null
)


CREATE TABLE [dbo].[Hotel](
	[id_hotel] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[descripcion] [varchar](50) NULL,
	Registrado varchar(50) null,

)

CREATE TABLE [dbo].[Habitacion](
	[id_habitacion] [int] NOT NULL,
	[descripcion_habitacion] [varchar](50) NULL,
	costo_habitacion float not null

)


--***Modi**********
CREATE TABLE [dbo].[HuespedXInstalacion](
	[id_tipo_doc] [int] NOT NULL,
	[num_doc] [int] NOT NULL,
	[id_instalacion] [int] NOT NULL,
	[fecha_hora] [varchar](30) NOT NULL,

)

--***Modi**********
CREATE TABLE [dbo].[HuespedXHabitacion](
	[id_habitacion] [int] NOT NULL,
	[id_tipo_doc] [int] NOT NULL,
	[num_doc] [int] NOT NULL,
	[fecha_hospedaje] [varchar](10) NOT NULL,
	[id_hotel] [int] NOT NULL,

)

--***Modi**********
CREATE TABLE [dbo].[Empleado](
	[legajo] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](40) NULL,
	[fecha_ingreso] [varchar](10) NULL,
	[id_hotel] [int] NOT NULL,
	[id_puesto] [int] NOT NULL,

)

--***Modi**********
CREATE TABLE [dbo].[Servicio](
	[id_servicio] [int] NOT NULL,
	[descripcion_servicio] [varchar](50) NULL,
	[id_tipo_servicio] [int] NOT NULL,
)


--***Modi**********
CREATE TABLE [dbo].[HuespedXServicio](
	[id_tipo_doc] [int] NOT NULL,
	[num_doc] [int] NOT NULL,
	[id_servicio] [int] NOT NULL,
	[fecha_solicitado] [varchar](10) NOT NULL,
	[costo_abonado] [int] NULL,
)


CREATE TABLE Detalle_Factura
(
num_factu   int  not null,
cod    int  not null,
descrip varchar(50)not null,
precio_vend  float not null,
cant_vend	float not null
)


CREATE TABLE Factura
(
num_factu   int  not null,
fecha_fact  date not null,
id_hotel_factu  int not null,
tipo_doc_hue   int not null,
num_doc_hue int not null,
nombre_huesped varchar(60)not null

)


	
--constraints
	
	ALTER TABLE TipoDocumento
	ADD PRIMARY KEY (id_tipoD)
	
	ALTER TABLE Huesped
	ADD PRIMARY KEY (id_tipoDoc,num_doc) 


	ALTER TABLE Hotel
	ADD PRIMARY KEY (id_hotel)
	
	ALTER TABLE Habitacion
	ADD
	PRIMARY KEY (id_habitacion)
	
	ALTER TABLE Instalacion
	ADD PRIMARY KEY (id_instalacion)
	
		
	ALTER TABLE Servicio
	ADD PRIMARY KEY (id_servicio)  
	
	ALTER TABLE TipoServicio
	ADD PRIMARY KEY (id_tipo_servicio)  
	
	ALTER TABLE Puesto
	ADD PRIMARY KEY (id_puesto)
	
	ALTER TABLE Empleado
	ADD PRIMARY KEY (legajo)  
	

	ALTER TABLE Usuario
	ADD PRIMARY KEY (id_user)
	
	--ALTER TABLE Detalle_Factura
	--ADD PRIMARY KEY (num_det)

	--ALTER TABLE Factura
	--ADD PRIMARY KEY (num_factu)
	
	 
	
--Empleado
ALTER TABLE [dbo].[Empleado]  
WITH CHECK ADD  CONSTRAINT [id_hotel_fk] FOREIGN KEY([id_hotel])
REFERENCES [dbo].[Hotel] ([id_hotel])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [id_hotel_fk]
GO

ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [id_puesto_fk] FOREIGN KEY([id_puesto])
REFERENCES [dbo].[Puesto] ([id_puesto])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [id_puesto_fk]
GO



--Servicio
ALTER TABLE [dbo].[Servicio]  WITH CHECK ADD FOREIGN KEY([id_tipo_servicio])
REFERENCES [dbo].[TipoServicio] ([id_tipo_servicio])
GO


/****** HuespedXHabitacion*/
ALTER TABLE [dbo].[HuespedXHabitacion]  WITH CHECK ADD FOREIGN KEY([id_habitacion])
REFERENCES [dbo].[Habitacion] ([id_habitacion])
GO

ALTER TABLE [dbo].[HuespedXHabitacion]  WITH CHECK ADD FOREIGN KEY([id_hotel])
REFERENCES [dbo].[Hotel] ([id_hotel])
GO

ALTER TABLE [dbo].[HuespedXHabitacion]  WITH CHECK ADD FOREIGN KEY([id_tipo_doc], [num_doc])
REFERENCES [dbo].[Huesped] ([id_tipoDoc], [num_doc])
GO


/****** HuespedXInstalac ******/
ALTER TABLE [dbo].[HuespedXInstalacion]  WITH CHECK ADD FOREIGN KEY([id_instalacion])
REFERENCES [dbo].[Instalacion] ([id_instalacion])
GO

ALTER TABLE [dbo].[HuespedXInstalacion]  WITH CHECK ADD FOREIGN KEY([id_tipo_doc], [num_doc])
REFERENCES [dbo].[Huesped] ([id_tipoDoc], [num_doc])
GO


/****** HuespedXServicio ******/
ALTER TABLE [dbo].[HuespedXServicio]  WITH CHECK ADD FOREIGN KEY([id_servicio])
REFERENCES [dbo].[Servicio] ([id_servicio])
GO

ALTER TABLE [dbo].[HuespedXServicio]  WITH CHECK ADD FOREIGN KEY([id_tipo_doc], [num_doc])
REFERENCES [dbo].[Huesped] ([id_tipoDoc], [num_doc])
GO




/****** Huesped ******/
ALTER TABLE Huesped
 ADD FOREIGN KEY(id_tipoDoc)
REFERENCES TipoDocumento (id_tipoD)


/****** Factura y Detalle ******/
ALTER TABLE Factura
ADD FOREIGN KEY(id_hotel_factu)
REFERENCES Hotel(id_hotel)

ALTER TABLE Factura
ADD FOREIGN KEY(tipo_doc_hue,num_doc_hue)
REFERENCES Huesped(id_tipoDoc,num_doc)




--ahora insertamos


INSERT [dbo].[Usuario] ([id_user], [nombre_user], [cuenta_user], [pass_user], [estado_user]) VALUES (1, N'ariel_zarate', N'ariel', N'123', 1)
INSERT [dbo].[Usuario] ([id_user], [nombre_user], [cuenta_user], [pass_user], [estado_user]) VALUES (2, N'esteban_correa', N'esteban', N'111', 0)
INSERT [dbo].[Usuario] ([id_user], [nombre_user], [cuenta_user], [pass_user], [estado_user]) VALUES (3, N'walter_xx', N'walter', N'222', 0)
INSERT [dbo].[Usuario] ([id_user], [nombre_user], [cuenta_user], [pass_user], [estado_user]) VALUES (4, N'mariano_zz', N'mariano', N'333', 0)
INSERT [dbo].[Usuario] ([id_user], [nombre_user], [cuenta_user], [pass_user], [estado_user]) VALUES (5, N'dario_lopez', N'dario', N'444', 0)
INSERT [dbo].[Usuario] ([id_user], [nombre_user], [cuenta_user], [pass_user], [estado_user]) VALUES (6, N'gaston_cabreara', N'gaston', N'555', 0)




INSERT [dbo].[Puesto] ([id_puesto], [descripcion]) VALUES (12, N'Mucamas')
INSERT [dbo].[Puesto] ([id_puesto], [descripcion]) VALUES (13, N'Recepcionista')
INSERT [dbo].[Puesto] ([id_puesto], [descripcion]) VALUES (20, N'Personal Limpieza')
INSERT [dbo].[Puesto] ([id_puesto], [descripcion]) VALUES (23, N'Conserje')
INSERT [dbo].[Puesto] ([id_puesto], [descripcion]) VALUES (28, N'Gerente')
INSERT [dbo].[Puesto] ([id_puesto], [descripcion]) VALUES (30, N'Mantenimiento')


INSERT TipoDocumento(id_tipoD,descripcion_tipoDoc)VALUES(10,'Documento Nacional de Identidad') 
INSERT TipoDocumento(id_tipoD,descripcion_tipoDoc)VALUES(11,'Pasapòrte') 

INSERT [dbo].[Huesped] ([id_tipoDoc], [num_doc], [nombre_huesped], [apellido_huesped], [num_tarjeta]) VALUES (10, 32785551, N'Ariel', N'zarate', 8725327)
INSERT [dbo].[Huesped] ([id_tipoDoc], [num_doc], [nombre_huesped], [apellido_huesped], [num_tarjeta]) VALUES (10, 47981292, N'Ana', N'Porto', NULL)
INSERT [dbo].[Huesped] ([id_tipoDoc], [num_doc], [nombre_huesped], [apellido_huesped], [num_tarjeta]) VALUES (10, 67821182, N'Juan ', N'bola', 3131351)
INSERT [dbo].[Huesped] ([id_tipoDoc], [num_doc], [nombre_huesped], [apellido_huesped], [num_tarjeta]) VALUES (11, 27978389, N'Maria', N'Sanchez', 252112)
INSERT [dbo].[Huesped] ([id_tipoDoc], [num_doc], [nombre_huesped], [apellido_huesped], [num_tarjeta]) VALUES (11, 39872356, N'antonellla', N'Miradas', 712522)



INSERT [dbo].[Hotel] ([id_hotel], [nombre], [descripcion]) VALUES (1, N'Howard Janshon 1 ', N'Nacional 4 Estrellas')
INSERT [dbo].[Hotel] ([id_hotel], [nombre], [descripcion]) VALUES (2, N'Hotel California1', N'Nacional 5 Estrellas')
INSERT [dbo].[Hotel] ([id_hotel], [nombre], [descripcion]) VALUES (3, N'Howard Janshon 3', N'Nacional 3 Estrellas')
INSERT [dbo].[Hotel] ([id_hotel], [nombre], [descripcion]) VALUES (4, N'Howard Janshon 4', N'Nacional 5 Estrellas')
INSERT [dbo].[Hotel] ([id_hotel], [nombre], [descripcion]) VALUES (5, N'Jaguar', N'Hotel 5 Estrellas')



INSERT [dbo].[Instalacion] ([id_instalacion], [descripcion_instalacion], [habilitada]) VALUES (301, N'Pileta', 1)
INSERT [dbo].[Instalacion] ([id_instalacion], [descripcion_instalacion], [habilitada]) VALUES (302, N'Gimnasio', 1)
INSERT [dbo].[Instalacion] ([id_instalacion], [descripcion_instalacion], [habilitada]) VALUES (303, N'Cancha de Tenis', 0)
INSERT [dbo].[Instalacion] ([id_instalacion], [descripcion_instalacion], [habilitada]) VALUES (304, N'Jacussi', 1)
INSERT [dbo].[Instalacion] ([id_instalacion], [descripcion_instalacion], [habilitada]) VALUES (305, N'Quincho', 1)
INSERT [dbo].[Instalacion] ([id_instalacion], [descripcion_instalacion], [habilitada]) VALUES (306, N'Espacio Recreativo', 1)





INSERT Habitacion (id_habitacion, descripcion_habitacion,costo_habitacion) VALUES (201, N'Cama Doble',1200)
INSERT Habitacion (id_habitacion, descripcion_habitacion,costo_habitacion) VALUES (202, N'Cama simple',800)
INSERT Habitacion (id_habitacion, descripcion_habitacion,costo_habitacion) VALUES (203, N'Completa con Spa',2800)
INSERT Habitacion (id_habitacion, descripcion_habitacion,costo_habitacion) VALUES (204, N'internacional ',4500)
INSERT Habitacion (id_habitacion, descripcion_habitacion,costo_habitacion) VALUES (205, N'simple cama doble',1000)





INSERT [dbo].[Empleado] ([legajo], [nombre], [apellido], [fecha_ingreso], [id_hotel], [id_puesto]) VALUES (12, N'Jose', N'Martinez', N'23112018', 1, 20)
INSERT [dbo].[Empleado] ([legajo], [nombre], [apellido], [fecha_ingreso], [id_hotel], [id_puesto]) VALUES (23, N'joaquin', N'sabina', N'21071967', 2, 20)
INSERT [dbo].[Empleado] ([legajo], [nombre], [apellido], [fecha_ingreso], [id_hotel], [id_puesto]) VALUES (33, N'maria', N'Selinez', N'25122016', 1, 13)



INSERT [dbo].[TipoServicio] ([id_tipo_servicio], [desc_tipo_servicio], [costo]) VALUES (901, N'Enfermeria', 300)
INSERT [dbo].[TipoServicio] ([id_tipo_servicio], [desc_tipo_servicio], [costo]) VALUES (902, N'Curaciones', 500)
INSERT [dbo].[TipoServicio] ([id_tipo_servicio], [desc_tipo_servicio], [costo]) VALUES (903, N'Comidas Habitacion',600)
INSERT [dbo].[TipoServicio] ([id_tipo_servicio], [desc_tipo_servicio], [costo]) VALUES (905, N'Delivery', 700)
INSERT [dbo].[TipoServicio] ([id_tipo_servicio], [desc_tipo_servicio], [costo]) VALUES (906, N'tontoreria',800)
INSERT [dbo].[TipoServicio] ([id_tipo_servicio], [desc_tipo_servicio], [costo]) VALUES (907, N'Servicios Especiales',1000)



INSERT [dbo].[Servicio] ([id_servicio], [descripcion_servicio], [id_tipo_servicio]) VALUES (801, N'Medico', 901)
INSERT [dbo].[Servicio] ([id_servicio], [descripcion_servicio], [id_tipo_servicio]) VALUES (802, N'Medico', 902)
INSERT [dbo].[Servicio] ([id_servicio], [descripcion_servicio], [id_tipo_servicio]) VALUES (803, N'Comida', 903)
INSERT [dbo].[Servicio] ([id_servicio], [descripcion_servicio], [id_tipo_servicio]) VALUES (805, N'comida Rapida',905)
INSERT [dbo].[Servicio] ([id_servicio], [descripcion_servicio], [id_tipo_servicio]) VALUES (806, N'Lavados', 906)
INSERT [dbo].[Servicio] ([id_servicio], [descripcion_servicio], [id_tipo_servicio]) VALUES (807, N'Masajistas',907)
