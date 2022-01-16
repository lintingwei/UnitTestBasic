using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestBasic
{
    public class SkaLegacyCode
    {
        public bool VerifyPassword(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return false;
            }

            var dt = MainDb.GetPasswordBy(username);

            if (dt == null || dt.Rows.Count != 1)
            {
                return false;
            }

            var dbPassword = dt.Rows[0]["password"].ToString();

            return !string.IsNullOrEmpty(dbPassword) && dbPassword.Equals(password);
        }
    }
}
