using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class CalculatorModel : CalculatorLibrary.IAgeCalculator
    {
        public int CalculateAge(DateTime dateOfBirth)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dateOfBirth.Year;
            if ((today.Month < dateOfBirth.Month) || (today.Month == dateOfBirth.Month && today.Day < dateOfBirth.Day))
            {
                age--;
            }
            return age;
        }

        public bool ParseInput(string input, out DateTime result)
        {
            
            DateTime parseResult;
            if(input != null)
            {
                Regex rgx = new Regex(@"^\d{2}-\d{2}-\d{4}$");
                if (rgx.IsMatch(input))
                {
                    if (DateTime.TryParseExact(input.Replace('-', '/'), "d", new System.Globalization.CultureInfo("fr-FR", true), System.Globalization.DateTimeStyles.None, out parseResult))
                    {
                        result = parseResult;
                        return true;
                    }
                }
            }
            
            result = new DateTime();
            return false;
            
            
        }
    }
}
