using System;
using HRM.Authentication.ApplicationCore.Contract.Repository;
using HRM.Authentication.ApplicationCore.Contract.Service;
using HRM.Authentication.ApplicationCore.Entity;

namespace HRM.Authentication.Infrastructure.Service
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository RoleRepository;

        public RoleService(IRoleRepository _RoleRepository)
        {
            RoleRepository = _RoleRepository;
        }

        public int AddRole(Role Role)
        {
            return RoleRepository.Insert(Role);
        }

        public int DeleteRole(int id)
        {
            return RoleRepository.Delete(id);
        }

        public Role GetRoleById(int id)
        {
            return RoleRepository.GetById(id);
        }

        public IEnumerable<Role> GetAllRoles()
        {
            return RoleRepository.GetAll();
        }

        public int UpdateRole(Role Role)
        {
            return RoleRepository.Update(Role);
        }
    }
}

