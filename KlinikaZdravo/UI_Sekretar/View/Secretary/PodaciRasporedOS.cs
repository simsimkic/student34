 using System;
using System.Collections.Generic;
using System.Text;

namespace UI_sekretar
{
    public class PodaciRasporedOS
    {
        public String PocetakOperacije { get; set; }

        public String KrajOperacije { get; set; }

        public PodaciStalni Pacijent { get; set; }

        public DateTime DatumOperacije { get; set; }

        public PodaciOperacioneSale Sala { get; set; }

        public PodaciDoktor Doktor { get; set; }

        public PodaciRasporedOS(String pocetak, String kraj, PodaciOperacioneSale sala, DateTime date)
        {
            this.PocetakOperacije = pocetak;
            this.KrajOperacije= kraj;
            this.Sala = sala;
            this.DatumOperacije = date;
        }
    }
}
