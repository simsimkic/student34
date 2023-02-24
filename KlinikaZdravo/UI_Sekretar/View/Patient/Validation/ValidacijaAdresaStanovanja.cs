using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace healthClinic.Validation
{
    class ValidacijaAdresaStanovanja : ValidationRule
    {   
        
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            try
            {
                var s = value as string;
                Regex r = new Regex(@"^([A-Z][a-zA-z ]+)+([ 0-9,_]+)+([A-Z][a-zA-z ]+)$");
                if (r.IsMatch(s))
                {
                    return new ValidationResult(true, null);
                }
                return new ValidationResult(false, "Unos mora biti u formatu 'Novi Sad 11 Srbija' !");
            }
            catch
            {
                return new ValidationResult(false, "Greška!Pokušajte ponovo da unesete!");
            }
        }
    }
}
