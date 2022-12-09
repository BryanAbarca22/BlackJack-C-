using BlackJackCs.Controller;
using System.Diagnostics;

namespace BlackJackCs.Vista
{
    public class GamePanel : Panel
    {
        GameController GameMaster;
        Button Pedir;
        Button Doblar;
        Button Plantarse;
        JugadorVista[] jugadoresjuego;
        Crupier oCrupier;
        int repartir;
        public GamePanel(GameController GM)
        {
            GameMaster = GM;
            this.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.Location = new System.Drawing.Point(12, 12);
            this.Name = "GamePanel";
            this.Size = new System.Drawing.Size(916, 540);
            this.TabIndex = 0;


            Pedir = new Button();
            Doblar = new Button();
            Plantarse = new Button();
            addActions();

            jugadoresjuego = new JugadorVista[GameMaster.numberplayers];
            addPlayers();
            oCrupier = new Crupier(GM.Crupier, 200, 0, 400, 200, "Crupier");
            this.Controls.Add(oCrupier);
            oCrupier.repartirCartas.Click += new EventHandler(this.RepartirCartas);
            repartir = 0;

        }
        public void addActions()
        {
            int a = this.Height - 300;
            int b = this.Width - 260;

            Pedir.Location = new System.Drawing.Point(b, a);
            Pedir.Text = "Pedir Carta";
            Pedir.BackColor = System.Drawing.Color.White;
            Pedir.Click += new EventHandler(this.fPedir);
            this.Controls.Add(Pedir);


            Doblar.Location = new System.Drawing.Point(b + Pedir.Width + 10, a);
            Doblar.Text = "Doblar Apuesta";
            Doblar.BackColor = System.Drawing.Color.White;
            Doblar.Click += new EventHandler(this.fDoblar);
            this.Controls.Add(Doblar);



            Plantarse.Location = new System.Drawing.Point(b + Pedir.Width + Doblar.Width + 20, a);
            Plantarse.Text = "Plantarse";
            Plantarse.BackColor = System.Drawing.Color.White;
            Plantarse.Click += new EventHandler(this.fPlantarse);
            this.Controls.Add(Plantarse);

        }
        public void addPlayers()
        {
            int nJugadores = GameMaster.numberplayers;
            int[] x = new int[nJugadores];
            int width = this.Width / nJugadores;
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = width * i;
            }
            int y = this.Height - 280;
            for (int i = 0; i < nJugadores; i++)
            {
                jugadoresjuego[i] = new JugadorVista(GameMaster.jugadores[i], x[i], y, width, 280, "Jugador #" + (1 + i).ToString());

                this.Controls.Add(jugadoresjuego[i]);
            }
        }
        public void fPedir(object sender, EventArgs e)
        {
            int a = GameMaster.currentMazo;
            int b;
            if (GameMaster.currentMazo + 1 > 7)
            {
                GameMaster.currentMazo++;
            }
            else
            {
                GameMaster.currentMazo = 0;
            }
            
            b = GameMaster.index[a];
            GameMaster.index[a]++;
            GameMaster.jugadores[GameMaster.turnoJugador].addCarta(GameMaster.CartasMazos[a].cartas[b]);
            jugadoresjuego[GameMaster.turnoJugador].updateContainer();

            if (GameMaster.jugadores[GameMaster.turnoJugador].ValorMazo() >= 21)
            {
                fPlantarse(sender, e);
            }
        }
        public void fPlantarse(object sender, EventArgs e)
        {
            if (GameMaster.turnoJugador + 1 < GameMaster.numberplayers)
            {
                GameMaster.turnoJugador++;
            }
            else
            {
                GameMaster.turnoJugador = 0;
            }
        }
        public void fDoblar(object sender, EventArgs e)
        {
            GameMaster.jugadores[GameMaster.turnoJugador].apuesta = GameMaster.jugadores[GameMaster.turnoJugador].apuesta * 2;
        }
        public void RepartirCartas(object sender, EventArgs e)
        {
            int a = GameMaster.currentMazo;
            int b;
            if (GameMaster.currentMazo + 1 > 7)
            {
                GameMaster.currentMazo++;
            }
            else
            {
                GameMaster.currentMazo = 0;
            }
            for (int i = 0; i < GameMaster.numberplayers; i++)
            {
                b = GameMaster.index[a];
                GameMaster.index[a]++;
                GameMaster.jugadores[i].addCarta(GameMaster.CartasMazos[a].cartas[b]);

            }
            b = GameMaster.index[a];
            GameMaster.Crupier.addCarta(GameMaster.CartasMazos[a].cartas[b]);
            for (int i = 0; i < GameMaster.numberplayers; i++)
            {
                jugadoresjuego[i].updateContainer();


            }

            a = GameMaster.currentMazo;
            b = GameMaster.index[a];
            GameMaster.index[a]++;
            if (GameMaster.currentMazo + 1 > 7)
            {
                GameMaster.currentMazo++;
            }
            else
            {
                GameMaster.currentMazo = 0;
            }
            oCrupier.ojugador.addCarta(GameMaster.CartasMazos[a].cartas[b]);
            oCrupier.updateContainer();
            if (repartir >= 1)
            {
                oCrupier.CartasContainer.Controls.Remove((Control)sender);
            }
            else
            {
                repartir++;
                RepartirCartas(sender, e);
            }
            
            
            //Debug.WriteLine("CLICK EN REPARTIR CARTAS");
        }
        public void endofGame()
        {

        }
    }
}
