namespace BlackJackCs.Vista
{
    public partial class NumberPlayers : Form
    {
        public NumberPlayers()
        {
            InitializeComponent();
        }



        private void Aceptar_Click(object sender, EventArgs e)
        {
            string numero = this.NumberPlayerTB.Text;
            try
            {
                if (Int32.Parse(numero) <= 7 && Int32.Parse(numero) > 0)
                {
                    this.numero = Int32.Parse(numero);
                    this.label1.Text = "numero aceptado";
                    this.Hide();
                }
                else
                {
                    this.label1.Text = "Numero tiene que ser menor o igual a 7 y mayor que 0";
                }
            }
            catch
            {
                this.label1.Text = "Por favor digite un valor valido, numero tiene que ser menor o igual a 7 y mayor que 0";
            }
            
        }

        private void NumberPlayerTB_TextChanged(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }
    }
}
