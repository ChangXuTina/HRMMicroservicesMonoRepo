﻿using System;
using System.ComponentModel.DataAnnotations;

namespace HRM.Recruiting.ApplicationCore.Model.Response
{
	public class CandidateResponseModel
	{
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string? ResumeURL { get; set; }

        public CandidateResponseModel()
		{
		}
	}
}

