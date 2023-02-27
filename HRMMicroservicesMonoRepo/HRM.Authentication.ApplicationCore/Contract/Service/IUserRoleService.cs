using System;
using HRM.Authentication.ApplicationCore.Entity;

namespace HRM.Authentication.ApplicationCore.Contract.Service
{
	public interface IUserRoleService
	{
        int AddUserRole(UserRole userRole);
        int UpdateUserRole(UserRole userRole);
        int DeleteUserRole(int id);
        UserRole GetUserRoleById(int id);
        IEnumerable<UserRole> GetAllUserRoles();

    }
}

