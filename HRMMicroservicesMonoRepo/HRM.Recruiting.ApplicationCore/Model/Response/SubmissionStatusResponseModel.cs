using System;
using System.ComponentModel.DataAnnotations;

namespace HRM.Recruiting.ApplicationCore.Model.Response
{
	public class SubmissionStatusResponseModel
	{
        public int Id { get; set; }
        public string Description { get; set; }

        public SubmissionStatusResponseModel()
		{
		}
	}
}

