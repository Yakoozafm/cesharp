using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taszimozgas_c
{
    class Mozgas : DB
    {
        int id { get; set; }
        int irany { get; set; }
        int eszkozId { get; set; }
        int tarhelyId { get; set; }
        DateTime datum { get; set; }
        int utolsoId { get; set; }
        string megjegyzes { get; set; }
        string hiba { get; set; }
        string javitas { get; set; }

        public Mozgas() {
        }

        public Mozgas(int id, int irany, int eszkozId, int tarhelyId, DateTime datum,
            int utolsoId, string megjegyzes, string hiba, string javitas){
            this.id = id;
            this.irany = irany;
            this.eszkozId = eszkozId;
            this.tarhelyId = tarhelyId;
            this.datum = datum;
            this.utolsoId = utolsoId;
            this.megjegyzes = megjegyzes;
            this.hiba = hiba;
            this.javitas = javitas;
        }

        

    }
}
