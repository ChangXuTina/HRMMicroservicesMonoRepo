using System;
using HRM.Authentication.ApplicationCore.Contract.Repository;
using HRM.Authentication.ApplicationCore.Contract.Service;
using HRM.Authentication.ApplicationCore.Entity;

namespace HRM.Authentication.Infrastructure.Service
{
    public class UserRoleService : IUserRoleService
    {
        private readonly IUserRoleRepository UserRoleRepository;

        public UserRoleService(IUserRoleRepository _UserRoleRepository)
        {
            UserRoleRepository = _UserRoleRepository;
        }

        public int AddUserRole(UserRole UserRole)
        {
            return UserRoleRepository.Insert(UserRole);
        }

        public int DeleteUserRole(int id)
        {
            return UserRoleRepository.Delete(id);
        }

        public UserRole GetUserRoleById(int id)
        {
            return UserRoleRepository.GetById(id);
        }

        public IEnumerable<UserRole> GetAllUserRoles()
        {
            return UserRoleRepository.GetAll();
        }

        public int UpdateUserRole(UserRole UserRole)
        {
            return UserRoleRepository.Update(UserRole);
        }
    }
}

