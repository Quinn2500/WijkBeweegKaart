using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DataModels;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class AccountDatabaseCalls
    {
        private readonly DatabaseCalls _databaseCalls = new DatabaseCalls();

        public void RegisterUser(Employee employee, string password)
        {
            string query = "INSERT INTO `employee`(`Email`, `Password`, `Firstname`, `Prepesistion`, `Lastname`) VALUES (@pEmail,@pPassword,@pFirstName,@pPrepesistion,@pLastname)";
            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@pEmail", employee.Email),
                new MySqlParameter("@pPassword", password),
                new MySqlParameter("@pFirstName", employee.FirstName),
                new MySqlParameter("@pPrepesistion", employee.PrePesition),
                new MySqlParameter("@pLastname", employee.LastName)
            };
            _databaseCalls.Command(query, parameters);
        }

        public Employee GetEmployee(string email)
        {
            string query = "SELECT * FROM `employee` WHERE employee.Email = @pEmail";
            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@pEmail", email)
            };

            DataRow dataRow = _databaseCalls.Select(query, parameters).Rows[0];

            Employee employee = new Employee
            {
                Email = dataRow[0].ToString(),
                FirstName = dataRow[1].ToString(),
                PrePesition = dataRow[2].ToString(),
                LastName = dataRow[3].ToString()
            };

            return employee;
        }

        public string GetPasswordHash(string email)
        {
            string query = "SELECT `Password` FROM `employee` WHERE employee.Email = @pEmail";
            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@pEmail", email)
            };
            return _databaseCalls.GetOneString(query, parameters);
        }
    }
}
