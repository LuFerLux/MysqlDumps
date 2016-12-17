using System;

namespace MysqlDumps.Validators
{
    public class String
    {
        public String()
        {

        }

        public static bool Validate(string str)
        {

            return string.IsNullOrEmpty(str);

        }



    }
}

