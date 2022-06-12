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


namespace Projek_Tea_Break
{
    public partial class formToppingUpdate : Form
    {
        public formToppingUpdate()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_11_TEABREAK;");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        public static string sqlQuery;
        public static string saveID = "";

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

        private void FormbtnEdit_Load(object sender, EventArgs e)
        {
            DataTable dtTopping = new DataTable();
            sqlQuery = "select id_topping as 'ID Topping', nama_topping as 'Nama Topping', harga_topping as 'Harga Topping' from TOPPING where STATUS_DELETE = '0';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTopping);
            dgvTopping.DataSource = dtTopping;
            tboxID.Text = dtTopping.Rows[0]["ID Topping"].ToString();
            tboxNama.Text = dtTopping.Rows[0]["Nama Topping"].ToString();
            tboxHarga.Text = dtTopping.Rows[0]["Harga Topping"].ToString();
                  
        }
        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dgvTopping.Rows[index];
                tboxID.Text = selectedRow.Cells[0].Value.ToString();
                tboxNama.Text = selectedRow.Cells[1].Value.ToString();
                tboxHarga.Text = selectedRow.Cells[2].Value.ToString();
                saveID = selectedRow.Cells["ID Topping"].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            formTopping Fmain = new formTopping();
            Fmain.ShowDialog();
            this.Close();
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (tboxID.Text != dgvTopping.CurrentRow.Cells["ID Topping"].Value.ToString())
                {
                    sqlConnect.Open();
                    sqlQuery = "UPDATE TOPPING SET ID_TOPPING = '" + tboxID.Text + "',NAMA_TOPPING = '" + tboxNama.Text + "', HARGA_TOPPING = '" + tboxHarga.Text + "' WHERE ID_TOPPING ='" + saveID + "'";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();
                }
                else
                {
                    sqlConnect.Open();
                    sqlQuery = "UPDATE TOPPING SET NAMA_TOPPING = '" + tboxNama.Text + "', HARGA_TOPPING = '" + tboxHarga.Text + "' WHERE ID_TOPPING ='" + tboxID.Text + "'";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();
                }

                MessageBox.Show("Berhasil Disimpan");

                Refresh();

                this.Hide();
                formTopping Fmain = new formTopping();
                Fmain.ShowDialog();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Input gagal");
                Refresh();

                this.Hide();
                formTopping Fmain = new formTopping();
                Fmain.ShowDialog();
                this.Close();
            }
        
        }
    }
}
