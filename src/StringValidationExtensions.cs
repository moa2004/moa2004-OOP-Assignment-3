using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace src
{
    public static class StringValidationExtensions
    {
        extension(string value)
        {
            public bool IsValidEgyptianPhone()
            {
                if (string.IsNullOrWhiteSpace(value))
                    return false;
                return Regex.IsMatch(value, @"^(0|\+20)1[0125][0-9]{8}$");
            }
            public bool IsValidEgyptianNationalId()
            {
                if (string.IsNullOrWhiteSpace(value))
                    return false;
                return Regex.IsMatch(value, @"^[23][0-9]{13}$");
            }
        }
    }
}
