using System;
using System.Collections.Generic;
using System.Text;

namespace UI_sekretar
{
    public class PodaciRasporedDoktora
    {
        public String VremePocetak { get; set; }
        public String VremeKraj { get; set; }
        public PodaciStalni Pacijent { get; set; }
        public DateTime DatumTermina { get; set; }
        public PodaciDoktor Doktor { get; set; }

        public PodaciRasporedDoktora(String pocetak, String kraj, DateTime date,PodaciDoktor podaciDoktor) 
        {
            this.VremePocetak = pocetak;
            this.VremeKraj = kraj;
            this.Doktor = podaciDoktor;
            this.DatumTermina = date;
        }
    }
}
