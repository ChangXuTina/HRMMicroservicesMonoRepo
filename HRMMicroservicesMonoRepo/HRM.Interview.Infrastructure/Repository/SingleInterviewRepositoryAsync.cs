using System;
using HRM.Interview.ApplicationCore.Contract.Respository;
using HRM.Interview.ApplicationCore.Entity;
using HRM.Interview.Infrastructure.Data;

namespace HRM.Interview.Infrastructure.Repository
{
    public class SingleInterviewRepositoryAsync : BaseRepositoryAsync<SingleInterview>, ISingleInterviewRepositoryAsync
    {
        public SingleInterviewRepositoryAsync(InterviewDbContext _context) : base(_context)
        {
        }
    }
}

