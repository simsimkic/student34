using System;
using System.Collections.Generic;
using System.Text;

namespace UI_sekretar
{
    class ZauzetostModel
    {
        public List<ZauzetostSala> Podaci { get; set; }
        public ZauzetostModel()
        {
            Podaci = new List<ZauzetostSala>()
            {
                new ZauzetostSala { Godina = "2009", Sala1 = "100", Sala2 = "78", Sala3 = "65" },
                new ZauzetostSala { Godina = "2010", Sala1 = "59", Sala2 = "74", Sala3 = "70" },
                new ZauzetostSala { Godina = "2011", Sala1 = "70", Sala2 = "90", Sala3 = "80" },
                new ZauzetostSala { Godina = "2012", Sala1 = "40", Sala2 = "43", Sala3 = "50" },
                new ZauzetostSala { Godina = "2013", Sala1 = "63", Sala2 = "67", Sala3 = "57" },
                new ZauzetostSala { Godina = "2014", Sala1 = "70", Sala2 = "87", Sala3 = "79" },
                new ZauzetostSala { Godina = "2015", Sala1 = "90", Sala2 = "69", Sala3 = "45" },
                new ZauzetostSala { Godina = "2016", Sala1 = "74", Sala2 = "45", Sala3 = "56" },
                new ZauzetostSala { Godina = "2017", Sala1 = "80", Sala2 = "80", Sala3 = "80" },
                new ZauzetostSala { Godina = "2018", Sala1 = "91", Sala2 = "70", Sala3 = "95" },
                new ZauzetostSala { Godina = "2019", Sala1 = "86", Sala2 = "50", Sala3 = "35" }
            };
        }
    }
}
