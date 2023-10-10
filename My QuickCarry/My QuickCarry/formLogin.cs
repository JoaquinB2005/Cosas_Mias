using System.Net.Http.Headers;

namespace My_QuickCarry
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();


        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }
        private void FormLogin_Resize(object sender, EventArgs e)
        {
            int panelWidth = 300;  // Ancho deseado del panel
            int panelHeight = 200; // Altura deseada del panel
            int panelX = (this.Width - panelWidth) / 2;  // Posición X centrada
            int panelY = (this.Height - panelHeight) / 2; // Posición Y centrada

            panel1.Width = panelWidth;
            panel1.Height = panelHeight;
            panel1.Location = new Point(panelX, panelY);
        }


        private void etiUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            if (txtUsuario.Text == "admin" && txtContraseña.Text == "admin")
            {
                formAdmin formAdmin = new formAdmin();
                formAdmin.Show();
                this.Hide();
            }


        }



    }
}