using Aplikacija.dugmeOprema;
using Aplikacija.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija.Services
{
    public class OpremaService
    {
        private static OpremaRepository opremaRepo;

        private static OpremaService instance;
        private OpremaService()
        {
            opremaRepo = new OpremaRepository();
        }

        public static OpremaService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OpremaService();
                }
                return instance;
            }
        }

        public bool RegistrujOpremu(Oprema oprema)
        {
            bool success = opremaRepo.KreirajOpremu(oprema);
            return success;
        }

        public bool IzmeniOpremu(Oprema oprema)
        {
            bool success = opremaRepo.IzmeniOpremu(oprema);
            return success;
        }

        public void ObrisiOpremu(Oprema oprema)
        {
            opremaRepo.ObrisiOpremu(oprema);
        }

        public Dictionary<string, Oprema> GetSvaOprema()
        {
            return opremaRepo.OpremaUsali;
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

