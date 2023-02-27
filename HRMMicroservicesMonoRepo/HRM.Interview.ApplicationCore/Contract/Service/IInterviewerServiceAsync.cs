using System;
using HRM.Interview.ApplicationCore.Model.Request;
using HRM.Interview.ApplicationCore.Model.Response;

namespace HRM.Interview.ApplicationCore.Contract.Service
{
	public interface IInterviewerServiceAsync
	{
        Task<int> AddInterviewerAsync(InterviewerRequestModel model);
        Task<int> UpdateInterviewerAsync(InterviewerRequestModel model);
        Task<int> DeleteInterviewerAsync(int id);
        Task<InterviewerResponseModel> GetInterviewerByIdAsync(int id);
        Task<IEnumerable<InterviewerResponseModel>> GetAllInterviewersAsync();

    }
}

