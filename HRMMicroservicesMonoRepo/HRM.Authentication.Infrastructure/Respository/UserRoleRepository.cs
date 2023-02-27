using System;
using Dapper;
using HRM.Authentication.ApplicationCore.Contract.Repository;
using HRM.Authentication.ApplicationCore.Entity;
using HRM.Authentication.Infrastructure.Data;

namespace HRM.Authentication.Infrastructure.Respository
{
    public class UserRoleRepository : IUserRoleRepository
    {
        private AuthenticationDbContext dbContext;
        public UserRoleRepository()
        {
            dbContext = new AuthenticationDbContext();
        }

        public int Delete(int id)
        {
            using (var conn = dbContext.GetConnection())
            {
                return conn.Execute("Delete From UserRole Where Id = @userRoleId", new { userRoleId = id });
            }
        }

        public IEnumerable<UserRole> GetAll()
        {
            using (var conn = dbContext.GetConnection())
            {
                return conn.Query<UserRole>("Select * From userRole");
            }
        }

        public UserRole GetById(int id)
        {
            using (var conn = dbContext.GetConnection())
            {
                return conn.QuerySingleOrDefault<UserRole>("Select * From UserRole Where Id = @userRoleId", new { userRoleId = id });
            }
        }

        public int Insert(UserRole entity)
        {
            using (var conn = dbContext.GetConnection())
            {
                return conn.Execute("Insert Into UserRole values (@AccountId, @RoleId)", entity);
            }
        }

        public int Update(UserRole entity)
        {
            using (var conn = dbContext.GetConnection())
            {
                return conn.Execute("Update UserRole Set AccountId = @AccountId, RoleId = @RoleId Where Id = @Id", entity);
            }
        }
    }

}

