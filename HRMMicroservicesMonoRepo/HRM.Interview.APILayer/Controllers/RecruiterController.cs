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
    public class RecruiterController : ControllerBase
    {
        private readonly IRecruiterServiceAsync RecruiterServiceAsync;

        public RecruiterController(IRecruiterServiceAsync _RecruiterServiceAsync)
        {
            RecruiterServiceAsync = _RecruiterServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await RecruiterServiceAsync.GetAllRecruitersAsync();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(RecruiterRequestModel model)
        {
            if (ModelState.IsValid)
            {
                await RecruiterServiceAsync.AddRecruiterAsync(model);
                return Ok();
            }
            return BadRequest(model);
        }

        [HttpPut]
        public async Task<IActionResult> Edit(RecruiterRequestModel model)
        {
            try
            {
                await RecruiterServiceAsync.UpdateRecruiterAsync(model);
                var updated = await RecruiterServiceAsync.GetRecruiterByIdAsync(model.Id);
                return Ok(updated);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(RecruiterResponseModel model)
        {
            await RecruiterServiceAsync.DeleteRecruiterAsync(model.Id);
            return NoContent();
        }

    }
}

