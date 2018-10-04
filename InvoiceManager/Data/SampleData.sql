USE InvoiceDB
GO
delete from [Invoices]
delete from [InvoiceAccounts]
delete from [PERIODS]
GO
set identity_insert [PERIODS] ON
GO
insert into [PERIODS] (Id, Name) Values(0, N'�� ������')
insert into [PERIODS] (Id, Name) Values(1, N'������')
insert into [PERIODS] (Id, Name) Values(2, N'�������')
GO
set identity_insert [PERIODS] OFF
GO
set identity_insert [InvoiceAccounts] ON
GO
insert into [InvoiceAccounts] (Id, AccountNumber, Name) values(1, N'99999999', N'��������� �� ���')
insert into [InvoiceAccounts] (Id, AccountNumber, Name) values(2, N'AJ71-456', N'��������� �� �������������� (���)')
GO
set identity_insert [InvoiceAccounts] OFF
GO
set identity_insert [Invoices] ON
GO
insert into [Invoices] (Id, InvoiceAccountId, PeriodId, Number, Sum, Created)
  values (1, 1, 0, N'80-895-12', 164.5, CURRENT_TIMESTAMP)
insert into [Invoices] (Id, InvoiceAccountId, PeriodId, Number, Sum, Created)
  values (2, 2, 1, N'6768', 2000, CURRENT_TIMESTAMP)
GO
set identity_insert [Invoices] OFF
GO
