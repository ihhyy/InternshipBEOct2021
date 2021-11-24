using AutoMapper;
using BL.DTOs.CandidateDTOs;
using BL.Interfaces;
using DAL.Entities;
using DAL.Entities.Filtering;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Shared.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BL.Services
{
    public class CandidateService : ICandidateService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CandidateService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<CandidateDTO> GetCandidateByIdAsync(int id)
        {
            var candidate = await _unitOfWork.Candidates.GetByIdAsync(id);

            return _mapper.Map<CandidateDTO>(candidate);
        }

        public async Task<CandidateDTO> CreateCandidateAsync(CandidateDTO newCandidate)
        {
            var mappedCandidate = _mapper.Map<Candidate>(newCandidate);

            var candidate = await _unitOfWork.Candidates.CreateAsync(mappedCandidate);

            return _mapper.Map<CandidateDTO>(candidate);
        }

        public async Task<CandidateDTO> UpdateCandidateAsync(CandidateDTO candidate)
        {

            var mappedCandidate = _mapper.Map<Candidate>(candidate);

            var updatedCandidate = await _unitOfWork.Candidates.UpdateAsync(mappedCandidate);

            return _mapper.Map<CandidateDTO>(updatedCandidate);
        }

        public async Task<List<CandidateDTO>> GetCandidatesByInternshipIdAsync(int internshipId, int pageSize, int pageNumber, CandidateFilterModel filterBy)
        {
            var candidates = await _unitOfWork.Candidates.GetCandidatesByInternshipIdAsync(internshipId, pageSize, pageNumber);

            if (filterBy != null)
            {
                candidates = await _unitOfWork.Candidates.GetCandidatesForFilterAsync(filterBy);
            }

            return _mapper.Map<List<CandidateDTO>>(candidates);
        }

        public async Task<List<CandidateDTO>> UpdateCandidateStatusByIdAsync(List<int> candidatesId, CandidateStatusType type)
        {
            var candidates = await _unitOfWork.Candidates.GetCandidatesListById(candidatesId);           

            candidates.ForEach(x => x.StatusType = type);

            candidates.ForEach(x => x.Users = null);

            var updatedCandidates = await _unitOfWork.Candidates.BulkUpdateAsync(candidates);

            return _mapper.Map<List<CandidateDTO>>(updatedCandidates);
        }

        public async Task<List<CandidateDTO>> SearchByInternshipIdAsync(CandidateDTO searchModel)
        {
            var query = await _unitOfWork.Candidates.SearchCandidatesAsync(searchModel.Skip, searchModel.Take, searchModel.SearchText, searchModel.SortBy, searchModel.IsDesc, searchModel.InternshipId);

            return _mapper.Map<List<CandidateDTO>>(query);
        }
    }
}