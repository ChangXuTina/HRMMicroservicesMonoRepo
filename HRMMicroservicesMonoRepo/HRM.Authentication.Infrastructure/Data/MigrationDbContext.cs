using System;
using HRM.Authentication.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;

namespace HRM.Authentication.Infrastructure.Data
{
	public class MigrationDbContext: DbContext
	{
        public MigrationDbContext(DbContextOptions<MigrationDbContext> options) : base(options)
        {
        }
        public DbSet<Account> Account { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<Role> Role { get; set; }
    }
}

