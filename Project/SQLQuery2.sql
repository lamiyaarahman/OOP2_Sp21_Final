/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [id]
      ,[employeename]
      ,[address]
      ,[phone]
      ,[salary]
  FROM [Shop].[dbo].[employee]