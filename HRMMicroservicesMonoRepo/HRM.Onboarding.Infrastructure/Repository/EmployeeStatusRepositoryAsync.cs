using System;
using HRM.Onboarding.ApplicationCore.Contract.Repository;
using HRM.Onboarding.ApplicationCore.Entity;
using HRM.Onboarding.Infrastructure.Data;

namespace HRM.Onboarding.Infrastructure.Repository
{
    public class EmployeeStatusRepositoryAsync : BaseRepositoryAsync<EmployeeStatus>, IEmployeeStatusRepositoryAsync
    {
        public EmployeeStatusRepositoryAsync(OnboardingDbContext _context) : base(_context)
        {
        }
    }
}

