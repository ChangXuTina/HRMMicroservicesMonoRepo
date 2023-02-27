using System;
using HRM.Recruiting.ApplicationCore.Utility;
using HRM.Recruiting.ApplicationCore.Contract.Repository;
using HRM.Recruiting.ApplicationCore.Contract.Service;
using HRM.Recruiting.ApplicationCore.Entity;
using HRM.Recruiting.ApplicationCore.Model.Request;
using HRM.Recruiting.ApplicationCore.Model.Response;

namespace HRM.Recruiting.Infrastructure.Service
{
    public class JobRequirementServiceAsync : IJobRequirementServiceAsync
    {
        private readonly IJobRequirementRepositoryAsync jobRequirementRepositoryAsync;

        public JobRequirementServiceAsync(IJobRequirementRepositoryAsync _jobRequirementRepositoryAsync)
        {
            jobRequirementRepositoryAsync = _jobRequirementRepositoryAsync;
        }

        public Task<int> AddJobRequirementAsync(JobRequirementRequestModel model)
        {
            JobRequirement jobRequirement = new JobRequirement()
            {
                NumberOfPositions = model.NumberOfPositions,
                Title = model.Title,
                Description = model.Description,
                HiringManagerId = model.HiringManagerId,
                HiringManagerName = model.HiringManagerName,
                StartDate = model.StartDate,
                IsActive = model.IsActive,
                ClosedOn = model.ClosedOn,
                ClosedReason = model.ClosedReason,
                CreatedOn = model.CreatedOn,
                EmployeeType = Enum.GetName(typeof(EmploymentType), model.EmployeeType)
            };
            return jobRequirementRepositoryAsync.InsertAsync(jobRequirement);

        }

        public Task<int> DeleteJobRequirementAsync(int id)
        {
            return jobRequirementRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<JobRequirementResponseModel>> GetAllJobRequirementsAsync()
        {
            var result = await jobRequirementRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(x => new JobRequirementResponseModel()
                {
                    Id = x.Id,
                    NumberOfPositions = x.NumberOfPositions,
                    Title = x.Title,
                    Description = x.Description,
                    HiringManagerId = x.HiringManagerId,
                    HiringManagerName = x.HiringManagerName,
                    StartDate = x.StartDate,
                    IsActive = x.IsActive,
                    ClosedOn = x.ClosedOn,
                    ClosedReason = x.ClosedReason,
                    CreatedOn = x.CreatedOn,
                    EmployeeType = (int)Enum.Parse(typeof(EmploymentType), x.EmployeeType)
                });
            }
            return null;
        }

        public async Task<JobRequirementResponseModel> GetJobRequirementByIdAsync(int id)
        {
            var result = await jobRequirementRepositoryAsync.GetByIdAsync(id);
            if (result != null)
            {
                return new JobRequirementResponseModel()
                {
                    Id = result.Id,
                    NumberOfPositions = result.NumberOfPositions,
                    Title = result.Title,
                    Description = result.Description,
                    HiringManagerId = result.HiringManagerId,
                    HiringManagerName = result.HiringManagerName,
                    StartDate = result.StartDate,
                    IsActive = result.IsActive,
                    ClosedOn = result.ClosedOn,
                    ClosedReason = result.ClosedReason,
                    CreatedOn = result.CreatedOn,
                    EmployeeType = (int)Enum.Parse(typeof(EmploymentType), result.EmployeeType)
                };
            }
            return null;
        }

        public Task<int> UpdateJobRequirementAsync(JobRequirementRequestModel model)
        {
            JobRequirement jobRequirement = new JobRequirement()
            {
                Id = model.Id,
                NumberOfPositions = model.NumberOfPositions,
                Title = model.Title,
                Description = model.Description,
                HiringManagerId = model.HiringManagerId,
                HiringManagerName = model.HiringManagerName,
                StartDate = model.StartDate,
                IsActive = model.IsActive,
                ClosedOn = model.ClosedOn,
                ClosedReason = model.ClosedReason,
                CreatedOn = model.CreatedOn,
                EmployeeType = Enum.GetName(typeof(EmploymentType), model.EmployeeType)
            };
            return jobRequirementRepositoryAsync.UpdateAsync(jobRequirement);
        }
    }
}

