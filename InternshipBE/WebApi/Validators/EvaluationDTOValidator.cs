﻿using BL.DTOs;
using FluentValidation;

namespace WebApi.Validators
{
    public class EvaluationDTOValidator : AbstractValidator<EvaluationDTO>
    {
        public EvaluationDTOValidator()
        {
            RuleFor(evaluation => evaluation.FeedbackId).NotEqual(0);
        }
    }
}
