## The Database

Something about the data base here.

#### Database Migrations

###### Add a Migration
`dotnet ef migrations add <name of the migration>`

###### Updating The Database
`dotnet ef database update`

###### Rolling Back A Migration (or to a Migration)
1. `dotnet ef database update <MigrationName>`

2. `dotnet ef migrations remove`