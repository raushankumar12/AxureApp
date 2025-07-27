CREATE TABLE People (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100),
    Age INT
);

INSERT INTO People (Name, Age) VALUES ('Alice', 30);
INSERT INTO People (Name, Age) VALUES ('Bob', 25);
