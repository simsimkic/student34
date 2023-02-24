using Aplikacija.dugmeOprema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;


namespace Aplikacija.Repositories
{
    public class OpremaRepository
    {
        private string path;

        public Dictionary<string, Oprema> OpremaUsali { get; }

        public OpremaRepository()
        {
            OpremaUsali = new Dictionary<string, Oprema>();
            Initialize();

            //Serijalizacija s = new Serijalizacija("radnici.txt"); OVO JE TREBALA BITI DESERIJALIZACIJA
            //s.DesiriazibleObject();
            //s.closeStream();

            // zaposlenici = deserijalizacija        
            // kad odradis to, obrises gornja 2 reda
        }
        public bool KreirajOpremu(Oprema zap)
        {
            if (OpremaUsali.ContainsKey(zap.IDOpreme))
            {
                return false;
            }
            else
            {
                OpremaUsali[zap.IDOpreme] = zap;
                ////serijalizuj zaposlenike
                //Serijalizacija s = new Serijalizacija("radnici.txt"); OVO JE TREBALA BITI SERIJALIZACIJA
                //s.SerializeObject(Zaposlenici);
                //s.closeStream();
                return true;
            }
        }

        public void ObrisiOpremu(Oprema obr)
        {
            if (OpremaUsali.ContainsKey(obr.IDOpreme))
            {
                OpremaUsali.Remove(obr.IDOpreme);
                //serijalizuj zaposlenike
            }
        }

        public bool IzmeniOpremu(Oprema zap)
        {
            if (OpremaUsali.ContainsKey(zap.IDOpreme))
            {

                OpremaUsali[zap.IDOpreme] = zap;


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
            Oprema salaPrva = new Oprema();
            salaPrva.IDOpreme = "1577l";
            salaPrva.naziv = "stolica";
            salaPrva.kolicina = 10;
            KreirajOpremu(salaPrva);

            Oprema salaPrva1 = new Oprema();
            salaPrva1.IDOpreme = "15444";
            salaPrva1.naziv = "sto";
            salaPrva1.kolicina = 3;
            KreirajOpremu(salaPrva1);

            Oprema o = new Oprema();
            o.IDOpreme = "1";
            o.naziv = "sto";
            o.kolicina = 52;
            KreirajOpremu(o);

        }
    }
}

