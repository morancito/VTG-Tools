using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPeluqueria
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            timer1.Start();
            this.Opacity = 0;
        }
        
        private void pbCloseProgram_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void pbCloseProgram_MouseHover(object sender, EventArgs e)
        {
            pbCloseProgram.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pbCloseProgram_MouseLeave(object sender, EventArgs e)
        {
            pbCloseProgram.BorderStyle = BorderStyle.None;
        }

        int iCounter;

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 0.95)
                this.Opacity += 0.01;

            iCounter++;

            if (iCounter == 100)
            {
                iCounter = 0;
                timer1.Stop();
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
                this.Opacity -= 0.05;

            iCounter++;

            if(iCounter == 100)
            {
                iCounter = 0;

                timer2.Stop();
                Application.Exit();
            }
        }

        private void btnClientLogin_Click(object sender, EventArgs e)
        {
            Hide();

            MenuPrincipalUsuario Formulario2 = new MenuPrincipalUsuario();
            Formulario2.Show();
        }
    }
}
