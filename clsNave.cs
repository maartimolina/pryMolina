using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryMolina
{
    internal class clsNave
    {
        //Propiedades
        public int vida;
        public string nombre;
        public int puntosDaños;
        public PictureBox imgNave;
        public PictureBox imgEne;
        public void crearJugador()
        {
            vida = 100;
            nombre = "Jugador ";
            puntosDaños = 5;
            imgNave = new PictureBox();
            imgNave.SizeMode= PictureBoxSizeMode.StretchImage;
            imgNave.ImageLocation = "https://steamuserimages-a.akamaihd.net/ugc/3336348870692605210/2DB65000D1AE5B34BCEC2E3E91A27537B3EFC057/?imw=268&imh=268&ima=fit&impolicy=Letterbox&imcolor=%23000000&letterbox=true";
            imgNave.Size= new Size(50,50);
        }

        public void crearEnemigo(int tipo)
        {
            switch (tipo)
            {
                case 1:
                        vida = 100;
                        nombre = "Enemigo 1";
                        puntosDaños=1;
                        imgEne = new PictureBox();
                        imgEne.SizeMode= PictureBoxSizeMode.StretchImage;
                        imgEne.ImageLocation = "https://mir-s3-cdn-cf.behance.net/project_modules/disp/67a42226734797.5635b665abaa4.gif";
                        break;
                case 2:
                    vida = 100;
                    nombre = "Enemigo 2";
                    puntosDaños = 1;
                    imgEne = new PictureBox();
                    imgEne.SizeMode = PictureBoxSizeMode.StretchImage;
                    imgEne.ImageLocation = "https://art.pixilart.com/5096bbb7736c227.gif";
                    break;
                case 3:
                    vida = 100;
                    nombre = "Enemigo 3";
                    puntosDaños = 1;
                    imgEne = new PictureBox();
                    imgEne.SizeMode = PictureBoxSizeMode.StretchImage;
                    imgEne.ImageLocation = "https://art.pixilart.com/5ce2059e8521.gif";
                    break;
                case 4:
                    vida = 100;
                    nombre = "Enemigo 4";
                    puntosDaños = 1;
                    imgEne = new PictureBox();
                    imgEne.SizeMode = PictureBoxSizeMode.StretchImage;
                    imgEne.ImageLocation = "https://mir-s3-cdn-cf.behance.net/project_modules/disp/f8c1a926734797.5635b665b810a.gif";
                    break;



            }
        }
    }

    
}
