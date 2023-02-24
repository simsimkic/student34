using System;
using System.Collections.Generic;
using System.Text;

namespace UI_sekretar
{
    public class RepozitorijumOS
    {
        public static List<PodaciOperacioneSale> sale = new List<PodaciOperacioneSale>();
   
        public RepozitorijumOS() { }

    public void init()
    {
            PodaciOperacioneSale sala1 = new PodaciOperacioneSale("Sala 1");
            PodaciOperacioneSale sala2 = new PodaciOperacioneSale("Sala 2");
            PodaciOperacioneSale sala3 = new PodaciOperacioneSale("Sala 3");
            sale.Add(sala1);
            sale.Add(sala2);
            sale.Add(sala3);
    }
    }
}
