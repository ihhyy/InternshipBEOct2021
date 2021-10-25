﻿using System.Threading.Tasks;

namespace BL.Interfaces
{
	public interface IUserService
	{
		Task<string> AuthenticateAsync(string login, string password);
	}
}