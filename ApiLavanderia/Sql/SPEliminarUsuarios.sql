-- ================================================
	--Procedimiento para Actualizar usuarios del sistema
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Juan Carlos Samano
-- Create date: 27/01/2024
-- Description:	Sp para Actualizar Informacion de los usuarios del sistema
-- =============================================
CREATE PROCEDURE SPEliminarUsuarios
		@KeyUsuario int
AS
BEGIN
	begin tran
		Delete from Usuarios_Sistema where key_usuario = @KeyUsuario 
	 commit tran
END
GO
