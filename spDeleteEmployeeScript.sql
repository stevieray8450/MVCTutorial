USE [mvctutorialdb]
GO

/****** Object:  StoredProcedure [dbo].[spDeleteEmployee]    Script Date: 7/11/2017 6:18:53 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spDeleteEmployee]
@Id int
AS
BEGIN
	DELETE FROM tblEmployee
	WHERE EmployeeId = @Id
END
GO

