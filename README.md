# NotionDatabaseStatusViewer
Notion Database Status Viewer using a Blazor Server App
## Features
* Authentication
* Notion API access
## Assumptions
* You have a GitHub account
* You have an Azure account
* You have a Notion account
## Steps
1.	Create a Visual Studio 2022 Blazor Server App project
    1.	NotionDatabaseStatusViewer
    2.	.NET 7.0
    3.	Authentication: Individual Accounts
    4.	Configure for HTTPS
2.	Create a Visual Studio 2022 Blazor Server App project
    1.	NotionDatabaseStatusViewer
    2.	.NET 7.0
    3.	Authentication: Individual Accounts
    4.	Configure for HTTPS
3.	Remove items from project
    1.	SurveyPrompt
        1.	Delete SurveyPrompt.razor
        2.	Remove SurveyPrompt from Index.razor
    2.	Counter
        1.	Delete Counter.razor
    3.	FetchData
        1.	Delete FetchData.razor
        2.	In the Data folder
            1.	Delete WeatherForecast.cs
            2.	Delete WeatherForecastService.cs
        3.	In Program.cs
        4.	Remove builder.Services.AddSingleton<WeatherForecastService>();
        5.	In MainLayout.razor, remove the About link.
    4.	NavMenu
        1.	Delete NavMenu.razor
        2.	In MainLayout.razor, remove the div that contains <NavMenu />
4.	Setup the Entity Framework database that is used for registering and logging in users
    1.	Add a scaffolded item to the project
    2.	Click Identity tab, click Identity section, click Add
    3.	Select Account\Login, Account\Logout, and Account\Register
    4.	Choose the default DbContext
    5.	You can choose to overwrite the existing Logout
5.	Publish to Azure
    1.	Create a publish profile for Azure by right-clicking on the project and clicking on ‘Publish’
    2.	Click ‘Azure’ and ‘Next’
    3.	Click ‘Azure App Service (Windows)’ and ‘Next’
    4.	Select your subscription
    5.	Click ‘+’ to create a new App Service (this is the application)
        1.	Fill in the name.  This must be unique.
        2.	Create a resource group.  This is a grouping of the items that will be created for all of the Azure resources we will create for this application.  Take note of the location to be close to the users.
    6.	Select a Hosting Plan by clicking ‘New’ next to it.  This is the physical server where the application will reside.
        1.	Fill in the name.  This must be unique.
        2.	Choose the location to be close to the users.
        3.	Choose ‘Free’ for a simple application.
        4.	Click OK.
        5.	Click ‘Create’
        6.	Click ‘Finish’
        7.	Click ‘Close’
    7.	Set up the SQL Server Database
        1.	Click the three dots (…) to the right of ‘SQL Server Database’
        2.	Click ‘Connect’
        3.	Click ‘Azure SQL Database’ and ‘Next’
        4.	Click ‘+’ to create a new database.
        5.	Fill in name
        6.	Click ‘New’ next to ‘Database Server’ to create the database server.  This is the physical server were the database resides.
        7.	Choose a database server name.  This must be unique.
        8.	Choose the location to be close to the users.
        9.	Fill in the administrator username and password.
        10.	Click ‘OK’.
        11.	Click ‘Create’.
        12.	Click ‘Next’ to select the newly created database.
    8.	Connect to the Azure SQL Database
        1.	Enter the admin username and password.
        2.	Copy the connection string value
        3.	Select Save connection string value in ‘Azure Key Vault’.  Click ‘Next’.
    9.	Create a new Azure Key Vault
        1.	Click ‘Create New’
        2.	Choose the location to be close to the users.
        3.	Choose ‘Standard’ SKU.
        4.	Click ‘Create’.
        5.	Click ‘Next’ to choose the newly created Key Vault.
    10.	Connect to Azure Key Vault
        1.	Click ‘Next’.
        2.	Click ‘Finish’.
            1.	If it fails
                1.	Click ‘Cancel’
                2.	Manually install NuGet package ‘Azure Identity’.
                3.	Repeat the section ‘Set up the SQL Server Database’ above.
        3.	Click ‘Close’.
    11.	Update the database in Azure
        1.	Change the connection string in secrets.json to the connection string for the database in Azure.
        2.	Go to the Package Manager Console
        3.	Enter ‘Add-Migration InitialCreate’.
        4.	Enter ‘Update-Database’.
            l.	Click ‘Publish’ (near the top of the Publish screen).

