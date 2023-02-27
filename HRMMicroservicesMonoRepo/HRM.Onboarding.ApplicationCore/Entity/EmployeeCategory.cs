using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Onboarding.ApplicationCore.Entity
{
	public class EmployeeCategory
	{
        public int Id { get; set; }
        [Required, Column(TypeName = "varchar(250)")]
        public string Description { get; set; }
        public EmployeeCategory()
		{
		}
	}
}

