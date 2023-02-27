using System;
using HRM.Interview.ApplicationCore.Model.Request;
using HRM.Interview.ApplicationCore.Model.Response;

namespace HRM.Interview.ApplicationCore.Contract.Service
{
	public interface IRecruiterServiceAsync
	{
        Task<int> AddRecruiterAsync(RecruiterRequestModel model);
        Task<int> UpdateRecruiterAsync(RecruiterRequestModel model);
        Task<int> DeleteRecruiterAsync(int id);
        Task<RecruiterResponseModel> GetRecruiterByIdAsync(int id);
        Task<IEnumerable<RecruiterResponseModel>> GetAllRecruitersAsync();

    }
}

