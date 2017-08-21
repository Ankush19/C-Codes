using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Day8
{
    class VerifyPhoneNumber
    {
        public void validate(string phone)
        {
            string pattern =  @"^\d{3}-\d{4}$";
            Regex r = new Regex(pattern,RegexOptions.IgnoreCase );
            Match m = r.Match(phone);
            if(m.Success)
            {
                Console.WriteLine("Valid pattern");

            }

            else
                Console.WriteLine("invalid");

            }
    }
}
