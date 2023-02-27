using System;
using HRM.Authentication.ApplicationCore.Contract.Repository;
using HRM.Authentication.ApplicationCore.Contract.Service;
using HRM.Authentication.ApplicationCore.Entity;
using HRM.Authentication.Infrastructure.Respository;

namespace HRM.Authentication.Infrastructure.Service
{
	public class AccountService: IAccountService
    {
        private readonly IAccountRepository accountRepository;

        public AccountService(IAccountRepository _accountRepository)
		{
            accountRepository = _accountRepository;
        }

        public int AddAccount(Account account)
        {
            return accountRepository.Insert(account);
        }

        public int DeleteAccount(int id)
        {
            return accountRepository.Delete(id);
        }

        public Account GetAccountById(int id)
        {
            return accountRepository.GetById(id);
        }

        public IEnumerable<Account> GetAllAccounts()
        {
            return accountRepository.GetAll();
        }

        public int UpdateAccount(Account account)
        {
            return accountRepository.Update(account);
        }
    }
}

