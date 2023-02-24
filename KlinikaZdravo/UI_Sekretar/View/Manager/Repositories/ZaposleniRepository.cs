using Aplikacija.dugmeZaposleni;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;

namespace Aplikacija.Repositories
{
    [Serializable]
    public class ZaposleniRepository
    {
        private string path;

        public Dictionary<string, Zaposleni> Zaposlenici { get; }

        public ZaposleniRepository()
        {
            Zaposlenici = new Dictionary<string, Zaposleni>();
            Initialize();

            //Serijalizacija s = new Serijalizacija("radnici.txt"); OVO JE TREBALA BITI DESERIJALIZACIJA
            //s.DesiriazibleObject();
            //s.closeStream();

            // zaposlenici = deserijalizacija        
            // kad odradis to, obrises gornja 2 reda
        }

        public bool KreirajZaposlenog(Zaposleni zap)
        {
            if (Zaposlenici.ContainsKey(zap.IDZaposleni))
            {
                return false;
            }
            else
            {
                Zaposlenici[zap.IDZaposleni] = zap;
                ////serijalizuj zaposlenike
                //Serijalizacija s = new Serijalizacija("radnici.txt"); OVO JE TREBALA BITI SERIJALIZACIJA
                //s.SerializeObject(Zaposlenici);
                //s.closeStream();
                return true;
            }
        }

        public void ObrisiZaposlenog(Zaposleni obr)
        {
            if (Zaposlenici.ContainsKey(obr.IDZaposleni))
            {
                Zaposlenici.Remove(obr.IDZaposleni);
                //serijalizuj zaposlenike
            }
        }

        public bool IzmeniZaposlenog(Zaposleni zap)
        {
            if (Zaposlenici.ContainsKey(zap.IDZaposleni))
            {
                Zaposlenici[zap.IDZaposleni] = zap;


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
            Zaposleni a = new Zaposleni();
            a.IDZaposleni = "1";
            a.ime = "a";
            a.prezime = "a";
            a.datumRodjena = "19.11.1973";
            a.jmbg = "a";
            a.telefon = "a";
            a.email = "a";
            a.zaposlenje = "endokrinolog";

          

            Zaposleni b = new Zaposleni();
            b.IDZaposleni = "2";
            b.ime = "b";
            b.prezime = "b";
            b.datumRodjena = "19.11.1973";
            b.jmbg = "b";
            b.telefon = "b";
            b.email = "b";
            b.zaposlenje = "urolog";


            KreirajZaposlenog(a);
            KreirajZaposlenog(b);
            
        }
    }
}
