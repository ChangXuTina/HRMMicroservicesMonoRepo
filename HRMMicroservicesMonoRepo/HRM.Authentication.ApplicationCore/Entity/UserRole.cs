using System;
using System.ComponentModel.DataAnnotations;

namespace HRM.Authentication.ApplicationCore.Entity
{
	public class UserRole
	{
		public int Id { get; set; }

		[Required]
		public int AccountId { get; set; }
		[Required]
		public int RoleId { get; set; }

		public Account Account { get; set; }
		public Role Role { get; set; }

		public UserRole()
		{
		}
	}
}

