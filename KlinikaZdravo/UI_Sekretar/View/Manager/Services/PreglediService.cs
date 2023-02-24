using Aplikacija.dugmeSobe;
using Aplikacija.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija.Services
{
    class PreglediService
    {
        private static RasporedPregledaaRepository preglediRepo;

        private static PreglediService  instance;

        private PreglediService()
        {
            preglediRepo = new RasporedPregledaaRepository();
        }

        public static PreglediService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PreglediService();
                }
                return instance;
            }
        }

        public bool DodajPregled(Pregledi ras)
        {
            bool success = preglediRepo.KreirajPregled(ras);
            return success;
        }

        public bool IzmeniPregled(Pregledi ras)
        {
            bool success = preglediRepo.IzmeniPregled(ras);
            return success;
        }

        public void ObrisiRaspored(Pregledi ras)
        {
            preglediRepo.ObrisiPregled(ras);
        }

        public Dictionary<string, Pregledi> GetSviPregledi()
        {
            return preglediRepo.PreglediZakazani;
        }
    }
}
