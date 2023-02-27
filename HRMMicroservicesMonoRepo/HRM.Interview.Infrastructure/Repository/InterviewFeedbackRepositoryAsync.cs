using System;
using HRM.Interview.ApplicationCore.Contract.Respository;
using HRM.Interview.ApplicationCore.Entity;
using HRM.Interview.Infrastructure.Data;

namespace HRM.Interview.Infrastructure.Repository
{
    public class InterviewFeedbackRepositoryAsync : BaseRepositoryAsync<InterviewFeedback>, IInterviewFeedbackRepositoryAsync
    {
        public InterviewFeedbackRepositoryAsync(InterviewDbContext _context) : base(_context)
        {
        }
    }
}

