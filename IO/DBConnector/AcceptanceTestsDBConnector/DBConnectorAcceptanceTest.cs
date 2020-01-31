using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fit;
using Oracle.DataAccess.Client;
using fitSharp;

namespace Acceptance.Tests
{
    public class MyAcceptanceTests : ColumnFixture
    {
        public string FirstString;
        public string SecondString;

        public string Concatenate()
        {
            return FirstString + " " + SecondString;
        }

        private string test;

        public bool isBlank()
        {
            if (String.IsNullOrEmpty(test))
                return true;
            return false;
        }

        public string login;
        public string pass;

        public string StringCipherEncrypt()
        {
            return DB.StringCipher.Encrypt(login, pass);
        }

        public string StringCipherDecrypt()
        {
            return DB.StringCipher.Decrypt(DB.StringCipher.Encrypt(login, pass), pass);
        }

        public bool StringCipherEncryptThrow()
        {
            try
            {
                DB.StringCipher.Encrypt(login, pass);
            }
            catch
            {
                return true;
            }
            return false;
        }
    }
}