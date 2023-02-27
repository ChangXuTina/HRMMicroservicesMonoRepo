using System;
using HRM.Onboarding.ApplicationCore.Contract.Repository;
using HRM.Onboarding.ApplicationCore.Contract.Service;
using HRM.Onboarding.ApplicationCore.Entity;
using HRM.Onboarding.ApplicationCore.Model.Request;
using HRM.Onboarding.ApplicationCore.Model.Response;

namespace HRM.Onboarding.Infrastructure.Service
{
    public class EmployeeRoleServiceAsync : IEmployeeRoleServiceAsync
    {
        private readonly IEmployeeRoleRepositoryAsync employeeRoleRepositoryAsync;

        public EmployeeRoleServiceAsync(IEmployeeRoleRepositoryAsync _employeeRoleRepositoryAsync)
        {
            employeeRoleRepositoryAsync = _employeeRoleRepositoryAsync;
        }

        public Task<int> AddEmployeeRoleAsync(EmployeeRoleRequestModel model)
        {
            EmployeeRole employeeRole = new EmployeeRole()
            {
                Name = model.Name,
                ABBR = model.ABBR
            };
            return employeeRoleRepositoryAsync.InsertAsync(employeeRole);
        }

        public Task<int> DeleteEmployeeRoleAsync(int id)
        {
            return employeeRoleRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<EmployeeRoleResponseModel>> GetAllEmployeeRolesAsync()
        {
            var result = await employeeRoleRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(x => new EmployeeRoleResponseModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    ABBR = x.ABBR
                });
            }
            return null;
        }

        public async Task<EmployeeRoleResponseModel> GetEmployeeRoleByIdAsync(int id)
        {
            var result = await employeeRoleRepositoryAsync.GetByIdAsync(id);
            if (result != null)
            {
                return new EmployeeRoleResponseModel()
                {
                    Id = result.Id,
                    Name = result.Name,
                    ABBR = result.ABBR
                };
            }
            return null;

        }

        public Task<int> UpdateEmployeeRoleAsync(EmployeeRoleRequestModel model)
        {
            EmployeeRole employeeRole = new EmployeeRole()
            {
                Id = model.Id,
                Name = model.Name,
                ABBR = model.ABBR
            };
            return employeeRoleRepositoryAsync.UpdateAsync(employeeRole);
        }
    }
}

