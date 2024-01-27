-- ================================================
	--Procedimiento para insertar usuarios del sistema
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Juan Carlos Samano
-- Create date: 27/01/2024
-- Description:	Sp para insetrar ifnromacion de los usuarios del sistema
-- =============================================
CREATE PROCEDURE SPAgregaUsuarios
		@Usuario varchar(20),
		@pssw varchar(20)
AS
BEGIN
	begin tran
	insert into Usuarios_Sistema (Nick, Secreto, Fecha_Registro, Activo ) 
		values (@Usuario , @pssw , getdate(),1)
	 commit tran
END
GO
