using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Authentication.ApplicationCore.Entity
{
	public class Role
	{
		public int Id { get; set; }
        [Required, Column(TypeName = "varchar(50)")]
        public string Name { get; set; }
        [Required, Column(TypeName = "varchar(50)")]
        public string Description { get; set; }
		public Role()
		{
		}
	}
}

