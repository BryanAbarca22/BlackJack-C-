using BlackJackCs.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackCs.Vista
{
    internal class Crupier : Panel
    {
        public Jugador ojugador;
        public TableLayoutPanel CartasContainer { get; set; }
        private Label nombre;
        public Button repartirCartas { get; set; }
        public Crupier(Jugador _oJugador, int x, int y, int width, int height, string name)
        {
            ojugador = _oJugador;
            this.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.Location = new System.Drawing.Point(x, y);
            this.Name = "GamePanel";
            this.Size = new System.Drawing.Size(width, height);
            this.TabIndex = 0;
            this.CartasContainer = new System.Windows.Forms.TableLayoutPanel();
            CartasContainer.Width = width;
            CartasContainer.Height = height;
            initCartsContainer();
            nombre = new Label();
            nombre.Text = name;
            nombre.Font = new Font("Arial", 13);
            this.CartasContainer.Controls.Add(nombre, 1, 1);
            this.CartasContainer.SetColumnSpan(nombre, 21);
            repartirCartas = new Button();
            repartirCartas.Text = "Empezar Juego";
            repartirCartas.Width = width;
            repartirCartas.Height = 30;
            repartirCartas.BackColor = System.Drawing.Color.White;
            this.CartasContainer.Controls.Add(repartirCartas, 1, 2);
            this.CartasContainer.SetColumnSpan(repartirCartas, 21);
            this.Controls.Add(CartasContainer);
            
        }
        public void initCartsContainer()
        {
            this.CartasContainer.RowCount = 3;
            this.CartasContainer.ColumnCount = 21;
            for (int i = 0; i < 6; i++)
            {
                this.CartasContainer.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            }
            this.CartasContainer.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            for (int i = 0; i < ojugador.index; i++)
            {
                this.CartasContainer.Controls.Add(new VistaCarta(ojugador.cartas[i]), i, 0);
            }

        }
        public void updateContainer()
        {

            this.CartasContainer.Controls.Add(new VistaCarta(ojugador.cartas[ojugador.index - 1]), ojugador.index - 1, 0);

        }
    }
}
