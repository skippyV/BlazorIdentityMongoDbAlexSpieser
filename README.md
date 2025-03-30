This is a Blazor server web app that uses Identity and MongoDb.

Initial project setup was done via guidance from a CodeWrinkles video: https://www.youtube.com/watch?v=asa2ucbZlCI&t=48s

Microsoft Visual Studio Community 2022 project template:
 - Blazor Web App - (choose .Net8)
 - Authentication type: Individual Accounts
 - Configure for HTTPS is checked
 - Interactive Render mode: Server
 - Interactivity location: Per page/component
 - Include sample pages is checked
 - Do not use top-level statements is checked
	
Then to remove unwanted stuff from project:
Delete from project:
 - Data->Migrations folder
 - Data->ApplicationDbContext.cs
   
From NuGet tools, UN-install packages:
 - Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore
 - Microsoft.AspNetCore.Identity.EntityFrameworkCore
 - Microsoft.EntityFrameworkCore.SqlServer
 - Microsoft.EntityFrameworkCore.Tools
	
Install MongoDb Nuget:
 - https://github.com/alexandre-spieser/AspNetCore.Identity.MongoDbCore (v6.0.0)



