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
            LoadRefresh();

            tboxID.ReadOnly = true;
        }
        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            formPromo Fmain = new formPromo();
            Fmain.ShowDialog();
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
            Fmain.ShowDialog();
            this.Close();
        }
    }
}
