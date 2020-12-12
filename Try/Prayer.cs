using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try
{
    public class Prayer
    {
        private int prayerid;
        private string prayerw;

        public Prayer(int prayerid, string prayerw)
        {
            this.Prayerid = prayerid;
            this.Prayerw = prayerw;
        }

        public int Prayerid { get => prayerid; set => prayerid = value; }
        public string Prayerw { get => prayerw; set => prayerw = value; }
    }
}
