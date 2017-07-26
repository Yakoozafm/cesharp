namespace taszimozgas_c
{
    partial class frmIndito
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIndito));
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMozgas = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnMenu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.btnKilepes);
            this.panel1.Controls.Add(this.btnAdmin);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnMozgas);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Name = "panel1";
            // 
            // btnKilepes
            // 
            resources.ApplyResources(this.btnKilepes, "btnKilepes");
            this.btnKilepes.FlatAppearance.BorderSize = 0;
            this.btnKilepes.ForeColor = System.Drawing.Color.Gold;
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.UseVisualStyleBackColor = false;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // btnAdmin
            // 
            resources.ApplyResources(this.btnAdmin, "btnAdmin");
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.ForeColor = System.Drawing.Color.Gold;
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.ForeColor = System.Drawing.Color.Gold;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMozgas
            // 
            resources.ApplyResources(this.btnMozgas, "btnMozgas");
            this.btnMozgas.FlatAppearance.BorderSize = 0;
            this.btnMozgas.ForeColor = System.Drawing.Color.Gold;
            this.btnMozgas.Name = "btnMozgas";
            this.btnMozgas.UseVisualStyleBackColor = false;
            this.btnMozgas.Click += new System.EventHandler(this.btnMozgas_Click);
            // 
            // btnLogin
            // 
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.ForeColor = System.Drawing.Color.Gold;
            this.btnLogin.ImageList = this.imageList1;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.button4_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "startup.png");
            this.imageList1.Images.SetKeyName(1, "if_menu-alt_134216.png");
            this.imageList1.Images.SetKeyName(2, "Burger.png");
            // 
            // btnMenu
            // 
            resources.ApplyResources(this.btnMenu, "btnMenu");
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.ForeColor = System.Drawing.Color.Gold;
            this.btnMenu.ImageList = this.imageList1;
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // frmIndito
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIndito";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnKilepes;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMozgas;
    }
}