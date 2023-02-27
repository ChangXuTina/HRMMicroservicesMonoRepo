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
    public class AccountController : ControllerBase
    {
        private readonly IAccountService AccountService;

        public AccountController(IAccountService _AccountService)
        {
            AccountService = _AccountService;
        }

        [HttpGet]
        public Object Get()
        {
            var result = AccountService.GetAllAccounts();
            return Ok(result);
        }

        [HttpPost]
        public Object Post(Account account)
        {
            if (ModelState.IsValid)
            {
                AccountService.AddAccount(account);
                return Ok();
            }
            return BadRequest(account);
        }

        [HttpPut]
        public Object Edit(Account account)
        {
            try
            {
                var result = AccountService.UpdateAccount(account);
                //var updated = AccountService.GetAccountById(account.Id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete]
        public Object Delete(Account account)
        {
            AccountService.DeleteAccount(account.Id);
            return NoContent();
        }

    }
}

