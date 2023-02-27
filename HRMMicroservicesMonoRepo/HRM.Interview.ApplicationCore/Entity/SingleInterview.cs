using System;
using System.ComponentModel.DataAnnotations;

namespace HRM.Interview.ApplicationCore.Entity
{
	public class SingleInterview
	{
		public int Id { get; set; }

		[Required]
		public int RecruiterId { get; set; }
		public Recruiter recruiter { get; set; }

        [Required]
        public int SubmissionId { get; set; }

        [Required]
        public int InterviewTypeId { get; set; }
		public InterviewType interviewType { get; set; }

        [Required]
        public int InterviewRound { get; set; }
        [Required]
        public DateTime ScheduledOn { get; set; }

        [Required]
        public int InterviewerId { get; set; }
		public Interviewer interviewer { get; set; }

        public int? InterviewFeedbackId { get; set; }
		public InterviewFeedback? interviewFeedback { get; set; }

		public SingleInterview()
		{
		}
	}
}

