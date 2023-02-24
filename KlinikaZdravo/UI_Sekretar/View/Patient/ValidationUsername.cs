using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Text.RegularExpressions;
using System.Windows.Controls;
namespace healthClinic
{
    class ValidationUsername : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            try
            {
                var s = value as string;
                Regex r = new Regex(@"^([a-z0-9.]+)$");
                if (r.IsMatch(s))
                {
                    return new ValidationResult(true, null);
                }
                return new ValidationResult(false, "Unos mora biti u formatu 'text1' !");
            }
            catch
            {
                return new ValidationResult(false, "Greška!Pokušajte ponovo da unesete!");
            }
        }
    }
}
