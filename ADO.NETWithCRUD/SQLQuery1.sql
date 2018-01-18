USE MembersDB
GO

CREATE TABLE Member
(
	MemberID			int				PRIMARY KEY IDENTITY
	,FirstName			varchar(50)		NOT NULL
	,LastName			varchar(50)		NOT NULL
	,BirthDate			date			NOT NULL
	,FavoriteAnimal		varchar(20)	NULL
)