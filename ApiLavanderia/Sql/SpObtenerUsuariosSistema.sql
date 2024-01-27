-- ================================================
--Este Sp funciona para obtener la lista de usuarios del sistema 
--llamado por la APILavanderia
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Juan carlos samano
-- Create date: 27/01/2024
-- Description:	Sp para obtener los usuarios del sistema.
-- =============================================
CREATE PROCEDURE SpObtenerUsuariosSistema
	
AS
BEGIN
	
	SET NOCOUNT ON;
    Select * from Usuarios_Sistema
END
GO
