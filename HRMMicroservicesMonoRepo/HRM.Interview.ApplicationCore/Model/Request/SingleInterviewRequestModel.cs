using System;
using HRM.Interview.ApplicationCore.Entity;
using System.ComponentModel.DataAnnotations;

namespace HRM.Interview.ApplicationCore.Model.Request
{
	public class SingleInterviewRequestModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "RecruiterId is required")]
        public int RecruiterId { get; set; }
        [Required(ErrorMessage = "SubmissionId is required")]
        public int SubmissionId { get; set; }
        [Required(ErrorMessage = "InterviewTypeId is required")]
        public int InterviewTypeId { get; set; }
        [Required(ErrorMessage = "InterviewRound is required")]
        public int InterviewRound { get; set; }
        [Required(ErrorMessage = "ScheduledOn is required")]
        public DateTime ScheduledOn { get; set; }
        [Required(ErrorMessage = "InterviewerId is required")]
        public int InterviewerId { get; set; }
        public int? InterviewFeedbackId { get; set; }

        public SingleInterviewRequestModel()
		{
		}
	}
}

