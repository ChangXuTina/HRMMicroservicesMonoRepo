using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRM.Recruiting.ApplicationCore.Contract.Service;
using HRM.Recruiting.ApplicationCore.Model.Request;
using HRM.Recruiting.ApplicationCore.Model.Response;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HRM.Recruiting.APILayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubmissionStatusController : ControllerBase
    {
        private readonly ISubmissionStatusServiceAsync SubmissionStatusServiceAsync;

        public SubmissionStatusController(ISubmissionStatusServiceAsync _SubmissionStatusServiceAsync)
        {
            SubmissionStatusServiceAsync = _SubmissionStatusServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await SubmissionStatusServiceAsync.GetAllSubmissionStatusAsync();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(SubmissionStatusRequestModel model)
        {
            if (ModelState.IsValid)
            {
                await SubmissionStatusServiceAsync.AddSubmissionStatusAsync(model);
                return Ok();
            }
            return BadRequest(model);
        }

        [HttpPut]
        public async Task<IActionResult> Edit(SubmissionStatusRequestModel model)
        {
            try
            {
                await SubmissionStatusServiceAsync.UpdateSubmissionStatusAsync(model);
                var updated = await SubmissionStatusServiceAsync.GetSubmissionStatusByIdAsync(model.Id);
                return Ok(updated);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(SubmissionStatusResponseModel model)
        {
            await SubmissionStatusServiceAsync.DeleteSubmissionStatusAsync(model.Id);
            return NoContent();
        }

    }
}

