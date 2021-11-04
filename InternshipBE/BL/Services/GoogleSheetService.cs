﻿using AutoMapper;
using BL.DTOs;
using BL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Shared.Config.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BL.Services
{
	public class GoogleSheetService : IGoogleSheetService
	{
		private readonly string Scope = SheetsService.Scope.Spreadsheets;
		private readonly IGoogleConfig _googleConfig;
		private readonly ICandidateRepository _candidateRepository;
		private IMapper _mapper;
		private SheetsService _sheetService;

		private const int COLUMN_NAMES_ROW = 1;

		public GoogleSheetService(IGoogleConfig googleConfig, IMapper mapper, ICandidateRepository candidateRepository)
		{
			_candidateRepository = candidateRepository;
			_mapper = mapper;
			_googleConfig = googleConfig;
		}

		public async Task SaveNewCandidatesAsync()
		{
			var values = await GetNewCandidatesAsync();

			if (values != null)
			{
				var models = _mapper.Map<List<CandidateDTO>>(values);
				var candidates = _mapper.Map<List<Candidate>>(models);

				await _candidateRepository.RangeSaveAsync(candidates);
			}
		}

		private async Task<IList<IList<object>>> GetNewCandidatesAsync()
		{
			var values = GetValuesFromTable().Skip(COLUMN_NAMES_ROW);
			var candidatesAmount = await _candidateRepository.GetCandidatesCountAsync();

			if (values.Count() > candidatesAmount)
			{
				var newCandidates = values.Skip(candidatesAmount).ToList();
				return newCandidates;
			}
			return null;
		}

		private IList<IList<object>> GetValuesFromTable()
		{
			var credential = GoogleCredential.FromFile(_googleConfig.ClientSecrets).CreateScoped(Scope);

			_sheetService = new SheetsService(new BaseClientService.Initializer()
			{
				HttpClientInitializer = credential,
				ApplicationName = _googleConfig.ApplicationName
			});

			var range = $"{_googleConfig.Sheet}{_googleConfig.RangeSettings}";
			var request = _sheetService.Spreadsheets.Values.Get(_googleConfig.SpreadsheetId, range);

			var response = request.Execute();

			return response.Values;
		}
	}
}


