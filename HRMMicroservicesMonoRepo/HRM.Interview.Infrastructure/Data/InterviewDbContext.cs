using System;
using HRM.Interview.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;

namespace HRM.Interview.Infrastructure.Data
{
	public class InterviewDbContext: DbContext
	{
        public InterviewDbContext(DbContextOptions<InterviewDbContext> options) : base(options)
        {
        }
        public DbSet<SingleInterview> SingleInterview { get; set; }
        public DbSet<Interviewer> Interviewer { get; set; }
        public DbSet<InterviewType> InterviewType { get; set; }
        public DbSet<InterviewFeedback> InterviewFeedback { get; set; }
        public DbSet<Recruiter> Recruiter { get; set; }
    }
}

