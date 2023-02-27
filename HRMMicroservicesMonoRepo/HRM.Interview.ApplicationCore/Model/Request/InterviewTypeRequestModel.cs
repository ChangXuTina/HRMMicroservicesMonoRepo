using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Interview.ApplicationCore.Model.Request
{
	public class InterviewTypeRequestModel
	{
        public int Id { get; set; }
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        public InterviewTypeRequestModel()
		{
		}
	}
}

