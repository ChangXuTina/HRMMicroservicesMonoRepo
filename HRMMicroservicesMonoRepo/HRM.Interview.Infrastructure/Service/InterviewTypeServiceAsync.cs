using System;
using HRM.Interview.ApplicationCore.Contract.Respository;
using HRM.Interview.ApplicationCore.Contract.Service;
using HRM.Interview.ApplicationCore.Entity;
using HRM.Interview.ApplicationCore.Model.Request;
using HRM.Interview.ApplicationCore.Model.Response;

namespace HRM.Interview.Infrastructure.Service
{
    public class InterviewTypeServiceAsync : IInterviewTypeServiceAsync
    {
        private readonly IInterviewTypeRepositoryAsync InterviewTypeRepositoryAsync;

        public InterviewTypeServiceAsync(IInterviewTypeRepositoryAsync _InterviewTypeRepositoryAsync)
        {
            InterviewTypeRepositoryAsync = _InterviewTypeRepositoryAsync;
        }

        public Task<int> AddInterviewTypeAsync(InterviewTypeRequestModel model)
        {
            InterviewType interviewType = new InterviewType()
            {
                Description = model.Description
            };
            return InterviewTypeRepositoryAsync.InsertAsync(interviewType);
        }

        public Task<int> DeleteInterviewTypeAsync(int id)
        {
            return InterviewTypeRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<InterviewTypeResponseModel>> GetAllInterviewTypesAsync()
        {
            var result = await InterviewTypeRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(x => new InterviewTypeResponseModel()
                {
                    Id = x.Id,
                    Description = x.Description
                });
            }
            return null;
        }

        public async Task<InterviewTypeResponseModel> GetInterviewTypeByIdAsync(int id)
        {
            var result = await InterviewTypeRepositoryAsync.GetByIdAsync(id);
            if (result != null)
            {
                return new InterviewTypeResponseModel()
                {
                    Id = result.Id,
                    Description = result.Description
                };
            }
            return null;
        }

        public Task<int> UpdateInterviewTypeAsync(InterviewTypeRequestModel model)
        {
            InterviewType InterviewType = new InterviewType()
            {
                Id = model.Id,
                Description = model.Description
            };
            return InterviewTypeRepositoryAsync.UpdateAsync(InterviewType);
        }
    }
}

