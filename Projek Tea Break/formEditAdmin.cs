using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Projek_Tea_Break
{
    public partial class formAdmin : Form
    {
        public formAdmin()
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

        DataTable dtPegawai = new DataTable();
        DataTable dtJabatan = new DataTable();

        private void FormOrder_Load(object sender, EventArgs e)
        {            
            sqlQuery = "select id_pegawai as 'ID', nama_pegawai as 'Nama', tgl_lahir_pegawai as 'Tanggal', alamat_pegawai as 'Alamat', no_hp_pegawai as 'HP', if(level_jabatan = 1,'Staff',if(level_jabatan = 2,'Cashier',if(level_jabatan = 3,'Manager',''))) as `Jabatan` from PEGAWAI;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPegawai);
            dgvPegawai.DataSource = dtPegawai;

            sqlQuery = "select distinct if( level_jabatan = 1,'Staff',if(level_jabatan = 2,'Cashier',if(level_jabatan = 3,'Manager',''))) as 'Jabatan' from PEGAWAI;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtJabatan);
            cbJabatan.DataSource = dtJabatan;
            cbJabatan.DisplayMember = "Jabatan";
            cbJabatan.Text = "";

            tbID.Enabled = false;
            tbNama.ReadOnly = true;
            dtpTanggalLahir.Enabled = false;
            tbAlamat.Enabled = false;
            tbHP.Enabled = false;
            cbJabatan.Enabled = false;
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

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            buttonCashier.BackColor = Color.Transparent;
            buttonEditMenu.BackColor = Color.Transparent;
            buttonAdmin.BackColor = Color.ForestGreen;
            buttonAdmin.Text = "Admin";

        }

        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvPegawai.Rows[index];
            tbID.Text = selectedRow.Cells[0].Value.ToString();
            tbNama.Text = selectedRow.Cells[1].Value.ToString();
            dtpTanggalLahir.Text = selectedRow.Cells[2].Value.ToString();
            tbAlamat.Text = selectedRow.Cells[3].Value.ToString();
            tbHP.Text = selectedRow.Cells[4].Value.ToString();
            cbJabatan.Text = selectedRow.Cells[5].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult drDelete = MessageBox.Show("Confirm to delete?", "Delete", MessageBoxButtons.YesNo);
            if (drDelete == DialogResult.Yes)
            {
                sqlQuery = "update PEGAWAI set STATUS_DELETE = 1 where ID_PEGAWAI = '" + tbID.Text + "'";
                MessageBox.Show(sqlQuery);
                //sqlConnect.Open();
                //sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                //sqlCommand.ExecuteNonQuery();
                //sqlConnect.Close();
            }
        }

        private void pbProfil_Click(object sender, EventArgs e)
        {
            formProfile formProfil = new formProfile();
            formProfil.ShowDialog(); 
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnSave.Visible = true;
            btnEdit.Visible = false;
            btnDelete.Visible = false;
            btnAdd.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sqlQuery = "insert";
            MessageBox.Show(sqlQuery);
            //sqlConnect.Open();
            //sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            //sqlCommand.ExecuteNonQuery();
            //sqlConnect.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sqlQuery = "update";
            MessageBox.Show(sqlQuery);
            //sqlConnect.Open();
            //sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            //sqlCommand.ExecuteNonQuery();
            //sqlConnect.Close();
        }

        private void rbEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEdit.Checked == true)
            {
                tbID.Enabled = true;
                tbNama.ReadOnly = false;
                dtpTanggalLahir.Enabled = true;
                tbAlamat.Enabled = true;
                tbHP.Enabled = true;
                cbJabatan.Enabled = true;
            }
            else if (rbAdd.Checked == true)
            {
                tbID.Enabled = true;
                tbNama.ReadOnly = false;
                dtpTanggalLahir.Enabled = true;
                tbAlamat.Enabled = true;
                tbHP.Enabled = true;
                cbJabatan.Enabled = true;
            }
            else
            {
                tbID.Enabled = false;
                tbNama.ReadOnly = true;
                dtpTanggalLahir.Enabled = false;
                tbAlamat.Enabled = false;
                tbHP.Enabled = false;
                cbJabatan.Enabled = false;
            }
        }

        private void rbAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEdit.Checked == true)
            {
                tbID.Enabled = true;
                tbNama.ReadOnly = false;
                dtpTanggalLahir.Enabled = true;
                tbAlamat.Enabled = true;
                tbHP.Enabled = true;
                cbJabatan.Enabled = true;
            }
            else if (rbAdd.Checked == true)
            {
                tbID.Enabled = true;
                tbNama.ReadOnly = false;
                dtpTanggalLahir.Enabled = true;
                tbAlamat.Enabled = true;
                tbHP.Enabled = true;
                cbJabatan.Enabled = true;
            }
            else
            {
                tbID.Enabled = false;
                tbNama.ReadOnly = true;
                dtpTanggalLahir.Enabled = false;
                tbAlamat.Enabled = false;
                tbHP.Enabled = false;
                cbJabatan.Enabled = false;
            }
        } // copas dari rbEdit

        private void rbView_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEdit.Checked == true)
            {
                tbID.Enabled = true;
                tbNama.ReadOnly = false;
                dtpTanggalLahir.Enabled = true;
                tbAlamat.Enabled = true;
                tbHP.Enabled = true;
                cbJabatan.Enabled = true;
            }
            else if (rbAdd.Checked == true)
            {
                tbID.Enabled = true;
                tbNama.ReadOnly = false;
                dtpTanggalLahir.Enabled = true;
                tbAlamat.Enabled = true;
                tbHP.Enabled = true;
                cbJabatan.Enabled = true;
            }
            else
            {
                tbID.Enabled = false;
                tbNama.ReadOnly = true;
                dtpTanggalLahir.Enabled = false;
                tbAlamat.Enabled = false;
                tbHP.Enabled = false;
                cbJabatan.Enabled = false;
            }
        }// copas dari rbEdit
    }
}
