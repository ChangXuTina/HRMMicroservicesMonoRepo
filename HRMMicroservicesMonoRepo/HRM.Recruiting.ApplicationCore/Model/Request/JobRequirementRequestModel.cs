using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Recruiting.ApplicationCore.Model.Request
{
	public class JobRequirementRequestModel
	{
        public int Id { get; set; }
        [Required(ErrorMessage = "NumberOfPositions is required")]
        public int NumberOfPositions { get; set; }
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
        public int? HiringManagerId { get; set; }
        public string? HiringManagerName { get; set; }
        [Required(ErrorMessage = "StartDate is required")]
        public DateTime StartDate { get; set; }
        [Required(ErrorMessage = "IsActive is required")]
        public bool IsActive { get; set; }
        public DateTime? ClosedOn { get; set; }
        public string? ClosedReason { get; set; }
        public DateTime CreatedOn { get; set; }
        [Required(ErrorMessage = "EmployeeType is required")]
        public int EmployeeType { get; set; }

        public JobRequirementRequestModel()
		{
		}
	}
}

