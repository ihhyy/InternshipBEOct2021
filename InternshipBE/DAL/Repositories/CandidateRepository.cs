using DAL.Database;
using DAL.Entities;
using DAL.Entities.Filtering;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Shared.Enums;
using Shared.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CandidateRepository : GenericRepository<Candidate>, ICandidateRepository
    {
        private readonly IValidator<Candidate> _validator;

        public CandidateRepository(ApplicationDbContext context, IValidator<Candidate> validator) : base(context)
        {
            _validator = validator;
        }

        public async override Task<Candidate> GetByIdAsync(int id)
        {
            var candidate = await _context.Candidates.AsNoTracking()
                .Include(x => x.Internship)
                .Include(x => x.Users)
                .ThenInclude(x => x.Feedbacks.Where(x => x.Candidate.Id == id))
                        .ThenInclude(x => x.Evaluations)
                            .ThenInclude(x => x.Skill)
                .FirstOrDefaultAsync(x => x.Id == id);

            _validator.ValidateIfEntityExist(candidate);

            return candidate;
        }

        public async Task<List<Candidate>> GetCandidatesByInternshipIdAsync(int id, int pageSize, int pageNumber, CandidateFilterModel filterBy)
        {
            if (filterBy != null)
                return GetFilteredCandidates(id, pageSize, pageNumber, filterBy);

            return await _context.Candidates.AsNoTracking()
                .Include(x => x.Internship)
                .Include(x => x.Users)
                    .ThenInclude(x => x.Feedbacks.Where(x => x.Candidate.InternshipId == id))
                        .ThenInclude(x => x.Evaluations)
                .Where(x => x.InternshipId == id)
                .Skip(pageSize * --pageNumber)
                .Take(pageSize)
                .ToListAsync();
    }

        public async Task<List<Candidate>> GetCandidatesByInternshipIdAsync(int internshipId, ReportType reportType)
        {
            CandidateStatusType? statusType = GetStatusType(reportType);

            var internship = await _context.Internships.AsNoTracking()
                .Include(x => x.Candidates.Where(r => r.StatusType == statusType || statusType == null))
                .Include(x => x.Users)
                .FirstOrDefaultAsync(x => x.Id == internshipId);

            return internship?.Candidates.ToList();
        }

        public async Task<int> GetCandidatesCountByTabelIdAsync(string tableId)
        {
            return await _context.Candidates.Where(x => x.Internship.SpreadSheetId == tableId).CountAsync();
        }

        public async Task<List<Candidate>> SearchCandidatesAsync(int skip, int take, string searchText, string sortBy, bool isDesc, int internshipId)
        {
            return await _context.Candidates
                .Include(x => x.Internship)
                .Where(x => x.FirstName.Contains(searchText) | x.LastName.Contains(searchText))
                .Where(x => x.InternshipId == internshipId)
                .Skip(skip)
                .Take(take)
                .OrderByPropertyName(sortBy, isDesc)
                .ToListAsync();
        }

        private CandidateStatusType? GetStatusType(ReportType reportType)
        {
            if (reportType == ReportType.CandidatesAccepted)
                return CandidateStatusType.Accepted;
            else if (reportType == ReportType.CandidatesRejection)
                return CandidateStatusType.Declined;
            else return null;
        }

        private List<Candidate> GetFilteredCandidates(int id, int pageSize, int pageNumber, CandidateFilterModel filterBy)
        {
            var candidates = _context.Candidates
                .Include(c => c.Users)
                .Include(c => c.Internship).AsQueryable();

            if (filterBy.Location != null)
                candidates = candidates.Where(c => c.Location == filterBy.Location);
            if (filterBy.LanguageType.HasValue)
                candidates = candidates.Where(c => c.InternshipLanguage == filterBy.LanguageType);
            if (filterBy.StatusType.HasValue)
                candidates = candidates.Where(c => c.StatusType == filterBy.StatusType);
            if (filterBy.HardSkills != null)
                candidates = candidates.Where(c => c.PrimarySkill == filterBy.HardSkills);
            if (filterBy.EnglishLevel.HasValue)
                candidates = candidates.Where(c => c.EnglishLevelType == filterBy.EnglishLevel);
            if (filterBy.UserId != null)
                candidates = candidates.Where(c => c.Users.Any(u => u.Id == filterBy.UserId));

            return candidates.Include(x => x.Internship)
                .Include(x => x.Users)
                    .ThenInclude(x => x.Feedbacks.Where(x => x.Candidate.InternshipId == id))
                        .ThenInclude(x => x.Evaluations)
                .Where(x => x.InternshipId == id)
                .Skip(pageSize * --pageNumber)
                .Take(pageSize)
                .ToList();
        }

        public async Task<List<Candidate>> GetCandidatesListByIdAsync(List<int> candidatesId)
        {
            var candidates = await _context.Candidates
                .Include(x => x.Users)
                .Where(x => candidatesId.Contains(x.Id)).ToListAsync();

            _validator.ValidateIfEntitesExist(candidates);

            return candidates;
        }

        public async override Task<Candidate> UpdateAsync(Candidate newCandidate)
        {
            var candidate = await _context.Candidates
                .Include(x => x.Internship)
                .Include(x => x.Team)
                .Include(x => x.Users)
                    .ThenInclude(x => x.Feedbacks.Where(x => x.CandidateId == newCandidate.Id))
                        .ThenInclude(x => x.Evaluations)
                            .ThenInclude(x => x.Skill)
                .FirstOrDefaultAsync(x => x.Id == newCandidate.Id);

            _validator.ValidateIfEntityExist(candidate);
            await MapFieldsToDbEntityAsync(newCandidate, candidate);
            await base.UpdateAsync(candidate);

            return candidate;
        }

        public async override Task<Candidate> CreateAsync(Candidate newCandidate)
        {
            var candidate = new Candidate();

            await MapFieldsToDbEntityAsync(newCandidate, candidate);

            return await base.CreateAsync(candidate);
        }

        private async Task MapFieldsToDbEntityAsync(Candidate fromCandidate, Candidate toCandidate)
        {
            toCandidate.BestContactTime = fromCandidate.BestContactTime;
            toCandidate.CurrentJob = fromCandidate.CurrentJob;
            toCandidate.Education = fromCandidate.Education;
            toCandidate.Email = fromCandidate.Email;
            toCandidate.EnglishLevelType = fromCandidate.EnglishLevelType;
            toCandidate.Feedbacks = toCandidate.Feedbacks;
            toCandidate.FirstName = fromCandidate.FirstName;
            toCandidate.Internship = await _context.Internships.FirstOrDefaultAsync(x => x.Id == fromCandidate.InternshipId);
            toCandidate.InternshipId = fromCandidate.InternshipId;
            toCandidate.InternshipLanguage = fromCandidate.InternshipLanguage;
            toCandidate.IsPlanningToJoin = fromCandidate.IsPlanningToJoin;
            toCandidate.LastName = fromCandidate.LastName;
            toCandidate.Links = fromCandidate.Links;
            toCandidate.Location = fromCandidate.Location;
            toCandidate.OtherInfo = fromCandidate.OtherInfo;
            toCandidate.Phone = fromCandidate.Phone;
            toCandidate.PrimarySkill = fromCandidate.PrimarySkill;
            toCandidate.ProfessionalCertificates = fromCandidate.ProfessionalCertificates;
            toCandidate.RegistrationDate = fromCandidate.RegistrationDate;
            toCandidate.Skype = fromCandidate.Skype;
            toCandidate.StackType = fromCandidate.StackType;
            toCandidate.StatusType = fromCandidate.StatusType;
            toCandidate.Team = await _context.Teams.FirstOrDefaultAsync(x => x.Id == fromCandidate.TeamId);
            toCandidate.TeamId = fromCandidate.TeamId;
            toCandidate.TestTaskEvaluation = fromCandidate.TestTaskEvaluation;
            toCandidate.Users = await _context.Users.Include(x => x.Feedbacks.Where(x => x.CandidateId == fromCandidate.Id)).ThenInclude(x => x.Evaluations).ThenInclude(x => x.Skill).Where(x => fromCandidate.Users.Select(x => x.Id).Contains(x.Id)).ToListAsync();
        }
    }
}