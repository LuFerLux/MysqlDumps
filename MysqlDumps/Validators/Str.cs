using System;
using System.Net;
using System.Text.RegularExpressions;

namespace Validators
{
    public class Str
    {
        public Str()
        {

        }

        public static bool Validate(string str)
        {

            return !string.IsNullOrEmpty(str);

        }

        internal static bool ValidateIP(string ip)
        {
            try
            {
                IPAddress IP = IPAddress.Parse(ip);
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}

