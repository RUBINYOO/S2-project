//using System;
//using System.Collections.Generic;
//using System.Text;
//using Logic.Interfaces;
//using Logic.Models;
//using Microsoft.Extensions.Configuration;
//using MySql.Data.MySqlClient;

//namespace DAL
//{
//	public class AccountRepo /*: IAccountRepo*/
//	{
//		private readonly string _connectionString;

//		public AccountRepo(IConfiguration config)
//		{
//			_connectionString = config.GetConnectionString("DefaultConnection");
//		}

//		public Account GetAccountByEmail(string email)
//		{
//			if (string.IsNullOrEmpty(email))
//			{
//				return null;
//			}

//			using var conn = new MySql.Data.MySqlClient.MySqlConnection(_connectionString);
//			conn.Open();

//			string query = @"SELECT * FROM Account WHERE Email = @Email";
//			using var cmd = new MySqlCommand(query, conn);
//			using var reader = cmd.ExecuteReader();

//			while (!reader.Read())
//			{
//				return null;
//			}

//			return new Account
//			{
//				email,
//				reader.GetString("UserName"),
//				eader.GetString("Email"),
//				reader.GetString("Password"),
//				(Role)reader.GetInt32("RoleType")

//			}

//	}
//}
//}
