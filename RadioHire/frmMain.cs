using System;
using System.Windows.Forms;

namespace RadioHire
{
    public sealed partial class frmMain : Form
    {   //Singleton
        private static readonly frmMain _Instance = new frmMain();

        private clsBrandList _BrandList = new clsBrandList();
                
        private frmMain()
        {
            InitializeComponent();
        }

        public static frmMain Instance
        {
            get { return frmMain._Instance; }
        }

        public void UpdateDisplay()
        {
            lstBrand.DataSource = null;
            string[] lcDisplayList = new string[_BrandList.Count];
            _BrandList.Keys.CopyTo(lcDisplayList, 0);
            lstBrand.DataSource = lcDisplayList;            
        }

        private void lstBrand_DoubleClick(object sender, EventArgs e)
        {
            string lcKey;

            lcKey = Convert.ToString(lstBrand.SelectedItem);
            if (lcKey != null)
                try
                {
                    frmInventory.Run(_BrandList[lcKey]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "This should never occur");
                }
        }
       

        private void btnQuit_Click(object sender, EventArgs e)
        {
                try
                {
                    _BrandList.Save();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "File Save Error");
                }
                Close();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                _BrandList = clsBrandList.RetrieveBrandList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "File retrieve error");
            }
            UpdateDisplay();            
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            try
            {
                frmReservation.Run(new clsReservations(_ReservationsList));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error creating new reservation");
            }
        }
    }
}
