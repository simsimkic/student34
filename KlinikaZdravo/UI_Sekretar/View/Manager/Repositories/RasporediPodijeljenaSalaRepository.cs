using Aplikacija.dugmeSobe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija.Repositories
{
   public  class RasporediPodijeljenaSalaRepository
    {
        private string path;

        public Dictionary<string, PreglediPodijeljene> PreglediZakazani { get; }

        public RasporediPodijeljenaSalaRepository()
        {
            PreglediZakazani = new Dictionary<string, PreglediPodijeljene>();
            Initialize();

            //Serijalizacija s = new Serijalizacija("radnici.txt"); OVO JE TREBALA BITI DESERIJALIZACIJA
            //s.DesiriazibleObject();
            //s.closeStream();

            // zaposlenici = deserijalizacija        
            // kad odradis to, obrises gornja 2 reda
        }
        public bool KreirajPregled1(PreglediPodijeljene zap)
        {
            if (PreglediZakazani.ContainsKey(zap.IDPregleda1))
            {
                return false;
            }
            else
            {
                PreglediZakazani[zap.IDPregleda1] = zap;
                ////serijalizuj zaposlenike
                //Serijalizacija s = new Serijalizacija("radnici.txt"); OVO JE TREBALA BITI SERIJALIZACIJA
                //s.SerializeObject(Zaposlenici);
                //s.closeStream();
                return true;
            }
        }

        public void ObrisiPregled1(PreglediPodijeljene zap)
        {
            if (PreglediZakazani.ContainsKey(zap.IDPregleda1))
            {
                PreglediZakazani.Remove(zap.IDPregleda1);
                //serijalizuj zaposlenike
            }
        }

        public bool IzmeniPregled1(PreglediPodijeljene zap)
        {
            if (PreglediZakazani.ContainsKey(zap.IDPregleda1))
            {

                PreglediZakazani[zap.IDPregleda1] = zap;


                //serijalizuj zaposlenike
                return true;
            }
            else
            {

                return false;
            }
        }

        private void Initialize()
        {
            PreglediPodijeljene r1 = new PreglediPodijeljene();
            r1.IDPregleda1 = "1A";
            r1.pocetak1 = "10:30";
            r1.krajPegleda1 = "11:30";
            r1.ljekar1 = "Tanja Drcelic";




            KreirajPregled1(r1);
        }
    }
}

