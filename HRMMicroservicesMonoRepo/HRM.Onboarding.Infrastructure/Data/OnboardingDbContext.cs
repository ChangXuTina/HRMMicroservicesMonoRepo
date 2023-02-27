using System;
using HRM.Onboarding.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;

namespace HRM.Onboarding.Infrastructure.Data
{
	public class OnboardingDbContext: DbContext
	{
        public OnboardingDbContext(DbContextOptions<OnboardingDbContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeeCategory> EmployeeCategory { get; set; }
        public DbSet<EmployeeRole> EmployeeRole { get; set; }
        public DbSet<EmployeeStatus> EmployeeStatus { get; set; }
    }
}

