USE [mvctutorialdb]
GO

/****** Object:  StoredProcedure [dbo].[spSaveEmployee]    Script Date: 7/11/2017 6:19:17 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spSaveEmployee]
@EmployeeId int,
@Name nvarchar(50),
@Gender nvarchar(50),
@City nvarchar(50),
@DepartmentId int,
@DateOfBirth DateTime
AS
BEGIN
	UPDATE tblEmployee 
	SET Name = @Name, Gender = @Gender, City = @City, DepartmentId = @DepartmentId, DateOfBirth = @DateOfBirth
	WHERE EmployeeId = @EmployeeId
END
GO

