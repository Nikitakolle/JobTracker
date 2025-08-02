#  JobTracker

##  Overview

**JobTracker** is a web application built using ASP.NET MVC and Entity Framework that allows users to efficiently manage their job applications. It lets you add, edit, view, and delete job entries, including company name, position, status, and application date. The app uses a SQL Server database and follows the MVC design pattern.



## Features

- ✅ Add new job applications  
- 📝 Edit existing job entries  
- 📄 View full job details  
- ❌ Delete job records  
- 📅 Track application date and status  
- 🎨 Clean and responsive UI with Bootstrap  



##  Technologies Used

- ASP.NET MVC (C#)  
- Entity Framework (Code First / Database First)  
- SQL Server  
- HTML, CSS, JavaScript  
- Bootstrap  



##  How to Run the Project Locally

###  Prerequisites

- Visual Studio (Community or higher)  
- SQL Server (LocalDB or Express)  
- .NET Framework (e.g., 4.7.2 or 4.8)  

###  Steps to Run

1. **Clone the repository**  
   bash
   git clone https://github.com/Nikitakolle/JobTracker.git

2. Open the project in Visual Studio

Go to File → Open → Project/Solution

Select the .sln file from the cloned folder



3. Set up the database

Update your connection string in the Web.config file to match your local SQL Server setup

Open Tools > NuGet Package Manager > Package Manager Console in Visual Studio

Run the command:

Update-Database


4. Run the application

Press F5 or click the green Start button in Visual Studio

Your default browser will open the app's homepage.

-------------
Author

Nikita Kolle
GitHub: @Nikitakolle



License

This project is for educational and portfolio purposes only.
