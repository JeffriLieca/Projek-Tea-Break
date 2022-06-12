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
        public static string buatID = "";

        private void LoadRefresh()
        {
            sqlQuery = "select `ID_PROMO` as 'ID Promo',`NAMA_PROMO` as 'Nama Promo',`BESAR_PROMO` as 'Besar Promo',`tgl_promo` as 'Tanggal Mulai' , `end_promo` as 'Tanggal Berakhir' from PROMO WHERE STATUS_DELETE = '0'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable promo = new DataTable();
            sqlAdapter.Fill(promo);
            dgvPromo.DataSource = promo;
        }
        private void BuatInsertID()
        {
            try
            {
                buatID = "PD" + comboBoxBesarPromo.Text + dtpFrom.Value.ToString("yMMdd");
            }
            catch (Exception)
            {

            }
            tboxID.Text = buatID;

        }
        private void FormbtnAdd_Load(object sender, EventArgs e)
        {
            
            comboBoxBesarPromo.Text = "10";
            BuatInsertID();
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
            if (tboxNama.Text == "")
            {
                MessageBox.Show("Nama tidak boleh kosong");
            }
            else
            {
                try
                {
                    sqlConnect.Open();
                    sqlQuery = "INSERT INTO `PROMO` VALUES('" + tboxID.Text + "','" + tboxNama.Text + "', '" + comboBoxBesarPromo.Text + "','" + dtpFrom.Value.ToString("yyyyMMdd") + "','" + dtpTo.Value.ToString("yyyyMMdd") + "','" + '0' + "')";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();
                    MessageBox.Show("Berhasil Disimpan");

                    LoadRefresh();
                }
                catch (Exception)
                {
                    MessageBox.Show("Input gagal");
                }
            }

            this.Hide();
            formPromo Fmain = new formPromo();
            Fmain.ShowDialog();
            this.Close();
        }


        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            BuatInsertID();
        }

        private void tboxBesar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void comboBoxBesarPromo_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuatInsertID();
        }
    }
}
