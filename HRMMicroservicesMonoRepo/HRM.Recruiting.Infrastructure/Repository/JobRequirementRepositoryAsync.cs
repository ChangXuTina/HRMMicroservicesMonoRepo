using System;
using HRM.Recruiting.ApplicationCore.Contract.Repository;
using HRM.Recruiting.ApplicationCore.Entity;
using HRM.Recruiting.Infrastructure.Data;

namespace HRM.Recruiting.Infrastructure.Repository
{
    public class JobRequirementRepositoryAsync : BaseRepositoryAsync<JobRequirement>, IJobRequirementRepositoryAsync
    {
        public JobRequirementRepositoryAsync(RecruitingDbContext _context) : base(_context)
        {
        }
    }
}

