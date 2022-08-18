using System;
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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            MainShowingForm msf = new MainShowingForm();
            msf.Show();
            this.Hide();
        }

        //завершение программы по нажатию на встроенную кнопку "закрыть"
        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
