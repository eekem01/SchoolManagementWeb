# School Management System

A comprehensive .NET web application for managing school operations, featuring an assessment summary portal that displays examination results in a user-friendly table format.

## Introduction

This School Management System is built using ASP.NET Core MVC and provides a portal for viewing assessment summaries of recently concluded examinations. The application displays student performance data including marks, percentages, and grades in an organized, easy-to-read table format.

## Features

- **Assessment Summary Portal**: View comprehensive assessment results for recently concluded examinations
- **Modern UI**: Clean, responsive design with Bootstrap 5
- **Student Performance Tracking**: Track student marks, percentages, and grades across multiple subjects
- **Examination Management**: View details of recent examinations including dates and academic year

## Getting Started

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later
- A code editor (Visual Studio, Visual Studio Code, or Rider)

### Installation Process

1. Clone or download this repository
2. Navigate to the project directory:
   ```bash
   cd SchoolManagementWeb
   ```

3. Restore the NuGet packages:
   ```bash
   dotnet restore
   ```

4. Build the project:
   ```bash
   dotnet build
   ```

5. Run the application:
   ```bash
   dotnet run
   ```

6. Open your browser and navigate to:
   ```
   https://localhost:5001
   ```
   or
   ```
   http://localhost:5000
   ```

### Software Dependencies

- .NET 8.0 Runtime
- ASP.NET Core MVC
- Bootstrap 5.3.0 (via CDN)
- Bootstrap Icons 1.11.0 (via CDN)

## Project Structure

```
SchoolManagementWeb/
├── Controllers/
│   └── HomeController.cs          # Main controller handling assessment summary
├── Models/
│   ├── AssessmentSummary.cs       # Model for individual assessment records
│   ├── AssessmentSummaryViewModel.cs  # View model for the assessment portal
│   └── Examination.cs             # Model for examination information
├── Services/
│   ├── IAssessmentService.cs      # Interface for assessment service
│   └── AssessmentService.cs       # Service providing sample assessment data
├── Views/
│   ├── Home/
│   │   ├── Index.cshtml           # Main assessment summary portal page
│   │   └── Privacy.cshtml         # Privacy policy page
│   └── Shared/
│       └── _Layout.cshtml         # Main layout template
├── wwwroot/
│   └── css/
│       └── site.css               # Custom styling
├── Program.cs                     # Application entry point
├── appsettings.json              # Application configuration
└── SchoolManagementWeb.csproj    # Project file
```

## Build and Test

### Build the Application

```bash
dotnet build
```

### Run the Application

```bash
dotnet run
```

### Run in Development Mode

The application will automatically reload when you make changes if you run:

```bash
dotnet watch run
```

## Usage

1. Launch the application using `dotnet run`
2. Navigate to the home page to view the Assessment Summary Portal
3. The portal displays:
   - Information about the most recent concluded examination
   - A comprehensive table showing all student assessment results
   - Student ID, Name, Subject, Marks, Percentage, and Grade for each assessment

## Sample Data

The application includes sample assessment data for demonstration purposes. In a production environment, you would connect this to a database to retrieve real assessment records.

## Contribute

Contributions are welcome! Please feel free to submit a Pull Request. For major changes, please open an issue first to discuss what you would like to change.

## License

This project is open source and available for educational purposes.
