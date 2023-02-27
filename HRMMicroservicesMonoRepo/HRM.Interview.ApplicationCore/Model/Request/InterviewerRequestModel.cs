using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Interview.ApplicationCore.Model.Request
{
	public class InterviewerRequestModel
	{
        public int Id { get; set; }
        [Required(ErrorMessage = "FirstName is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "EmployeeId is required")]
        public int EmployeeId { get; set; }

        public InterviewerRequestModel()
		{
		}
	}
}

