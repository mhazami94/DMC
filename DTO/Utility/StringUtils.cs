using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DTO.Utility
{
    public static class StringUtils
    {
        public static bool IsMailAddress(this string email)
        {
            string pattern = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }
    }
}
