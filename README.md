# JobTracker

## Overview

**JobTracker** is a web application built using ASP.NET MVC and Entity Framework that allows users to efficiently manage their job applications. It lets you add, edit, view, and delete job entries, including company name, position, status, and application date. The app uses a PostgreSQL database hosted on Railway and follows the MVC design pattern.

---

## Features

- ✅ Add new job applications  
- 📝 Edit existing job entries  
- 📄 View full job details  
- ❌ Delete job records  
- 📅 Track application date and status  
- 🎨 Clean and responsive UI with Bootstrap  

---

## Technologies Used

- ASP.NET MVC (C#)  
- Entity Framework (Code First / Database First)  
- PostgreSQL (via Railway)  
- HTML, CSS, JavaScript  
- Bootstrap  

---
📸 Project Preview
🖼️ Create Page
<img width="1361" height="727" alt="Create" src="https://github.com/user-attachments/assets/9e7fa05a-5948-489e-9415-30d237838279" />

🖼️ Dashboard Page
<img width="1366" height="731" alt="Dashboard" src="https://github.com/user-attachments/assets/9b4b30d4-eb5c-4f03-8684-55042b6ff2ef" />

🖼️ Edit Page
<img width="1343" height="725" alt="Edit" src="https://github.com/user-attachments/assets/49605d8e-17fa-41f3-947b-0c148bd205ba" />

🖼️ Details Page
<img width="1366" height="694" alt="Details" src="https://github.com/user-attachments/assets/bb940875-4a5c-4188-96ab-55745817077f" />

🖼️ Delete Page
<img width="1364" height="727" alt="Delete" src="https://github.com/user-attachments/assets/5ac09b70-9ecb-4d63-9292-d13d6a5dfe4a" />


🧑‍💻 Getting Started
## How to Run the Project (Docker + Railway)

### Prerequisites

- Docker  
- .NET SDK 8.0  
- A PostgreSQL database (we're using [Railway](https://railway.app))  

---

### 1. Clone the Repository

git clone https://github.com/Nikitakolle/JobTracker.git
cd JobTracker
2. Set up PostgreSQL on Railway
Go to https://railway.app

Create a new PostgreSQL project

Copy the DATABASE_URL (e.g., postgresql://...)

Set it in your terminal:

export DATABASE_URL=your_actual_url_here

On Windows PowerShell:
$env:DATABASE_URL="your_actual_url_here"

3. Run with Docker

docker build -t jobtracker .
docker run -e DATABASE_URL=$DATABASE_URL -p 8080:80 jobtracker
Visit: http://localhost:8080

------------------

Author
Nikita Kolle
GitHub: @Nikitakolle

License
This project is for educational and portfolio purposes only.
