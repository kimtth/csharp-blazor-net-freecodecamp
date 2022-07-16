
# Blazor WebAssembly and Web API on .NET 6

The source files refer to `freecodecamp.com` Blazor WebAssembly course mentioned below.
Base on that, I just attached Migration code files that have not been included on original source code. You can find those in `ShopOnline.API > Migrations` directory.

- Screen

    ![screen](screen-shot.png "screenshot")

- Course Video

    https://youtu.be/sHuuo9L3e5c

- Course Source code

    https://github.com/GavinLonDigital/ShopOnlineSolution

- Course overview

    https://www.freecodecamp.org/news/learn-blazor-webassembly-and-web-api-on-net-6-by-building-a-shopping-cart-app/


# ShopOnlineSolution

ShopOnlineSolution is part of a Blazor Shopping Cart Application video tutorial demonstrated on YouTube at this location,
https://youtu.be/3_AsedRrqww?list=PL4LFuHwItvKbdK-ogNsOx2X58hHGeQm8c

# ShopOnline.API > appsetting.json - Database ConnectionString

You need to change the SQL server connection string as following your case.

In case of Azure SQL database, that is going to come from ADO.Net connection string. 

```
Server=tcp:{your_azure_db}.database.windows.net,1433;Initial Catalog={db_name}};Persist Security Info=False;User ID={your_id};Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;
```

# Migration command - C# Entity Framework

- For creating a migration code

```powershell
Add-Migration InitialCreate
```

This command will create a file name such as "20220702030443_InitialCreate.cs". But this will make duplicated Up and Down functions, it will make a collision between "20220702030443_InitialCreate.cs" and "InitialCreate.cs". so that, Before executing "Update-database" you should rename InitialCreate in "InitialCreate.cs" as to "InitialCreate2" or whatever.

- Actual database creation and data are going to be triggered by this command.

```powershell
Update-database
```

# Razor syntax

https://docs.microsoft.com/en-us/aspnet/core/mvc/views/razor?view=aspnetcore-6.0
