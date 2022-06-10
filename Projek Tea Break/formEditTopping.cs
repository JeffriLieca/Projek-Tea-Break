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

        DataTable dtTopping = new DataTable();

        private void FormOrder_Load(object sender, EventArgs e)
        {
            sqlConnect.Open();
            sqlQuery = "select id_topping as 'ID', nama_topping as 'Nama', harga_topping as 'Harga' from TOPPING where STATUS_DELETE = '0';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTopping);
            dgvMenu.DataSource = dtTopping;
            sqlConnect.Close();
        }
        private void buttonCashier_Click(object sender, EventArgs e)
        {
            buttonEditMenu.BackColor = Color.Transparent;
            buttonAdmin.BackColor = Color.Transparent;
            buttonCashier.BackColor = Color.ForestGreen;
            buttonCashier.Text = "Cashier";
        }


        private void buttonEditMenu_Click(object sender, EventArgs e)
        {
            buttonCashier.BackColor = Color.Transparent;
            buttonAdmin.BackColor = Color.Transparent;
            buttonEditMenu.BackColor = Color.ForestGreen;
            buttonEditMenu.Text = "Edit Menu";
        }

        private void buttonAdmin_Click_1(object sender, EventArgs e)
        {
            buttonCashier.BackColor = Color.Transparent;
            buttonEditMenu.BackColor = Color.Transparent;
            buttonAdmin.BackColor = Color.ForestGreen;
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

        }

        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tboxID.Text = dgvMenu.Rows[e.RowIndex].Cells[0].Value.ToString();
            tboxNama.Text = dgvMenu.Rows[e.RowIndex].Cells[1].Value.ToString();
            tboxHarga.Text = dgvMenu.Rows[e.RowIndex].Cells[2].Value.ToString();

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            sqlQuery = "INSERT INTO TOPPING VALUES('" + tboxID.Text + "', '" + tboxNama.Text + "' , '" + tboxHarga.Text + "', '0');";
            btnSave.Visible = true;
            btnEdit.Visible = false;
            btnDelete.Visible = false;
            btnAdd.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tboxID.Text != dgvMenu.Rows[e.RowIndex].Cells[0].Value.ToString())
            {
                sqlQuery = "update TOPPING set id_topping = '" + tboxID.Text + "', nama_topping = '" + tboxNama.Text + "' , harga_topping = '" + tboxHarga.Text + "' where id_topping = '" + tboxID.Text + "';";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
            }
            else
            {
                sqlQuery = "update TOPPING set nama_topping = '" + tboxNama.Text + "' , harga_topping = '" + tboxHarga.Text + "' where id_topping = '" + tboxID.Text + "';";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
            }
        }

        private void buttonAddImage_Click(object sender, EventArgs e)
        {

        }
    }
}

