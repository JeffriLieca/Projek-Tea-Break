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
using System.Resources;

namespace Projek_Tea_Break
{
    public partial class formEditTopping : Form
    {
        public formEditTopping()
        {
            InitializeComponent();
        }

        public static string sqlConnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_11_TEABREAK";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public static string sqlQuery;
        public static string cekID = "";

        DataTable dtTopping = new DataTable();

        private void Refresh()
        {
            DataTable dtTopping = new DataTable();
            sqlQuery = "select id_topping as 'ID', nama_topping as 'Nama', harga_topping as 'Harga' from TOPPING where STATUS_DELETE = '0';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTopping);
            dgvTopping.DataSource = dtTopping;
        }
        private void InvisText()
        {
            buttonCashier.Text = " ";
            buttonEditMenu.Text = " ";
            buttonAdmin.Text = " ";
        }
        private void FormOrder_Load(object sender, EventArgs e)
        {
            buttonEditMenu.BackColor = Color.Transparent;
            buttonAdmin.BackColor = Color.Transparent;
            buttonCashier.BackColor = Color.ForestGreen;
            InvisText();
            buttonCashier.Text = "Cashier";

            Refresh();
            
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnSave.Visible = true;
            btnEdit.Visible = false;
            btnDelete.Visible = false;
            btnAdd.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sqlQuery = "update TOPPING set STATUS_DELETE = 1 where ID_TOPPING = '" + tboxID.Text + "' ";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();

            Refresh();
        }

        private void dgvTopping_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tboxID.Text = dgvTopping.Rows[e.RowIndex].Cells[0].Value.ToString();
            tboxNama.Text = dgvTopping.Rows[e.RowIndex].Cells[1].Value.ToString();
            tboxHarga.Text = dgvTopping.Rows[e.RowIndex].Cells[2].Value.ToString();
            cekID = dgvTopping.Rows[e.RowIndex].Cells["ID"].Value.ToString();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            sqlQuery = "INSERT INTO TOPPING VALUES('" + tboxID.Text + "', '" + tboxNama.Text + "' , '" + tboxHarga.Text + "', '0');";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            MessageBox.Show("Berhasil ditambah");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tboxID.Text != dgvTopping.CurrentRow.Cells["ID"].Value.ToString())
            {
                sqlQuery = "update TOPPING set id_topping = '" + tboxID.Text + "', nama_topping = '" + tboxNama.Text + "' , harga_topping = '" + tboxHarga.Text + "' where id_topping = '" + cekID + "';";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                MessageBox.Show("Berhasil diubah");
                Refresh();
            }
            else
            {
                sqlQuery = "update TOPPING set nama_topping = '" + tboxNama.Text + "' , harga_topping = '" + tboxHarga.Text + "' where id_topping = '" + tboxID.Text + "';";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                MessageBox.Show("Berhasil diubah");
                Refresh();
            }
        }

        private void pbProfil_Click(object sender, EventArgs e)
        {
            formProfile formProfil = new formProfile();
            formProfil.ShowDialog();
            this.Close();
        }
    }
}

