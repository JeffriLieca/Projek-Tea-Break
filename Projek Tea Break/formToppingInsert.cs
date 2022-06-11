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
    public partial class formToppingInsert : Form
    {
        public formToppingInsert()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_11_TEABREAK;");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        public static string sqlQuery;

        private void FormbtnAdd_Load(object sender, EventArgs e)
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

            sqlQuery = "select `ID_MINUMAN`,`NAMA_MINUMAN`,`HARGA_MINUMAN` from MINUMAN";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable menu = new DataTable();
            sqlAdapter.Fill(menu);
            dgvMenu.DataSource = menu;
        }
        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            formMinuman Fmain = new formMinuman();
            Fmain.Show();
            this.Hide();
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
    }
}
