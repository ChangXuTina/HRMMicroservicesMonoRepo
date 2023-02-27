using System;
using HRM.Authentication.ApplicationCore.Entity;

namespace HRM.Authentication.ApplicationCore.Contract.Service
{
	public interface IAccountService
	{
        int AddAccount(Account account);
        int UpdateAccount(Account account);
        int DeleteAccount(int id);
        Account GetAccountById(int id);
        IEnumerable<Account> GetAllAccounts();

    }
}

