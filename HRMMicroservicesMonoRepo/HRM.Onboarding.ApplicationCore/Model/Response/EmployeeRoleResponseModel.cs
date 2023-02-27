using System;
using System.ComponentModel.DataAnnotations;

namespace HRM.Onboarding.ApplicationCore.Model.Response
{
	public class EmployeeRoleResponseModel
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string ABBR { get; set; }

        public EmployeeRoleResponseModel()
		{
		}
	}
}

