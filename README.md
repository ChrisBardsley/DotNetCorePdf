# DotNetCorePdf
Dotnetcore PDF html based generator. Uses the libwkhtmltox native libraries to genrate pdf data.
More information on the libwkhtmltox native libraries can be found [here](https://wkhtmltopdf.org "libwkhtmltox home page").<br/>

## Installation
*Currently compiled to dotnetcore version 1.1 so you will need to have dotnetcore 1.1 installed in your project or you can download the source and change the dotnetcore framework to your prefered framework.* <br/>

Installation is pretty straight forward. The typical installation is as follows:
1. Add the nuget package to your project `Install-Package DotNetCorePdf -Version 1.0.0`
2. Register the singleton service in Startup.cs (this method requires that the class be registered in the DI framework)
3. Add DotNetCorePdf to the constructor of the class you want to use it in. (this method requires that the class be registered in the DI framework)
4. Create a converter using DotNetCorePdf.CreateStandardPdfConverter() or DotNetCorePdf.CreateUriSourcePdfConverter()
5. Create your pdf!
## Usage
Refer to our github URL: [here](https://github.com/ChrisBardsley/DotNetCorePdf "DotNetCorePdf Github Repo")
## Contributing
1. Fork it!
2. Create your feature branch: `git checkout -b my-new-feature`
3. Commit your changes: `git commit -am 'Add some feature'`
4. Push to the branch: `git push origin my-new-feature`
5. Submit a pull request :D
## History
TODO: Write history
## Credits
1. https://wkhtmltopdf.org for there wonderful native library (that works!)
2. https://github.com/rdvojmoc/DinkToPdf for the inspiration!
## License
MIT