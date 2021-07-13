using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bd2_trabalho_final.Services;
// using bd2_trabalho_final.Forms.Client;
using bd2_trabalho_final.Forms.OperatorForms;

namespace bd2_trabalho_final.Forms
{
    public partial class FrmMainMenu : Form
    {
        private bool logout = false;

        public FrmMainMenu()
        {
            InitializeComponent();
            InitializeLayout();
            TSSLSession.Text = $"Sessão Atual: {Session.UserName}";
        }

        private void InitializeLayout()
        {
            if (Session.IsLoggedUserOperator()) TCOperator.Visible = true;
            else TCClient.Visible = true;
        }

        #region EXIT_FUNTIONALITY

        private void TSMILogout_Click(object sender, EventArgs e)
        {
            logout = true;
            Close();
        }

        private void TSMISair_Click(object sender, EventArgs e)
        {
            logout = false;
            Close();
        }

        private void FrmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (logout)
            {
                DialogResult logoutResult = MessageBox.Show("Deseja fazer logout do sistema?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (logoutResult == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }

                Session.Logout();
                new FrmLogin().Show();
                return;
            }

            DialogResult result = MessageBox.Show("Deseja sair do sistema?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.No) e.Cancel = true;
        }

        private void FrmMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!logout) Application.Exit();
        }

        #endregion

        private void OpenSelectedForm(Form form, Form parentForm)
        {
            if (false)
            {
                MessageBox.Show("Já existe um formulário aberto!", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //isFormOpen = true;
            form.MdiParent = parentForm;
            form.Show();
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            OpenSelectedForm(new FrmUser(), this);
        }

        private void BtnProductsCategories_Click(object sender, EventArgs e)
        {
            OpenSelectedForm(new FrmProductsCategories(), this);
        }
    }
}
