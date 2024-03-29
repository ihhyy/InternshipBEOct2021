﻿using Microsoft.Extensions.Configuration;
using Shared.Config.Interfaces;

namespace Shared.Config
{
	public class GoogleConfig : IGoogleConfig
	{
		private readonly IConfiguration _configuration;

		private const string rangeSettings = "!A1:ZZ";
		private const string clientSecrets = "client_secrets.json";

		public GoogleConfig(IConfiguration configuration)
		{
			_configuration = configuration;
		}

		public string ApplicationName => _configuration["SheetsConfig:ApplicationName"];

		public string SpreadsheetId => _configuration["SheetsConfig:SpreadsheetId"];

		public string Sheet => _configuration["SheetsConfig:Sheet"];

		public string RangeSettings => rangeSettings;

		public string ClientSecrets => clientSecrets;

		public string CultureFormat => _configuration["CultureFormat"];
	}
}
