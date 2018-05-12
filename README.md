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


