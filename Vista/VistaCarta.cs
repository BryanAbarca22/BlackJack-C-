using BlackJackCs.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackCs.Vista
{
    public class VistaCarta : PictureBox
    {
        private Carta oCarta;
        
        public VistaCarta(Carta _oCarta)
        {
            oCarta = _oCarta;
            Image imagen = Image.FromFile("Imagenes\\" + oCarta.imgpath);
            this.Width = imagen.Width;
            this.Height = imagen.Height;
            this.Image = imagen;

        }
    }
}
