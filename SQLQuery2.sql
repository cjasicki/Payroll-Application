USE [Payroll]
GO

DECLARE	@return_value Int,
		@PayRate smallmoney

EXEC	@return_value = [dbo].[GetPayRateByID]
		@EmpID = 1,
		@PayRate = @PayRate OUTPUT

SELECT	@PayRate as N'@PayRate'

SELECT	@return_value as 'Return Value'

GO
