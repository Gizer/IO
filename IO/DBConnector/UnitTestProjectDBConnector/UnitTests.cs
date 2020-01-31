using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DB;
using Moq;
using System.Collections.Generic;

namespace UnitTestProjectDBConnector
{
    [TestClass]
    public class DBConnectorTests
    {
        [TestMethod]
        public void StringCipher_Encrypt_IsNotNull()
        {
            List<string> parameters = new List<string> { "", "\b", "\n", "abc", "abc123", "123" };
            List<string> passPhrases = new List<string> { "", "\b", "\n", "abc", "abc123", "123" };
            string[,] resultsSet = new string[parameters.Count, passPhrases.Count];
            for (int i = 0; i < parameters.Count; i++)
                for (int j = 0; j < passPhrases.Count; j++)
                    resultsSet[i, j] = StringCipher.Encrypt(parameters[i], passPhrases[j]);

            bool nul = true;
            for (int i = 0; i < parameters.Count; i++)
                for (int j = 0; j < passPhrases.Count; j++)
                    if (!String.IsNullOrEmpty(resultsSet[i, j]))
                        nul = false;
                    else
                        nul = true;
            Assert.IsFalse(nul);
        }

        [TestMethod]
        public void StringCipher_Decrypt_IsNotNull()
        {
            List<string> parameters = new List<string> { "", "\b", "\n", "abc", "abc123", "123" };
            List<string> passPhrases = new List<string> { "", "\b", "\n", "abc", "abc123", "123" };
            string[,] passSet = new string[parameters.Count, passPhrases.Count];
            for (int i = 0; i < parameters.Count; i++)
                for (int j = 0; j < passPhrases.Count; j++)
                    passSet[i, j] = StringCipher.Encrypt(parameters[i], passPhrases[j]);

            string[,] resultsSet = new string[parameters.Count, passPhrases.Count];
            for (int i = 0; i < parameters.Count; i++)
                for (int j = 0; j < passPhrases.Count; j++)
                    resultsSet[i, j] = StringCipher.Decrypt(passSet[i, j], passPhrases[j]);

            bool nul = true;
            for (int i = 0; i < parameters.Count; i++)
                for (int j = 0; j < passPhrases.Count; j++)
                    if (!String.IsNullOrEmpty(resultsSet[i, j]))
                        nul = false;
                    else
                        nul = true;
            Assert.IsFalse(nul);
        }

        [TestMethod]
        public void StringCipher_Encrypt_ThrowOnNull1()
        {
            bool throws = false;
            try
            {
                StringCipher.Encrypt(null, "");
            }
            catch
            {
                throws = true;
            }
            Assert.IsTrue(throws);
        }

        [TestMethod]
        public void StringCipher_Encrypt_ThrowOnNull2()
        {
            bool throws = false;
            try
            {
                StringCipher.Encrypt(null, null);
            }
            catch
            {
                throws = true;
            }
            Assert.IsTrue(throws);
        }

        [TestMethod]
        public void StringCipher_Encrypt_ThrowOnNull3()
        {
            bool throws = false;
            try
            {
                StringCipher.Encrypt("", null);
            }
            catch
            {
                throws = true;
            }
            Assert.IsTrue(throws);
        }

        //[TestMethod]
        //public void Open_IsTrue()
        //{
        //    var mock = new Mock<DBConnector.IConnector>();
        //    mock.Setup(con => con.OracleConnection("User Id = kiero"/*StringCipher.Decrypt(Login,encString)*/ + "; Password = kierownik1"/*StringCipher.Decrypt(Pass, encString)*/ + "; Data Source = localhost;")).Returns(new Oracle.DataAccess.Client.OracleConnection());
        //    mock.Setup(con => con.Open()).Verifiable();
        //    DBConnector.Open(mock.Object);
        //}

        [TestMethod]
        public void SetLogin_NoThrow()
        {
            List<string> parameters = new List<string> { null, "", "\b", "\n", "abc", "abc123", "123" };
            bool noThrow = true;
            foreach (string param in parameters)
                try
                {
                    DBConnector.SetLogin(param);
                }
                catch
                {
                    noThrow = false;
                }
            Assert.IsTrue(noThrow);
        }

        [TestMethod]
        public void SetPass_NoThrow()
        {
            List<string> parameters = new List<string> { null, "", "\b", "\n", "abc", "abc123", "123" };
            bool noThrow = true;
            foreach (string param in parameters)
                try
                {
                    DBConnector.SetLogin(param);
                }
                catch
                {
                    noThrow = false;
                }
            Assert.IsTrue(noThrow);
        }

        //[TestMethod]
        //public void DisplayTable()
        //{
        //}
    }
}