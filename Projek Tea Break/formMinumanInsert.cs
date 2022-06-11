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
    public partial class formMinumanInsert : Form
    {
        public formMinumanInsert()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_11_TEABREAK;");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        public static string sqlQuery;

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

        private void FormbtnAdd_Load(object sender, EventArgs e)
        {
            Refresh();
            LoadGambar();

            tboxID.Text = menu.Rows[0][0].ToString();
            tboxNama.Text = menu.Rows[0][1].ToString();
            tboxHarga.Text = menu.Rows[0][2].ToString();
        }
        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            formMinuman Fmain = new formMinuman();
            Fmain.Show();
            this.Close();
        }

        private void btnSaveAdd_Click(object sender, EventArgs e)
        {
            // Gambar
            byte[] images = null;
            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);


            sqlConnect.Open();
            sqlQuery = "INSERT INTO `MINUMAN`VALUES('" + tboxID.Text + "','" + tboxNama.Text + "','" + tboxHarga.Text + "',@images,'" + '0' + "')";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.Parameters.Add(new MySqlParameter("@images", images));
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

        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvMenu.Rows[index];
            tboxID.Text = selectedRow.Cells[0].Value.ToString();
            tboxNama.Text = selectedRow.Cells[1].Value.ToString();
            tboxHarga.Text = selectedRow.Cells[2].Value.ToString();

            LoadGambar();
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
