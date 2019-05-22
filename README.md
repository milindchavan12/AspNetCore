# ASP.Net Core
So what exactly is ASP. NET Core? It's a complete rewrite of the platform. It is meant to be **cross-platform** and open source. It has combined the platforms of MVC and WebAPI into a single code base. 

### WebHost with CreateDefaultBuilder

WebHost Builder is an object that knows how to setup our Web Server Envionment. Default Web Host builder sets our environment in specific way.
1. Will use Kestrel web server. [Cross-Platform Server]
2. IIS Integration
3. Detault Logging
4. IConfiguration Service made available.
   - JSON File (appsettings.json)
   - User Secrets
   - Environment variables
   - Command Line arguments

# Adding/Registering Custom Services in Startup 
In the ConfigureServices method, we can register all custom services that can be used in Dependancy Injection
1. services.AddSingelton() : Needs only one instance of a service for entire application.
2. services.AddTransient() : Create always new instance of custome service.
3. services.AddScoped() : Create scoped instance for each Http Request

# IHostingEnvironment
With IHostingEnvironment Service, injected to Configure Method can help to find the various pieces of information about the current envionment by IsDevelopement(), IsStaging() or IsProductionEnviornment() methods. These Environment can be set with "ASPNETCORE_ENVIRONMENT": "Development" inside launchSettings.json file.
