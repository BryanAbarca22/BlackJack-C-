using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackCs.Modelo
{
    public class Carta
    {
        public Carta()
        {
            imgpath = "";
        }
        public Carta(string _imgpath, int value, int valueopt)
        {
            imgpath = _imgpath;
            this.value = value;
            this.valueopt = valueopt;
        }
        public Carta(string _imgpath, int value)
        {
            imgpath = _imgpath;
            this.value = value;
            this.valueopt = null;
        }

        public string imgpath { get; set; }
        public int value { get; set; }
        public int? valueopt { get; set; }
    }
}
