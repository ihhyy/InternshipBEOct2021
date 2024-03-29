﻿using BL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class GoogleSheetController : ControllerBase
	{
		private readonly IGoogleSheetService _googleSheetService;

		public GoogleSheetController(IGoogleSheetService googleSheetService)
		{
			_googleSheetService = googleSheetService;
		}

		[HttpGet]
		public async Task<IActionResult> UpdateCandidatesAsync()
		{
			await _googleSheetService.SaveNewCandidatesAsync();

			return Ok();
		}
	}
}
