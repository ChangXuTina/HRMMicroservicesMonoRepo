using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRM.Authentication.ApplicationCore.Contract.Service;
using HRM.Authentication.ApplicationCore.Entity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HRM.Authentication.APILayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService RoleService;

        public RoleController(IRoleService _RoleService)
        {
            RoleService = _RoleService;
        }

        [HttpGet]
        public Object Get()
        {
            var result = RoleService.GetAllRoles();
            return Ok(result);
        }

        [HttpPost]
        public Object Post(Role Role)
        {
            if (ModelState.IsValid)
            {
                RoleService.AddRole(Role);
                return Ok();
            }
            return BadRequest(Role);
        }

        [HttpPut]
        public Object Edit(Role Role)
        {
            try
            {
                var result = RoleService.UpdateRole(Role);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete]
        public Object Delete(Role Role)
        {
            RoleService.DeleteRole(Role.Id);
            return NoContent();
        }

    }
}

