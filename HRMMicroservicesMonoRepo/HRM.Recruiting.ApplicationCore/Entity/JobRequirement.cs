using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Recruiting.ApplicationCore.Entity
{
	public class JobRequirement
	{
		public int Id { get; set; }
        [Required]
        public int NumberOfPositions { get; set; }
        [Required, Column(TypeName = "varchar(25)")]
        public string Title { get; set; }
        [Required, Column(TypeName = "varchar(150)")]
        public string Description { get; set; }
		public int? HiringManagerId { get; set; }
		public string? HiringManagerName { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public bool IsActive { get; set; }
		public DateTime? ClosedOn { get; set; }
		public string? ClosedReason { get; set; }
		public DateTime CreatedOn { get; set; } = DateTime.Now;
        [Required]
        public string EmployeeType { get; set; }

        public JobRequirement()
		{
		}
	}
}

