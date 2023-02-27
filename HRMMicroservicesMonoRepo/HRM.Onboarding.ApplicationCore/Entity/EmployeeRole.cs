using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Onboarding.ApplicationCore.Entity
{
	public class EmployeeRole
	{
		public int Id { get; set; }
        [Required, Column(TypeName = "varchar(25)")]
        public string Name { get; set; }
        [Required, Column(TypeName = "varchar(50)")]
        public string ABBR { get; set; }
		public EmployeeRole()
		{
		}
	}
}

