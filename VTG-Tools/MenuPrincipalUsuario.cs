using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;


namespace ProyectoPeluqueria
{
    public partial class MenuPrincipalUsuario : Form
    {
        string[ ] sProgramsDownloadLinks = new string[ 3 ]
        {
            "https://download.anydesk.com/AnyDesk.exe",
            "https://download.anydesk.com/AnyDesk.exe",
            "https://download.anydesk.com/AnyDesk.exe"
        };

        string[] sProgramsExecutables = new string[3]
        {
            "AnyDesk.exe",
            "",
            ""
        };

        string sDirectoryName = @"\Programs\";

        int iSelectedProgram = -1;

        public MenuPrincipalUsuario()
        {
            InitializeComponent();
        }

        private void MenuPrincipalUsuario_Load(object sender, EventArgs e)
        {
            timer1.Start();
            this.Opacity = 0;
        }

        private void btnDownload(object sender, EventArgs e)
        {
            Button bButton = sender as Button;
            iSelectedProgram = Convert.ToInt32(bButton.TabIndex);

            EnableButtons(sender, false);

            if (File.Exists(@Directory.GetCurrentDirectory( ) + sDirectoryName + sProgramsExecutables[ iSelectedProgram ] ))
            {
                DownloadBar.Value = 100;
                Process.Start(@Directory.GetCurrentDirectory() + sDirectoryName + sProgramsExecutables[iSelectedProgram]);

                EnableButtons(sender, true);
            }

            else
            {
                if( !Directory.Exists(@Directory.GetCurrentDirectory() + sDirectoryName ) )
                    Directory.CreateDirectory(@Directory.GetCurrentDirectory() + sDirectoryName);

                WebClient client = new WebClient();

                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);

                client.DownloadFileAsync(new Uri(@sProgramsDownloadLinks[ iSelectedProgram ] ), 
                    (@Directory.GetCurrentDirectory() + sDirectoryName + sProgramsExecutables[ iSelectedProgram ] ));
            }
        }

        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;
            DownloadBar.Value = int.Parse(Math.Truncate(percentage).ToString());
        }

        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Process.Start(@Directory.GetCurrentDirectory() + sDirectoryName + sProgramsExecutables[iSelectedProgram]);
            EnableButtons(sender, true);
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

        // Stocks
        private void EnableButtons(object sender, bool EnableButtons)
        {
            btnDownload_0.Enabled = EnableButtons ? true : false;
            btnDownload_1.Enabled = EnableButtons ? true : false;
            btnDownload_2.Enabled = EnableButtons ? true : false;
            btnDownload_3.Enabled = EnableButtons ? true : false;
            btnDownload_4.Enabled = EnableButtons ? true : false;
        }

        // Timers
        int iCounter;

        private void timer1_Tick(object sender, EventArgs e)
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
                this.Opacity -= 0.05;

            iCounter++;

            if (iCounter == 100)
            {
                iCounter = 0;

                timer2.Stop();
                Application.Exit();
            }
        }
    }
}