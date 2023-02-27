using System;
using HRM.Interview.ApplicationCore.Contract.Respository;
using HRM.Interview.ApplicationCore.Contract.Service;
using HRM.Interview.ApplicationCore.Entity;
using HRM.Interview.ApplicationCore.Model.Request;
using HRM.Interview.ApplicationCore.Model.Response;

namespace HRM.Interview.Infrastructure.Service
{
    public class SingleInterviewServiceAsync : ISingleInterviewServiceAsync
    {
        private readonly ISingleInterviewRepositoryAsync SingleInterviewRepositoryAsync;

        public SingleInterviewServiceAsync(ISingleInterviewRepositoryAsync _SingleInterviewRepositoryAsync)
        {
            SingleInterviewRepositoryAsync = _SingleInterviewRepositoryAsync;
        }

        public Task<int> AddSingleInterviewAsync(SingleInterviewRequestModel model)
        {
            SingleInterview singleInterview = new SingleInterview()
            {
                RecruiterId = model.RecruiterId,
                SubmissionId = model.SubmissionId,
                InterviewTypeId = model.InterviewTypeId,
                InterviewRound = model.InterviewRound,
                ScheduledOn = model.ScheduledOn,
                InterviewerId = model.InterviewerId,
                InterviewFeedbackId = model.InterviewFeedbackId
            };
            return SingleInterviewRepositoryAsync.InsertAsync(singleInterview);
        }

        public Task<int> DeleteSingleInterviewAsync(int id)
        {
            return SingleInterviewRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<SingleInterviewResponseModel>> GetAllSingleInterviewsAsync()
        {
            var result = await SingleInterviewRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(x => new SingleInterviewResponseModel()
                {
                    Id = x.Id,
                    RecruiterId = x.RecruiterId,
                    SubmissionId = x.SubmissionId,
                    InterviewTypeId = x.InterviewTypeId,
                    InterviewRound = x.InterviewRound,
                    ScheduledOn = x.ScheduledOn,
                    InterviewerId = x.InterviewerId,
                    InterviewFeedbackId = x.InterviewFeedbackId
                });
            }
            return null;
        }

        public async Task<SingleInterviewResponseModel> GetSingleInterviewByIdAsync(int id)
        {
            var result = await SingleInterviewRepositoryAsync.GetByIdAsync(id);
            if (result != null)
            {
                return new SingleInterviewResponseModel()
                {
                    Id = result.Id,
                    RecruiterId = result.RecruiterId,
                    SubmissionId = result.SubmissionId,
                    InterviewTypeId = result.InterviewTypeId,
                    InterviewRound = result.InterviewRound,
                    ScheduledOn = result.ScheduledOn,
                    InterviewerId = result.InterviewerId,
                    InterviewFeedbackId = result.InterviewFeedbackId
                };
            }
            return null;
        }

        public Task<int> UpdateSingleInterviewAsync(SingleInterviewRequestModel model)
        {
            SingleInterview SingleInterview = new SingleInterview()
            {
                Id = model.Id,
                RecruiterId = model.RecruiterId,
                SubmissionId = model.SubmissionId,
                InterviewTypeId = model.InterviewTypeId,
                InterviewRound = model.InterviewRound,
                ScheduledOn = model.ScheduledOn,
                InterviewerId = model.InterviewerId,
                InterviewFeedbackId = model.InterviewFeedbackId
            };
            return SingleInterviewRepositoryAsync.UpdateAsync(SingleInterview);
        }
    }
}

