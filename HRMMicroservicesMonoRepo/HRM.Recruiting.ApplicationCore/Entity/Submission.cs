using System;
using System.ComponentModel.DataAnnotations;

namespace HRM.Recruiting.ApplicationCore.Entity
{
	public class Submission
	{
		public int Id { get; set; }

		[Required]
		public int JobRequirementId { get; set; }
		public JobRequirement JobRequirement { get; set; }

        [Required]
        public int CandidateId { get; set; }
		public Candidate Candidate { get; set; }

		public DateTime SubmittedOn { get; set; } = DateTime.Now;

        [Required]
        public int SubmissionStatusId { get; set; }
		public SubmissionStatus SubmissionStatus { get; set; }

		public DateTime? ConfirmedOn { get; set; }
		public DateTime? RejectedOn { get; set; }

		public Submission()
		{
		}
	}
}

