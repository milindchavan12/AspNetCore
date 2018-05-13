# WebHost with CreateDefaultBuilder

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

