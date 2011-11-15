About
=====

This Visual Studio template has the following features:

* Comes with all the normal DNN module "glue" - build scripts, manifest file, license, release notes and read me files
* Includes a DNN module "View" control and corresponding WebFormsMVP view interface, model & presenter
* Includes a DNN module "Edit" control, also in the WebFormsMVP style, that shows off the DNN 6 form pattern
* Contains samples of the new DNN form pattern on the edit and settings pages
* Implements new organizational JS/CSS strategy using the DNN 6.1 Client Resource Management API
* Includes a standard DNN module settings control, which also uses the new form patterns.
* Includes a test project, and a test fixture for each presenter.
* Comes with all dependencies (DNN, MbUnit, Moq, MSBuild Community Tasks)

Download
========
Head over to the downloads tab up above and download both of the project templates.

Set up
======
Checkout this 5 minute video to see how to set it up: http://screencast.com/t/MUDpyxrg9. 

These templates work just like normal VS templates, the only special stuff to note is that you should create the module project first and the test project second. Put the module project in the DesktopModules folder of your dev environment, and then put the tests project *inside* the module project folder. This'll give you a nice self contained dev environment. If that sounds confusing, check out the video, as that's exactly what it shows (and more).

Note
----
There are a few items that you may wish to edit in the vstemplate files. Here are the default values:

      <CustomParameter Name="$YourCompany$" Value="Awesome Cycles" />
      <CustomParameter Name="$Namespace$" Value="AwesomeCycles.Dnn.Modules." />
      <CustomParameter Name="$YourWebsite$" Value="http://www.dotnetnuke.com" />
      <CustomParameter Name="$YourEmail$" Value="awesome.cycles@dotnetnuke.com" />
      <CustomParameter Name="$CopyrightYear$" Value="2011" />

I'd recommend updating the vstemplate file with new values and placing it back in the zip before placing in the visual studio templates folder and using it.

Issues
======
If you have any issues. Please open one here using the issues tab above.