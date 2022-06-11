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
    public partial class formToppingUpdate : Form
    {
        public formToppingUpdate()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_11_TEABREAK;");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        public static string saveID = "";

        private void FormbtnEdit_Load(object sender, EventArgs e)
        {
            tboxID.Text = "";
            tboxNama.Text = "";
            tboxHarga.Text = "";
            dgvMenu.ReadOnly = true;

            sqlQuery = "select `ID_MINUMAN`,`NAMA_MINUMAN`,`HARGA_MINUMAN` from MINUMAN";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            tboxID.Text = dt.Rows[0][0].ToString();
            tboxNama.Text = dt.Rows[0][1].ToString();
            tboxHarga.Text = dt.Rows[0][2].ToString();
            LoadGambar();

            sqlQuery = "select `ID_MINUMAN` as 'ID',`NAMA_MINUMAN`,`HARGA_MINUMAN` from MINUMAN";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable menu = new DataTable();
            sqlAdapter.Fill(menu);
            dgvMenu.DataSource = menu;
        }
        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvMenu.Rows[index];
            tboxID.Text = selectedRow.Cells[0].Value.ToString();
            tboxNama.Text = selectedRow.Cells[1].Value.ToString();
            tboxHarga.Text = selectedRow.Cells[2].Value.ToString();
            saveID = selectedRow.Cells[2].Value.ToString();

            LoadGambar();
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            formMinuman Fmain = new formMinuman();
            Fmain.Show();
            this.Close();
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            // Gambar
            byte[] images = null;
            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);

            if (imgLocation != "")
            {
                sqlConnect.Open();
                sqlQuery = "update MINUMAN set GAMBAR=@images where ID_MINUMAN='"+tboxID.Text+"'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.Parameters.Add(new MySqlParameter("@images", images));
                sqlConnect.Close();
            }


            if (tboxID.Text != dgvMenu.CurrentRow.Cells["ID"].Value.ToString())
            {
                sqlConnect.Open();
                sqlQuery = "UPDATE MINUMAN SET ID_MINUMAN = '"+tboxID.Text+"',NAMA_MINUMAN = '" + tboxNama.Text + "', HARGA_MINUMAN = '" + tboxHarga.Text + "' WHERE ID_MINUMAN ='" + saveID + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                MessageBox.Show("Berhasil Disimpan");
                sqlQuery = "select `ID_MINUMAN`,`NAMA_MINUMAN`,`HARGA_MINUMAN` from MINUMAN";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                DataTable menu = new DataTable();
                sqlAdapter.Fill(menu);
                dgvMenu.DataSource = menu;
                formMinuman Fmain = new formMinuman();
                Fmain.Show();
                this.Hide();
            }
            else
            {
                sqlConnect.Open();
                sqlQuery = "UPDATE MINUMAN SET NAMA_MINUMAN = '" + tboxNama.Text + "', HARGA_MINUMAN = '" + tboxHarga.Text + "' WHERE ID_MINUMAN ='" + tboxID.Text + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                MessageBox.Show("Berhasil Disimpan");
                sqlQuery = "select `ID_MINUMAN`,`NAMA_MINUMAN`,`HARGA_MINUMAN` from MINUMAN";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                DataTable menu = new DataTable();
                sqlAdapter.Fill(menu);
                dgvMenu.DataSource = menu;
                formMinuman Fmain = new formMinuman();
                Fmain.Show();
                this.Hide();
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
    }
}
