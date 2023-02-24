using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Aplikacija.Commands
{
    public static class RoutedCommands
    {
        public static readonly RoutedUICommand DodajZaposlenog = new RoutedUICommand(
           "Dodaj Zaposlenog",
           "DodajZaposlenog",
           typeof(RoutedCommands)
           );
        public static readonly RoutedUICommand IzbrisiZaposlenog = new RoutedUICommand(
          "Izbrisi Zaposlenog",
          "IzbrisiZaposlenog",
          typeof(RoutedCommands)
          );
        public static readonly RoutedUICommand IzmeniZaposlenog = new RoutedUICommand(
          "Izmeni Zaposlenog",
          "IzmeniZaposlenog",
          typeof(RoutedCommands)
          );

        public static readonly RoutedUICommand SnimiZaposlenog = new RoutedUICommand(
           "Snimi Zaposlenog",
           "SnimiZaposlenog",
           typeof(RoutedCommands)
           );

        public static readonly RoutedUICommand OdustaniZaposlenog = new RoutedUICommand(
           "Odustani Zaposlenog",
           "OdustaniZaposlenog",
           typeof(RoutedCommands)
           );

        public static readonly RoutedUICommand DodajLijek = new RoutedUICommand(
           "Dodaj Lijek",
           "DodajLijek",
           typeof(RoutedCommands)
           );
        public static readonly RoutedUICommand IzbrisiLijek = new RoutedUICommand(
          "Izbrisi Lijek",
          "IzbrisiLijek",
          typeof(RoutedCommands)
          );
        public static readonly RoutedUICommand IzmeniLijek = new RoutedUICommand(
          "Izmijeni Lijek",
          "IzmijeniLijek",
          typeof(RoutedCommands)
          );

        public static readonly RoutedUICommand SnimiLijek = new RoutedUICommand(
           "Snimi Lijek",
           "SnimiLijek",
           typeof(RoutedCommands)
           );

        public static readonly RoutedUICommand OdustaniLijek = new RoutedUICommand(
           "OdustaniLijek",
           "OdustaniLijek",
           typeof(RoutedCommands)
           );
        public static readonly RoutedUICommand NabaviLijek = new RoutedUICommand(
        "Nabavi Lijek",
        "NabaviLijek",
        typeof(RoutedCommands)
        );
        public static readonly RoutedUICommand DodajPregled = new RoutedUICommand(
          "Dodaj Pregled",
          "DodajPregled",
          typeof(RoutedCommands)
          );

        public static readonly RoutedUICommand IzbrisiPregled = new RoutedUICommand(
           "Izbrisi Pregled",
           "IzbrisiPregled",
           typeof(RoutedCommands)
           );
        public static readonly RoutedUICommand IzmijeniPregled = new RoutedUICommand(
        "Izmijeni Pregled",
        "IzmijeniPregled",
        typeof(RoutedCommands)
        );
        public static readonly RoutedUICommand SnimiPregled = new RoutedUICommand(
          "Snimi Pregleg",
          "SnimiPregleg",
          typeof(RoutedCommands)
          );

        public static readonly RoutedUICommand OdustaniPregled = new RoutedUICommand(
           "Odustani Pregled",
           "OdustaniPregled",
           typeof(RoutedCommands)
           );
        public static readonly RoutedUICommand DodajPregled1 = new RoutedUICommand(
        "Dodaj Pregled1",
        "DodajPregled1",
        typeof(RoutedCommands)
        );

        public static readonly RoutedUICommand IzbrisiPregled1 = new RoutedUICommand(
           "Izbrisi Pregled1",
           "IzbrisiPregled1",
           typeof(RoutedCommands)
           );
        public static readonly RoutedUICommand IzmijeniPregled1 = new RoutedUICommand(
        "Izmijeni Pregled1",
        "IzmijeniPregled1",
        typeof(RoutedCommands)
        );
        public static readonly RoutedUICommand SnimiPregled1 = new RoutedUICommand(
          "Snimi Pregleg1",
          "SnimiPregleg1",
          typeof(RoutedCommands)
          );

        public static readonly RoutedUICommand OdustaniPregled1 = new RoutedUICommand(
           "Odustani Pregled1",
           "OdustaniPregled1",
           typeof(RoutedCommands)
           );

        public static readonly RoutedUICommand DodajOpremu = new RoutedUICommand(
          "Dodaj Opremu",
          "DodajOpremu",
          typeof(RoutedCommands)
          );
        public static readonly RoutedUICommand IzbrisiOpremu = new RoutedUICommand(
          "Izbrisi Opremu",
          "IzbrisiOpremu",
          typeof(RoutedCommands)
          );
        public static readonly RoutedUICommand IzmeniOpremu = new RoutedUICommand(
          "Izmeni Opremu",
          "IzmeniOpremu",
          typeof(RoutedCommands)
          );

        public static readonly RoutedUICommand SnimiOpremu = new RoutedUICommand(
           "Snimi Opremu",
           "SnimiOpremu",
           typeof(RoutedCommands)
           );

        public static readonly RoutedUICommand OdustaniOpremu = new RoutedUICommand(
           "Odustani Opremu",
           "OdustaniOpremu",
           typeof(RoutedCommands)
           );

        public static readonly RoutedUICommand PremjestiOpremu = new RoutedUICommand(
           "Premjesti Opremu",
           "PremjestiOpremu",
           typeof(RoutedCommands)
           );

    }
}
