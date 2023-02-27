using System;
using HRM.Interview.ApplicationCore.Contract.Respository;
using HRM.Interview.ApplicationCore.Contract.Service;
using HRM.Interview.ApplicationCore.Entity;
using HRM.Interview.ApplicationCore.Model.Request;
using HRM.Interview.ApplicationCore.Model.Response;

namespace HRM.Interview.Infrastructure.Service
{
    public class InterviewFeedbackServiceAsync : IInterviewFeedbackServiceAsync
    {
        private readonly IInterviewFeedbackRepositoryAsync InterviewFeedbackRepositoryAsync;

        public InterviewFeedbackServiceAsync(IInterviewFeedbackRepositoryAsync _InterviewFeedbackRepositoryAsync)
        {
            InterviewFeedbackRepositoryAsync = _InterviewFeedbackRepositoryAsync;
        }

        public Task<int> AddInterviewFeedbackAsync(InterviewFeedbackRequestModel model)
        {
            InterviewFeedback InterviewFeedback = new InterviewFeedback()
            {
                Rating = model.Rating,
                Comment = model.Comment
            };
            return InterviewFeedbackRepositoryAsync.InsertAsync(InterviewFeedback);
        }

        public Task<int> DeleteInterviewFeedbackAsync(int id)
        {
            return InterviewFeedbackRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<InterviewFeedbackResponseModel>> GetAllInterviewFeedbackAsync()
        {
            var result = await InterviewFeedbackRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(x => new InterviewFeedbackResponseModel()
                {
                    Id = x.Id,
                    Rating = x.Rating,
                    Comment = x.Comment

                });
            }
            return null;
        }

        public async Task<InterviewFeedbackResponseModel> GetInterviewFeedbackByIdAsync(int id)
        {
            var result = await InterviewFeedbackRepositoryAsync.GetByIdAsync(id);
            if (result != null)
            {
                return new InterviewFeedbackResponseModel()
                {
                    Id = result.Id,
                    Rating = result.Rating,
                    Comment = result.Comment
                };
            }
            return null;
        }

        public Task<int> UpdateInterviewFeedbackAsync(InterviewFeedbackRequestModel model)
        {
            InterviewFeedback InterviewFeedback = new InterviewFeedback()
            {
                Id = model.Id,
                Rating = model.Rating,
                Comment = model.Comment
            };
            return InterviewFeedbackRepositoryAsync.UpdateAsync(InterviewFeedback);
        }
    }
}

