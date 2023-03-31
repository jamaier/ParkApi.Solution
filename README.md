# Travel API

#### By Jacob Maier

#### _An API that allows users to GET and POST reviews about various National Parks around the country(USA)._

## Technologies Used

* _C#/.NET_
* _SQL Workbench_
* _MVC_
* _Entity Framework_
* _Identity_
* _Swagger_

## Description

An API that allows users to GET, POST, EDIT and DELETE reviews about various National Parks around the country(USA).

_There are custom endpoints for some of these user stories._

* A user can GET details of the parks.

* A user can PUT and DELETE reviews, but only if their userName is attributed.

* A user can search parks just for fun.

* A user can access the API endpoint with a query parameter that specifies the page that should be returned.

## Setup/Installation Requirements
_Requires console application such as Git Bash, Terminal, or PowerShell_

1. Open Git Bash or PowerShell if on Windows and Terminal if on Mac
2. Run the command

    `git clone https://github.com/jamaier/ParkApi.Solution.git`

3. Run the command

    ``cd ParkApi``

* You should now have a folder `ParkApi` with the following structure.


4. Add a file named `appsettings.json` in the following location, inside ParkApi folder 

      
5. Copy and paste below JSON text in appsettings.json.

json:
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=parkapi;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}
```


6. Run the command

    `dotnet ef database update`


<strong>To Run</strong>

Navigate to the following directory in the console
    <pre>ParkApi
    └── <strong>ParkApi</strong></pre>

Run the following command in the console

  `dotnet build`

Then run the following command in the console

  `dotnet run`

This program was built using _`Microsoft .NET SDK 6.0`_, and may not be compatible with other versions. Cross-version performance is neither implied nor guaranteed, your actual mileage may vary.

## API Documentation
Explore the API endpoints in Postman or a browser. You will not be able to utilize authentication in a browser.

###  Swagger Documentation 
To view the Swagger documentation for the ParkApi, launch the project using `dotnet run` using Terminal or Powershell, then input the following URL into your browser: `https://localhost:5001/swagger/index.html`

### Park

Get information about different global Park.

#### HTTP Request Structure
```
GET https://localhost:5001/api/Parks/
GET https://localhost:5001/api/Parks/{id}
POST https://localhost:5001/api/Parks/
PUT https://localhost:5001/api/Parks/{id}
DELETE https://localhost:5001/api/Parks/{id}
GET https://localhost:5001/api/Parks/Search
```
* To utilize the POST request and create a new instance of a destination, the following information is required.
```
{
    "destinationId": "int",
    "Name": "string",
    "State": "string",
    "Description": "string",
}
```

#### Example Query
```
https://localhost:5001/api/Parks/1
```
#### Sample JSON Response
```
{
    "destinationId": 1,
    "Name": "Zion",
    "State": "Utah",
    "Description": "PlaceHolder Text",
}
```

## Known Bugs

* _Currently unsure if CORS has functionality_

* _Reach out with any questions or concerns to [jacobamaier@gmail.com](jacobamaier@gmail.com)_

## License

[MIT](/LICENSE)

_Copyright_ _2023_ _Jacob Maier_