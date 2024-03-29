﻿using DAL.Entities;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IInternshipLanguagesService
    {
        Task<Internship> CreateOrDeleteLanguagesAsync(Internship oldInternship, Internship newInternship);
    }
}
