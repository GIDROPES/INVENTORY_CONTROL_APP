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
    public partial class MainShowingForm : Form
    {
        private DAL dal = new DAL();
        private List<string> allStores;
        private string[] arrayStores; //для комбо-бокса
        public static int storeComboBoxCode; //статичный код склада

        public MainShowingForm()
        {
            InitializeComponent();
            allStores = dal.getAllStores();
            arrayStores = (string[])allStores.ToArray();

            cmbBxStores.Items.AddRange(arrayStores);
            cmbBxStores.SelectedItem = arrayStores[0];
        }
        //Метод перехода на форму просмотра товаров на складе по щелчку на кнопку
        private void btnShowStore_Click(object sender, EventArgs e)
        {
            ShowStoreStock sss = new ShowStoreStock();
            sss.Show();
            this.Hide();
        }

        //Метод регулирует, какой код склада будет отправлен для просмотра товаров с конкретного склада
        private void cmbBxStores_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cmbBxStores.SelectedItem.ToString();
            if (selected == arrayStores[0])
                storeComboBoxCode = 1001;
            else if (selected == arrayStores[1])
                storeComboBoxCode = 1002;
            else
                storeComboBoxCode = 1003;

        }

        //Завершение программы по нажатию на встроенную кнопку "закрыть"
        private void MainShowingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //Метод перехода на форму просмотра доставок по щелчку на кнопку
        private void btnShowDelivers_Click(object sender, EventArgs e)
        {
            DeliversForm df = new DeliversForm();
            df.Show();
            this.Hide();

        }

        //Метод перехода на форму просмотра возвратов по щелчку на кнопку
        private void btnShowReturns_Click(object sender, EventArgs e)
        {
            ReturnsForm rf = new ReturnsForm();
            rf.Show();
            this.Hide();
        }
    }
}
