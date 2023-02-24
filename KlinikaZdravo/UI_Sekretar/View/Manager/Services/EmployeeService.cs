using Aplikacija.dugmeZaposleni;
using Aplikacija.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija.Services
{
    public class EmployeeService
    {
        private static ZaposleniRepository zaposleniRepo;

        private static EmployeeService instance;

        private EmployeeService()
        {
            zaposleniRepo = new ZaposleniRepository();
        }

        public static EmployeeService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EmployeeService();
                }
                return instance;
            }
        }

        public bool RegistrujZaposlenog(Zaposleni zaposleni)
        {
            bool success = zaposleniRepo.KreirajZaposlenog(zaposleni);
            return success;
        }

        public bool IzmeniZaposlenog(Zaposleni zaposleni)
        {
            bool success = zaposleniRepo.IzmeniZaposlenog(zaposleni);
            return success;
        }

        public void ObrisiZaposlenog(Zaposleni obrisan)
        {
            zaposleniRepo.ObrisiZaposlenog(obrisan);
        }

        public Dictionary<string, Zaposleni> GetSviZaposleni()
        {
            return zaposleniRepo.Zaposlenici;
        }
        //public Zaposleni GetZaposleniById(Zaposleni zap) { 
        ////{
        ////    if (zaposleniRepo.Zaposlenici.ContainsKey(zap.IDZaposleni))
        ////    {
        ////        return zaposleniRepo.Zaposlenici[zap.IDZaposleni];
        ////    }
        ////    else
        ////    {
        ////        return null;
        ////    }

        //}
    }
}
