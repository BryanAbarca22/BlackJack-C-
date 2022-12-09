using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackCs.Modelo
{
    public class Mazo
    {
        public Mazo()
        {
            cartas = new Carta[53];
            initTipo(0, "T.jpg");
            initTipo(13, "D.jpg");
            initTipo(26, "C.jpg");
            initTipo(36, "B.jpg");
            //desordenar();
        }
        public Carta[] cartas { get; set; }
        public void initTipo(int start, string simbolo)
        {
           
            int end = start + 12;
            int offset = start - 1;
            for (int i = start; i <= end; i++)
            {

                if (i - offset == 1)
                {
                    cartas[i] = new Carta("A"+simbolo,i-offset,11);
                    //Debug.WriteLine(cartas[i].imgpath);
                }
                else if (i - offset <= 10)
                {
                    int val = i - offset;
                    cartas[i] = new Carta(val.ToString() + simbolo, i - offset);
                    //Debug.WriteLine(cartas[i].imgpath);

                }
                else if (i - offset == 11)
                {

                    cartas[i] = new Carta("J" + simbolo, i - offset);
                    //Debug.WriteLine(cartas[i].imgpath);

                }
                
                else if (i - offset == 12)
                {
                    cartas[i] = new Carta("Q" + simbolo, i - offset);
                    //Debug.WriteLine(cartas[i].imgpath);
                }
                else if (i - offset == 13)
                {
                    cartas[i] = new Carta("K" + simbolo, i - offset);
                    //Debug.WriteLine(cartas[i].imgpath);
                }
            }
            
        }
        public void desordenar()
        {
            Random rnd = new Random();
            int num = rnd.Next();

            for (int i = 0; i < (52 / 2); i++)
            {
                int r = rnd.Next(52);
                Carta aux = cartas[i];
                cartas[i] = cartas[r];
                cartas[r] = aux;
            }
        }
    }
}
