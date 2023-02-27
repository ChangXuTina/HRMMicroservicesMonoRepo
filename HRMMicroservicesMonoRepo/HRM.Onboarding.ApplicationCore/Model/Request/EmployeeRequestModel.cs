using System;
using HRM.Onboarding.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Onboarding.ApplicationCore.Model.Request
{
	public class EmployeeRequestModel
	{
        public int Id { get; set; }
        [Required(ErrorMessage = "FirstName is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName is required")]
        public string LastName { get; set; }
        public string? MiddleName { get; set; }
        [Required(ErrorMessage = "SSN is required")]
        public string SSN { get; set; }
        [Required(ErrorMessage = "HireDate is required")]
        public DateTime HireDate { get; set; }
        public DateTime? EndDate { get; set; }
        [Required(ErrorMessage = "EmployeeCategoryId is required")]
        public int EmployeeCategoryId { get; set; }
        [Required(ErrorMessage = "EmployeeStatusId is required")]
        public int EmployeeStatusId { get; set; }
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "EmployeeRoleId is required")]
        public int EmployeeRoleId { get; set; }

        public EmployeeRequestModel()
		{
		}
	}
}

