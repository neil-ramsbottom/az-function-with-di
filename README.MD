
# Azure Function with Dependency Injection

The basic templates provided by Microsoft do not have dependency injection enabled by default. To enable it you should do the following:

* Reference the `Microsoft.Azure.Functions.Extensions` nuget package.
* Create a Startup class that derives from the `Microsoft.Extensions.DependencyInjection.FunctionsStartup` type.
* Create an assembly attribute that references your startup class: `[assembly: Microsoft.Azure.Functions.Extensions.DependencyInjection.FunctionsStartup(typeof(Startup))]`

Review the code in this repository for an example. You may need to create a `local.settings.json` file to run the project locally, which should contain the following:
```
{
    "IsEncrypted": false,
    "Values": {
        "AzureWebJobsStorage": "UseDevelopmentStorage=true",
        "FUNCTIONS_WORKER_RUNTIME": "dotnet"
    }
}
```

## Disclaimer

Note that this repository is intended as a personal reference and should not be considered in any way accurate.
