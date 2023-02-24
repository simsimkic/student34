using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace UI_sekretar
{
    class Validacija : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            try
            {
                var s = value as string;
                Regex r = new Regex("^[A-Z][a-zA-z]+$");
                if (r.IsMatch(s))
                {
                    return new ValidationResult(true, null);
                }
                return new ValidationResult(false, "Prvo slovo mora biti veliko!");
            }
            catch
            {
                return new ValidationResult(false, "Doslo je do nepoznate greške!");
            }
        }
    }
}

