using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try
{
    public class Verses
    {
        private int verseid;
        private string versesw;

        public Verses(int verseid, string verses)
        {
            this.Verseid = verseid;
            this.Versesw = verses;
        }

        public int Verseid { get => verseid; set => verseid = value; }
        public string Versesw { get => versesw; set => versesw = value; }
    }
}
