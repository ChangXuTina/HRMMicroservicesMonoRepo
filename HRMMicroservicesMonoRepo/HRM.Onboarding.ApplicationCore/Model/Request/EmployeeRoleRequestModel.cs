using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Onboarding.ApplicationCore.Model.Request
{
	public class EmployeeRoleRequestModel
	{
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "ABBR is required")]
        public string ABBR { get; set; }

        public EmployeeRoleRequestModel()
		{
		}
	}
}

