﻿using BL.DTOs;
using BL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EvaluationController : Controller
    {
        private readonly IEvaluationService _evaluationService;

        public EvaluationController(IEvaluationService evaluationService)
        {
            _evaluationService = evaluationService;
        }

        [HttpPost("createEvaluation")]
        public async Task<IActionResult> CreateEvaluation([FromBody] EvaluationDTO createEvaluationDto)
        {
            return Ok(await _evaluationService.CreateEvaluationAsync(createEvaluationDto));
        }

        [HttpPost("getEvaluationsByFeedbackId")]
        public async Task<IActionResult> GetEvaluationsByFeedbackId([FromQuery] int feedbackId)
        {
            return Ok(await _evaluationService.GetEvaluationsByFeedbackIdAsync(feedbackId));
        }

        [HttpPut("updateEvaluation")]
        public async Task<ActionResult> UpdateEvaluation([FromBody] EvaluationDTO fullEvaluationDto)
        {
            return Ok(await _evaluationService.UpdateEvaluationAsync(fullEvaluationDto));
        }
    }
}
