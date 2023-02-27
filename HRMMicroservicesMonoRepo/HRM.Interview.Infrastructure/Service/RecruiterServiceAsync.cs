using System;
using HRM.Interview.ApplicationCore.Contract.Respository;
using HRM.Interview.ApplicationCore.Contract.Service;
using HRM.Interview.ApplicationCore.Entity;
using HRM.Interview.ApplicationCore.Model.Request;
using HRM.Interview.ApplicationCore.Model.Response;

namespace HRM.Interview.Infrastructure.Service
{
    public class RecruiterServiceAsync : IRecruiterServiceAsync
    {
        private readonly IRecruiterRepositoryAsync RecruiterRepositoryAsync;

        public RecruiterServiceAsync(IRecruiterRepositoryAsync _RecruiterRepositoryAsync)
        {
            RecruiterRepositoryAsync = _RecruiterRepositoryAsync;
        }

        public Task<int> AddRecruiterAsync(RecruiterRequestModel model)
        {
            Recruiter Recruiter = new Recruiter()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                EmployeeId = model.EmployeeId
            };
            return RecruiterRepositoryAsync.InsertAsync(Recruiter);
        }

        public Task<int> DeleteRecruiterAsync(int id)
        {
            return RecruiterRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<RecruiterResponseModel>> GetAllRecruitersAsync()
        {
            var result = await RecruiterRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(x => new RecruiterResponseModel()
                {
                    Id = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    EmployeeId = x.EmployeeId

                });
            }
            return null;
        }

        public async Task<RecruiterResponseModel> GetRecruiterByIdAsync(int id)
        {
            var result = await RecruiterRepositoryAsync.GetByIdAsync(id);
            if (result != null)
            {
                return new RecruiterResponseModel()
                {
                    Id = result.Id,
                    FirstName = result.FirstName,
                    LastName = result.LastName,
                    EmployeeId = result.EmployeeId
                };
            }
            return null;
        }

        public Task<int> UpdateRecruiterAsync(RecruiterRequestModel model)
        {
            Recruiter Recruiter = new Recruiter()
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                EmployeeId = model.EmployeeId
            };
            return RecruiterRepositoryAsync.UpdateAsync(Recruiter);
        }
    }
}

