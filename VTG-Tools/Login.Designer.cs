namespace ProyectoPeluqueria
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelLogin = new System.Windows.Forms.Panel();
            this.btnClientLogin = new System.Windows.Forms.Button();
            this.pbCloseProgram = new System.Windows.Forms.PictureBox();
            this.lblLoginTitle = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseProgram)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 500);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(72, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Coded by Morancito";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PanelLogin
            // 
            this.PanelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(10)))));
            this.PanelLogin.Controls.Add(this.btnClientLogin);
            this.PanelLogin.Controls.Add(this.pbCloseProgram);
            this.PanelLogin.Controls.Add(this.lblLoginTitle);
            this.PanelLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelLogin.Location = new System.Drawing.Point(274, 0);
            this.PanelLogin.Name = "PanelLogin";
            this.PanelLogin.Size = new System.Drawing.Size(687, 500);
            this.PanelLogin.TabIndex = 1;
            this.PanelLogin.TabStop = true;
            // 
            // btnClientLogin
            // 
            this.btnClientLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(38)))));
            this.btnClientLogin.FlatAppearance.BorderSize = 0;
            this.btnClientLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(72)))));
            this.btnClientLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientLogin.ForeColor = System.Drawing.Color.DarkGray;
            this.btnClientLogin.Location = new System.Drawing.Point(100, 116);
            this.btnClientLogin.Name = "btnClientLogin";
            this.btnClientLogin.Size = new System.Drawing.Size(480, 47);
            this.btnClientLogin.TabIndex = 0;
            this.btnClientLogin.TabStop = false;
            this.btnClientLogin.Text = "PROGRAMAS";
            this.btnClientLogin.UseVisualStyleBackColor = false;
            this.btnClientLogin.Click += new System.EventHandler(this.btnClientLogin_Click);
            // 
            // pbCloseProgram
            // 
            this.pbCloseProgram.Image = ((System.Drawing.Image)(resources.GetObject("pbCloseProgram.Image")));
            this.pbCloseProgram.Location = new System.Drawing.Point(648, 12);
            this.pbCloseProgram.Name = "pbCloseProgram";
            this.pbCloseProgram.Size = new System.Drawing.Size(16, 18);
            this.pbCloseProgram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCloseProgram.TabIndex = 4;
            this.pbCloseProgram.TabStop = false;
            this.pbCloseProgram.Click += new System.EventHandler(this.pbCloseProgram_Click);
            this.pbCloseProgram.MouseLeave += new System.EventHandler(this.pbCloseProgram_MouseLeave);
            this.pbCloseProgram.MouseHover += new System.EventHandler(this.pbCloseProgram_MouseHover);
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.AutoSize = true;
            this.lblLoginTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginTitle.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblLoginTitle.Location = new System.Drawing.Point(254, 37);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(162, 45);
            this.lblLoginTitle.TabIndex = 0;
            this.lblLoginTitle.Text = "VTG Tools";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(961, 500);
            this.Controls.Add(this.PanelLogin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VTG Tools";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelLogin.ResumeLayout(false);
            this.PanelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseProgram)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLoginTitle;
        private System.Windows.Forms.PictureBox pbCloseProgram;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnClientLogin;
        private System.Windows.Forms.Label label1;
    }
}

