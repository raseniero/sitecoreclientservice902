# A sample Sitecore Service Client (SSC) for Sitecore Experience Platform (XP) v9.0.2

This is a sample code to demonstrate how to create an EntityService in SSC.

>Note: This documentation is still a **work-in-progress**, do expect constant updates. For questions or need elaboration please send an email to *rasenieroAtGmailDotCom*.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on a live system.

### Prerequisites

What things you need to install the software and how to install them.

1. Working installation of Sitecore v9.0.2
2. Installed Visual Studio version 2017
3. Installed Fiddler (latest version)

### Installing and Running a tests

A step by step series of examples that tell you how to get a development env running

1. Clone this repository
2. Launch *Visual Studio* 
3. Open the solution file (**SSC-PoC2.sln**) from Visual Studio
4. Restore *Nuget package* for the solution
5. Build the solution
6. Locate the */bin/* folder of your solution then copy **SSC-PoC2.dll** to your Sitecore's instance */bin/* folder.
7. Launch *Fiddler*
8. From *Fiddler* compose a *GET* request with HTTP/1.1 to http://xp0.sc/sitecore/api/ssc/ssc-poc2-controller/newarticle - (**Note:** Replace *xp0.sc* with the domain of your site.)
9. From *Fiddler* inspect the results, if test was successful it should return a JSON object with *Title=News1 and Description=Description1*

## Built With

* [Sitecore](http://www.sitecore.com/) - Version 9.0.2
* [Fiddler](https://www.fiddler.org/) - Use to test the request (I used the MacOS version)
* [Visual Studio](https://www.visualstudio.com/) - Version 2017

## Contributing

Please read [CONTRIBUTING.md](https://gist.github.com/PurpleBooth/b24679402957c63ec426) for details on our code of conduct, and the process for submitting pull requests to us.

## Versioning

We use [SemVer](http://semver.org/) for versioning. For the versions available, see the [tags on this repository](https://github.com/your/project/tags). 

## Authors

[**raseniero**](https://raseniero.github.io/)

See also the list of [contributors](https://github.com/raseniero/sitecoreclientservice902/graphs/contributors) who participated in this project.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

## Acknowledgments

* Hat tip to anyone whose code was used
* Inspiration
* etc