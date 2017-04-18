## Introduction

This solution is the extracted framework for the [bb-prototype-website-razor](https://github.com/buildingblocks/bb-prototype-website-razor) project.

This allows the HTML project to be simpler to update and cleaner to work in.

This project contains all the cs code form the MVC project:
* Controllers
* Extensions
* Helpers
* Models
* ViewComponents

This is all generic content that can be reused accross all HTML demo sites.

Having this as a nuget allows easier upgrading of the framework in the future to add in additonial features.

Nuget link :

https://www.nuget.org/packages/BB.Prototype.Website.Razor.Framework/

## Page Content

Pages are defined in the Pages Views folder. This is mapped to URLs through a convention.

/pages/contentcards will be mapped to the view /Views/Pages/ContentCards.cshtml

## API Content

To return JSON from the application json files can be placed in the api folder.

These can then be accessed through a convention mapping the folder structure to the json files.

/api/content will rerurn the /api/content.json

/api/users/user will return a json fole placed at /api/users/user.json


