CREATE TABLE transactions
(
	[Tnum] INT NOT NULL PRIMARY KEY IDENTITY, 
    [date] DATE NULL, 
    [time] TIME NULL, 
    [br_Id] INT NULL, 
    [book_num] INT NULL, 
    [Authorized_by] VARCHAR(20) NULL, 
    [return_date] DATE NULL, 
    [hasReturned] BIT NULL, 
    CONSTRAINT [FK_transactions_ToTable] FOREIGN KEY ([book_num]) REFERENCES books([accNo]), 
    CONSTRAINT [FK_transactions_ToTable_1] FOREIGN KEY ([Authorized_by]) REFERENCES systemTable([Property])
)
