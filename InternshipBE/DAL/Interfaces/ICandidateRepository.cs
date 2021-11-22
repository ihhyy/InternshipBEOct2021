﻿using DAL.Entities;
using Shared.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ICandidateRepository : IGenericRepository<Candidate>
    {
        Task<List<Candidate>> GetCandidatesByInternshipIdAsync(int id, int pageSize, int pageNumber);

        Task<List<Candidate>> GetCandidatesByInternshipIdAsync(int internshipId, ReportType reportType);

        Task<int> GetCandidatesCountByTabelIdAsync(string tableId);

        IQueryable<Candidate> GetCandidatesForFIlter();

        Task<List<Candidate>> SearchCandidatesAsync(int skip, int take, string searchText, string sortBy, bool isDesc, int internshipId);
    }
}
