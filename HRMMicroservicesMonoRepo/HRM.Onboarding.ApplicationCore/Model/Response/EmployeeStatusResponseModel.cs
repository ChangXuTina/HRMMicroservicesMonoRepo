using System;
namespace HRM.Onboarding.ApplicationCore.Model.Response
{
	public class EmployeeStatusResponseModel
	{
        public int Id { get; set; }
        public string Description { get; set; }
        public string ABBR { get; set; }

        public EmployeeStatusResponseModel()
		{
		}
	}
}

