using System;
using System.Collections.Generic;
using System.Text;
using DataModels;
using DAL;

namespace Logic
{
    public class AccountLogic
    {
        private readonly AccountDatabaseCalls _databaseCalls = new AccountDatabaseCalls();
        public Employee LoginUser(string email, string password)
        {
            return BCrypt.Net.BCrypt.Verify(password, _databaseCalls.GetPasswordHash(email)) ? _databaseCalls.GetEmployee(email) : null;
        }

        public void RegisterEmployee(Employee employee, string password)
        {
            _databaseCalls.RegisterUser(employee, BCrypt.Net.BCrypt.HashPassword(password, BCrypt.Net.BCrypt.GenerateSalt()));
        }
    }
}
