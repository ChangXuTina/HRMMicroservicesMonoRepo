using System;
using HRM.Recruiting.ApplicationCore.Entity;
using System.ComponentModel.DataAnnotations;

namespace HRM.Recruiting.ApplicationCore.Model.Request
{
	public class SubmissionRequestModel
	{
        public int Id { get; set; }
        [Required(ErrorMessage = "JobRequirementId is required")]
        public int JobRequirementId { get; set; }
        [Required(ErrorMessage = "CandidateId is required")]
        public int CandidateId { get; set; }
        public DateTime SubmittedOn { get; set; }
        [Required(ErrorMessage = "SubmissionStatusId is required")]
        public int SubmissionStatusId { get; set; }
        public DateTime? ConfirmedOn { get; set; }
        public DateTime? RejectedOn { get; set; }

        public SubmissionRequestModel()
		{
		}
	}
}

