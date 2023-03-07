using System;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlecyAPI.Persistence
{
	static class Configuration
	{
		static public string ConnectionString
		{
			get
			{
				ConfigurationManager configurationManager = new();
				configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/BlecyAPI.API"));
				configurationManager.AddJsonFile("appsettings.json");
				return configurationManager.GetConnectionString("MsSQL");
			}
		}
	}
}

