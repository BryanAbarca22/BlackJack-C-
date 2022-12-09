using BlackJackCs.Modelo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackCs.Controller
{
    public class GameController
    {
        public int numberplayers { get; set; }
        public Jugador[] jugadores { get; set; }
        public Mazo[] CartasMazos { get; set; }
        public Jugador Crupier { get; set; }
        public int[] index { get; set; }
        public int currentMazo { get; set; }
        public int turnoJugador { get; set; }
        public GameController(int _numerPlayers)
        {
            numberplayers = _numerPlayers;
            CartasMazos = new Mazo[6];

            for(int i = 0; i<6; i++)
            {
                CartasMazos[i] = new Mazo();
            }

            index = new int[6];

            for (int i = 0; i < 6; i++)
            {
                index[i] = 0;
            }

            jugadores = new Jugador[numberplayers];

            for (int i = 0; i < numberplayers; i++)
            {
                jugadores[i] = new Jugador();
                Debug.WriteLine(i.ToString()+ "Numero de jugador");
            }

            Crupier = new Jugador();
            currentMazo = 0;
            turnoJugador = 0;
            
        }
        
    }
}
