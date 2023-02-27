using System;
using System.ComponentModel.DataAnnotations;

namespace HRM.Interview.ApplicationCore.Model.Response
{
	public class InterviewFeedbackResponseModel
	{
        public int Id { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }

        public InterviewFeedbackResponseModel()
		{
		}
	}
}

