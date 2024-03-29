﻿using BL.DTOs;
using DAL.Entities;
using Shared.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IUserService
    {
        Task<string> AuthenticateAsync(string email, string password);

        Task<UserDTO> GetUserInfoByUserNameAsync(string userName);

        Task<List<UserDTO>> GetSpecificUsersByInternshipIdAsync(int id, RoleType? roleType);

        Task<List<UserDTO>> GetUsersByCandidateIdAsync(int id);

        Task<List<UserDTO>> UpdateUsersFromInternshipAsync(int id, string[] userIds, UpdateUserType updateType);

        Task<List<UserDTO>> GetAllUsersAsync();

        Task<UserDTO> GetUserInfoByUserIdAsync(string id);
    }
}
