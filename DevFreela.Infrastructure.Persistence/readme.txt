Para utilizar o Migations:
	Para criar scripts com o migrations: 
		* dotnet ef migrations script 0 FirstMigration -s ../DevFreela.API -o ../Scripts/FirstMigration.sql

	Para criar o primeiro migrations: 
		* dotnet ef migrations add FirstMigration -s ../DevFreela.API

	Para dar um update e criar a base de dados: 
		* dotnet ef database update -s ../DevFreela.API