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
    public class InterviewFeedbackController : ControllerBase
    {
        private readonly IInterviewFeedbackServiceAsync InterviewFeedbackServiceAsync;

        public InterviewFeedbackController(IInterviewFeedbackServiceAsync _InterviewFeedbackServiceAsync)
        {
            InterviewFeedbackServiceAsync = _InterviewFeedbackServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await InterviewFeedbackServiceAsync.GetAllInterviewFeedbackAsync();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(InterviewFeedbackRequestModel model)
        {
            if (ModelState.IsValid)
            {
                await InterviewFeedbackServiceAsync.AddInterviewFeedbackAsync(model);
                return Ok();
            }
            return BadRequest(model);
        }

        [HttpPut]
        public async Task<IActionResult> Edit(InterviewFeedbackRequestModel model)
        {
            try
            {
                await InterviewFeedbackServiceAsync.UpdateInterviewFeedbackAsync(model);
                var updated = await InterviewFeedbackServiceAsync.GetInterviewFeedbackByIdAsync(model.Id);
                return Ok(updated);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(InterviewFeedbackResponseModel model)
        {
            await InterviewFeedbackServiceAsync.DeleteInterviewFeedbackAsync(model.Id);
            return NoContent();
        }

    }
}

