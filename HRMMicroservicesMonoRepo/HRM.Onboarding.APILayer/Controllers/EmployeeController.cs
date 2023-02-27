using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRM.Onboarding.ApplicationCore.Contract.Service;
using HRM.Onboarding.ApplicationCore.Model.Request;
using HRM.Onboarding.ApplicationCore.Model.Response;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HRM.Onboarding.APILayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeServiceAsync EmployeeServiceAsync;

        public EmployeeController(IEmployeeServiceAsync _EmployeeServiceAsync)
        {
            EmployeeServiceAsync = _EmployeeServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await EmployeeServiceAsync.GetAllEmployeesAsync();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(EmployeeRequestModel model)
        {
            if (ModelState.IsValid)
            {
                await EmployeeServiceAsync.AddEmployeeAsync(model);
                return Ok();
            }
            return BadRequest(model);
        }

        [HttpPut]
        public async Task<IActionResult> Edit(EmployeeRequestModel model)
        {
            try
            {
                await EmployeeServiceAsync.UpdateEmployeeAsync(model);
                var updated = await EmployeeServiceAsync.GetEmployeeByIdAsync(model.Id);
                return Ok(updated);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(EmployeeResponseModel model)
        {
            await EmployeeServiceAsync.DeleteEmployeeAsync(model.Id);
            return NoContent();
        }

    }
}

