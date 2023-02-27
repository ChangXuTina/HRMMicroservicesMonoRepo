using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Interview.ApplicationCore.Model.Request
{
	public class InterviewFeedbackRequestModel
	{
        public int Id { get; set; }
        [Required(ErrorMessage = "Rating is required")]
        public int Rating { get; set; }
        [Required(ErrorMessage = "Comment is required")]
        public string Comment { get; set; }

        public InterviewFeedbackRequestModel()
		{
		}
	}
}

