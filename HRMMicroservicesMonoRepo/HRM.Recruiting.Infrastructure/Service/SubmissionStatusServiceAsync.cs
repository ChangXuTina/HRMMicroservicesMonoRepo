using System;
using HRM.Recruiting.ApplicationCore.Contract.Repository;
using HRM.Recruiting.ApplicationCore.Contract.Service;
using HRM.Recruiting.ApplicationCore.Entity;
using HRM.Recruiting.ApplicationCore.Model.Request;
using HRM.Recruiting.ApplicationCore.Model.Response;

namespace HRM.Recruiting.Infrastructure.Service
{
    public class SubmissionStatusServiceAsync : ISubmissionStatusServiceAsync
    {
        private readonly ISubmissionStatusRepositoryAsync SubmissionStatusRepositoryAsync;

        public SubmissionStatusServiceAsync(ISubmissionStatusRepositoryAsync _SubmissionStatusRepositoryAsync)
        {
            SubmissionStatusRepositoryAsync = _SubmissionStatusRepositoryAsync;
        }

        public async Task<int> AddSubmissionStatusAsync(SubmissionStatusRequestModel model)
        {
            SubmissionStatus SubmissionStatus = new SubmissionStatus()
            {
                Description = model.Description
            };
            return await SubmissionStatusRepositoryAsync.InsertAsync(SubmissionStatus);
        }

        public Task<int> DeleteSubmissionStatusAsync(int id)
        {
            return SubmissionStatusRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<SubmissionStatusResponseModel>> GetAllSubmissionStatusAsync()
        {
            var result = await SubmissionStatusRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(x => new SubmissionStatusResponseModel()
                {
                    Id = x.Id,
                    Description = x.Description
                });
            }
            return null;
        }

        public async Task<SubmissionStatusResponseModel> GetSubmissionStatusByIdAsync(int id)
        {
            var result = await SubmissionStatusRepositoryAsync.GetByIdAsync(id);
            if (result != null)
            {
                return new SubmissionStatusResponseModel()
                {
                    Id = result.Id,
                    Description = result.Description
                };
            }
            return null;
        }

        public Task<int> UpdateSubmissionStatusAsync(SubmissionStatusRequestModel model)
        {
            SubmissionStatus SubmissionStatus = new SubmissionStatus()
            {
                Id = model.Id,
                Description = model.Description
            };
            return SubmissionStatusRepositoryAsync.UpdateAsync(SubmissionStatus);
        }

    }
}

