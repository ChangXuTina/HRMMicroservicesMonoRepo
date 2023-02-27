using System;
using HRM.Authentication.ApplicationCore.Entity;

namespace HRM.Authentication.ApplicationCore.Contract.Service
{
	public interface IRoleService
	{
        int AddRole(Role role);
        int UpdateRole(Role role);
        int DeleteRole(int id);
        Role GetRoleById(int id);
        IEnumerable<Role> GetAllRoles();

    }
}

