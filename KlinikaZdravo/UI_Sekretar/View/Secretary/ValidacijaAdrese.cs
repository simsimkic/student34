using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace UI_sekretar
{
    class ValidacijaAdrese : ValidationRule
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
                return new ValidationResult(false, "Adresa treba da bude oblika: Ulica broj, Grad!");
            }
            catch
            {
                return new ValidationResult(false, "Doslo je do nepoznate greške!");
            }

        }
    }
}
