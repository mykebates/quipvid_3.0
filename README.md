# QuipVid 3.0

### Will formalize a real deal README once all directions are figured out.

#### But for now here are some quick notes...

There seems to be an annoying version issue with .NET Core 3.0.x and the current build of the dotnet-ef command line tool.
Perhaps when .NET Core 3.1(LTS) launches in December and all things are on that wavelength all will be well... 🤷‍♂️
Until then I specified the version and installed the dotnet-ef tool locally to the project with

`dotnet tool install dotnet-ef --version 3.0.0`

Otherwise the following steps should hopefully get you up and running

* Have .NET Core 3.0 + SDK installed
* PostgresSQL database installed and running
* Copy and rename appsettings.json.default to appsettings.json (or appsettings.Development.json) and configure the ConnectionStrings:PostgreSQL value
* in the QuipVid.WWW dir run the following commands
    * Run data migration with `dotnet ef database update` 
    * Run `dotnet run`
* Open site and register a user
* Manually add Quip entries int he database to see them represented on the home page