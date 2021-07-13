
namespace bd2_trabalho_final.Forms
{
    partial class FrmMainMenu
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
            this.MSMainMenu = new System.Windows.Forms.MenuStrip();
            this.TSMISair = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMILogout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TSSLSession = new System.Windows.Forms.ToolStripStatusLabel();
            this.TCOperator = new System.Windows.Forms.TabControl();
            this.TPAdministration = new System.Windows.Forms.TabPage();
            this.FLPAdministration = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnUser = new System.Windows.Forms.Button();
            this.TPFinantial = new System.Windows.Forms.TabPage();
            this.TCClient = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.TPProducts = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnProducts = new System.Windows.Forms.Button();
            this.BtnProductsCategories = new System.Windows.Forms.Button();
            this.MSMainMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.TCOperator.SuspendLayout();
            this.TPAdministration.SuspendLayout();
            this.FLPAdministration.SuspendLayout();
            this.TCClient.SuspendLayout();
            this.TPProducts.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MSMainMenu
            // 
            this.MSMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMISair,
            this.TSMILogout});
            this.MSMainMenu.Location = new System.Drawing.Point(0, 0);
            this.MSMainMenu.Name = "MSMainMenu";
            this.MSMainMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MSMainMenu.Size = new System.Drawing.Size(800, 29);
            this.MSMainMenu.TabIndex = 1;
            this.MSMainMenu.Text = "menuStrip1";
            // 
            // TSMISair
            // 
            this.TSMISair.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TSMISair.Name = "TSMISair";
            this.TSMISair.Size = new System.Drawing.Size(49, 25);
            this.TSMISair.Text = "Sair";
            this.TSMISair.Click += new System.EventHandler(this.TSMISair_Click);
            // 
            // TSMILogout
            // 
            this.TSMILogout.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TSMILogout.Name = "TSMILogout";
            this.TSMILogout.Size = new System.Drawing.Size(71, 25);
            this.TSMILogout.Text = "Logout";
            this.TSMILogout.Click += new System.EventHandler(this.TSMILogout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSLSession});
            this.statusStrip1.Location = new System.Drawing.Point(0, 426);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 24);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TSSLSession
            // 
            this.TSSLSession.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TSSLSession.Name = "TSSLSession";
            this.TSSLSession.Size = new System.Drawing.Size(89, 19);
            this.TSSLSession.Text = "Sessão Atual:";
            // 
            // TCOperator
            // 
            this.TCOperator.Controls.Add(this.TPProducts);
            this.TCOperator.Controls.Add(this.TPFinantial);
            this.TCOperator.Controls.Add(this.TPAdministration);
            this.TCOperator.Dock = System.Windows.Forms.DockStyle.Left;
            this.TCOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCOperator.Location = new System.Drawing.Point(0, 29);
            this.TCOperator.Name = "TCOperator";
            this.TCOperator.SelectedIndex = 0;
            this.TCOperator.Size = new System.Drawing.Size(287, 397);
            this.TCOperator.TabIndex = 4;
            this.TCOperator.Visible = false;
            // 
            // TPAdministration
            // 
            this.TPAdministration.Controls.Add(this.FLPAdministration);
            this.TPAdministration.Location = new System.Drawing.Point(4, 29);
            this.TPAdministration.Name = "TPAdministration";
            this.TPAdministration.Padding = new System.Windows.Forms.Padding(3);
            this.TPAdministration.Size = new System.Drawing.Size(279, 364);
            this.TPAdministration.TabIndex = 0;
            this.TPAdministration.Text = "Administração";
            this.TPAdministration.UseVisualStyleBackColor = true;
            // 
            // FLPAdministration
            // 
            this.FLPAdministration.Controls.Add(this.BtnUser);
            this.FLPAdministration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPAdministration.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPAdministration.Location = new System.Drawing.Point(3, 3);
            this.FLPAdministration.Name = "FLPAdministration";
            this.FLPAdministration.Size = new System.Drawing.Size(273, 358);
            this.FLPAdministration.TabIndex = 0;
            // 
            // BtnUser
            // 
            this.BtnUser.Location = new System.Drawing.Point(3, 3);
            this.BtnUser.Name = "BtnUser";
            this.BtnUser.Size = new System.Drawing.Size(267, 33);
            this.BtnUser.TabIndex = 0;
            this.BtnUser.Text = "Usuários";
            this.BtnUser.UseVisualStyleBackColor = true;
            this.BtnUser.Click += new System.EventHandler(this.BtnUser_Click);
            // 
            // TPFinantial
            // 
            this.TPFinantial.Location = new System.Drawing.Point(4, 29);
            this.TPFinantial.Name = "TPFinantial";
            this.TPFinantial.Padding = new System.Windows.Forms.Padding(3);
            this.TPFinantial.Size = new System.Drawing.Size(279, 364);
            this.TPFinantial.TabIndex = 1;
            this.TPFinantial.Text = "Financeiro";
            this.TPFinantial.UseVisualStyleBackColor = true;
            // 
            // TCClient
            // 
            this.TCClient.Controls.Add(this.tabPage3);
            this.TCClient.Controls.Add(this.tabPage4);
            this.TCClient.Dock = System.Windows.Forms.DockStyle.Left;
            this.TCClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCClient.Location = new System.Drawing.Point(287, 29);
            this.TCClient.Name = "TCClient";
            this.TCClient.SelectedIndex = 0;
            this.TCClient.Size = new System.Drawing.Size(246, 397);
            this.TCClient.TabIndex = 5;
            this.TCClient.Visible = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(238, 364);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(192, 364);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // TPProducts
            // 
            this.TPProducts.Controls.Add(this.flowLayoutPanel1);
            this.TPProducts.Location = new System.Drawing.Point(4, 29);
            this.TPProducts.Name = "TPProducts";
            this.TPProducts.Size = new System.Drawing.Size(279, 364);
            this.TPProducts.TabIndex = 2;
            this.TPProducts.Text = "Produtos";
            this.TPProducts.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.BtnProducts);
            this.flowLayoutPanel1.Controls.Add(this.BtnProductsCategories);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(279, 364);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // BtnProducts
            // 
            this.BtnProducts.Location = new System.Drawing.Point(3, 3);
            this.BtnProducts.Name = "BtnProducts";
            this.BtnProducts.Size = new System.Drawing.Size(273, 33);
            this.BtnProducts.TabIndex = 1;
            this.BtnProducts.Text = "Produtos";
            this.BtnProducts.UseVisualStyleBackColor = true;
            // 
            // BtnProductsCategories
            // 
            this.BtnProductsCategories.Location = new System.Drawing.Point(3, 42);
            this.BtnProductsCategories.Name = "BtnProductsCategories";
            this.BtnProductsCategories.Size = new System.Drawing.Size(273, 33);
            this.BtnProductsCategories.TabIndex = 2;
            this.BtnProductsCategories.Text = "Categorias dos Produtos";
            this.BtnProductsCategories.UseVisualStyleBackColor = true;
            this.BtnProductsCategories.Click += new System.EventHandler(this.BtnProductsCategories_Click);
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TCClient);
            this.Controls.Add(this.TCOperator);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MSMainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MSMainMenu;
            this.Name = "FrmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMainMenu_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMainMenu_FormClosed);
            this.MSMainMenu.ResumeLayout(false);
            this.MSMainMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.TCOperator.ResumeLayout(false);
            this.TPAdministration.ResumeLayout(false);
            this.FLPAdministration.ResumeLayout(false);
            this.TCClient.ResumeLayout(false);
            this.TPProducts.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MSMainMenu;
        private System.Windows.Forms.ToolStripMenuItem TSMISair;
        private System.Windows.Forms.ToolStripMenuItem TSMILogout;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TSSLSession;
        private System.Windows.Forms.TabControl TCOperator;
        private System.Windows.Forms.TabPage TPAdministration;
        private System.Windows.Forms.TabPage TPFinantial;
        private System.Windows.Forms.TabControl TCClient;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.FlowLayoutPanel FLPAdministration;
        private System.Windows.Forms.Button BtnUser;
        private System.Windows.Forms.TabPage TPProducts;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BtnProducts;
        private System.Windows.Forms.Button BtnProductsCategories;
    }
}