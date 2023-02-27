using System;
using HRM.Interview.ApplicationCore.Model.Request;
using HRM.Interview.ApplicationCore.Model.Response;

namespace HRM.Interview.ApplicationCore.Contract.Service
{
	public interface IInterviewFeedbackServiceAsync
	{
        Task<int> AddInterviewFeedbackAsync(InterviewFeedbackRequestModel model);
        Task<int> UpdateInterviewFeedbackAsync(InterviewFeedbackRequestModel model);
        Task<int> DeleteInterviewFeedbackAsync(int id);
        Task<InterviewFeedbackResponseModel> GetInterviewFeedbackByIdAsync(int id);
        Task<IEnumerable<InterviewFeedbackResponseModel>> GetAllInterviewFeedbackAsync();

    }
}

