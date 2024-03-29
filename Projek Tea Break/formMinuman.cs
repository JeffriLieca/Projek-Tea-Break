﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Projek_Tea_Break
{
    public partial class formMinuman : Form
    {
        public formMinuman()
        {
            InitializeComponent();
        }
        public static string sqlConnection = "server=127.0.0.1;uid=root;pwd=;database=db_tea_break";
        MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        public static string sqlQuery;

        DataTable menu = new DataTable();

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
           
            sqlQuery = "select `ID_MINUMAN`,`NAMA_MINUMAN`,`HARGA_MINUMAN` from MINUMAN WHERE STATUS_DELETE = '0'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable menu = new DataTable();
            sqlAdapter.Fill(menu);
            dgvMenu.DataSource = menu;
            tboxID.Text = menu.Rows[0][0].ToString();
            tboxHarga.Text = menu.Rows[0][2].ToString();
            tboxNama.Text = menu.Rows[0][1].ToString();
            
            LoadGambar();

            tboxID.Enabled = false;
            tboxNama.Enabled = false;
            tboxHarga.Enabled = false;
        }

        public void LoadData()
        {
            sqlQuery = "select `ID_MINUMAN`,`NAMA_MINUMAN`,`HARGA_MINUMAN` from MINUMAN WHERE STATUS_DELETE = '0'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable menu = new DataTable();
            sqlAdapter.Fill(menu);
            dgvMenu.DataSource = menu;
        }


        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dgvMenu.Rows[index];
                tboxID.Text = selectedRow.Cells[0].Value.ToString();
                tboxNama.Text = selectedRow.Cells[1].Value.ToString();
                tboxHarga.Text = selectedRow.Cells[2].Value.ToString();

                LoadGambar();
            }
            catch(Exception)
            {
            }
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

            this.Hide();
            formEditPilih formPilih = new formEditPilih();
            formPilih.ShowDialog();
            this.Close();
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            formMinumanUpdate F1 = new formMinumanUpdate();
            F1.ShowDialog();
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            formMinumanInsert F2 = new formMinumanInsert();
            F2.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult drDelete = MessageBox.Show("Confirm to delete?", "Delete", MessageBoxButtons.YesNo);
            if (drDelete == DialogResult.Yes)
            {
                sqlConnect.Open();
                sqlQuery = "update MINUMAN set STATUS_DELETE = '1' where ID_MINUMAN = '" + tboxID.Text + "' ";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                LoadData();
            }
        }
        private void pbProfil_Click(object sender, EventArgs e)
        {
            formProfile formProfil = new formProfile();
            formProfil.ShowDialog();
        }


        // Jeffri
        string imgLocation = "";
        private void buttonAddImage_Click(object sender, EventArgs e) 
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                //display image in picture box
                imgLocation = open.FileName.ToString();
                pictureBoxAdd.ImageLocation = imgLocation;
            }
        }

        public void SaveGambar() // ini apa
        {
            byte[] images = null;
            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);

            sqlConnect.Open();
            sqlQuery = "insert into MINUMAN(GAMBAR) values (@images)";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.Parameters.Add(new MySqlParameter("@images", images));
            int N = sqlCommand.ExecuteNonQuery();
            MessageBox.Show(N.ToString() + " Data Saved Succesfully");
            sqlConnect.Close();
        }


        public void LoadGambar()
        {
            imgLocation = "";
            sqlConnect.Open();
            sqlQuery = "select GAMBAR from MINUMAN where ID_MINUMAN='" + tboxID.Text + "';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable dtCoba = new DataTable();
            sqlAdapter.Fill(dtCoba);
            byte[] images = ((byte[])dtCoba.Rows[0][0]);
            MemoryStream mstream = new MemoryStream(images);
            pictureBoxAdd.Image = Image.FromStream(mstream);
            sqlConnect.Close();
        }

    }
}
