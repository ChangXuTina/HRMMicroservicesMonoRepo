using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Recruiting.ApplicationCore.Model.Request
{
	public class SubmissionStatusRequestModel
	{
        public int Id { get; set; }
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        public SubmissionStatusRequestModel()
		{
		}
	}
}

