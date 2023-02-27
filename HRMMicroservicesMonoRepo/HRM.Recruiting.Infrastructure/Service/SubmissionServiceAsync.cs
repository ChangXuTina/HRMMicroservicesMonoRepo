using System;
using HRM.Recruiting.ApplicationCore.Contract.Repository;
using HRM.Recruiting.ApplicationCore.Contract.Service;
using HRM.Recruiting.ApplicationCore.Entity;
using HRM.Recruiting.ApplicationCore.Model.Request;
using HRM.Recruiting.ApplicationCore.Model.Response;

namespace HRM.Recruiting.Infrastructure.Service
{
    public class SubmissionServiceAsync : ISubmissionServiceAsync
    {
        private readonly ISubmissionRepositoryAsync submissionRepositoryAsync;

        public SubmissionServiceAsync(ISubmissionRepositoryAsync _submissionRepositoryAsync)
        {
            submissionRepositoryAsync = _submissionRepositoryAsync;
        }

        public async Task<int> AddSubmissionAsync(SubmissionRequestModel model)
        {
            Submission submission = new Submission()
            {                
                JobRequirementId = model.JobRequirementId,
                CandidateId = model.CandidateId,
                //SubmittedOn = model.SubmittedOn,
                SubmissionStatusId = model.SubmissionStatusId,
                ConfirmedOn = model.ConfirmedOn,
                RejectedOn = model.RejectedOn
            };
            return await submissionRepositoryAsync.InsertAsync(submission);
        }

        public Task<int> DeleteSubmissionAsync(int id)
        {
            return submissionRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<SubmissionResponseModel>> GetAllSubmissionsAsync()
        {
            var result = await submissionRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(x => new SubmissionResponseModel()
                {
                    Id = x.Id,
                    JobRequirementId = x.JobRequirementId,
                    CandidateId = x.CandidateId,
                    SubmittedOn = x.SubmittedOn,
                    SubmissionStatusId = x.SubmissionStatusId,
                    ConfirmedOn = x.ConfirmedOn,
                    RejectedOn = x.RejectedOn
                });
            }
            return null;
        }

        public async Task<SubmissionResponseModel> GetSubmissionByIdAsync(int id)
        {
            var result = await submissionRepositoryAsync.GetByIdAsync(id);
            if (result != null)
            {
                return new SubmissionResponseModel()
                {
                    Id = result.Id,
                    JobRequirementId = result.JobRequirementId,
                    CandidateId = result.CandidateId,
                    SubmittedOn = result.SubmittedOn,
                    SubmissionStatusId = result.SubmissionStatusId,
                    ConfirmedOn = result.ConfirmedOn,
                    RejectedOn = result.RejectedOn
                };
            }
            return null;
        }

        public Task<int> UpdateSubmissionAsync(SubmissionRequestModel model)
        {
            Submission submission = new Submission()
            {
                Id = model.Id,
                JobRequirementId = model.JobRequirementId,
                CandidateId = model.CandidateId,
                SubmittedOn = model.SubmittedOn,
                SubmissionStatusId = model.SubmissionStatusId,
                ConfirmedOn = model.ConfirmedOn,
                RejectedOn = model.RejectedOn
            };
            return submissionRepositoryAsync.UpdateAsync(submission);
        }

    }
}

