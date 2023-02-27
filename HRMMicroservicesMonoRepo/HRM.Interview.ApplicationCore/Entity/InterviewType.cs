﻿using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Interview.ApplicationCore.Entity
{
	public class InterviewType
	{
		public int Id { get; set; }
        [Required, Column(TypeName = "varchar(50)")]
        public string Description { get; set; }
		public InterviewType()
		{
		}
	}
}

