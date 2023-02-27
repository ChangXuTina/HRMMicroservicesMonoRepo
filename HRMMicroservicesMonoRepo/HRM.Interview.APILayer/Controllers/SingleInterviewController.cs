using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRM.Interview.ApplicationCore.Contract.Service;
using HRM.Interview.ApplicationCore.Model.Request;
using HRM.Interview.ApplicationCore.Model.Response;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HRM.Interview.APILayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SingleInterviewController : ControllerBase
    {
        private readonly ISingleInterviewServiceAsync SingleInterviewServiceAsync;

        public SingleInterviewController(ISingleInterviewServiceAsync _SingleInterviewServiceAsync)
        {
            SingleInterviewServiceAsync = _SingleInterviewServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await SingleInterviewServiceAsync.GetAllSingleInterviewsAsync();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(SingleInterviewRequestModel model)
        {
            if (ModelState.IsValid)
            {
                await SingleInterviewServiceAsync.AddSingleInterviewAsync(model);
                return Ok();
            }
            return BadRequest(model);
        }

        [HttpPut]
        public async Task<IActionResult> Edit(SingleInterviewRequestModel model)
        {
            try
            {
                await SingleInterviewServiceAsync.UpdateSingleInterviewAsync(model);
                var updated = await SingleInterviewServiceAsync.GetSingleInterviewByIdAsync(model.Id);
                return Ok(updated);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(SingleInterviewResponseModel model)
        {
            await SingleInterviewServiceAsync.DeleteSingleInterviewAsync(model.Id);
            return NoContent();
        }

    }
}

