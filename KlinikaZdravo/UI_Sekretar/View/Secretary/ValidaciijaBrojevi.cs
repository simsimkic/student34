using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace UI_sekretar
{
    class ValidaciijaBrojevi : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            try
            {
                var s = value as string;
                Regex r = new Regex("^[0-9_]+$");
                if (r.IsMatch(s))
                {
                    return new ValidationResult(true, null);
                }
                return new ValidationResult(false, "Dozvoljen je samo unos brojeva!");
            }
            catch
            {
                return new ValidationResult(false, "Doslo je do nepoznate greške!");
            }
        }
    }
}
