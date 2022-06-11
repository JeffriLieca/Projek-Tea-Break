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
using System.IO;

namespace Projek_Tea_Break
{
    public partial class formEditMenuLAMA : Form
    {
        public formEditMenuLAMA()
        {
            InitializeComponent();
        }

        public static string sqlConnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_11_TEABREAK";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;

        public static string sqlQuery;
        public static string sqlInsert;
        public static int nomorMinuman;

        public static string IDMinumanLama;
        private void FormOrder_Load(object sender, EventArgs e)
        {
            sqlConnect.Open();
            sqlQuery = "select `ID_MINUMAN`,`NAMA_MINUMAN`,`HARGA_MINUMAN` from MINUMAN";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            tboxID.Text = dt.Rows[0][0].ToString();
            tboxNama.Text = dt.Rows[0][1].ToString();
            tboxHarga.Text = dt.Rows[0][2].ToString();

            sqlQuery = "select `ID_MINUMAN`,`NAMA_MINUMAN`,`HARGA_MINUMAN` from MINUMAN";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable menu = new DataTable();
            sqlAdapter.Fill(menu);
            dgvMenu.DataSource = menu;


            sqlQuery = "select NAMA, IMAGE from COBA_MINUMAN ;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable dtCoba = new DataTable();
            sqlAdapter.Fill(dtCoba);
            dgvMenu.DataSource = dtCoba;

            sqlConnect.Close();


            //OpenFileDialog open = new OpenFileDialog();

            //open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            //if (open.ShowDialog() == DialogResult.OK)
            //{
            //    //display image in picture box
            //    pictureBoxAdd.Image = new Bitmap(open.FileName);


            //    //image file path
            //    textBox1.Text = open.FileName;
            //}


        }
        private void buttonCashier_Click(object sender, EventArgs e)
        {
            buttonEditMenu.BackColor = Color.Transparent;
            buttonAdmin.BackColor = Color.Transparent;
            buttonCashier.BackColor = Color.ForestGreen;
            buttonCashier.Text = "Cashier";
        }


        private void buttonEditMenu_Click(object sender, EventArgs e)
        {
            buttonCashier.BackColor = Color.Transparent;
            buttonAdmin.BackColor = Color.Transparent;
            buttonEditMenu.BackColor = Color.ForestGreen;
            buttonEditMenu.Text = "Edit Menu";
        }

        private void buttonAdmin_Click_1(object sender, EventArgs e)
        {
            buttonCashier.BackColor = Color.Transparent;
            buttonEditMenu.BackColor = Color.Transparent;
            buttonAdmin.BackColor = Color.ForestGreen;
            buttonAdmin.Text = "Admin";

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnSave.Visible = true;
            btnEdit.Visible = false;
            btnDelete.Visible = false;
            btnAdd.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sqlQuery = "update MINUMAN set STATUS_DELETE = 1 where ID_MINUMAN = '" + tboxID.Text + "' ";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();

        }

        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvMenu.Rows[index];
            tboxID.Text = selectedRow.Cells[0].Value.ToString();
            tboxNama.Text = selectedRow.Cells[1].Value.ToString();
            tboxHarga.Text = selectedRow.Cells[2].Value.ToString();






        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            sqlQuery = "INSERT INTO MINUMAN(ID_MINUMAN,NAMA_MINUMAN,HARGA_MINUMAN) set ID_MINUMAN = '" + tboxID.Text + "', NAMA_MINUMAN = '" + tboxNama.Text + "' , HARGA_MINUMAN = '" + tboxHarga.Text + "'";
            btnSave.Visible = true;
            btnEdit.Visible = false;
            btnDelete.Visible = false;
            btnAdd.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sqlQuery = "update MINUMAN(ID_MINUMAN,NAMA_MINUMAN,HARGA_MINUMAN) set ID_MINUMAN = '" + tboxID.Text + "', NAMA_MINUMAN = '" + tboxNama.Text + "' , HARGA_MINUMAN = '" + tboxHarga.Text + "'";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream stream = new FileStream(imgLocation,FileMode.Open,FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);

            sqlConnect.Open();
            sqlQuery = "insert into COBA_MINUMAN values ('"+textBoxIDgambar.Text+"','"+textBoxNamagambar.Text+"',@images)";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.Parameters.Add(new MySqlParameter("@images",images));
            int N = sqlCommand.ExecuteNonQuery();
            MessageBox.Show(N.ToString()+" Data Saved Succesfully");
            sqlConnect.Close();
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();
            sqlQuery = "select NAMA, IMAGE from COBA_MINUMAN where ID_COBA='"+textBoxIDgambar.Text+"';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            //sqlAdapter = new MySqlDataAdapter(sqlCommand);
            //DataTable dtCoba = new DataTable();
            //sqlAdapter.Fill(dtCoba);
            //byte[] images = ((byte[])dtCoba.Rows[0][1]);
            //MemoryStream mstream = new MemoryStream(images);
            //pictureBoxAdd.Image = Image.FromStream(mstream);

            //pictureBoxAdd.Image = dtCoba.Rows[0][1];


            //MySqlDataReader DataRead = sqlCommand.ExecuteReader();
            //DataRead.Read();

            //if (DataRead.HasRows)
            //{
            //    textBoxNamagambar.Text = DataRead[0].ToString();
            //    byte[] images = ((byte[])DataRead[1]);
            //    if (images == null)
            //    {
            //        pictureBoxAdd.Image = null;
            //    }
            //    else
            //    {
            //        MemoryStream mstream = new MemoryStream(images);
            //        pictureBoxAdd.Image = Image.FromStream(mstream);
            //    }

            //}
            //else
            //{
            //    MessageBox.Show("This Data Not Available");
            //}
            sqlConnect.Close();
        }
    }
}

