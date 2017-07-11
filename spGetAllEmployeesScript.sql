USE [mvctutorialdb]
GO

/****** Object:  StoredProcedure [dbo].[spGetAllEmployees]    Script Date: 7/11/2017 6:19:07 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spGetAllEmployees]
as
Begin
	Select EmployeeId, Name, Gender, City, DepartmentId, DateOfBirth
	from tblEmployee
End
GO

