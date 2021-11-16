﻿using BL.Interfaces;
using BL.Services;
using BL.Validators;
using DAL.Interfaces;
using DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace WebApi.Extensions
{
    public static class RegisterServices
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IGoogleSheetService, GoogleSheetService>();
            services.AddTransient<ICandidateService, CandidateService>();
            services.AddTransient<IUnitOfWork, EFUnitOfWork>();
            services.AddTransient<IInternshipService, InternshipService>();
            services.AddTransient<IFeedbackService, FeedbackService>();
            services.AddTransient<IEvaluationService, EvaluationService>();
            services.AddTransient<ISkillService, SkillService>();
            services.AddTransient<IBestContactTimeService, BestContactTimeService>();
            services.AddTransient<IGoogleCalendarService, GoogleCalendarService>();
            services.AddTransient<IInternshipStackService, InternshipStackService>();
            services.AddTransient<ILocationService, LocationService>();
            services.AddTransient<IReportService, ReportService>();
            services.AddTransient<ICandidateValidator, CandidateValidator>();
            services.AddTransient<IUserValidator, UserValidator>();
            services.AddTransient<IFeedbackValidator, FeedbackValidator>();
            services.AddTransient<IInternshipValidator, InternshipValidator>();

            return services;
        }
    }
}
