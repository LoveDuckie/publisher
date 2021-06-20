![Publisher Logo](https://github.com/LoveDuckie/publisher/blob/main/logos/png/publisher.png?raw=true)

A command-line tool for posting your blogs to multiple platforms.

## Technologies

* C# and .NET 5.0
* EntityFrameworkCore
* SQLite
* JSON
* Markdown
* SilverStripe

## Goals
* **GUI**
   * Enable for the same underlying framework to be used by a GUI instead of a CLI.  
* **Extensible**
   * Enable for this project to be extensible by third-party plugins
* **Portable**
   * Enable for this project to work on as many platforms that .NET supports 

## Targets
Below are a list of platforms that I intend on developing "publishers" for.

* **Medium**
    * [Website](http://medium.com/)
* **Hashnode**
    * [Website](https://hashnode.com/)
* **Dev.to**
    * Website 
* **Hackernoon**
    * Website

I will support as many platforms as possible providing there is a public-facing API available for them.

## Special Thanks

TBD

## SilverStripe?

I use SilverStripe as the CMS of choice for my personal website. Unfortunately it doesn't support Markdown out of the box, and therefore requires a bit of scaffolding code. This is why I have additionally created a "target publisher", along with supporting PHP code to enable for this. Use at your own risk!
