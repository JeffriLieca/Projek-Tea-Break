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
    public partial class formPromoUpdate : Form
    {
        public formPromoUpdate()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_11_TEABREAK;");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        public static string saveID = "";
        private void LoadRefresh()
        {
            sqlQuery = "select `ID_PROMO` as 'ID Promo',`NAMA_PROMO` as 'Nama Promo',`BESAR_PROMO` as 'Besar Promo',`tgl_promo` as 'Tanggal Mulai', `end_promo` as 'Tanggal Berakhir' from PROMO WHERE STATUS_DELETE = '0'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable promo = new DataTable();
            sqlAdapter.Fill(promo);
            dgvPromo.DataSource = promo;
        }

        private void FormbtnEdit_Load(object sender, EventArgs e)
        {
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

            LoadRefresh();
        }
        private void dgvPromo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvPromo.Rows[index];
            tboxID.Text = selectedRow.Cells[0].Value.ToString();
            tboxNama.Text = selectedRow.Cells[1].Value.ToString();
            tboxBesar.Text = selectedRow.Cells[2].Value.ToString();
            dtpFrom.Text = selectedRow.Cells[3].Value.ToString();
            dtpTo.Text = selectedRow.Cells[4].Value.ToString();
            saveID = selectedRow.Cells["ID Promo"].Value.ToString();
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            formPromo Fmain = new formPromo();
            Fmain.Show();
            this.Close();
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            if (tboxID.Text != dgvPromo.CurrentRow.Cells["ID Promo"].Value.ToString())
            {
                sqlConnect.Open();
                sqlQuery = "UPDATE PROMO SET ID_PROMO = '" + tboxID.Text + "', NAMA_PROMO ='" + tboxNama.Text + "', BESAR_PROMO = '" + tboxBesar.Text + "', tgl_promo = '" + dtpFrom.Value.ToString("yyyyMMdd") + "', end_promo = '" + dtpTo.Value.ToString("yyyyMMdd") + "' WHERE ID_PROMO ='" + saveID + "'";

                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                MessageBox.Show("Berhasil Disimpan");

                LoadRefresh();

                this.Hide();
                formPromo Fmain = new formPromo();
                Fmain.Show();
                this.Close();
            }
            else
            {
                sqlConnect.Open();
                sqlQuery = "UPDATE PROMO SET NAMA_PROMO ='" + tboxNama.Text + "', BESAR_PROMO = '" + tboxBesar.Text + "', tgl_promo = '" + dtpFrom.Value.ToString("yyyyMMdd") + "', end_promo = '" + dtpTo.Value.ToString("yyyyMMdd") + "' WHERE ID_PROMO ='" + tboxID.Text + "'";

                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                MessageBox.Show("Berhasil Disimpan");

                LoadRefresh();

                this.Hide();
                formPromo Fmain = new formPromo();
                Fmain.Show();
                this.Close();
            }
        }
    }
}
