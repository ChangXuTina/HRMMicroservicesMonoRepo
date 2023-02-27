using System;
using HRM.Onboarding.ApplicationCore.Contract.Repository;
using HRM.Onboarding.ApplicationCore.Entity;
using HRM.Onboarding.Infrastructure.Data;

namespace HRM.Onboarding.Infrastructure.Repository
{
    public class EmployeeRepositoryAsync : BaseRepositoryAsync<Employee>, IEmployeeRepositoryAsync
    {
        public EmployeeRepositoryAsync(OnboardingDbContext _context) : base(_context)
        {
        }
    }
}

