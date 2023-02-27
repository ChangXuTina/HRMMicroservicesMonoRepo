using System;
using HRM.Interview.ApplicationCore.Model.Request;
using HRM.Interview.ApplicationCore.Model.Response;

namespace HRM.Interview.ApplicationCore.Contract.Service
{
	public interface ISingleInterviewServiceAsync
    {
        Task<int> AddSingleInterviewAsync(SingleInterviewRequestModel model);
        Task<int> UpdateSingleInterviewAsync(SingleInterviewRequestModel model);
        Task<int> DeleteSingleInterviewAsync(int id);
        Task<SingleInterviewResponseModel> GetSingleInterviewByIdAsync(int id);
        Task<IEnumerable<SingleInterviewResponseModel>> GetAllSingleInterviewsAsync();

    }
}

