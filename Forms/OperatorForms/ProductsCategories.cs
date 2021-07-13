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
using bd2_trabalho_final.Classes.Persons.Users;
using bd2_trabalho_final.Services;
using bd2_trabalho_final.Utilities;

namespace bd2_trabalho_final.Forms.OperatorForms
{
    public partial class FrmProductsCategories : Form
    {
        private readonly string messageBoxTitle = "Categoria dos Produtos";
        private ProductCategory productCategory = null;
        private bool isExecuting;

        public FrmProductsCategories()
        {
            InitializeComponent();
            GetFormData();

            if (DgvUsers.Rows.Count < 0) return;

            DgvUsers.Columns[0].HeaderText = "ID";
            DgvUsers.Columns[1].HeaderText = "Nome";
        }

        private void GetFormData()
        {
            DgvUsers.DataSource = ProductService.GetDataTableProductsCategories();
        }

        private void DgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            UpdateSelectedRow();
        }

        private DataGridViewCell GetDGVCell(int index, int cell)
        {
            return DgvUsers.Rows[index].Cells[cell];
        }

        private void UpdateSelectedRow()
        {
            int index = DgvUsers.CurrentRow.Index;
            if (index < 0) return;

            productCategory = new ProductCategory(
                Convert.ToInt32(GetDGVCell(index, 0).Value),
                Convert.ToString(GetDGVCell(index, 1).Value));
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

        private void CRUDInputsManager(bool name)
        {
            TbxName.Enabled = name;
        }

        private void CRUDInputsFill()
        {
            LblId.Text = productCategory.Id.ToString();
            TbxName.Text = productCategory.Name;
        }

        private void CRUDInputsReset()
        {
            LblId.Text = "0";
            TbxName.Text = "";
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
            CRUDInputsManager(true);
        }

        private void ExecuteCreate()
        {
            CRUDInputsManager(false);
            ProductService.CreateProductCategory(new ProductCategory(0, TbxName.Text));
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            CRUDButtonsManager(false, true, false);
            ExecuteEvent(PrepareUpdate, ExecuteUpdate);
        }

        private void PrepareUpdate()
        {
            if (productCategory == null)
            {
                MessageBox.Show("Deve selecionar uma categoria para atualizar ela", messageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CRUDInputsFill();
            CRUDInputsManager(true);
        }

        private void ExecuteUpdate()
        {
            CRUDInputsManager(false);
            productCategory.Name = TbxName.Text;

            ProductService.UpdateProductCategory(productCategory);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            ExecuteEvent(() => { }, ExecuteDelete, true);
        }

        private void ExecuteDelete()
        {
            if (productCategory == null)
            {
                MessageBox.Show("Deve selecionar uma categoria para apagar ela", messageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ProductService.DeleteProductCategory(productCategory);
            MessageBox.Show($"Categoria {productCategory.Name} excluída com sucesso!", messageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
