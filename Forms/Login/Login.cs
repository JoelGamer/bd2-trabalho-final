using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bd2_trabalho_final.Classes;
using bd2_trabalho_final.Enums;
using bd2_trabalho_final.Services;

namespace bd2_trabalho_final.Forms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            TbxUsername.Text = Properties.Settings.Default.Username;
            TbxPassword.Text = Properties.Settings.Default.Password;
            CbxRememberPassword.Checked = Properties.Settings.Default.IsSavingPassword;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            PerformUserLogin();
        }

        private void TbxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)13))
            {
                PerformUserLogin();
            }
        }


        private void PerformUserLogin()
        {
            string username = TbxUsername.Text;
            string password = TbxPassword.Text;
            int idUser = LoginService.IsValidLogin(username, password);

            if (idUser != 0)
            {
                SaveSettings();

                if (UserService.GetUser(idUser).UserType == UserType.Client) Session.Client = UserService.GetClient(idUser);
                else Session.Operator = UserService.GetOperator(idUser);

                Hide();
                new FrmMainMenu().Show();
            }
            else MessageBox.Show("Usuário e/ou senha inválido!", "Login", MessageBoxButtons.OK);
        }

        private void SaveSettings()
        {
            if (CbxRememberPassword.Checked)
            {
                Properties.Settings.Default.Username = TbxUsername.Text;
                Properties.Settings.Default.Password = TbxPassword.Text;
                Properties.Settings.Default.IsSavingPassword = CbxRememberPassword.Checked;
            }
            else
            {
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.IsSavingPassword = false;
            }

            Properties.Settings.Default.Save();
        }
    }
}
