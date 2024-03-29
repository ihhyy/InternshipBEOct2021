﻿using AutoMapper;
using BL.DTOs;
using DAL.Entities;
using Shared.Enums;
using System;

namespace BL.Mapping.Profiles
{
    public class FeedbackProfile: Profile
    {
        public FeedbackProfile()
        {
            CreateMap<Feedback, FeedbackDTO>()
                .ForMember(dto => dto.Id, src => src.MapFrom(entity => entity.Id))
                .ForMember(dto => dto.UserId, src => src.MapFrom(entity => entity.UserId))
                .ForMember(dto => dto.UserName, src => src.MapFrom(entity => entity.User.UserName))
                .ForMember(dto => dto.UserRoleType, src => src.MapFrom(entity => entity.User.RoleType.ToString()))
                .ForMember(dto => dto.CandidateId, src => src.MapFrom(entity => entity.CandidateId))
                .ForMember(dto => dto.EnglishLevelType, src => src.MapFrom(entity => entity.EnglishLevelType.ToString()))
                .ForMember(dto => dto.Date, src => src.MapFrom(entity => entity.Date))
                .ForMember(dto => dto.Description, src => src.MapFrom(entity => entity.Description))
                .ForMember(dto => dto.Evaluations, src => src.MapFrom(entity => entity.Evaluations))
                .ForMember(dto => dto.FinalEvaluation, src => src.MapFrom(entity => entity.FinalEvaluation));
            
                CreateMap<FeedbackDTO, Feedback>()
                .ForMember(entity => entity.Id, src => src.MapFrom(dto => dto.Id))
                .ForMember(entity => entity.CandidateId, src => src.MapFrom(dto => dto.CandidateId))
                .ForMember(entity => entity.EnglishLevelType, src => src.MapFrom(dto => Enum.Parse<EnglishLevelType>(dto.EnglishLevelType)))
                .ForMember(entity => entity.Date, src => src.MapFrom(dto => dto.Date))
                .ForMember(entity => entity.Description, src => src.MapFrom(dto => dto.Description))
                .ForMember(entity => entity.Evaluations, src => src.MapFrom(dto => dto.Evaluations))
                .ForMember(entity => entity.UserId, src => src.MapFrom(dto => dto.UserId))
                .ForMember(entity => entity.FinalEvaluation, src => src.MapFrom(dto => dto.FinalEvaluation));
        }
    }
}
