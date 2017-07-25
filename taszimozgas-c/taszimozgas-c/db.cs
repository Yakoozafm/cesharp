using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taszimozgas_c
{
    class DB
    {
        private String Felhnev;
        private String Jelsz;

        public String getFelhnev()
        {
            return this.Felhnev;
        }
        public String getJelsz()
        {
            return this.Jelsz;
        }


        public void setFelhnev(String felnev)
        {
            this.Felhnev = felnev;
        }

        public void setJelsz(String jelszo)
        {
            this.Jelsz = jelszo;
        }
    }
}
