﻿using System.Threading.Tasks;

namespace BL.Interfaces
{
	public interface IUserService
	{
		Task<string> AuthenticateAsync(string email, string password);
	}
}
