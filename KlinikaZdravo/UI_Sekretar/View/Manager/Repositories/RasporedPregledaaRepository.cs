using Aplikacija.dugmeSobe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija.Repositories
{
    public class RasporedPregledaaRepository
    {
        private string path;

        public Dictionary<string, Pregledi> PreglediZakazani { get; }

        public RasporedPregledaaRepository()
        {
            PreglediZakazani = new Dictionary<string, Pregledi>();
            Initialize();

            //Serijalizacija s = new Serijalizacija("radnici.txt"); OVO JE TREBALA BITI DESERIJALIZACIJA
            //s.DesiriazibleObject();
            //s.closeStream();

            // zaposlenici = deserijalizacija        
            // kad odradis to, obrises gornja 2 reda
        }

        public bool KreirajPregled(Pregledi zap)
        {
            if (PreglediZakazani.ContainsKey(zap.IDPregleda))
            {
                return false;
            }
            else
            {
                PreglediZakazani[zap.IDPregleda] = zap;
                ////serijalizuj zaposlenike
                //Serijalizacija s = new Serijalizacija("radnici.txt"); OVO JE TREBALA BITI SERIJALIZACIJA
                //s.SerializeObject(Zaposlenici);
                //s.closeStream();
                return true;
            }
        }

        public void ObrisiPregled(Pregledi zap)
        {
            if (PreglediZakazani.ContainsKey(zap.IDPregleda))
            {
                PreglediZakazani.Remove(zap.IDPregleda);
                //serijalizuj zaposlenike
            }
        }

        public bool IzmeniPregled(Pregledi zap)
        {
            if (PreglediZakazani.ContainsKey(zap.IDPregleda))
            {

                return false;
            }
            else
            {

                PreglediZakazani[zap.IDPregleda] = zap;
                

                //serijalizuj zaposlenike
                return true;
            }
        }

        private void Initialize()
        {
            Pregledi r1 = new Pregledi();
            r1.IDPregleda = "1A";
            r1.pocetak = "10:30:00";
            r1.krajPegleda = "11:30:00";
            r1.ljekar = "Tanja Drcelic";
            Pregledi r2 = new Pregledi();
            r2.IDPregleda = "1A";
            r2.pocetak = "11:30:00";
            r2.krajPegleda = "12:00:00";
            r2.ljekar = "Tanja Drcelic";
            Pregledi r3 = new Pregledi();
            r3.IDPregleda = "1A";
            r3.pocetak = "12:00:00";
            r3.krajPegleda = "13:30:00";
            r3.ljekar = "Tanja Drcelic";
           




            KreirajPregled(r1);
        }
    }
}
