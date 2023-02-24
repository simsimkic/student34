using Aplikacija.dugmeApoteka;
using Aplikacija.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija.Services
{
    public class LijekoviServece
    {
        private static LijekoviRepository lijekoviRepo;

        private static LijekoviServece instance;

        private LijekoviServece()
        {
            lijekoviRepo = new LijekoviRepository();
        }

        public static LijekoviServece Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LijekoviServece();
                }
                return instance;
            }
        }

        public bool RegistrujLijek(Lijekovi lijekovi)
        {
            bool success = lijekoviRepo.KreirajLijek(lijekovi);
            return success;
        }

        public bool IzmeniLijek(Lijekovi lijekovi )
        {
            bool success = lijekoviRepo.IzmeniLijek(lijekovi);
            return success;
        }
        public bool NabaviLijek(Lijekovi lijekovi)
        {
            bool success = lijekoviRepo.NabaviLijek(lijekovi);
            return success;
        }

        public void ObrisiLijek(Lijekovi obrisanLijek)
        {
            lijekoviRepo.ObrisiLijek(obrisanLijek);
        }

        public Dictionary<string, Lijekovi> GetSviLijekovi()
        {
            return lijekoviRepo.LijekoviUApoteci;
        }
    }
}

