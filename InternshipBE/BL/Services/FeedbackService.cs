﻿using AutoMapper;
using BL.DTOs;
using BL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL.Services
{
    public class FeedbackService : IFeedbackService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IValidator<Feedback> _validator;

        public FeedbackService(IUnitOfWork unitOfWork, IMapper mapper, IValidator<Feedback> validator)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _validator = validator;
        }

        public async Task<FeedbackDTO> CreateFeedbackAsync(FeedbackDTO newFeedback)
        {
            var feedback = await _unitOfWork.Feedbacks.CreateAsync(_mapper.Map<Feedback>(newFeedback));

            return _mapper.Map<FullGetFeedbackDTO>(feedback);
        }

        public async Task<List<FeedbackDTO>> GetFeedbacksByCandidateIdAsync(int candidateId)
        {
            var feedbacks = await _unitOfWork.Feedbacks.GetFeedbacksByCandidateIdAsync(candidateId);
            
            return _mapper.Map<List<FeedbackDTO>>(feedbacks);
        }

        public async Task<FeedbackDTO> GetFeedbackByIdAsync(int id)
        {
            var feedback = await _unitOfWork.Feedbacks.GetByIdAsync(id);

            _validator.ValidateIfValueExist(feedback);

            return _mapper.Map<FeedbackDTO>(feedback);
        }

        public async Task<FeedbackDTO> UpdateFeedbackAsync(FeedbackDTO updatedFeedback)
        {
            var feedback = await _unitOfWork.Feedbacks.UpdateAsync(_mapper.Map<Feedback>(updatedFeedback));

            return _mapper.Map<UpdateFeedbackDTO>(feedback);
        }
    }
}
