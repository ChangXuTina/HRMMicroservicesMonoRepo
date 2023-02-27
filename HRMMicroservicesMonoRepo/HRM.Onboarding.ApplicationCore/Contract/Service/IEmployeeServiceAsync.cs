using System;
using HRM.Onboarding.ApplicationCore.Model.Request;
using HRM.Onboarding.ApplicationCore.Model.Response;

namespace HRM.Onboarding.ApplicationCore.Contract.Service
{
	public interface IEmployeeServiceAsync
	{
        Task<int> AddEmployeeAsync(EmployeeRequestModel model);
        Task<int> UpdateEmployeeAsync(EmployeeRequestModel model);
        Task<int> DeleteEmployeeAsync(int id);
        Task<EmployeeResponseModel> GetEmployeeByIdAsync(int id);
        Task<IEnumerable<EmployeeResponseModel>> GetAllEmployeesAsync();

    }
}

