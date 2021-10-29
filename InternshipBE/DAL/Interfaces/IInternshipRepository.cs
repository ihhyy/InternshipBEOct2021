﻿using DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IInternshipRepository : IGenericRepository<Internship>
    {
        Task<List<Internship>> GetAllInternshipsPartialAsync(int itemsCount, int pageNumber);
    }
}
