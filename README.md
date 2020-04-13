# Local Businesses API

#### _4/03/2020_

#### _By Jonathan Carlos_

## **Description**

_This C# codebase will build an API that contains an object-oriented list of information on local businesses and shops._

## **Request Types**

| Request | Type | Output |
|----------|:-----:|--------|
| Query == Name | String | Surfboards R Us |
| Query == Description | String | We sell the gnarliest surfboards. |
| Query == Established. | String | 1978|
| Query == Owner. | String | Andy |

## **Minimum Viable Product (MVP)**

The MVP of this project is to successfully create an API with full CRUD (Create, Read, Update, and Delete) functionality.

Stretch goals include:

* Add feature that randomly returns a local business or shop.
* Add a custom endpoint that accepts parameters in order to search by specific business and shop names.

## **Setup/Installation**

*Installing .NET Core* 

1. Download the .NET Core SDK [Software Development Kit](https://dotnet.microsoft.com/download).
2. Open the .Net Core SDK file and install.
3. Confirm the installation was successful by runnning the `$ dotnet --version` command in your terminal (You should see something like this in the response: `2.2.105`).
4. Install the dotnet script REPL tool by running the `$ dotnet tool install -g dotnet-script` command in your terminal.
5. Restart your terminal to complete the installation.

*Installing MySQL | MacOS:*

1. Download the MySQL Community Server DMG File from [MySQL Community Server](https://dev.mysql.com/downloads/file/?id=484914)
2. You can exit the mysql program by entering `exit`.
3. Download the MySQL Workbench DMG File from [MySQL Workbench](https://dev.mysql.com/downloads/file/?id=484391). (Use the No thanks, just start my download link.)
4. Install MySQL Workbench to Applications folder.
5. Open MySQL Workbench and select the `Local instance 3306 server`. You will need to enter the password you set. (We used `epicodus`.) If it connects, you're all set.

*Installing MySQL | Windows 10:*

1. Download the MySQL Web Installer from [MySQL Downloads](https://dev.mysql.com/downloads/file/?id=484919) (Use the No thanks, just start my download link.).
2. Choose `Custom` setup type.
3. When prompted to `Select Products and Features`, make sure you select both `MySQL Server` (Under MySQL Servers), and `MySQL Workbench` (Under applications).
4. When you reach `Configuration`:
  * Set `High Availability` to `Standalone`. 
  * Defaults are OK under `Type and Networking`. 
  * Set `Authentication Method` to `Use Legacy Authenticationn Method`.
  * Lastly, set your password and complete the installation process.
5. You can exit the mysql program by entering `exit`
6. Add the MySQL environment variable to the System PATH. We must include MySQL in the System Environment Path Variable. This is its own multi-step process. Instructions here are for Windows 10:
  * Open the Control Panel and visit System > Advanced System Settings > Environment Variables...
  * Then select PATH..., click Edit..., then Add.
  * Add the exact location of your MySQL installation, and click OK. (This location is likely `C:\Program Files\MySQL\MySQL Server 8.0\bin`, but may differ depending on your specific installation.)
7. Open MySQL Workbench and select the `Local instance 3306` server (it may have a different name). You will need to enter the password you set (We used `epicodus`). If it connects, you're all set.

*Cloning this repository:*

1. Open your terminal.
2. Navigate to the desired directory in which you want to clone this repository.
3. Use the command `git clone https://github.com/jamestlalocPDX/PierresTreats.Solution` to clone this repository.
4. Open this repository from within your terminal and navigate to the project folder: `PierresTreats/`.
5. Run the command `dotnet restore`.
6. Run the command `dotnet build`.
7. If build is successful, run the command `dotnet ef migrations add Initial`. If build failed, make necessary updates and repeat steps 5-7.
8. Run the command `dotnet ef database update`.
9. Use `dotnet run` to generate a local server.
10. Copy and paste the generated `localhost:5000` onto your URL.

*Downloading this repository:*

1. On the top right of this page, click the "Clone or download" button.
2. Click on "Download ZIP."
3. Click the downloaded file to unzip and extract this repository to your desired directory.
4. Open this repository from within your terminal and navigate to the project folder: `PierresTreats/`.
5. Run the command `dotnet restore`.
6. Run the command `dotnet build`.
7. If build is successful, run the command `dotnet ef migrations add Initial`. If build failed, make necessary updates and repeat steps 5-7.
8. Run the command `dotnet ef database update`.
8. Use `dotnet run` to generate a local server.
10. Copy and paste the generated `localhost:5000` onto your URL.

## **Known Bugs**

There are no known bugs at this time.

## **Support and contact details**

If you have any questions, comments, or concerns, please feel free to contact the content creator at examplemail@company.net 

## **Technologies used**

* _Git 2.23.0_

* _C# language_

* _.NET Core 2.2.106_

* _dotnet script 0.50.1_

* _Visual Studio Code 1.43.1_

* _Model-View-Controller(MVC) framework_

* _MySQL 8.0.15_

* _MySQL Workbench 8.0.15_

* _Entity Framework Core 2.2.4_

* _Language-Integrated Query (LINQ)_

* _ASP.NET Razor_

* GitBash

* RestSharp version 106.6.10

* Newtonsoft.Json version 12.0.2

## **License**

Copyright (c) 2020 **_Local Businesses API_**

This software is licensed under the MIT license.