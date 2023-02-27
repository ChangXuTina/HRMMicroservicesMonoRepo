using System;
using System.ComponentModel.DataAnnotations;

namespace HRM.Onboarding.ApplicationCore.Model.Response
{
	public class EmployeeCategoryResponseModel
	{
        public int Id { get; set; }
        public string Description { get; set; }

        public EmployeeCategoryResponseModel()
		{
		}
	}
}

