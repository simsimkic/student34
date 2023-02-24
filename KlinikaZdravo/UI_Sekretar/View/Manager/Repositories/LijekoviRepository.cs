using Aplikacija.dugmeApoteka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija.Repositories
{
    public class LijekoviRepository
    {
        private string path;

        public Dictionary<string, Lijekovi> LijekoviUApoteci { get; }

        public LijekoviRepository()
        {
            LijekoviUApoteci = new Dictionary<string, Lijekovi>();
            Initialize();
            // zaposlenici = deserijalizacija        
            // kad odradis to, obrises gornja 2 reda
        }

        public bool KreirajLijek(Lijekovi zap)
        {
            if (LijekoviUApoteci.ContainsKey(zap.IDlijeka))
            {
                return false;
            }
            else
            {
                LijekoviUApoteci[zap.IDlijeka] = zap;
                //serijalizuj zaposlenike
                return true;
            }
        }

        public void ObrisiLijek(Lijekovi obr)
        {
            if (LijekoviUApoteci.ContainsKey(obr.IDlijeka))
            {
                LijekoviUApoteci.Remove(obr.IDlijeka);
                //serijalizuj zaposlenike
            }
        }

        public bool IzmeniLijek(Lijekovi zap)
        {
            if (LijekoviUApoteci.ContainsKey(zap.IDlijeka))
            {
                LijekoviUApoteci[zap.IDlijeka] = zap;


                //serijalizuj zaposlenike
                return true;

              
            }
            else
            {

                return false;
            }
        }
        public bool NabaviLijek(Lijekovi zap)
        {
            if (LijekoviUApoteci.ContainsKey(zap.IDlijeka))
            {
                LijekoviUApoteci[zap.IDlijeka] = zap;

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
            Lijekovi lijekBrufen = new Lijekovi();
            lijekBrufen.nazivLijeka = "Paracetamol";
            lijekBrufen.IDlijeka = "1";
            lijekBrufen.kolicina = 10;

            Lijekovi lijekAndol = new Lijekovi();
            lijekAndol.nazivLijeka = "Andol";
            lijekAndol.IDlijeka = "2";
            lijekAndol.kolicina = 20;

            KreirajLijek(lijekBrufen);
            KreirajLijek(lijekAndol);
        }
    }
}

