using System;
using System.Collections.Generic;
using System.Text;

namespace UI_sekretar
{
   public class RepozitorijumDoktori
    {
        public static List<PodaciDoktor> doktori = new List<PodaciDoktor>();

        public RepozitorijumDoktori()
        {
            
        }
        public void init()
        {
            PodaciDoktor doktor1 = new PodaciDoktor("Marko Markovic");
            PodaciDoktor doktor2 = new PodaciDoktor("Aleksandra Anic");
            PodaciDoktor doktor3 = new PodaciDoktor("Jovana Jovic");

            doktori.Add(doktor1);
            doktori.Add(doktor2);
            doktori.Add(doktor3);
        }

    }
}
