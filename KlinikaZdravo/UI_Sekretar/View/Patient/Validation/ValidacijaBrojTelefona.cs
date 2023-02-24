using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace healthClinic.Validation
{
     public class ValidacijaBrojTelefona : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            try
            {
                var s = value as string;
                Regex r = new Regex(@"^((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}$");//@"^((\(\d{3}\)?)|(\d{3}-))?\d{3}-\d{3}$");

                if (r.IsMatch(s))
                {
                    return new ValidationResult(true, null);
                }
                return new ValidationResult(false, "Unos broja telefona mora biti u sledećem formatu 064-567-9876");
            }
            catch
            {
                return new ValidationResult(false, "Greška. Molimo pokušajte ponovo!");
            }
        }
    }
}
