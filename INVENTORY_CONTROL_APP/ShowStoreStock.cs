using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INVENTORY_CONTROL_APP
{
    public partial class ShowStoreStock : Form
    {
        DAL dal = new DAL();
        public ShowStoreStock()
        {
            InitializeComponent();
            if (dal.getAllProductsFromStore(MainShowingForm.storeComboBoxCode) != null) { 
            ArrayList allProducts = dal.getAllProductsFromStore(MainShowingForm.storeComboBoxCode); //получение всех товаров с конкретного склада по коду склада из предыдущей формы
            dgvShowProducts.DataSource = allProducts; //источник данных для DGV
            }
        }

        private void ShowStoreStock_Load(object sender, EventArgs e)
        {

        }

        private void btnGoBack1_Click(object sender, EventArgs e)
        {
            MainShowingForm msf = new MainShowingForm();
            msf.Show();
            this.Hide();
        }
        //завершение программы по нажатию на встроенную кнопку "закрыть"
        private void ShowStoreStock_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
