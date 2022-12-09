using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackCs.Modelo
{
    public class Jugador
    {
        public Jugador()
        {
            index = 0;
            apuesta = 0;
            cartas = new Carta[21];
        }
        public Carta[] cartas { get; set; }
        public int index { get; set; }
        public int apuesta { get; set; }
        bool opt;

        public void addCarta(Carta nCarta)
        {
            cartas[index] = nCarta;
            index++;
        }
        public int ValorMazo()
        {
            int valor = 0;
            for (int i = 0; i < index; i++)
            {
                valor += cartas[i].value;
            }
            return valor;
        }
        public int ValorMazoOpt()
        {
            int valor = 0;
            for (int i = 0; i < index; i++)
            {
                if (cartas[i].valueopt != null)
                {
                    valor += (int)cartas[i].valueopt;
                }
                else
                {
                    valor += cartas[i].value;
                }
                
            }
            return valor;
        }
    }
}