using System;
using System.Windows.Forms;

namespace RadioHire
{
    public partial class frmRadio : Form
    {
        protected clsInventory _Inventory;
        protected frmHireRadio _HireRadioForm = new frmHireRadio();
        protected frmSaleRadio _SaleRadioForm = new frmSaleRadio();
        protected string[] _Brand = { "Hytera", "Kenwood", "Motorola", "Tait", "Vertex" };

        public frmRadio()
        {
            InitializeComponent();
        }
                public void SetDetails(clsInventory prInventory)
        {
            _Inventory = prInventory;
            updateForm();
            ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                pushData();
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected virtual bool isValid()
        {
            return true;
        }

        protected virtual void updateForm()
        {
            cboBrand.DataSource = _Brand;
            cboBrand.SelectedIndex = 0;
            txtModel.Text = _Inventory.Model;
            txtDescription.Text = _Inventory.Description;
            txtPrice.Text = _Inventory.Price.ToString();
        }

        protected virtual void pushData()
        {
            _Inventory.Model = txtModel.Text;
            _Inventory.Description = txtDescription.Text;
            _Inventory.Price = decimal.Parse(txtPrice.Text);
        }
    }
}
