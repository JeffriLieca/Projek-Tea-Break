using System;
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
        public static string buatID = "";

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
        private void BuatInsertID()
        {
            DataTable cekID = new DataTable();
            sqlQuery = "select right(id_topping,2) as urut from TOPPING order by 1 desc;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(cekID);
            string noID = "";
            if (cekID.Rows.Count == 0)
            {
                buatID = "TOP01";
            }
            else
            {
                noID = (Convert.ToInt32(cekID.Rows[0][0].ToString()) + 1).ToString();
                for (int i = 0; i < 2-noID.Length; i++)
                {
                    noID = "0" + noID;
                }
                buatID = "TOP" + noID;
            }
            tboxID.Text = buatID;
        }
        private void FormbtnAdd_Load(object sender, EventArgs e)
        {
            Refresh();
            BuatInsertID();
            tboxID.ReadOnly = true;
        }
        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            formTopping Fmain = new formTopping();
            Fmain.ShowDialog();
            this.Close();
        }

        private void btnSaveAdd_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();
            sqlQuery = "INSERT INTO `TOPPING`VALUES('" + tboxID.Text + "','" + tboxNama.Text + "','" + tboxHarga.Text + "','0')";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            MessageBox.Show($"{tboxID.Text} Berhasil Disimpan");
            Refresh();

            this.Hide();
            formTopping Fmain = new formTopping();
            Fmain.ShowDialog();
            this.Close();
        }
    }
}
