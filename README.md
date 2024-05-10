-------------------------

Appsettings.json:
```
{
"Values": {
"GithubClientId": "",
"GithubClientSecret": ""
},

"ConnectionStrings": {
"DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Initial Catalog=TCSA_V2; Integrated Security=true;"
},
"Logging": {
"LogLevel": {
"Default": "Information",
"Microsoft.AspNetCore": "Warning"
}
},
"AllowedHosts": "\*"
}
```
GetRanking Store Procedure

```
/****** Object:  StoredProcedure [dbo].[GetRanking]    Script Date: 17/02/2024 5:39:04 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetRanking]
    @userId NVARCHAR(450),
    @ranking INT OUTPUT
AS
BEGIN
    DECLARE @userExperiencePoints INT;

    -- Get the user's experience points based on the provided user ID
    SELECT @userExperiencePoints = [ExperiencePoints]
    FROM [AspNetUsers]
    WHERE [Id] = @userId;

    -- Calculate the user's ranking
    SELECT @ranking = COUNT(*) + 1
FROM [AspNetUsers]
WHERE [ExperiencePoints] > @userExperiencePoints
   OR ([ExperiencePoints] = @userExperiencePoints AND (
       [FirstName] < (SELECT [FirstName] FROM [AspNetUsers] WHERE [Id] = @userId) OR
       ([FirstName] = (SELECT [FirstName] FROM [AspNetUsers] WHERE [Id] = @userId) AND [LastName] < (SELECT [LastName] FROM [AspNetUsers] WHERE [Id] = @userId))
   ));
END;
GO
```

