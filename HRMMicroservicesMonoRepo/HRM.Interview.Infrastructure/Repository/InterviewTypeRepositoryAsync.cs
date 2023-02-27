using System;
using HRM.Interview.ApplicationCore.Contract.Respository;
using HRM.Interview.ApplicationCore.Entity;
using HRM.Interview.Infrastructure.Data;

namespace HRM.Interview.Infrastructure.Repository
{
    public class InterviewTypeRepositoryAsync : BaseRepositoryAsync<InterviewType>, IInterviewTypeRepositoryAsync
    {
        public InterviewTypeRepositoryAsync(InterviewDbContext _context) : base(_context)
        {
        }
    }
}

