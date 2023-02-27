using System;
using System.ComponentModel.DataAnnotations;

namespace HRM.Interview.ApplicationCore.Model.Response
{
	public class InterviewerResponseModel
	{
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmployeeId { get; set; }

        public InterviewerResponseModel()
		{
		}
	}
}

