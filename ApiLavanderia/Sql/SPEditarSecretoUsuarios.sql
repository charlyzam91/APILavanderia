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
CREATE PROCEDURE SPEditarSecretoUsuarios
		@KeyUsuario int,
		@pssw varchar(20)
AS
BEGIN
	begin tran
		update Usuarios_Sistema set Secreto = @pssw where key_usuario = @KeyUsuario 
	 commit tran
END
GO
