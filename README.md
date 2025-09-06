# MunicipalityApp

A comprehensive Windows Forms application developed over 4 years for efficient municipal issue reporting and management. Built with .NET and SQLite, it provides a user-friendly interface for citizens to report local issues and track their resolution.

## Table of Contents
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Usage](#usage)
- [Architecture](#architecture)
- [Database Schema](#database-schema)
- [Contributing](#contributing)
- [License](#license)
- [Changelog](#changelog)
- [Support](#support)

## Features

### Core Functionality
- **Issue Reporting**: Submit detailed reports with location, category, description, and file attachments
- **Category Support**: Predefined categories including Water, Electricity, Roads, and Sanitation
- **Unique Report Numbers**: Automatic generation of unique identifiers for tracking
- **File Attachments**: Support for image and video attachments to issues
- **Data Persistence**: Robust SQLite database storage with automatic initialization

### User Interface
- **Intuitive Forms**: Clean, Windows-native interface using Windows Forms
- **Input Validation**: Comprehensive validation with user-friendly error messages
- **Status Updates**: Real-time feedback on submission status
- **Form Reset**: Automatic form clearing after successful submissions

### Data Management
- **SQLite Integration**: Local database storage for offline functionality
- **Data Integrity**: Unique constraints and proper indexing
- **Backup Ready**: Database stored in user AppData for easy backup

## Screenshots

### Main Application Window
![Municipality App Main Window](assests/muncipality%20app.png)

*The main interface showing the issue reporting form with category selection and input fields.*

## Technologies Used
- **Framework**: .NET 8.0 Windows Forms
- **Database**: SQLite with Microsoft.Data.Sqlite
- **Language**: C# 12.0
- **UI Framework**: Windows Forms with modern styling
- **Build Tool**: MSBuild / dotnet CLI

## Prerequisites
- Windows 10 or later
- .NET 8.0 Runtime or SDK
- 100 MB free disk space

## Installation

### From Source
1. **Clone the repository**
   ```bash
   git clone https://github.com/yourusername/MunicipalityApp.git
   cd MunicipalityApp
   ```

2. **Restore dependencies**
   ```bash
   dotnet restore
   ```

3. **Build the application**
   ```bash
   dotnet build --configuration Release
   ```

4. **Run the application**
   ```bash
   dotnet run
   ```

### Alternative: Download Release
Download the latest release from the [Releases](https://github.com/yourusername/MunicipalityApp/releases) page and run the installer.

## Usage

### Reporting an Issue
1. Launch the MunicipalityApp
2. Click "Report Issue" from the main menu
3. Fill in the required fields:
   - **Location**: Address or area description
   - **Category**: Select from Water, Electricity, Roads, Sanitation
   - **Description**: Detailed description of the issue
   - **Attachment**: Optional file attachment (images/videos)
4. Click "Submit" to save the report
5. Note the unique Report Number for future reference

### Viewing Issues
- Access the View Issues feature (under development)
- Filter and search through submitted reports
- Track resolution status

## Architecture

### Project Structure
```
MunicipalityApp/
├── DataStorage.cs          # Database operations and SQLite management
├── MainForm.cs             # Main application window
├── ReportIssueForm.cs      # Issue reporting interface
├── ViewIssuesForm.cs       # Issue viewing interface
├── Program.cs              # Application entry point
├── MunicipalityApp.csproj  # Project configuration
└── assets/                 # Static assets (images, icons)
```

### Database Design
- **Local Storage**: SQLite database in user AppData
- **Automatic Initialization**: Database created on first run
- **Schema Evolution**: Support for future database updates
- **Connection Management**: Proper connection handling and disposal

## Database Schema

The application uses a single SQLite table:

```sql
CREATE TABLE Issues (
    Id TEXT PRIMARY KEY,
    Location TEXT NOT NULL,
    Category TEXT NOT NULL,
    Description TEXT NOT NULL,
    FilePath TEXT,
    SubmittedAt TEXT NOT NULL,
    ReportNumber TEXT NOT NULL UNIQUE
);
```

### Field Descriptions
- **Id**: GUID primary key
- **Location**: Issue location description
- **Category**: Issue category (Water/Electricity/Roads/Sanitation)
- **Description**: Detailed issue description
- **FilePath**: Path to attached file (optional)
- **SubmittedAt**: ISO 8601 timestamp
- **ReportNumber**: Unique human-readable identifier

## Contributing

We welcome contributions! Please follow these steps:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

### Development Guidelines
- Follow C# coding standards
- Add unit tests for new features
- Update documentation for API changes
- Ensure compatibility with .NET 8.0

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Changelog

### Version 1.0.0 (Current)
- Initial release with core issue reporting functionality
- SQLite database integration
- File attachment support
- Input validation and error handling

### Version 0.9.0 (Beta)
- Basic Windows Forms interface
- Issue submission without database
- Form validation

### Version 0.5.0 (Alpha)
- Initial prototype
- Basic UI mockups
- Proof of concept

## Support

For support and questions:
- Create an issue on GitHub
- Check the [Wiki](https://github.com/yourusername/MunicipalityApp/wiki) for documentation
- Email: support@municipalityapp.com

---


