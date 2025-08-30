using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Linq;

namespace MunicipalityApp
{
    public static class IssueDataStorage
    {
        private static readonly string _filePath;
        private static Dictionary<Guid, Issue> _issues;
        private static readonly Random _random = new Random();

        static IssueDataStorage()
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string appFolder = Path.Combine(appDataPath, "MunicipalityApp");
            Directory.CreateDirectory(appFolder); // Ensure the directory exists
            _filePath = Path.Combine(appFolder, "issues.json");

            LoadIssues();
        }

        private static void LoadIssues()
        {
            if (File.Exists(_filePath))
            {
                string json = File.ReadAllText(_filePath);
                // If the file is empty or just whitespace, start with a new list.
                if (string.IsNullOrWhiteSpace(json))
                {
                    _issues = new Dictionary<Guid, Issue>();
                    return;
                }

                try
                {
                    _issues = JsonSerializer.Deserialize<Dictionary<Guid, Issue>>(json) ?? new Dictionary<Guid, Issue>();
                }
                catch (JsonException)
                {
                    // The file is corrupted or not valid JSON. Start with a fresh list.
                    // In a real-world app, you might backup the corrupted file and notify the user.
                    _issues = new Dictionary<Guid, Issue>();
                }
            }
            else
            {
                _issues = new Dictionary<Guid, Issue>();
            }
        }

        private static void SaveIssues()
        {
            string json = JsonSerializer.Serialize(_issues, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }

        private static string GenerateUniqueReportNumber()
        {
            string reportNumber;
            do
            {
                int number = _random.Next(100000, 999999);
                reportNumber = $"MUN-{number}";
            } while (_issues.Values.Any(issue => issue.ReportNumber == reportNumber));
            return reportNumber;
        }

        public static string AddIssue(string location, string category, string description, string filePath)
        {
            Guid id = Guid.NewGuid();
            var newIssue = new Issue(location, category, description, filePath);
            newIssue.ReportNumber = GenerateUniqueReportNumber();
            _issues[id] = newIssue;
            SaveIssues();
            return newIssue.ReportNumber;
        }

        public static IEnumerable<Issue> GetIssues()
        {
            return _issues.Values;
        }
    }

    public class Issue
    {
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string FilePath { get; set; }
        public DateTime SubmittedAt { get; set; }
        public string ReportNumber { get; set; }

        /// <summary>
        /// Parameterless constructor required for JSON deserialization.
        /// </summary>
        public Issue()
        {
            // Initialize properties to prevent null warnings
            Location = string.Empty;
            Category = string.Empty;
            Description = string.Empty;
            FilePath = string.Empty;
            ReportNumber = string.Empty;
        }
        
        public Issue(string location, string category, string description, string filePath)
        {
            Location = location;
            Category = category;
            Description = description;
            FilePath = filePath;
            SubmittedAt = DateTime.UtcNow;
        }
    }
}
