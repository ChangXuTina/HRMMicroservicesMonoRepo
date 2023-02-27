using System;
using Dapper;
using HRM.Authentication.ApplicationCore.Contract.Repository;
using HRM.Authentication.ApplicationCore.Entity;
using HRM.Authentication.Infrastructure.Data;

namespace HRM.Authentication.Infrastructure.Respository
{
    public class RoleRepository : IRoleRepository
    {
        private AuthenticationDbContext dbContext;
        public RoleRepository()
        {
            dbContext = new AuthenticationDbContext();
        }

        public int Delete(int id)
        {
            using (var conn = dbContext.GetConnection())
            {
                return conn.Execute("Delete From Role Where Id = @roleId", new { roleId = id });
            }
        }

        public IEnumerable<Role> GetAll()
        {
            using (var conn = dbContext.GetConnection())
            {
                return conn.Query<Role>("Select * From Role");
            }
        }

        public Role GetById(int id)
        {
            using (var conn = dbContext.GetConnection())
            {
                return conn.QuerySingleOrDefault<Role>("Select * From Role Where Id = @roleId", new { roleId = id });
            }
        }

        public int Insert(Role entity)
        {
            using (var conn = dbContext.GetConnection())
            {
                return conn.Execute("Insert Into Role values (@Name, @Description)", entity);
            }
        }

        public int Update(Role entity)
        {
            using (var conn = dbContext.GetConnection())
            {
                return conn.Execute("Update Role Set Name = @Name, Description = @Description Where Id = @Id", entity);
            }
        }
    }

}

