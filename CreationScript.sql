USE [VMDB]
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([Id], [Nombre], [Apellido], [Email], [Password]) VALUES (1, N'Alejandro', N'Bella', N'ab@gmail.com', N'123456')
INSERT [dbo].[User] ([Id], [Nombre], [Apellido], [Email], [Password]) VALUES (2, N'Pepe', N'Juarez', N'AJ@yahoo.com.ar', N'654321')
INSERT [dbo].[User] ([Id], [Nombre], [Apellido], [Email], [Password]) VALUES (3, N'Juan ', N'Perez', N'JP@hotmail.com', N'253614')
SET IDENTITY_INSERT [dbo].[User] OFF
