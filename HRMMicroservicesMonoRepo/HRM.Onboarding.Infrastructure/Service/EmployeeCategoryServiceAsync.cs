using System;
using HRM.Onboarding.ApplicationCore.Contract.Repository;
using HRM.Onboarding.ApplicationCore.Contract.Service;
using HRM.Onboarding.ApplicationCore.Entity;
using HRM.Onboarding.ApplicationCore.Model.Request;
using HRM.Onboarding.ApplicationCore.Model.Response;

namespace HRM.Onboarding.Infrastructure.Service
{
    public class EmployeeCategoryServiceAsync : IEmployeeCategoryServiceAsync
    {
        private readonly IEmployeeCategoryRepositoryAsync EmployeeCategoryRepositoryAsync;

        public EmployeeCategoryServiceAsync(IEmployeeCategoryRepositoryAsync _EmployeeCategoryRepositoryAsync)
        {
            EmployeeCategoryRepositoryAsync = _EmployeeCategoryRepositoryAsync;
        }

        public async Task<int> AddEmployeeCategoryAsync(EmployeeCategoryRequestModel model)
        {
            EmployeeCategory employeeCategory = new EmployeeCategory()
            {
                Description = model.Description
            };
            return await EmployeeCategoryRepositoryAsync.InsertAsync(employeeCategory);
        }

        public Task<int> DeleteEmployeeCategoryAsync(int id)
        {
            return EmployeeCategoryRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<EmployeeCategoryResponseModel>> GetAllEmployeeCategoriesAsync()
        {
            var result = await EmployeeCategoryRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(x => new EmployeeCategoryResponseModel()
                {
                    Id = x.Id,
                    Description = x.Description
                });
            }
            return null;
        }

        public async Task<EmployeeCategoryResponseModel> GetEmployeeCategoryByIdAsync(int id)
        {
            var result = await EmployeeCategoryRepositoryAsync.GetByIdAsync(id);
            if (result != null)
            {
                return new EmployeeCategoryResponseModel()
                {
                    Id = result.Id,
                    Description = result.Description
                };
            }
            return null;
        }

        public Task<int> UpdateEmployeeCategoryAsync(EmployeeCategoryRequestModel model)
        {
            EmployeeCategory EmployeeCategory = new EmployeeCategory()
            {
                Id = model.Id,
                Description = model.Description
            };
            return EmployeeCategoryRepositoryAsync.UpdateAsync(EmployeeCategory);
        }

    }
}
