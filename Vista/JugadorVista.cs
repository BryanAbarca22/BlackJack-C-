using BlackJackCs.Modelo;

namespace BlackJackCs.Vista
{
    public class JugadorVista : Panel
    {
        private Jugador ojugador;
        private TableLayoutPanel CartasContainer;
        private Label nombre;
        public JugadorVista()
        {

        }
        public JugadorVista(Jugador _oJugador, int x, int y, int width, int height, string name)
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
            CartasContainer.Width = width - 20;
            CartasContainer.Height = height -20;
            initCartsContainer();
            nombre = new Label();
            nombre.Text = name;
            nombre.Font = new Font("Arial", 13);

            this.CartasContainer.Controls.Add(nombre, 1, 0);
            this.CartasContainer.SetColumnSpan(nombre, 21);
            this.Controls.Add(CartasContainer);
        }
        public void initCartsContainer()
        {
            this.CartasContainer.RowCount = 2;
            this.CartasContainer.ColumnCount = 21;
            for (int i = 0; i < 6; i++)
            {
                this.CartasContainer.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            }
            this.CartasContainer.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            for (int i = 0; i < ojugador.index; i++)
            {
                this.CartasContainer.Controls.Add(new VistaCarta(ojugador.cartas[i]), i, 1);
            }

        }
        public void updateContainer()
        {

            this.CartasContainer.Controls.Add(new VistaCarta(ojugador.cartas[ojugador.index-1]), ojugador.index-1, 1);

        }
    }
}
