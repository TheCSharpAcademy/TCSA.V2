### 🛠️ Configure Project Locally

0. If it doesn't exist, create a ticket in https://github.com/users/TheCSharpAcademy/projects/5 and https://www.thecsharpacademy.com/dashboard/community (both are necessary)

1. Create **appsettings.json** file and paste the following:

``` appsettings.json
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
"AllowedHosts": "*"
}
```

2. Make sure you have SQL Server Management Studio (or other Database 
   Management Software) installed and configured.
3. Replace ```DefaultConnection``` string with your own Connection String.
4. Go to **Program.cs** and uncomment lines 92 and 93:

```Program.cs
using (var scope = app.Services.CreateScope())
{
  var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    //dbContext.Database.EnsureDeleted();
    //dbContext.Database.EnsureCreated();
}
```

5. Run the project.

#### _If you want to log in to dummy account via Github_

1. Update ```GithubClientId``` and ```GithubClientSecret``` 
   with random values (e.x. abcde12345).
2. Run the project and register using Github.
3. Log in to that account.




### GetRanking Store Procedure

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

