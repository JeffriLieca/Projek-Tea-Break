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
        public static string buatID = "";

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

        private void BuatInsertID()
        {
            DataTable cekID = new DataTable();
            sqlQuery = "select left(id_minuman,1) as id, right(id_minuman,3) as urut from MINUMAN where left(id_minuman,1) = '"+cbKategori.SelectedValue.ToString()+"' order by 2 desc;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(cekID);
            string noID = "";
            if (cekID.Rows.Count == 0)
            {
                buatID = cbKategori.SelectedValue.ToString() + "001";
            }
            else
            {
                noID = (Convert.ToInt32(cekID.Rows[0][1].ToString()) + 1).ToString();
                for (int i = 0; i < 4 - noID.Length; i++)
                {
                    noID = "0" + noID;
                }
                buatID = cbKategori.SelectedValue.ToString() + noID;
            }
            tboxID.Text = buatID;
        }

        private void IsicbKategori()
        {
            sqlQuery = "select distinct if(left(id_minuman,1)='F','Fantastic',if(left(id_minuman,1)='S','Signature','The Special')) as ID, left(id_minuman,1) as inisial from MINUMAN where status_delete = '0';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable dtKategori = new DataTable();
            sqlAdapter.Fill(dtKategori);
            cbKategori.DataSource = dtKategori;
            cbKategori.DisplayMember = "ID";
            cbKategori.ValueMember = "inisial";
        }
        private void FormbtnAdd_Load(object sender, EventArgs e)
        {
            Refresh();
            LoadGambar();
            IsicbKategori();
            BuatInsertID();

            tboxID.ReadOnly = true;
        }
        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            formMinuman Fmain = new formMinuman();
            Fmain.ShowDialog();
            this.Close();
        }

        private void btnSaveAdd_Click(object sender, EventArgs e)
        {
            // Gambar
            byte[] images = null;
            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);

            sqlConnect.Close();
            sqlConnect.Open();
            sqlQuery = "INSERT INTO `MINUMAN`VALUES('" + tboxID.Text + "','" + tboxNama.Text + "','" + tboxHarga.Text + "',@images,'" + '0' + "')";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.Parameters.Add(new MySqlParameter("@images", images));
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Berhasil Disimpan");

            sqlQuery = "select `ID_MINUMAN`,`NAMA_MINUMAN`,`HARGA_MINUMAN` from MINUMAN";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable menu = new DataTable();
            sqlAdapter.Fill(menu);
            dgvMenu.DataSource = menu;

            sqlConnect.Close();

            this.Hide();
            formMinuman Fmain = new formMinuman();
            Fmain.ShowDialog();
            this.Close();
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
            //int index = e.RowIndex;
            //DataGridViewRow selectedRow = dgvMenu.Rows[index];
            //tboxID.Text = selectedRow.Cells[0].Value.ToString();
            //tboxNama.Text = selectedRow.Cells[1].Value.ToString();
            //tboxHarga.Text = selectedRow.Cells[2].Value.ToString();

            //LoadGambar();
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

        private void cbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuatInsertID();
        }
    }
}
