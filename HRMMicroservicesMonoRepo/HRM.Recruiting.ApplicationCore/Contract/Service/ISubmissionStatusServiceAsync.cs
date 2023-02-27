using System;
using HRM.Recruiting.ApplicationCore.Model.Request;
using HRM.Recruiting.ApplicationCore.Model.Response;

namespace HRM.Recruiting.ApplicationCore.Contract.Service
{
	public interface ISubmissionStatusServiceAsync
	{
        Task<int> AddSubmissionStatusAsync(SubmissionStatusRequestModel model);
        Task<int> UpdateSubmissionStatusAsync(SubmissionStatusRequestModel model);
        Task<int> DeleteSubmissionStatusAsync(int id);
        Task<SubmissionStatusResponseModel> GetSubmissionStatusByIdAsync(int id);
        Task<IEnumerable<SubmissionStatusResponseModel>> GetAllSubmissionStatusAsync();

    }
}

