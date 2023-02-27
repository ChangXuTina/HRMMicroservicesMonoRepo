using System;
using System.ComponentModel.DataAnnotations;

namespace HRM.Interview.ApplicationCore.Model.Response
{
	public class InterviewTypeResponseModel
	{
        public int Id { get; set; }
        public string Description { get; set; }

        public InterviewTypeResponseModel()
		{
		}
	}
}

