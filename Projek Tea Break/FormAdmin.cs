using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projek_Tea_Break
{
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
        }

        private void daftarMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPilihan FormPilihan = new FormPilihan();
            FormPilihan.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonCashier_Click(object sender, EventArgs e)
        {
            buttonCashier.BackColor = Color.ForestGreen;
            buttonEdit.BackColor = Color.White;
            pictureBoxEdit.BackColor = Color.White;
            pictureBoxCashier.BackColor = Color.ForestGreen;
            labelEdit.BackColor = Color.White;
            labelEdit.ForeColor = Color.White;
            labelCashier.ForeColor = Color.White;
            labelCashier.BackColor = Color.ForestGreen;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            buttonCashier.BackColor = Color.White;
            buttonEdit.BackColor = Color.ForestGreen;
            pictureBoxCashier.BackColor = Color.White;
            pictureBoxEdit.BackColor = Color.ForestGreen;
            labelCashier.BackColor = Color.White;
            labelCashier.ForeColor = Color.White;
            labelEdit.BackColor = Color.ForestGreen;
            labelEdit.ForeColor = Color.White;
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            buttonCashier.BackColor = Color.White;
            buttonAdmin.BackColor = Color.ForestGreen;
            pictureBoxCashier.BackColor = Color.White;
            pictureBoxEdit.BackColor = Color.White;
            labelCashier.BackColor = Color.White;
            labelCashier.ForeColor = Color.White;
            labelEdit.BackColor = Color.White;
            labelEdit.ForeColor = Color.White;
        }
    }
}
