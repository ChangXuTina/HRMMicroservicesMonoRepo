using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Recruiting.ApplicationCore.Entity
{
	public class SubmissionStatus
	{
		public int Id { get; set; }
        [Required, Column(TypeName = "varchar(250)")]
        public string Description { get; set; }
		public SubmissionStatus()
		{
		}
	}
}

