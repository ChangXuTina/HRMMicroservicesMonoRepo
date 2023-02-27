using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HRM.Recruiting.ApplicationCore.Entity
{
	[Index(nameof(Email), IsUnique = true)]
	public class Candidate
	{
		public int Id { get; set; }
		[Required, Column(TypeName = "varchar(25)")]
		public string FirstName { get; set; }
		public string? MiddleName { get; set; }
        [Required, Column(TypeName = "varchar(25)")]
        public string LastName { get; set; }
        [Required, Column(TypeName = "varchar(150)"), DataType(DataType.EmailAddress)]
        public string Email { get; set; }
		public string? ResumeURL { get; set; }

		public Candidate()
		{
		}
	}
}

