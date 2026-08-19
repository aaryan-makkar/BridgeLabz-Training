using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Email_Campaign_Engagement_Analyzer
{
    public static class EmailValidator
    {
        private const string EmailPattern =
            @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9-]+(\.[A-Za-z0-9-]+)+$";

        public static bool IsValid(string email)
        {
            return Regex.IsMatch(email, EmailPattern);
        }
    }
}
