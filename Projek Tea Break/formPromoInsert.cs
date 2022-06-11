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
    public partial class formPromoInsert : Form
    {
        public formPromoInsert()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_11_TEABREAK;");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        public static string sqlQuery;

        private void LoadRefresh()
        {
            sqlQuery = "select `ID_PROMO` as 'ID Promo',`NAMA_PROMO` as 'Nama Promo',`BESAR_PROMO` as 'Besar Promo',`tgl_promo` as 'Tanggal Mulai' , `end_promo` as 'Tanggal Berakhir' from PROMO WHERE STATUS_DELETE = '0'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable promo = new DataTable();
            sqlAdapter.Fill(promo);
            dgvPromo.DataSource = promo;
        }
        private void FormbtnAdd_Load(object sender, EventArgs e)
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
        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            formPromo Fmain = new formPromo();
            Fmain.Show();
            this.Close();
        }

        private void btnSaveAdd_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();
            sqlQuery = "INSERT INTO `PROMO` VALUES('" + tboxID.Text + "','" + tboxNama.Text + "', '" + tboxBesar.Text + "','" + dtpFrom.Value.ToString("yyyyMMdd") + "','" + dtpTo.Value.ToString("yyyyMMdd") + "','" + '0' + "')";
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

        private void dgvPromo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvPromo.Rows[index];
            tboxID.Text = selectedRow.Cells[0].Value.ToString();
            tboxNama.Text = selectedRow.Cells[1].Value.ToString();
            tboxBesar.Text = selectedRow.Cells[2].Value.ToString();
            dtpFrom.Text = selectedRow.Cells[3].Value.ToString();
            dtpTo.Text = selectedRow.Cells[4].Value.ToString();
        }
    }
}
