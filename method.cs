using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class method
    {
        public DateTime loginfate;
        public string username;

        public static Boolean id_number_iscorrect(string idnumber) // use ID number is correct or Incorrect.
        {
            if (idnumber.Length == 12 && idnumber.All(char.IsDigit)) // <-- for new ID numbers
            {
                return true; //if all characters are numbers and length of numbers are 12..
            }
            else if (idnumber.Length == 10 && idnumber.EndsWith("V", StringComparison.OrdinalIgnoreCase) && idnumber.Substring(0, 9).All(char.IsDigit)) // cheack last latter is "v" or "V" 
            {//<---- for old ID numbers
                return true;
            }
            else 
            {
                return false; 
            }

        }

        public static bool IsStrongPassword(string password)
        {
            // Criteria 1: Minimum length of 8 characters
            if (password.Length < 8)
            {
                return false;
            }
            // Criteria 2: Contains at least one uppercase letter
            if (!password.Any(char.IsUpper))
            {
                return false;
            }
            // Criteria 3: Contains at least one lowercase letter
            if (!password.Any(char.IsLower))
            {
                return false;
            }
            // Criteria 4: Contains at least one digit
            if (!password.Any(char.IsDigit))
            {
                return false;
            }
            // Criteria 5: Contains at least one special character (e.g., asterisk *)
            if (!password.Any(c => !char.IsLetterOrDigit(c)))
            {
                return false;
            }
            // All criteria passed, so the password is strong
            return true;
        }

        public static bool CheackeIsEquil(string one, string two)
        {
            if (one == two)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
