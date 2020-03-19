# _[Best Restaurants](https://github.com/KristaRutz/best-restaurants)_

#### _Brief desc of Project, 03.19.2020_

#### By _**Tiffany Siu and Krista Rutz**_

[![Project Status: Inactive – The project has reached a stable, usable state but is no longer being actively developed; support/maintenance will be provided as time allows.](https://www.repostatus.org/badges/latest/inactive.svg)](https://www.repostatus.org/#inactive)
![LastCommit](https://img.shields.io/github/last-commit/KristaRutz/best-restaurants)
![Languages](https://img.shields.io/github/languages/top/KristaRutz/best-restaurants)
[![MIT license](https://img.shields.io/badge/License-MIT-orange.svg)](https://lbesson.mit-license.org/)

---
## Table of Contents
1. [Description](#description)
    - [3/19 Work from Home Summary](#3/19-Work-from-Home-Summary)
    - [3/18 Work from Home Summary](#3/18-Work-from-Home-Summary)
2. [Setup/Installation Requirements](#setup/installation-requirements)
    - [Requirements to Run](#requirements-to-run)
    - [Instructions](#instructions)
    - [Other Technologies Used](#other-technologies-used)
3. [Notable Features](#notable-features)
4. [Specifications](#specifications)
5. [Screenshots](#screenshots)
7. [Known Bugs](#known-bugs)
8. [Support and Contact Details](#support-and-contact-details)
9. [License](#license)
---
## Description

Track your favorite restaurants of any cuisine you like to eat!

This application allows a user to keep track of inputted cuisines, restaurants, and reviews. Each of these 3 types of inputs are stored in a database, and can be edited or deleted. Reviews are associated with a specific restaurant, and restaurants are tied to one cuisine, but there is no limit to the amount of cuisines, reviews, or restaurants that a user can make.

This application makes use of a fully functioning front end website with forms and menus for the user to interact with.

#### 3/19 Work from Home Summary
- Best Restaurants
  - Implement styling with custom CSS and HTML partials
  - Develop Edit() and Delete() functionality for Reviews
  - Attach reviews to specific restaurants ONLY - no index.
  - MySQL database construction and manipulation
  - Entity Framework Viewbag and Helper functions - further exploration
  - Finished README for all sections
- Help other classmates with coding issues
- Technical Interview Practice Questions
  - In depth review of terminology and concepts
- Whiteboarding
- Struggles:
  - Requiring pure HTML instead of Helper functions to correctly bind values
  - Implementing timestamps as auto-generated values
  - Transferring data between controllers, which broke when we tried to link through a ```<button>``` rather than ```<p>``` tag.


#### 3/18 Work from Home Summary
- To Do List Edit and Delete with Entity
- Best Restaurants
- Struggles: 
  - Printing list of items on the category's detail page (the lists were initialized to empty, and never filled)
  - Routing with id numbers for views for reviews/object types passed between different controllers and views
  - adding review to restaurant and returning to restaurant details page
  - Networking error? Things not adding to database, then appeared all at once

## Setup/Installation Requirements

Download or clone the repository to run this program locally!

_This program requires .NET Core SDK to run. [Here is a free tutorial](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-c-and-net) for installing .NET on Mac or Windows 10._ 

_This program also makes use of SQL databases. We recommend using MySQL Workbench to build your databases. [Here is a free tutorial](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql) for installing MySQL WorkBench and MySQL Community Server on Mac or Windows 10._

### Requirements to Run
* _.NET Core_
* _ASP.NET Core MVC_
* _Entity Framework_
* _MySQL Workbench_
* _Command Prompt_
* _Web Browser_

### Instructions

*This application may be viewed by doing the following steps:*

- Download or clone this repo.
  - **To Download ZIP:**
    - Select "Download" on the [GitHub Repository](https://github.com/KristaRutz/best-restaurants) site
    - Once downloaded, open the ZIP and extract files. The new folder will be created as 'best-restaurants'.
  - **To Clone:**
    - Clone from command line into your Desktop: `$ git clone https://github.com/KristaRutz/best-restaurants.git`
    - The new directory will be created as 'Desktop/best-restaurants'.
- Construct your databases using `best-restaurants/best_restaurant_structure.sql` (or `best-restaurants/best_restaurant_structure_and_data.sql` for databases with prefilled cuisines, restaurants, and review data). You may simply import this file into your MySQL workbench or follow the command line instructions in `DatabaseConstruction.txt`.
- Once you have stored the files locally, execute the following commands.
  - Navigate to the application directory: `$ cd best-restaurants/BestRestaurant`
  - `dotnet build`
  - `dotnet run`
- Type the URL listed under "Now listening on:" into a web browser. Upon success, the program will begin running in your browser.

## Other Technologies Used
* _C#_
* _HTML_
* _CSS_
* _MSTest_
* _Razor_
* _Markdown_

## Notable Features
This project shows a nicely styled application using a database with objects within objects within objects (Reviews within Restaurants within Cuisines).  Routing between pages is intuitive and comprehensive for ease of movement between pages.

## Specifications

- Create a website where users can add their favorite restaurants based on the type of cuisine they offer.

- Add a Cuisine class. Build out all CRUD functionality (Create, Read, Update, Delete) for this class. Remember that "Read" means to view a particular cuisine and to list out all of the cuisines.

- Add a Restaurant class. Build out all CRUD functionality for this class.

- Add properties other than name to your Restaurant class so that you can display descriptive information about the restaurants.

- Make the connection between a cuisine and a restaurant in the database. A cuisine can have many restaurants, but a restaurant can only be attached to one cuisine.

- Allow a user to search for all of a cuisine's restaurants.

- Build out a Review class and make the relationship in the database so that a restaurant has many reviews. Pretend that the users who are reviewing the website are different from the user who added the restaurant.

- Display all of the reviews at the bottom of the restaurant's page.

## Screenshots

_Here is a snippet of what the cuisine list looks like:_

![Snippet of cuisine list](img/cuisine-list.png)

_Here is a preview of what restaurant detail page looks like:_

![Snippet of restaurant detail](img/thai-cottage-detail.png)

## Known Bugs

_There are currently no known bugs in this program_

## Support and contact details

_If there are any question or concerns please contact us at our emails: [Tiffany Siu](mailto:tsiu88@gmail.com) and [Krista Rutz](mailto:rutzkri000@gmail.com). Thank you._

### License

*This software is licensed under the MIT license*

Copyright (c) 2020 **_Tiffany Siu, Krista Rutz_**
