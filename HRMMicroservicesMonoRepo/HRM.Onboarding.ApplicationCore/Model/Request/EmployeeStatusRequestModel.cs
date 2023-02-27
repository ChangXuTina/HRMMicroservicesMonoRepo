using System;
using System.ComponentModel.DataAnnotations;

namespace HRM.Onboarding.ApplicationCore.Model.Request
{
	public class EmployeeStatusRequestModel
	{
        public int Id { get; set; }
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
        [Required(ErrorMessage = "ABBR is required")]
        public string ABBR { get; set; }

        public EmployeeStatusRequestModel()
		{
		}
	}
}

