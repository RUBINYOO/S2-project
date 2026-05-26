using System;
using System.Collections.Generic;
using System.Text;
using Logic.Interfaces;
using Logic.Models;

namespace Logic.Services
{
	public class AccountService
	{
		IAccountRepo accountRepo;
		public AccountService(IAccountRepo accountRepo)
		{
			this.accountRepo = accountRepo;
		}

		public Account GetAccountByEmail(string email)
		{
			return accountRepo.GetAccountByEmail(email);
		}
	}
}
