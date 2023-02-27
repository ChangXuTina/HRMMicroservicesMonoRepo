using System;
using HRM.Recruiting.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;

namespace HRM.Recruiting.Infrastructure.Data
{
	public class RecruitingDbContext: DbContext
	{
        public RecruitingDbContext(DbContextOptions<RecruitingDbContext> options) : base(options)
        {
        }
        public DbSet<Candidate> Candidate { get; set; }
        public DbSet<JobRequirement> JobRequirement { get; set; }
        public DbSet<Submission> Submission { get; set; }
        public DbSet<SubmissionStatus> SubmissionStatus { get; set; }
    }
}

