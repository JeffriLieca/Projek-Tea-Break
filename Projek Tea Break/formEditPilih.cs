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
    public partial class formEditPilih : Form
    {
        public formEditPilih()
        {
            InitializeComponent();
        }

        private void InvisText()
        {
            buttonCashier.Text = " ";
            buttonEditMenu.Text = " ";
            buttonAdmin.Text = " ";
        }
        private void FormOrder_Load(object sender, EventArgs e)
        {
            buttonEditMenu.BackColor = Color.ForestGreen;
            buttonAdmin.BackColor = Color.Transparent;
            buttonCashier.BackColor = Color.Transparent;
            InvisText();
            buttonEditMenu.Text = "Edit";
        }
        

        private void buttonCashier_Click(object sender, EventArgs e)
        {
            buttonEditMenu.BackColor = Color.Transparent;
            buttonAdmin.BackColor = Color.Transparent;
            buttonCashier.BackColor = Color.ForestGreen;
            InvisText();
            buttonCashier.Text = "Cashier";

            this.Hide();
            FormOrder formOrder = new FormOrder();
            formOrder.ShowDialog();
            this.Close();
        }


        private void buttonEditMenu_Click(object sender, EventArgs e)
        {
            buttonCashier.BackColor = Color.Transparent;
            buttonAdmin.BackColor = Color.Transparent;
            buttonEditMenu.BackColor = Color.ForestGreen;
            InvisText();
            buttonEditMenu.Text = "Edit";
        }

        private void buttonAdmin_Click_1(object sender, EventArgs e)
        {
            buttonCashier.BackColor = Color.Transparent;
            buttonEditMenu.BackColor = Color.Transparent;
            buttonAdmin.BackColor = Color.ForestGreen;
            InvisText();
            buttonAdmin.Text = "Admin";

            this.Hide();
            formAdmin formAdmin = new formAdmin();
            formAdmin.ShowDialog();
            this.Close();

        }

        private void btnMinuman_Click(object sender, EventArgs e)
        {
            this.Hide();
            formMinuman formMinuman = new formMinuman();
            formMinuman.ShowDialog();
            this.Close();
        }

        private void btnTopping_Click(object sender, EventArgs e)
        {
            this.Hide();
            formTopping formTopping = new formTopping();
            formTopping.ShowDialog();
            this.Close();
        }

        private void btnPromo_Click(object sender, EventArgs e)
        {
            this.Hide();
            formPromo formMinuman = new formPromo();
            formMinuman.ShowDialog();
            this.Close();
        }
    }
 }
