USE [mvctutorialdb]
GO

/****** Object:  StoredProcedure [dbo].[spAddEmployee]    Script Date: 7/11/2017 6:17:45 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spAddEmployee]

@Name nvarchar(50) = NULL,

@Gender nvarchar(10) = NULL,

@City nvarchar(50) = NULL,

@DepartmentId int = NULL,

@DateOfBirth DateTime = NULL

as

Begin

	INSERT INTO tblEmployee (Name, Gender, City, DepartmentId, DateOfBirth)

	VALUES (@Name, @Gender, @City, @DepartmentId, @DateOfBirth)

End
GO

