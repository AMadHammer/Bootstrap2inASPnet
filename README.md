Bootstrap2inASPnet
==================

Code and content used in my bootstrap presentation. Below is a copy of my blog. See the full version at http://amadhammer.blogspot.com/


Bootstrap is a powerful front end framework that contain a collection of tools used to create great  sites and solve common  front end problems.
I stumbled upon bootstrap while looking for a way to improve the look of my web pages. I come from a native  development background and the front end of my application -while important- has not been my focus. I wanted to create cool looking, and yet, not time consuming UI for my applications. Twitter Bootstrap saved my day.

I tried to change the front end of my ASP.NET MVC web apps and Here is a quick way to use bootstrap in your ASP.NET application:

 1-Create a new blank ASP.NET MVC 4 project. 


2- Let Nuget handle it for you (OR you can manually add the bootstrap files to the correct directory. Not recommended). You should find the package installer under Tools (don't mix between it and the VS command line). The command is  :

Install-Package Twitter.Bootstrap.
Your Bootstrap files will be located in your content file



3-Add the libraries to your BundleConfig.cs file. This is not required but it is a good practice.  





4- Include your CSS and JS bundles in the _layout header. I ran the site before and after including the bootstrap file.



5- Change the contents of the file to fit your style. I used an example from bootstrap website to start. I added padding to the top of the body to allow for room for the navbar.


Code  is available (folder: Working Example) at  https://github.com/AMadHammer/Bootstrap2inASPnet
