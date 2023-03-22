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
    public partial class formTopping : Form
    {
        public formTopping()
        {
            InitializeComponent();
        }

        public static string sqlConnection = "server=127.0.0.1;uid=root;pwd=;database=db_tea_break";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
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

            tboxID.Enabled = false;
            tboxHarga.Enabled = false;
            tboxNama.Enabled = false;

            DataTable dtTopping = new DataTable();
            sqlQuery = "select id_topping as 'ID Topping', nama_topping as 'Nama Topping', harga_topping as 'Harga Topping' from TOPPING where STATUS_DELETE = '0';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTopping);
            dgvTopping.DataSource = dtTopping;
            tboxHarga.Text = dtTopping.Rows[0]["Harga Topping"].ToString();
            tboxID.Text = dtTopping.Rows[0]["ID Topping"].ToString();
            tboxNama.Text = dtTopping.Rows[0]["Nama Topping"].ToString();

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult drDelete = MessageBox.Show("Confirm to delete?", "Delete", MessageBoxButtons.YesNo);
            if (drDelete == DialogResult.Yes)
            {
                sqlQuery = "update TOPPING set STATUS_DELETE = 1 where ID_TOPPING = '" + tboxID.Text + "' ";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();

                Refresh();
            }
        }

        private void dgvTopping_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tboxID.Text = dgvTopping.Rows[e.RowIndex].Cells[0].Value.ToString();
                tboxNama.Text = dgvTopping.Rows[e.RowIndex].Cells[1].Value.ToString();
                tboxHarga.Text = dgvTopping.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            this.Hide();
            formToppingInsert ftInsert = new formToppingInsert();
            ftInsert.ShowDialog();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Hide();
            formToppingUpdate ftUpdate = new formToppingUpdate();
            ftUpdate.ShowDialog();
            this.Close();
        }

        private void pbProfil_Click(object sender, EventArgs e)
        {
            formProfile formProfil = new formProfile();
            formProfil.ShowDialog();
        }
    }
}

