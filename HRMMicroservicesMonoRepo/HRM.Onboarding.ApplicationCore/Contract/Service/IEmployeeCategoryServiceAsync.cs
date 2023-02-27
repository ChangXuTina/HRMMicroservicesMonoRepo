using System;
using HRM.Onboarding.ApplicationCore.Model.Request;
using HRM.Onboarding.ApplicationCore.Model.Response;

namespace HRM.Onboarding.ApplicationCore.Contract.Service
{
	public interface IEmployeeCategoryServiceAsync
	{
        Task<int> AddEmployeeCategoryAsync(EmployeeCategoryRequestModel model);
        Task<int> UpdateEmployeeCategoryAsync(EmployeeCategoryRequestModel model);
        Task<int> DeleteEmployeeCategoryAsync(int id);
        Task<EmployeeCategoryResponseModel> GetEmployeeCategoryByIdAsync(int id);
        Task<IEnumerable<EmployeeCategoryResponseModel>> GetAllEmployeeCategoriesAsync();

    }
}

