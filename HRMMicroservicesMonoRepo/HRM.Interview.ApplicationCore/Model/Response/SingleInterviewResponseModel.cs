using System;
using System.ComponentModel.DataAnnotations;

namespace HRM.Interview.ApplicationCore.Model.Response
{
	public class SingleInterviewResponseModel
    {
        public int Id { get; set; }
        public int RecruiterId { get; set; }
        public int SubmissionId { get; set; }
        public int InterviewTypeId { get; set; }
        public int InterviewRound { get; set; }
        public DateTime ScheduledOn { get; set; }
        public int InterviewerId { get; set; }
        public int? InterviewFeedbackId { get; set; }

        public SingleInterviewResponseModel()
		{
		}
	}
}

