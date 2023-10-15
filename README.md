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

