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
    public class ValidacijaJMBG : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            try
            {
                var s = value as string;
                Regex r = new Regex(@"^(\d{13})?$");

                if (r.IsMatch(s))
                {
                    return new ValidationResult(true, null);
                }
                return new ValidationResult(false, "Unos JMBG zahteva 13 cifara.");
            }
            catch
            {
                return new ValidationResult(false, "Greška. Molimo pokušajte ponovo!");
            }
        }
    }
}
