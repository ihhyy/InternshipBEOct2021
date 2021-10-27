﻿using BL.Interfaces;
using BL.Services;
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

			return services;
		}
	}
}
