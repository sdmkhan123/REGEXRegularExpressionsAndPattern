using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace REGEXRegularExpressionsAndPattern
{
    public class ToCheckRegexPattern
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Function to check name is valid or not
        /// </summary>
        /// <param name="fName"></param>
        public static bool validName(string name)
        {
            string namePattern = @"^[A-Z]{1}[a-z]{3,}";
            //if name pattern is match
            return (Regex.IsMatch(name, namePattern));
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
