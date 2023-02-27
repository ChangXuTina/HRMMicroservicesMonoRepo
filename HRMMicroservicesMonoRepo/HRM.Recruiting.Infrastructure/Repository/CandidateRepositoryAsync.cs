using System;
using HRM.Recruiting.ApplicationCore.Contract.Repository;
using HRM.Recruiting.ApplicationCore.Entity;
using HRM.Recruiting.Infrastructure.Data;

namespace HRM.Recruiting.Infrastructure.Repository
{
    public class CandidateRespositoryAsync : BaseRepositoryAsync<Candidate>, ICandidateRepositoryAsync
    {
        public CandidateRespositoryAsync(RecruitingDbContext _context) : base(_context)
        {
        }
    }
}

