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
        public static string cekID;
        public static string idPegawai = "";

        DataTable dtPegawai = new DataTable();
        DataTable dtJabatan = new DataTable();

        private void Refresh()
        {
            DataTable dtPegawai = new DataTable();
            sqlQuery = "select id_pegawai as 'ID', nama_pegawai as 'Nama', tgl_lahir_pegawai as 'Tanggal', alamat_pegawai as 'Alamat', no_hp_pegawai as 'HP', if(level_jabatan = 1,'Staff',if(level_jabatan = 2,'Cashier',if(level_jabatan = 3,'Manager',''))) as `Jabatan` from PEGAWAI where status_delete = '0';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPegawai);
            dgvPegawai.DataSource = dtPegawai;
        }
        private void InvisText()
        {
            buttonCashier.Text = " ";
            buttonEditMenu.Text = " ";
            buttonAdmin.Text = " ";
        }
        private void AddIDPegawai()
        {
            DataTable cekPegawai = new DataTable();
            sqlQuery = "select left(id_pegawai,1) as inisial, right(id_pegawai,4) as urut from PEGAWAI where left(id_pegawai,1) = left('" + tbNama.Text.ToUpper() + "',1) order by 2 desc";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(cekPegawai);
            string noPegawai = "";
            if (cekPegawai.Rows.Count == 0)
            {
                idPegawai = tbNama.Text.Substring(0, 1).ToUpper() + "0001";
            }
            else
            {
                noPegawai = (Convert.ToInt32(cekPegawai.Rows[0][1].ToString()) + 1).ToString();
                for (int i = 0; i < 6 - noPegawai.Length; i++)
                {
                    noPegawai = "0" + noPegawai;
                }
                idPegawai = cekPegawai.Rows[0][0].ToString() + noPegawai;
            }
            tbID.Text = idPegawai;
        }
        private void FormOrder_Load(object sender, EventArgs e)
        {
            buttonEditMenu.BackColor = Color.Transparent;
            buttonAdmin.BackColor = Color.ForestGreen;
            buttonCashier.BackColor = Color.Transparent;
            InvisText();
            buttonAdmin.Text = "Admin";

            sqlQuery = "select id_pegawai as 'ID', nama_pegawai as 'Nama', tgl_lahir_pegawai as 'Tanggal', alamat_pegawai as 'Alamat', no_hp_pegawai as 'HP', if(level_jabatan = 1,'Staff',if(level_jabatan = 2,'Cashier',if(level_jabatan = 3,'Manager',''))) as `Jabatan` from PEGAWAI where status_delete = '0';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPegawai);
            dgvPegawai.DataSource = dtPegawai;

            sqlQuery = "select distinct level_jabatan as 'level',if( level_jabatan = 1,'Staff',if(level_jabatan = 2,'Cashier',if(level_jabatan = 3,'Manager',''))) as 'Jabatan' from PEGAWAI where status_delete = '0';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtJabatan);
            cbJabatan.DataSource = dtJabatan;
            cbJabatan.DisplayMember = "Jabatan";
            cbJabatan.ValueMember = "level";
            cbJabatan.Text = "";
            dtpTanggalLahir.Text = "";

            rbView.Checked = true;
            tbID.Enabled = false;
            tbNama.Enabled = false;
            dtpTanggalLahir.Enabled = false;
            tbAlamat.Enabled = false;
            tbHP.Enabled = false;
            cbJabatan.Enabled = false;


            btnSave.Visible = false;
            btnAdd.Visible = false;
            btnDelete.Visible = false;
        }
        private void buttonCashier_Click(object sender, EventArgs e)
        {
            buttonEditMenu.BackColor = Color.Transparent;
            buttonAdmin.BackColor = Color.Transparent;
            buttonCashier.BackColor = Color.ForestGreen;
            InvisText();
            buttonCashier.Text = "Cashier";

            this.Hide();
            FormOrder formOrder = new FormOrder();
            formOrder.ShowDialog();
            this.Close();
        }


        private void buttonEditMenu_Click(object sender, EventArgs e)
        {
            buttonCashier.BackColor = Color.Transparent;
            buttonAdmin.BackColor = Color.Transparent;
            buttonEditMenu.BackColor = Color.ForestGreen;
            InvisText();
            buttonEditMenu.Text = "Edit Menu";

            this.Hide();
            formEditPilih formPilih = new formEditPilih();
            formPilih.ShowDialog();
            this.Close();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            buttonCashier.BackColor = Color.Transparent;
            buttonEditMenu.BackColor = Color.Transparent;
            buttonAdmin.BackColor = Color.ForestGreen;
            InvisText();
            buttonAdmin.Text = "Admin";

        }

        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rbAdd.Checked == false)
            {
                try
                {
                    int index = e.RowIndex;
                    DataGridViewRow selectedRow = dgvPegawai.Rows[index];
                    tbID.Text = selectedRow.Cells[0].Value.ToString();
                    tbNama.Text = selectedRow.Cells[1].Value.ToString();
                    dtpTanggalLahir.Text = selectedRow.Cells[2].Value.ToString();
                    tbAlamat.Text = selectedRow.Cells[3].Value.ToString();
                    tbHP.Text = selectedRow.Cells[4].Value.ToString();
                    cbJabatan.Text = selectedRow.Cells[5].Value.ToString();
                    cekID = selectedRow.Cells["ID"].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult drDelete = MessageBox.Show("Confirm to delete?", "Delete", MessageBoxButtons.YesNo);
                if (drDelete == DialogResult.Yes)
                {
                    sqlQuery = "update PEGAWAI set STATUS_DELETE = 1 where ID_PEGAWAI = '" + tbID.Text + "'";
                    //MessageBox.Show(sqlQuery);
                    sqlConnect.Open();
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();

                    Refresh();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Delete gagal");
            }
        }

        private void pbProfil_Click(object sender, EventArgs e)
        {
            formProfile formProfil = new formProfile();
            formProfil.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {


                sqlQuery = "insert into PEGAWAI values('" + tbID.Text + "', '" + tbNama.Text + "', '" + dtpTanggalLahir.Value.ToString("yyyyMMdd") + "', '" + tbAlamat.Text + "', '" + tbHP.Text + "', '" + cbJabatan.SelectedValue + "', '0');";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();

                MessageBox.Show($"{tbID.Text} Berhasil ditambah");

                Refresh();



                tbID.Text = "";
                tbNama.Text = "";
                tbAlamat.Text = "";
                tbHP.Text = "";
                cbJabatan.Text = "";
                dtpTanggalLahir.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add gagal");
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbID.Text != dgvPegawai.CurrentRow.Cells["ID"].Value.ToString())
                {
                    sqlQuery = "UPDATE PEGAWAI SET ID_PEGAWAI = '" + tbID.Text + "', NAMA_PEGAWAI = '" + tbNama.Text + "', TGL_LAHIR_PEGAWAI = '" + dtpTanggalLahir.Value.ToString("yyyyMMdd") + "', alamat_pegawai = '" + tbAlamat.Text + "',no_hp_pegawai = '" + tbHP.Text + "',level_jabatan ='" + cbJabatan.SelectedValue + "' WHERE id_pegawai = '" + cekID + "';";
                    //MessageBox.Show(sqlQuery);
                    sqlConnect.Open();
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();

                    MessageBox.Show("Berhasil diubah");

                    Refresh();
                }
                else
                {
                    sqlQuery = "UPDATE PEGAWAI SET NAMA_PEGAWAI = '" + tbNama.Text + "', TGL_LAHIR_PEGAWAI = '" + dtpTanggalLahir.Value.ToString("yyyyMMdd") + "', alamat_pegawai = '" + tbAlamat.Text + "',no_hp_pegawai = '" + tbHP.Text + "',level_jabatan ='" + cbJabatan.SelectedValue + "' WHERE id_pegawai = '" + tbID.Text + "';";
                    //MessageBox.Show(sqlQuery);
                    sqlConnect.Open();
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();

                    MessageBox.Show("Berhasil diubah");

                    Refresh();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Update gagal");
            }
        }

        private void rbEdit_CheckedChanged(object sender, EventArgs e)// kurang posisi"
        {
            if (rbEdit.Checked == true)
            {
                tbID.Enabled = true;
                tbNama.Enabled = true;
                dtpTanggalLahir.Enabled = true;
                tbAlamat.Enabled = true;
                tbHP.Enabled = true;
                cbJabatan.Enabled = true;

                btnSave.Visible = true;
                btnAdd.Visible = false;
                btnDelete.Visible = true;

                btnSave.Location = new Point(301, 407);
                btnDelete.Location = new Point(422, 407);
            }
            else if (rbAdd.Checked == true)
            {
                tbID.Enabled = true;
                tbID.ReadOnly = true;
                tbNama.Enabled = true;
                dtpTanggalLahir.Enabled = true;
                tbAlamat.Enabled = true;
                tbHP.Enabled = true;
                cbJabatan.Enabled = true;

                btnSave.Visible = false;
                btnAdd.Visible = true;
                btnDelete.Visible = false;

                btnAdd.Location = new Point(301, 407);

                tbID.Text = "";
                tbNama.Text = "";
                dtpTanggalLahir.Text = "";
                tbAlamat.Text = "";
                tbHP.Text = "";
                cbJabatan.Text = "";
            }
            else
            {
                tbID.Enabled = false;
                tbNama.Enabled = false;
                dtpTanggalLahir.Enabled = false;
                tbAlamat.Enabled = false;
                tbHP.Enabled = false;
                cbJabatan.Enabled = false;
                btnSave.Visible = false;
                btnAdd.Visible = false;
                btnDelete.Visible = false;

                btnSave.Visible = false;
                btnAdd.Visible = false;
                btnDelete.Visible = false;
            }
        }

        private void rbAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEdit.Checked == true)
            {
                tbID.Enabled = true;
                tbNama.Enabled = true;
                dtpTanggalLahir.Enabled = true;
                tbAlamat.Enabled = true;
                tbHP.Enabled = true;
                cbJabatan.Enabled = true;

                btnSave.Visible = true;
                btnAdd.Visible = false;
                btnDelete.Visible = true;

                btnSave.Location = new Point(301, 407);
                btnDelete.Location = new Point(422, 407);
            }
            else if (rbAdd.Checked == true)
            {
                tbID.Enabled = true;
                tbID.ReadOnly = true;
                tbNama.Enabled = true;
                dtpTanggalLahir.Enabled = true;
                tbAlamat.Enabled = true;
                tbHP.Enabled = true;
                cbJabatan.Enabled = true;

                btnSave.Visible = false;
                btnAdd.Visible = true;
                btnDelete.Visible = false;

                btnAdd.Location = new Point(301, 407);

                tbID.Text = "";
                tbNama.Text = "";
                dtpTanggalLahir.Text = "";
                tbAlamat.Text = "";
                tbHP.Text = "";
                cbJabatan.Text = "";
            }
            else
            {
                tbID.Enabled = false;
                tbNama.Enabled = false;
                dtpTanggalLahir.Enabled = false;
                tbAlamat.Enabled = false;
                tbHP.Enabled = false;
                cbJabatan.Enabled = false;
                btnSave.Visible = false;
                btnAdd.Visible = false;
                btnDelete.Visible = false;

                btnSave.Visible = false;
                btnAdd.Visible = false;
                btnDelete.Visible = false;
            }
        } // copas dari rbEdit

        private void rbView_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEdit.Checked == true)
            {
                tbID.Enabled = true;
                tbNama.Enabled = true;
                dtpTanggalLahir.Enabled = true;
                tbAlamat.Enabled = true;
                tbHP.Enabled = true;
                cbJabatan.Enabled = true;

                btnSave.Visible = true;
                btnAdd.Visible = false;
                btnDelete.Visible = true;

                btnSave.Location = new Point(301, 407);
                btnDelete.Location = new Point(422, 407);
            }
            else if (rbAdd.Checked == true)
            {
                tbID.Enabled = true;
                tbID.ReadOnly = true;
                tbNama.Enabled = true;                
                dtpTanggalLahir.Enabled = true;
                tbAlamat.Enabled = true;
                tbHP.Enabled = true;
                cbJabatan.Enabled = true;

                btnSave.Visible = false;
                btnAdd.Visible = true;
                btnDelete.Visible = false;

                btnAdd.Location = new Point(301, 407);

                tbID.Text = "";
                tbNama.Text = "";
                dtpTanggalLahir.Text = "";
                tbAlamat.Text = "";
                tbHP.Text = "";
                cbJabatan.Text = "";
            }
            else
            {
                tbID.Enabled = false;
                tbNama.Enabled = false;
                dtpTanggalLahir.Enabled = false;
                tbAlamat.Enabled = false;
                tbHP.Enabled = false;
                cbJabatan.Enabled = false;
                btnSave.Visible = false;
                btnAdd.Visible = false;
                btnDelete.Visible = false;

                btnSave.Visible = false;
                btnAdd.Visible = false;
                btnDelete.Visible = false;
            }
        }// copas dari rbEdit

        private void tbNama_TextChanged(object sender, EventArgs e)
        {
            if (rbAdd.Checked == true)
            {
                if (tbNama.Text != "")
                {
                    AddIDPegawai();
                }
                else
                {
                    tbID.Text =  "";
                }
            }
        }

        private void tbHP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
