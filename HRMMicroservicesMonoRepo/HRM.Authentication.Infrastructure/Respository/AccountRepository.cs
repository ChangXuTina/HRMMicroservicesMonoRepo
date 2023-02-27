using System;
using Dapper;
using HRM.Authentication.ApplicationCore.Contract.Repository;
using HRM.Authentication.ApplicationCore.Entity;
using HRM.Authentication.Infrastructure.Data;

namespace HRM.Authentication.Infrastructure.Respository
{
	public class AccountRepository: IAccountRepository
    {
		private AuthenticationDbContext dbContext;
		public AccountRepository()
		{
			dbContext = new AuthenticationDbContext();
		}

        public int Delete(int id)
        {
            using (var conn = dbContext.GetConnection())
            {
                return conn.Execute("Delete From Account Where Id = @accId", new { accId = id });
            }
        }

        public IEnumerable<Account> GetAll()
        {
            using (var conn = dbContext.GetConnection())
            {
                return conn.Query<Account>("Select * From Account");
            }
        }

        public Account GetById(int id)
        {
            using (var conn = dbContext.GetConnection())
            {
                return conn.QuerySingleOrDefault<Account>("Select * From Account Where Id = @accId", new { accId = id });
            }
        }

        public int Insert(Account entity)
        {
            using (var conn = dbContext.GetConnection())
            {
                return conn.Execute("Insert Into Account values (@EmployeeId, @Email, @FirstName, @LastName, @HashPassword, @Salt)", entity);
            }
        }

        public int Update(Account entity)
        {
            using (var conn = dbContext.GetConnection())
            {
                return conn.Execute("Update Account Set EmployeeId=@EmployeeId, Email=@Email, FirstName=@FirstName, LastName=@LastName, HashPassword=@HashPassword, Salt=@Salt Where Id=@Id", entity);
            }
        }
    }

}

