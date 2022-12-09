using BlackJackCs.Vista;
using System.Windows.Forms;

namespace BlackJackCs
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            var formPopup = new NumberPlayers();
            formPopup.ShowDialog();
            //this.Hide();
            InitializeComponent();
            CustomInitialize(formPopup.numero);
        }
    }
}