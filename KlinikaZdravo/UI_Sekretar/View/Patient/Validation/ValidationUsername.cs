using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Text.RegularExpressions;
using System.Windows.Controls;
namespace healthClinic.Validation

{
    class ValidationUsername : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            try
            {
                var s = value as string;
                Regex r = new Regex(@"^([A-Z]{1}[a-z]{1,30})$");
                if (r.IsMatch(s))
                {
                    return new ValidationResult(true, null);
                }
                return new ValidationResult(false, "Format unosa je 'Ime1'!");
            }
            catch
            {
                return new ValidationResult(false, "Greška. Molimo unesite ponovo!");
            }
        }
    }
}
