using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace UI_sekretar
{
    class ValidacijaKorisnickoIme : ValidationRule
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
                return new ValidationResult(false, "Korisnicko ime moze sadrzati mala slova, brojeve i specijalni karakter \".\"!");
            }
            catch
            {
                return new ValidationResult(false, "Doslo je do nepoznate greške!");
            }
        }
    }
}