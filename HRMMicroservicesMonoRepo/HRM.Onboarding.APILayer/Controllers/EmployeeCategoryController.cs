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
    public class EmployeeCategoryController : ControllerBase
    {
        private readonly IEmployeeCategoryServiceAsync EmployeeCategoryServiceAsync;

        public EmployeeCategoryController(IEmployeeCategoryServiceAsync _EmployeeCategoryServiceAsync)
        {
            EmployeeCategoryServiceAsync = _EmployeeCategoryServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await EmployeeCategoryServiceAsync.GetAllEmployeeCategoriesAsync();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(EmployeeCategoryRequestModel model)
        {
            if (ModelState.IsValid)
            {
                await EmployeeCategoryServiceAsync.AddEmployeeCategoryAsync(model);
                return Ok();
            }
            return BadRequest(model);
        }

        [HttpPut]
        public async Task<IActionResult> Edit(EmployeeCategoryRequestModel model)
        {
            try
            {
                await EmployeeCategoryServiceAsync.UpdateEmployeeCategoryAsync(model);
                var updated = await EmployeeCategoryServiceAsync.GetEmployeeCategoryByIdAsync(model.Id);
                return Ok(updated);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(EmployeeCategoryResponseModel model)
        {
            await EmployeeCategoryServiceAsync.DeleteEmployeeCategoryAsync(model.Id);
            return NoContent();
        }

    }
}

