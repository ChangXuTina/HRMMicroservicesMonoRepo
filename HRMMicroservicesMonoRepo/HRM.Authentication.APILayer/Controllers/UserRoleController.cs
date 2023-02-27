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
    public class UserRoleController : ControllerBase
    {
        private readonly IUserRoleService UserRoleService;

        public UserRoleController(IUserRoleService _UserRoleService)
        {
            UserRoleService = _UserRoleService;
        }

        [HttpGet]
        public Object Get()
        {
            var result = UserRoleService.GetAllUserRoles();
            return Ok(result);
        }

        [HttpPost]
        public Object Post(UserRole UserRole)
        {
            if (ModelState.IsValid)
            {
                UserRoleService.AddUserRole(UserRole);
                return Ok();
            }
            return BadRequest(UserRole);
        }

        [HttpPut]
        public Object Edit(UserRole UserRole)
        {
            try
            {
                var result = UserRoleService.UpdateUserRole(UserRole);                
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete]
        public Object Delete(UserRole UserRole)
        {
            UserRoleService.DeleteUserRole(UserRole.Id);
            return NoContent();
        }

    }
}

