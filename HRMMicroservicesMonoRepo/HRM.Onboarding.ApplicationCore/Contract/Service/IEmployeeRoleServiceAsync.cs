using System;
using HRM.Onboarding.ApplicationCore.Model.Request;
using HRM.Onboarding.ApplicationCore.Model.Response;

namespace HRM.Onboarding.ApplicationCore.Contract.Service
{
	public interface IEmployeeRoleServiceAsync
	{
        Task<int> AddEmployeeRoleAsync(EmployeeRoleRequestModel model);
        Task<int> UpdateEmployeeRoleAsync(EmployeeRoleRequestModel model);
        Task<int> DeleteEmployeeRoleAsync(int id);
        Task<EmployeeRoleResponseModel> GetEmployeeRoleByIdAsync(int id);
        Task<IEnumerable<EmployeeRoleResponseModel>> GetAllEmployeeRolesAsync();

    }
}

