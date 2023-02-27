using System;
using System.Data;
using System.Data.SqlClient;
using HRM.Authentication.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;

namespace HRM.Authentication.Infrastructure.Data
{
	public class AuthenticationDbContext
	{
        IDbConnection dbConnection;
        public AuthenticationDbContext()
        {
            dbConnection = new SqlConnection("Data Source=localhost,1433;Initial Catalog=AuthenticationApiDb;Integrated Security=True;User ID=sa;Password=@Mang1hjj;Integrated security=False;TrustServerCertificate=True");
        }
        public IDbConnection GetConnection()
        {
            return dbConnection;
        }
        //public DbSet<Account> Account { get; set; }
        //public DbSet<UserRole> UserRole { get; set; }
        //public DbSet<Role> Role { get; set; }
    }
}

