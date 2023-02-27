using System;
using HRM.Interview.ApplicationCore.Contract.Respository;
using HRM.Interview.ApplicationCore.Contract.Service;
using HRM.Interview.ApplicationCore.Entity;
using HRM.Interview.ApplicationCore.Model.Request;
using HRM.Interview.ApplicationCore.Model.Response;

namespace HRM.Interview.Infrastructure.Service
{
    public class InterviewerServiceAsync : IInterviewerServiceAsync
    {
        private readonly IInterviewerRepositoryAsync InterviewerRepositoryAsync;

        public InterviewerServiceAsync(IInterviewerRepositoryAsync _InterviewerRepositoryAsync)
        {
            InterviewerRepositoryAsync = _InterviewerRepositoryAsync;
        }

        public Task<int> AddInterviewerAsync(InterviewerRequestModel model)
        {
            Interviewer interviewer = new Interviewer()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                EmployeeId = model.EmployeeId
            };
            return InterviewerRepositoryAsync.InsertAsync(interviewer);
        }

        public Task<int> DeleteInterviewerAsync(int id)
        {
            return InterviewerRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<InterviewerResponseModel>> GetAllInterviewersAsync()
        {
            var result = await InterviewerRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(x => new InterviewerResponseModel()
                {
                    Id = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    EmployeeId = x.EmployeeId

                });
            }
            return null;
        }

        public async Task<InterviewerResponseModel> GetInterviewerByIdAsync(int id)
        {
            var result = await InterviewerRepositoryAsync.GetByIdAsync(id);
            if (result != null)
            {
                return new InterviewerResponseModel()
                {
                    Id = result.Id,
                    FirstName = result.FirstName,
                    LastName = result.LastName,
                    EmployeeId = result.EmployeeId
                };
            }
            return null;
        }

        public Task<int> UpdateInterviewerAsync(InterviewerRequestModel model)
        {
            Interviewer Interviewer = new Interviewer()
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                EmployeeId = model.EmployeeId
            };
            return InterviewerRepositoryAsync.UpdateAsync(Interviewer);
        }
    }
}

