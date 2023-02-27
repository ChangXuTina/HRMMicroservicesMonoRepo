using System;
namespace HRM.Interview.ApplicationCore.Model.Response
{
	public class RecruiterResponseModel
	{
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmployeeId { get; set; }

        public RecruiterResponseModel()
		{
		}
	}
}

