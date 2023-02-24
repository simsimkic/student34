using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace healthClinic.Validation
{
    public class ValidacijaImePrezime : ValidationRule

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
                return new ValidationResult(false, "Unos mora biti u formatu 'Ime' !");
            }
            catch
            {
                return new ValidationResult(false, "Greška!Pokušajte ponovo da unesete!");
            }
        }
    }
}
