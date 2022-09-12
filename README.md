# National and OR State Parks Lookup

#### By _**Louie Knolle**_

#### _A searchable and RESTful C#/.NET web API that returns data about National and Oregon State Parks._

## Technologies Used

- _C#_
- _.NET 5_
- _ASP.NET Core MVC_
- _MySQL_
- _Entity Framework Core_
- _MS Identity Authentication_
- _ASP.NET Core Swashbuckle_
- _Newtonsoft.json_

## Description

A web API that stores national and OR state park information such as name, location and type of park.  Users can search park by name, location and park type specifically as well as check to see if any park names match an impartial name. Swagger views can be used to test/visualize routes and pagination can be specified to minimize the amount of data being returned.  The default is 10 items, but can be changed. There is a route that also returns one random park from the database. 


## Setup/Installation Requirements
* _Open the terminal on your computer_
* _If they do not currently exist in your system, install [C#](https://docs.microsoft.com/en-us/dotnet/csharp/) and [.NET](https://docs.microsoft.com/en-us/dotnet/). You can follow the instructions found in this [lesson](https://www.learnhowtoprogram.com/c-and-net-part-time-c-and-react-track/getting-started-with-c/installing-and-configuring-mysql)_
* _Install Entity Framework Core to your system with this command in your terminal `dotnet tool install --global dotnet-ef --version 5.0.1`_
* _Clone this repository onto your computer by running this command in your terminal `git clone https://github.com/louieknolle/ParksAPI.Solution.git`_
* _In your terminal, navigate to the root directory with the command `$ cd ParksAPI.Solution`_
* _In your terminal, issue command `$ cd ParksAPI` to enter the project folder and create a file within to store your connection string for connecting the project to the database with the command `touch appsettings.json`_
* _In your text editor add the following code to the newly created appsettings.json file. *Note that uid and pwd may vary depending on your local MySql configurations. Database name can be whatever you choose, I used 'parks_api' for this project._

```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE-NAME-HERE];uid=root;pwd=[YOUR-PASSWORD-HERE];"
  }
}
```
* _Issue command `$dotnet build` in the project folder to launch the developer environment and install required dependencies_
* _And then use the command `dotnet ef database update` to apply the all previous migrations and create the database on mySQL_

* _Next run the program with `$dotnet run` and a server will be launched in your default browser_
* _Open the project by navigating your browser to http://localhost:5000/api/Parks or http://localhost:5001/api/Parks_
* _The following routes can be used and tested in Postman or using Swagger at _


## Known Bugs

_none_

## License

_MIT_

**Copyright (c) _August 2022_ _Louie Knolle_**
**Please contact me for any contribution or questions: [email](mailto:knollelw@gmail.com)**