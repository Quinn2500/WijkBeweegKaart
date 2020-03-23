using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
             MySqlConnection _msConn = new MySqlConnection("Server=localhost; database=eendbtest; UID=root; password=; Sslmode=none; port=3308;");

            try
            {
                _msConn.Open();
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                _msConn.Close();
            }
        }
    }
}
