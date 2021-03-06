USE [FinalDB]
GO
/****** Object:  StoredProcedure [dbo].[ListePaysProc]    Script Date: 14/04/2018 19:22:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[ListePaysProc]
@IdContinent bigint
AS
SELECT        Pays.Nom AS Nom, Pays.IdPays As IdPays, Pays.IdContinent AS IdContinent
FROM            Pays INNER JOIN
                         Continent ON Pays.IdContinent = Continent.IdContinent
WHERE Continent.IdContinent = @IdContinent

