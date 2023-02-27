using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Onboarding.ApplicationCore.Entity
{
	public class Employee
	{
		public int Id { get; set; }
        [Required, Column(TypeName = "varchar(25)")]
        public string FirstName { get; set; }
        [Required, Column(TypeName = "varchar(25)")]
        public string LastName { get; set; }
		public string? MiddleName { get; set; }
        [Required, Column(TypeName = "varchar(10)")]
        public string SSN { get; set; }
        [Required]
        public DateTime HireDate { get; set; }
		public DateTime? EndDate { get; set; }

        [Required]
        public int EmployeeCategoryId { get; set; }
		public EmployeeCategory employeeCategory { get; set; }

        [Required]
        public int EmployeeStatusId { get; set; }
		public EmployeeStatus employeeStatus { get; set; }

        [Required, Column(TypeName = "varchar(50)")]
        public string Address { get; set; }
        [Required, Column(TypeName = "varchar(70)"), DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public int EmployeeRoleId { get; set; }
		public EmployeeRole employeeRole { get; set; }

		public Employee()
		{
		}
	}
}

