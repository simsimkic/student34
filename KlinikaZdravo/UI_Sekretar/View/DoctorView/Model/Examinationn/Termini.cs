using ClassDiagram.Model.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatHciDoktor.Model.Examination
{
    class Termini
    {
        private Lekar doctor;
        private String status;
        private Patient pacijent;
        private DateTime vreme;

        private Termini()
        {

        }

        public Lekar Lekar
        {
            set
            {
                doctor = value;
            }
            get
            {
                return doctor;
            }
        }
        public String ImeLekara
        {
            get
            {
                return doctor.Ime + doctor.Prezime;
            }
        }


        public String Status
        {
            set
            {
                status = value;
            }
            get
            {
                return status;
            }
        }


        public Patient Pacijent
        {
            set
            {
                pacijent = value;
            }
            get
            {
                return pacijent;
            }
        }


        public DateTime Vreme
        {
            set
            {
                vreme = value;
            }
            get
            {
                return vreme;
            }
        }
    }
}
