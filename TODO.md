`# Migration to SQLite Database

## Steps to Complete
- [x] Add Microsoft.Data.Sqlite package to project
- [x] Modify DataStorage.cs to use SQLite instead of JSON
  - [x] Remove JSON file handling code
  - [x] Add SQLite connection and table creation
  - [x] Update AddIssue method to insert into SQLite
  - [x] Update GetIssues method to query from SQLite
- [ ] Test the application to ensure issues can be added and viewed
- [ ] Restore NuGet packages if needed

## Notes
- Database file will be created in the same location as the old JSON file for consistency.
- Issue class remains unchanged.
- Ensure backward compatibility if possible, but since migrating, old JSON data may need manual migration.
