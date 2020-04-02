# _Hair Salon_

#### _An application that allows the user to view and edit different stylists details and clients._

#### By _**Patrick Delaney**_

## Description

_In this application, the user is able to navigate through different pages. Exploring a list of stylists, stylist details, and clients of said stylists. User has full ability to alter any of these fields._

## Specs

* Behavior: User is able to navigate from one webpage to another.
	* Input: *click link*
	* Output: *re-route to connected webpage*

	* Behavior: User is able to add or remove objects through the webpage.

## Setup/Installation Requirements

* (1)_Open your terminal, navigate to your desktop directory, and clone the HairSalon repository: `cd desktop` -> `git clone https://github.com/Prestwick97/HairSalon.git`._
* (2)_With the repository cloned, you're now ready to set up your database. Assuming you have all of the neccessary technology installed, continue with the following terminal commands:
	* `CREATE DATABASE patrick_delaney;`
	* `USE patrick_delaney;`
	* `CREATE TABLE stylists (stylistId serial PRIMARY KEY, name VARCHAR (255), clientId INT(11));`
	* `CREATE TABLE clients (clientId serial PRIMARY KEY, description VARCHAR(255), stylistId INT(11));`
Congratulations! You've created the databse.

* (3) _Navigate to the root directory of the project in your terminal (`cd HairSalon`) and input the following commands one after another:_
	* `dotnet build` 
	* `dotnet run`

* (4) _Either (cmd +) click on the link `localhost:5000`, or enter `localhost:5000` into your web broswer_

## Known Bugs

_No known bugs at this moment_

## Support and contact details

_If you have any questions, comments, concerns, or suggestions, feel free to email me at: Prestwick97@gmail.com._

## Technologies Used

* HTML
* CSS
* C#
* MVC
* MySQL
* Command Terminal

__

### License

*Licensed under the MIT opensource license.*

Copyright (c) 2020 **_Patrick Delaney_**
