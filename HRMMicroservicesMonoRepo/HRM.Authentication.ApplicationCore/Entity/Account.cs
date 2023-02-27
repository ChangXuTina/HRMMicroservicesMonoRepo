using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Authentication.ApplicationCore.Entity
{
	public class Account
	{
		public int Id { get; set; }
		[Required]
		public int EmployeeId { get; set; }
        [Required, Column(TypeName = "varchar(70)"), DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, Column(TypeName = "varchar(25)")]
        public string FirstName { get; set; }
        [Required, Column(TypeName = "varchar(25)")]
        public string LastName { get; set; }
        [Required]
        public string HashPassword { get; set; }
        [Required]
        public string salt { get; set; }

		public Account()
		{
		}
	}
}

