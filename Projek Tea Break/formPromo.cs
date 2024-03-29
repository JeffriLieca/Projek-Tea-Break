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
    public partial class formPromo : Form
    {
        public formPromo()
        {
            InitializeComponent();
        }
        public static string sqlConnection = "server=127.0.0.1;uid=root;pwd=;database=db_tea_break";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public static string sqlQuery;
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

            LoadData();

            sqlQuery = "select `ID_PROMO`,`NAMA_PROMO`,`BESAR_PROMO`,`tgl_promo` , `end_promo` from PROMO where status_delete ='0'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            tboxID.Text = dt.Rows[0][0].ToString();
            tboxNama.Text = dt.Rows[0][1].ToString();
            tboxBesar.Text = dt.Rows[0][2].ToString();
            dtpFrom.Text = dt.Rows[0][3].ToString();
            dtpTo.Text = dt.Rows[0][4].ToString();

            tboxID.Enabled = false;
            tboxNama.Enabled = false;
            tboxBesar.Enabled = false;
            dtpFrom.Enabled = false;
            dtpTo.Enabled = false;
        }

        public void LoadData()
        {
            DataTable promo = new DataTable();
            sqlQuery = "select `ID_PROMO` as 'ID Promo',`NAMA_PROMO` as 'Nama Promo',`BESAR_PROMO` as 'Besar Promo',`tgl_promo` as 'Tanggal Mulai', `end_promo` as 'Tanggal Berakhir' from PROMO WHERE STATUS_DELETE = '0'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(promo);
            dgvPromo.DataSource = promo;
        }


        private void dgvPromo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dgvPromo.Rows[index];
                tboxID.Text = selectedRow.Cells[0].Value.ToString();
                tboxNama.Text = selectedRow.Cells[1].Value.ToString();
                tboxBesar.Text = selectedRow.Cells[2].Value.ToString();
                dtpFrom.Text = selectedRow.Cells[3].Value.ToString();
                dtpTo.Text = selectedRow.Cells[4].Value.ToString();
            }
            catch (Exception)
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
            this.Hide();
            formPromoUpdate F3 = new formPromoUpdate();
            F3.ShowDialog();
            this.Close();
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            this.Hide();
            formPromoInsert F2 = new formPromoInsert();
            F2.ShowDialog();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult drDelete = MessageBox.Show("Confirm to delete?", "Delete", MessageBoxButtons.YesNo);
            if (drDelete == DialogResult.Yes)
            {
                sqlConnect.Open();
                sqlQuery = "update PROMO set STATUS_DELETE = '1' where ID_PROMO = '" + tboxID.Text + "' ";
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

        private void tboxBesar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
