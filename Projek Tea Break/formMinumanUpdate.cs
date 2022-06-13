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
    public partial class formMinumanUpdate : Form
    {
        public formMinumanUpdate()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_11_TEABREAK;");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        public static string saveID = "";

        DataTable menu = new DataTable();

        private void Refresh()
        {
            sqlQuery = "select `ID_MINUMAN` as 'ID Minuman',`NAMA_MINUMAN` as 'Nama Minuman',`HARGA_MINUMAN` as 'Harga Minuman' from MINUMAN where status_delete = '0';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable menu = new DataTable();
            sqlAdapter.Fill(menu);
            dgvMenu.DataSource = menu;
        }

        private void FormbtnEdit_Load(object sender, EventArgs e)
        {
            Refresh();
            LoadGambar();

            try
            {
                tboxID.Text = menu.Rows[0][0].ToString();
                tboxNama.Text = menu.Rows[0][1].ToString();
                tboxHarga.Text = menu.Rows[0][2].ToString();
            }
            catch (Exception)
            {

            }
        }
        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dgvMenu.Rows[index];
                tboxID.Text = selectedRow.Cells[0].Value.ToString();
                tboxNama.Text = selectedRow.Cells[1].Value.ToString();
                tboxHarga.Text = selectedRow.Cells[2].Value.ToString();
                saveID = selectedRow.Cells[2].Value.ToString();

                sqlQuery = "select GAMBAR from MINUMAN where ID_MINUMAN='" + tboxID.Text + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                DataTable dtCoba = new DataTable();
                sqlAdapter.Fill(dtCoba);
                byte[] images = ((byte[])dtCoba.Rows[0][0]);
                MemoryStream mstream = new MemoryStream(images);
                pictureBoxAdd.Image = Image.FromStream(mstream);
            }
            catch (Exception)
            {

            }
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            formMinuman Fmain = new formMinuman();
            this.Close();
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            // Gambar
            try
            {
                byte[] images = null;
                FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                images = brs.ReadBytes((int)stream.Length);

                if (imgLocation != "")
                {
                    sqlConnect.Open();
                    sqlQuery = "update MINUMAN set GAMBAR=@images where ID_MINUMAN='" + tboxID.Text + "'";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.Parameters.Add(new MySqlParameter("@images", images));
                    sqlConnect.Close();
                }
                if (tboxID.Text != dgvMenu.CurrentRow.Cells["ID Minuman"].Value.ToString())
                {
                    sqlConnect.Close();
                    sqlConnect.Open();
                    sqlQuery = "UPDATE MINUMAN SET ID_MINUMAN = '" + tboxID.Text + "',NAMA_MINUMAN = '" + tboxNama.Text + "', HARGA_MINUMAN = '" + tboxHarga.Text + "' WHERE ID_MINUMAN ='" + saveID + "'";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();
                    MessageBox.Show("Berhasil Disimpan");

                    Refresh();

                    formMinuman Fmain = new formMinuman();
                    this.Close();
                }
                else
                {
                    sqlConnect.Open();
                    sqlQuery = "UPDATE MINUMAN SET NAMA_MINUMAN = '" + tboxNama.Text + "', HARGA_MINUMAN = '" + tboxHarga.Text + "' WHERE ID_MINUMAN ='" + tboxID.Text + "'";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();
                    MessageBox.Show("Berhasil Disimpan");

                    Refresh();

                    formMinuman Fmain = new formMinuman();
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Input gagal");
                this.Close();
            }

            
        }


        // Jeffri
        string imgLocation = "";
        private void buttonAddImage_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                //display image in picture box
                imgLocation = open.FileName.ToString();
                pictureBoxAdd.ImageLocation = imgLocation;
            }


        }
         public void LoadGambar()
        {
            try
            {
                imgLocation = "";
                sqlConnect.Open();
                sqlQuery = "select GAMBAR from MINUMAN where ID_MINUMAN='" + tboxID.Text + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                DataTable dtCoba = new DataTable();
                sqlAdapter.Fill(dtCoba);
                byte[] images = ((byte[])dtCoba.Rows[0][0]);
                MemoryStream mstream = new MemoryStream(images);
                pictureBoxAdd.Image = Image.FromStream(mstream);
                sqlConnect.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
