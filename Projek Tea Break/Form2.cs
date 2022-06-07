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

        private void FormOrder_Load(object sender, EventArgs e)
        {
            buttonEditMenu.BackColor = Color.Transparent;
            buttonAdmin.BackColor = Color.Transparent;
            buttonCashier.BackColor = Color.ForestGreen;
            InvisText();
            buttonCashier.Text = "Cashier";
        }
        private void buttonCashier_Click(object sender, EventArgs e)
        {
            buttonEditMenu.BackColor = Color.Transparent;
            buttonAdmin.BackColor = Color.Transparent;
            buttonCashier.BackColor = Color.ForestGreen;
            InvisText();
            buttonCashier.Text = "Cashier";
        }


        private void buttonEditMenu_Click(object sender, EventArgs e)
        {
            buttonCashier.BackColor = Color.Transparent;
            buttonAdmin.BackColor = Color.Transparent;
            buttonEditMenu.BackColor = Color.ForestGreen;
            InvisText();
            buttonEditMenu.Text = "Edit Menu";
        }

        private void buttonAdmin_Click_1(object sender, EventArgs e)
        {
            buttonCashier.BackColor = Color.Transparent;
            buttonEditMenu.BackColor = Color.Transparent;
            buttonAdmin.BackColor = Color.ForestGreen;
            InvisText();
            buttonAdmin.Text = "Admin";
        }

        public void InvisText()
        {
            buttonCashier.Text = " ";
            buttonEditMenu.Text = " ";
            buttonAdmin.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonCashier.Name = "testnama";
            label4.Text = buttonCashier.Name;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }


        public static int posisiX = 0;
        public static int posisiY = 0;
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    Button buttonhu = new Button();
                    panel3.Controls.Add(buttonhu);
                    buttonhu.Size = new Size(110, 140);
                    buttonhu.Location = new Point(posisiX, posisiY);
                    buttonhu.Name = "buttonBaru";
                    buttonhu.Text = posisiX.ToString();
                    buttonhu.Visible = true;
                    buttonhu.BringToFront();
                    buttonhu.ImageList = imageList1;
                    buttonhu.ImageIndex = 1;
                    buttonhu.TextImageRelation = TextImageRelation.ImageAboveText;
                    buttonhu.TextAlign = ContentAlignment.MiddleRight;
                    buttonhu.ImageAlign = ContentAlignment.MiddleCenter;
                    buttonhu.Click += Buttonhu_Click;
                    buttonhu.ForeColor = Color.Black;
                    posisiX += 120;
                    if (posisiX > 300)
                    {
                        posisiX = 0;
                    }
                }
                posisiY += 150;
            }
        }

        private void Buttonhu_Click(object sender, EventArgs e)
        {
            Button buttonhu = (sender as Button);
            MessageBox.Show(buttonhu.Location.ToString());
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
        }
    }
}
