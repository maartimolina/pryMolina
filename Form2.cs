using Microsoft.VisualBasic.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMolina
{
    public partial class frmJuego : Form
    {

        clsNave objNaveJugador;
        List<PictureBox> balas = new List<PictureBox>();
        public string NombreJugador { get; set; }
        public int puntaje { get; set; } = 0;

        public frmJuego(string nombre)
        {
            InitializeComponent();
            objNaveJugador = new clsNave();
            objNaveJugador.EnemigoEliminado += ObjNaveJugador_EnemigoEliminado;
            progressBar.Value = 0;
            NombreJugador = nombre;
            lblNombreJugador.Text = nombre;
        }
        private void ObjNaveJugador_EnemigoEliminado(object sender, EventArgs e)
        {
            puntaje += 10;
            progressBar.Value = puntaje;
        }


        private void frmJuego_Load(object sender, EventArgs e)
        {
            objNaveJugador = new clsNave();
            objNaveJugador.crearJugador();
            objNaveJugador.imgNave.BringToFront();
            objNaveJugador.imgNave.Location = new Point(
                this.ClientSize.Width / 2 - objNaveJugador.imgNave.Width / 2,
                this.ClientSize.Height - objNaveJugador.imgNave.Height);
            Controls.Add(objNaveJugador.imgNave);

            Random rnd = new Random();
            List<Point> posiciones = new List<Point>();
            for (int i = 0; i < 4; i++)
            {
                Point posicion;
                do
                {
                    int x = rnd.Next(0, this.Width - 50);
                    int y = rnd.Next(0, this.Height / 2);
                    posicion = new Point(x, y);
                } while (posiciones.Any(p => Math.Abs(p.X - posicion.X) < 50 && Math.Abs(p.Y - posicion.Y) < 50));

                posiciones.Add(posicion);
                objNaveJugador.crearEnemigo(i + 1);
                PictureBox imgEnemigo = new PictureBox();
                imgEnemigo.SizeMode = PictureBoxSizeMode.StretchImage;
                imgEnemigo.ImageLocation = objNaveJugador.imgEne.ImageLocation;
                imgEnemigo.Location = posicion;
                imgEnemigo.Tag = "Enemigo";
                Controls.Add(imgEnemigo);
            }
        }

        private void frmJuego_KeyDown(object sender, KeyEventArgs e)
        {
            int limiteDerecho = this.ClientSize.Width - objNaveJugador.imgNave.Width; // Límite derecho del formulario

            if (e.KeyCode == Keys.Right && objNaveJugador.imgNave.Location.X < limiteDerecho)
            {
                objNaveJugador.imgNave.Location = new Point(
                    Math.Min(objNaveJugador.imgNave.Location.X + 5, limiteDerecho),
                    this.ClientSize.Height - objNaveJugador.imgNave.Height); // Mantener la nave en la parte inferior
            }
            else if (e.KeyCode == Keys.Left && objNaveJugador.imgNave.Location.X > 0)
            {
                objNaveJugador.imgNave.Location = new Point(
                    Math.Max(objNaveJugador.imgNave.Location.X - 5, 0),
                    this.ClientSize.Height - objNaveJugador.imgNave.Height); // Mantener la nave en la parte inferior
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < balas.Count; i++)
            {
                PictureBox bala = balas[i];
                bala.Top -= 30;
                bala.BringToFront();

                if (bala.Location.Y <= 0)
                {
                    balas.Remove(bala);
                    bala.Dispose();
                }
                else
                {
                    // Comprueba si la bala colisiona con algún enemigo
                    foreach (Control control in Controls)
                    {
                        if (control is PictureBox && control.Tag == "Enemigo" && bala.Bounds.IntersectsWith(control.Bounds))
                        {
                            balas.Remove(bala);
                            bala.Dispose();
                            objNaveJugador.EliminarEnemigo((PictureBox)control);
                            break;
                        }
                    }
                }
            }

            if (balas.Count == 0)
            {
                timer1.Stop();
            }
        }

        private void frmJuego_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                PictureBox nuevaBala = new PictureBox();
                nuevaBala.SizeMode = PictureBoxSizeMode.StretchImage;
                nuevaBala.ImageLocation = "https://toppng.com/uploads/thumbnail/alaga-galaga-missile-11562887504dfmxt6dqa0.png";
                nuevaBala.Size = new Size(20, 30);
                nuevaBala.Location = new Point(objNaveJugador.imgNave.Location.X + objNaveJugador.imgNave.Width / 2 - nuevaBala.Width / 2, objNaveJugador.imgNave.Location.Y);
                Controls.Add(nuevaBala);

                balas.Add(nuevaBala);
                timer1.Start();
            }
        }

    }
}
