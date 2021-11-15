﻿using Microsoft.AspNetCore.Mvc;
using Shared.Enums;
using System;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnumController : ControllerBase
    {
        [HttpGet("getLaguageTypes")]
        public IActionResult GetLanguageTypes()
        {                       
            return Ok(Enum.GetNames(typeof(LanguageType)));
        }

        [HttpGet("getStackTypes")]
        public IActionResult GetStackTypes()
        {
            return Ok(Enum.GetNames(typeof(StackType)));
        }

        [HttpGet("getCandidateStatusTypes")]
        public IActionResult GetCandidateStatusTypes()
        {
            return Ok(Enum.GetNames(typeof(CandidateStatusType)));
        }

        [HttpGet("getEnglishLevelTypes")]
        public IActionResult GetEnglishLevelTypes()
        {
            return Ok(Enum.GetNames(typeof(EnglishLevelType)));
        }

        [HttpGet("getReportTypes")]
        public IActionResult GetReportTypes()
        {
            return Ok(Enum.GetNames(typeof(ReportType)));
        }

        [HttpGet("getRoleTypes")]
        public IActionResult GetRoleTypes()
        {
            return Ok(Enum.GetNames(typeof(RoleType)));
        }

        [HttpGet("getInternshipStatusTypes")]
        public IActionResult GetInternshipStatusTypes()
        {
            return Ok(Enum.GetNames(typeof(InternshipStatusType)));
        }
    }
}
