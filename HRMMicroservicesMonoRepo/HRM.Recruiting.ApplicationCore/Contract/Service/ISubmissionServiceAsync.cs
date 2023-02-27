using System;
using HRM.Recruiting.ApplicationCore.Model.Request;
using HRM.Recruiting.ApplicationCore.Model.Response;

namespace HRM.Recruiting.ApplicationCore.Contract.Service
{
    public interface ISubmissionServiceAsync
    {
        Task<int> AddSubmissionAsync(SubmissionRequestModel model);
        Task<int> UpdateSubmissionAsync(SubmissionRequestModel model);
        Task<int> DeleteSubmissionAsync(int id);
        Task<SubmissionResponseModel> GetSubmissionByIdAsync(int id);
        Task<IEnumerable<SubmissionResponseModel>> GetAllSubmissionsAsync();
    }
}
