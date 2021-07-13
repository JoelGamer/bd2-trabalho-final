using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bd2_trabalho_final.Classes.Persons.Users;
using bd2_trabalho_final.Services;
using bd2_trabalho_final.Utilities;

namespace bd2_trabalho_final.Forms.OperatorForms
{
    public partial class FrmUser : Form
    {
        private readonly string messageBoxTitle = "Usuários";
        private Operator @operator = null;
        private bool isExecuting;

        public FrmUser()
        {
            InitializeComponent();
            GetFormData();

            if (DgvUsers.Rows.Count < 0) return;

            DgvUsers.Columns[0].HeaderText = "ID";
            DgvUsers.Columns[1].HeaderText = "Nome";
            DgvUsers.Columns[2].HeaderText = "Tipo";
            DgvUsers.Columns[3].HeaderText = "Usuário";
            DgvUsers.Columns[4].HeaderText = "Administrador";
        }

        private void GetFormData()
        {
            DgvUsers.DataSource = UserService.GetDataTableOperatorsHumanized();
        }

        private void DgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            UpdateSelectedRow();
        }

        private void UpdateSelectedRow()
        {
            int index = DgvUsers.CurrentRow.Index;
            if (index < 0) return;

            @operator = ClassCreate.GenerateOperator(
                Convert.ToInt32(DgvUsers.Rows[index].Cells[0].Value),
                Convert.ToString(DgvUsers.Rows[index].Cells[1].Value),
                Convert.ToString(DgvUsers.Rows[index].Cells[3].Value),
                "",
                Convert.ToBoolean(DgvUsers.Rows[index].Cells[4].Value)
            );
        }

        private void BtnShowPassword_Click(object sender, EventArgs e)
        {
            if (!TbxPassword.PasswordChar.Equals('*')) TbxPassword.PasswordChar = char.Parse("*");
            else TbxPassword.PasswordChar = char.Parse("\0");
        }

        private void CRUDButtonsManager(bool create, bool update, bool delete)
        {
            BtnCreate.Enabled = create;
            BtnUpdate.Enabled = update;
            BtnDelete.Enabled = delete;
        }

        private void CRUDButtonsReset()
        {
            CRUDButtonsManager(true, true, true);
            CRUDInputsReset();
        }

        private void CRUDInputsManager(bool name, bool username, bool password, bool administrator)
        {
            TbxName.Enabled = name;
            TbxUsername.Enabled = username;
            TbxPassword.Enabled = password;
            CbxAdministrator.Enabled = administrator;
        }

        private void CRUDInputsFill()
        {
            LblId.Text = @operator.Id.ToString();
            TbxName.Text = @operator.Name;
            TbxUsername.Text = @operator.Username;
            TbxPassword.Text = "";
            CbxAdministrator.Checked = @operator.IsAdministrator;
        }

        private void CRUDInputsReset()
        {
            LblId.Text = "0";
            TbxName.Text = "";
            TbxUsername.Text = "";
            TbxPassword.Text = "";
            CbxAdministrator.Checked = false;
        }

        private void ExecuteEvent(Action isNotExecutingAction, Action isExecutingAction)
        {
            if (isExecuting)
            {
                isExecuting = false;
                isExecutingAction();
                CRUDButtonsReset();
                GetFormData();
            }
            else
            {
                isExecuting = true;
                isNotExecutingAction();
            }
        }

        private void ExecuteEvent(Action isNotExecutingAction, Action isExecutingAction, bool isDelete)
        {
            if (isDelete)
            {
                isExecutingAction();
                GetFormData();
                return;
            }

            if (isExecuting)
            {
                isExecuting = false;
                isExecutingAction();
                CRUDButtonsReset();
                GetFormData();
            }
            else
            {
                isExecuting = true;
                isNotExecutingAction();
            }
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            CRUDButtonsManager(true, false, false);
            ExecuteEvent(PrepareCreate, ExecuteCreate);
        }

        private void PrepareCreate()
        {
            CRUDInputsManager(true, true, true, Session.Operator.IsAdministrator);
        }

        private void ExecuteCreate()
        {
            CRUDInputsManager(false, false, false, false);
            UserService.CreateOperator(ClassCreate.GenerateOperator(TbxName.Text, TbxUsername.Text, TbxPassword.Text, CbxAdministrator.Checked));
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            CRUDButtonsManager(false, true, false);
            ExecuteEvent(PrepareUpdate, ExecuteUpdate);
        }

        private void PrepareUpdate()
        {
            if (@operator == null)
            {
                MessageBox.Show("Deve selecionar um usuário para atualizar ele", messageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CRUDInputsFill();
            CRUDInputsManager(true, true, true, Session.Operator.IsAdministrator);
        }

        private void ExecuteUpdate()
        {
            CRUDInputsManager(false, false, false, false);
            @operator.Name = TbxName.Text;
            @operator.Username = TbxUsername.Text;
            @operator.Password = TbxPassword.Text;
            @operator.IsAdministrator = CbxAdministrator.Checked;

            UserService.UpdateOperator(@operator);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            ExecuteEvent(() => { }, ExecuteDelete, true);
        }

        private void ExecuteDelete()
        {
            if (@operator == null)
            {
                MessageBox.Show("Deve selecionar um usuário para apagar ele", messageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            UserService.DeleteOperator(@operator);
            MessageBox.Show($"Usuário {@operator.Username} excluído com sucesso!", messageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
