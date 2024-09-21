# coink-api

## Database

The DB of the API was made having in count the following ER diagram:

![image](https://github.com/user-attachments/assets/c2b9653a-8293-4f46-a6e8-e2434a20b13e)

## App Folders

- Controllers
- DTOs
- Mappers
- Migrations
- Models
- scripts

## How to run the project?

To run the project you will need to have installed the .NET 8.0 SDK and a SQL database (preferably postgreSQL, which is where it was developed).

You will need to run the SQL script on the **_scripts_** folder, if you are using postgreSQL you can use the following command:

```
psql your_db_name < coink-db.sql
```

This will create the DB with the necessary tables and initial data for the API to work correctly.

After setup the DB you can run the following command in the root of the project to start the server:

```
dotnet run --launch-profile https
```

After run the server you can access the endpoint to create users through swagger in the following direction:

```
https://localhost:{portWhereTheServerIsRunning}/swagger
```

You should see something like this where you can test the endpoint to create users:
![image](https://github.com/user-attachments/assets/122bc876-d64d-4466-b97a-e52f94994afe)
