namespace pryMolina
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnJuego_Click(object sender, EventArgs e)
        {
            Form Juego = new frmInicio();
            Juego.Show();
        }
    }
}