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
    public partial class formEdit : Form
    {
        public formEdit()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_11_TEABREAK");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        public static string sqlQuery;
        public static string sqlInsert;
        public static int nomorMinuman;
        public static string IDMinumanLama;
        private void InvisText()
        {

        }
        private void FormOrder_Load(object sender, EventArgs e)
        {
            buttonEditMenu.BackColor = Color.ForestGreen;
            buttonAdmin.BackColor = Color.Transparent;
            buttonCashier.BackColor = Color.Transparent;
            InvisText();
            buttonEditMenu.Text = "Edit";

            LoadData();
            tboxID.Text = "";
            tboxNama.Text = "";
            tboxHarga.Text = "";
            dgvMenu.ReadOnly = true;
            tboxID.Visible = false;
            tboxNama.Visible = false;
            tboxHarga.Visible = false;
            labelID.Visible = false;
            labelNama.Visible = false;
            labelHarga.Visible = false;
        }

        public void LoadData()
        {
            sqlQuery = "select `ID_MINUMAN`,`NAMA_MINUMAN`,`HARGA_MINUMAN` from MINUMAN WHERE STATUS_DELETE = '0'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            tboxID.Text = dt.Rows[0][0].ToString();
            tboxNama.Text = dt.Rows[0][1].ToString();
            tboxHarga.Text = dt.Rows[0][2].ToString();

            sqlQuery = "select `ID_MINUMAN`,`NAMA_MINUMAN`,`HARGA_MINUMAN` from MINUMAN WHERE STATUS_DELETE = '0'";
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

        }

        private void buttonCashier_Click(object sender, EventArgs e)
        {
            buttonEditMenu.BackColor = Color.Transparent;
            buttonAdmin.BackColor = Color.Transparent;
            buttonCashier.BackColor = Color.ForestGreen;
            InvisText();
            buttonCashier.Text = "Cashier";
        }


        private void buttonEditMenu_Click(object sender, EventArgs e)
        {
            buttonCashier.BackColor = Color.Transparent;
            buttonAdmin.BackColor = Color.Transparent;
            buttonEditMenu.BackColor = Color.ForestGreen;
            InvisText();
            buttonEditMenu.Text = "Edit";
        }

        private void buttonAdmin_Click_1(object sender, EventArgs e)
        {
            buttonCashier.BackColor = Color.Transparent;
            buttonEditMenu.BackColor = Color.Transparent;
            buttonAdmin.BackColor = Color.ForestGreen;
            InvisText();
            buttonAdmin.Text = "Admin";

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormbtnEdit F1 = new FormbtnEdit();
            F1.Show();
            this.Hide();
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            FormbtnAdd F2 = new FormbtnAdd();
            F2.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();
            sqlQuery = "update MINUMAN set STATUS_DELETE = '1' where ID_MINUMAN = '" + tboxID.Text + "' ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            LoadData();
        }

        private void pbProfil_Click(object sender, EventArgs e)
        {
            formProfile formProfil = new formProfile();
            formProfil.ShowDialog();
            this.Close();
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

        public void SaveGambar()
        {
            byte[] images = null;
            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);

            sqlConnect.Open();
            sqlQuery = "insert into MINUMAN(GAMBAR) values (@images)";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.Parameters.Add(new MySqlParameter("@images", images));
            int N = sqlCommand.ExecuteNonQuery();
            MessageBox.Show(N.ToString() + " Data Saved Succesfully");
            sqlConnect.Close();
        }

        private void pictureBoxAdd_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }
