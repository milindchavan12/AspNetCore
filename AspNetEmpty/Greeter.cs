using System;
using Microsoft.Extensions.Configuration;

namespace AspNetEmpty
{
	public class Greeter : IGreeting
	{
		private IConfiguration _configuration;

		public Greeter(IConfiguration configuration)
		{
			_configuration = configuration;
		}

		public string GetMessageOfTheDay()
		{
			return _configuration["Greeting"];
		}
	}
}
