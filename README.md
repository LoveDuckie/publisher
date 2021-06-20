![Publisher Logo](https://github.com/LoveDuckie/publisher/blob/main/logos/png/publisher.png?raw=true)

A command-line tool for posting your blogs to multiple platforms.

# Getting Started

```publisher --action init-project```

```publisher --action new-blog --title "This is a new blog!"```

```publisher --action publish-blogs```

```publisher --action publish-blog --blog test-blog-id```

## Technologies

* **C# and .NET 5.0**
* **EntityFrameworkCore**
* **SQLite**
* **JSON**
* **Markdown**
* **SilverStripe**

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
    * [Website](https://dev.to/) 
* **Hackernoon**
    * **Note:** No API currently exists for HackerNoon. Support will be added once there is.
    * [Website](https://hackernoon.com/)

I will support as many platforms as possible providing there is a public-facing API available for them.

## Special Thanks

TBD

## SilverStripe?

I use SilverStripe CMS for my website. Unfortunately there's no out-of-the-box features for remotely submitting blog entries with the `silverstripe/blog` module, so I created a simple build task that exposes this kind of functionality. I cannot guarantee that it implements best security practices, so tread carefully when using the addon (should you choose to).
