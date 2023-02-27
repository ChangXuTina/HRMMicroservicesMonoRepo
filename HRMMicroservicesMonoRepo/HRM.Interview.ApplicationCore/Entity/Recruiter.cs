using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Interview.ApplicationCore.Entity
{
	public class Recruiter
	{
        public int Id { get; set; }
        [Required, Column(TypeName = "varchar(25)")]
        public string FirstName { get; set; }
        [Required, Column(TypeName = "varchar(25)")]
        public string LastName { get; set; }
        [Required]
        public int EmployeeId { get; set; }

        public Recruiter()
		{
		}
	}
}

