using Aplikacija.dugmeSobe;
using Aplikacija.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija.Services
{
    class PodijeljenaSalaRasporedService
    {
        private static RasporediPodijeljenaSalaRepository preglediRepo;

        private static PodijeljenaSalaRasporedService instance;

        private PodijeljenaSalaRasporedService()
        {
            preglediRepo = new RasporediPodijeljenaSalaRepository();
        }

        public static PodijeljenaSalaRasporedService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PodijeljenaSalaRasporedService();
                }
                return instance;
            }
        }

        public bool DodajPregled1(PreglediPodijeljene ras)
        {
            bool success = preglediRepo.KreirajPregled1(ras);
            return success;
        }

        public bool IzmeniPregled1(PreglediPodijeljene ras)
        {
            bool success = preglediRepo.IzmeniPregled1(ras);
            return success;
        }

        public void ObrisiRaspored1(PreglediPodijeljene ras)
        {
            preglediRepo.ObrisiPregled1(ras);
        }

        public Dictionary<string, PreglediPodijeljene> GetSviPregledi()
        {
            return preglediRepo.PreglediZakazani;
        }
    }
}
