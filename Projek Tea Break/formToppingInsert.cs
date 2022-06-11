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
    public partial class formToppingInsert : Form
    {
        public formToppingInsert()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_11_TEABREAK;");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        public static string sqlQuery;

        DataTable dtTopping = new DataTable();

        private void Refresh()
        {
            DataTable dtTopping = new DataTable();
            sqlQuery = "select id_topping as 'ID Topping', nama_topping as 'Nama Topping', harga_topping as 'Harga Topping' from TOPPING where STATUS_DELETE = '0';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTopping);
            dgvTopping.DataSource = dtTopping;
        }

        private void FormbtnAdd_Load(object sender, EventArgs e)
        {
            Refresh();

            tboxID.Text = dtTopping.Rows[0]["ID Topping"].ToString();
            tboxNama.Text = dtTopping.Rows[0]["Nama Topping"].ToString();
            tboxHarga.Text = dtTopping.Rows[0]["Harga Topping"].ToString();
        }
        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            formTopping Fmain = new formTopping();
            Fmain.Show();
            this.Close();
        }

        private void btnSaveAdd_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();
            sqlQuery = "INSERT INTO `TOPPING`VALUES('" + tboxID.Text + "','" + tboxNama.Text + "','" + tboxHarga.Text + "','0')";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            MessageBox.Show("Berhasil Disimpan");
            Refresh();

            this.Hide();
            formTopping Fmain = new formTopping();
            Fmain.Show();
            this.Close();
        }

        private void dgvTopping_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvTopping.Rows[index];
            tboxID.Text = selectedRow.Cells[0].Value.ToString();
            tboxNama.Text = selectedRow.Cells[1].Value.ToString();
            tboxHarga.Text = selectedRow.Cells[2].Value.ToString();
        }
    }
}
