﻿using BL.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IInterviewInviteService
    {
        Task<List<InterviewInviteDTO>> GetAllInterviewInvitesAsync();

        Task<List<InterviewInviteDTO>> GetInterviewInvitesByUserIdAsync(string userId);

        Task<InterviewInviteDTO> CreateInterviewInviteAsync(InterviewInviteDTO inviteDto);

        Task<InterviewInviteDTO> UpdateInterviewInviteAsync(InterviewInviteDTO inviteDto);

        Task DeleteInterviewInviteAsync(int id);
    }
}
