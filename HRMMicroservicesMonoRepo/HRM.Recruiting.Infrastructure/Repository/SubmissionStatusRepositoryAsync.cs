using System;
using HRM.Recruiting.ApplicationCore.Contract.Repository;
using HRM.Recruiting.ApplicationCore.Entity;
using HRM.Recruiting.Infrastructure.Data;

namespace HRM.Recruiting.Infrastructure.Repository
{
    public class SubmissionStatusRepositoryAsync : BaseRepositoryAsync<SubmissionStatus>, ISubmissionStatusRepositoryAsync
    {
        public SubmissionStatusRepositoryAsync(RecruitingDbContext _context) : base(_context)
        {
        }
    }
}
