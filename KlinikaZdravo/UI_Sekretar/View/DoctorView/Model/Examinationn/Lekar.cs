using ClassDiagram.Model.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatHciDoktor.Model.Examination
{
    public class Lekar
    {
        private String ime;
        private String prezime;
        private String username;
        private String lozinka;
        private String spec;
        private DateTime datum;
        private String mesto;
        private String brtel;

        public String Ime
        {
            set
            {
                ime = value;
            }
            get
            {
                return ime;
            }
        }
        public String BrTel
        {
            set
            {
                brtel = value;
            }
            get
            {
                return brtel;
            }
        }
        public String Mesto
        {
            set
            {
                mesto = value;
            }
            get
            {
                return mesto;
            }
        }
        public DateTime Rodj
        {
            set
            {
                datum = value;
            }
            get
            {
                return datum;
            }
        }
        public String Prezime
        {
            set
            {
                prezime = value;
            }
            get
            {
                return prezime;
            }
        }
        public String Spec
        {
            set
            {
                spec = value;
            }
            get
            {
                return spec;
            }
        }
        public String Username
        {
            set
            {
                username = value;
            }
            get
            {
                return username;
            }
        }
        public String Passward
        {
            set
            {
                lozinka = value;
            }
            get
            {
                return lozinka;
            }
        }
    }
}
