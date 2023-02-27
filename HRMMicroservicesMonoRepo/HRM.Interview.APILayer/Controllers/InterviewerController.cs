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
    public class InterviewerController : ControllerBase
    {
        private readonly IInterviewerServiceAsync InterviewerServiceAsync;

        public InterviewerController(IInterviewerServiceAsync _InterviewerServiceAsync)
        {
            InterviewerServiceAsync = _InterviewerServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await InterviewerServiceAsync.GetAllInterviewersAsync();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(InterviewerRequestModel model)
        {
            if (ModelState.IsValid)
            {
                await InterviewerServiceAsync.AddInterviewerAsync(model);
                return Ok();
            }
            return BadRequest(model);
        }

        [HttpPut]
        public async Task<IActionResult> Edit(InterviewerRequestModel model)
        {
            try
            {
                await InterviewerServiceAsync.UpdateInterviewerAsync(model);
                var updated = await InterviewerServiceAsync.GetInterviewerByIdAsync(model.Id);
                return Ok(updated);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(InterviewerResponseModel model)
        {
            await InterviewerServiceAsync.DeleteInterviewerAsync(model.Id);
            return NoContent();
        }

    }
}

