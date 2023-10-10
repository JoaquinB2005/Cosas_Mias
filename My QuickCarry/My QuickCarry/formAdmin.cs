using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_QuickCarry
{
    public partial class formAdmin : Form
    {
        public formAdmin()
        {
            InitializeComponent();

        }

        private void formAdmin_Load(object sender, EventArgs e)
        {

        }
        private void FormAdmin_Resize(object sender, EventArgs e)
        {
            int panelWidth = 300;  // Ancho deseado del panel
            int panelHeight = 200; // Altura deseada del panel
            int panelX = (this.Width - panelWidth) / 2;  // Posición X centrada
            int panelY = (this.Height - panelHeight) / 2; // Posición Y centrada

            panel1.Width = panelWidth;
            panel1.Height = panelHeight;
            panel1.Location = new Point(panelX, panelY);
        }

        private void FormLogin_FormClosing(Object sender, FormClosingEventArgs e)
        {


            formLogin formLogin = new formLogin();
            formLogin.Close();
        }



    }
}
