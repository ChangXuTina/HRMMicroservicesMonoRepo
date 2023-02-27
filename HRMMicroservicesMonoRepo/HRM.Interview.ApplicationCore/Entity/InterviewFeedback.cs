using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Interview.ApplicationCore.Entity
{
	public class InterviewFeedback
	{
		public int Id { get; set; }
        [Required, Column(TypeName = "varchar(5)")]
        public int Rating { get; set; }
        [Required, Column(TypeName = "varchar(250)")]
        public string Comment { get; set; }
		public InterviewFeedback()
		{
		}
	}
}

