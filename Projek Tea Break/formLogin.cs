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
using System.Media;

namespace Projek_Tea_Break
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        public static string sqlConnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_11_TEABREAK";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public static string sqlQuery;
        public static string saveID = "";
        public static string saveNama = "";
        public static string saveJabatan = "";
        public static string saveIDPegawai = "";
        public static string saveNamaDepan = "";
       

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();
            DataTable dtLogin = new DataTable();
            sqlQuery = "select id_pegawai as 'id', nama_pegawai as 'nama', level_jabatan as 'jabatan', if( level_jabatan = 1,'Staff',if(level_jabatan = 2,'Cashier',if(level_jabatan = 3,'Manager',''))) as 'saveJabatan' from PEGAWAI where id_pegawai = '" + textBoxPassword.Text + "' and nama_pegawai = '" + textBoxUsername.Text + "' and status_delete = 0;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtLogin);
            if (dtLogin.Rows.Count > 0)
            {
                saveID = dtLogin.Rows[0]["jabatan"].ToString();
                saveNama = dtLogin.Rows[0]["nama"].ToString();
                saveJabatan = dtLogin.Rows[0]["saveJabatan"].ToString();
                saveIDPegawai = dtLogin.Rows[0]["id"].ToString();
                if (saveID == "1")
                {
                    MessageBox.Show("Username / Password tidak terdaftar");
                }
                else
                {
                    this.Hide();
                    FormOrder FormOrder = new FormOrder();
                    FormOrder.ShowDialog();
                    this.Close();
                }                
            }
            else if (textBoxPassword.Text == "" || textBoxUsername.Text == "")
            {
                MessageBox.Show("Username / Password masih kosong");
            }
            else
            {
                MessageBox.Show("Username / Password yang dimasukkan salah");
                textBoxUsername.Clear();
                textBoxPassword.Clear();
            }
            sqlConnect.Close();
        }

        private void buttonLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                sqlConnect.Open();
                DataTable dtLogin = new DataTable();
                sqlQuery = "select id_pegawai as 'id', nama_pegawai as 'nama', level_jabatan as 'jabatan', if( level_jabatan = 1,'Staff',if(level_jabatan = 2,'Cashier',if(level_jabatan = 3,'Manager',''))) as 'saveJabatan',concat(upper(left(substring_index(NAMA_PEGAWAI,' ',1),1)),lower(substring(substring_index(NAMA_PEGAWAI,' ',1),2))) as 'namadepan' from PEGAWAI where id_pegawai = '" + textBoxPassword.Text + "' and nama_pegawai = '" + textBoxUsername.Text + "' and status_delete = 0;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtLogin);
                if (dtLogin.Rows.Count > 0)
                {
                    saveID = dtLogin.Rows[0]["jabatan"].ToString();
                    saveNama = dtLogin.Rows[0]["nama"].ToString();
                    saveJabatan = dtLogin.Rows[0]["saveJabatan"].ToString();
                    saveIDPegawai = dtLogin.Rows[0]["id"].ToString();
                    saveNamaDepan = dtLogin.Rows[0]["namadepan"].ToString();
                    if (saveID == "1")
                    {
                        MessageBox.Show("Username / Password tidak terdaftar");
                    }
                    else
                    {
                        this.Hide();
                        FormOrder FormOrder = new FormOrder();
                        FormOrder.ShowDialog();
                        this.Close();
                    }
                }
                else if (textBoxPassword.Text == "" || textBoxUsername.Text == "")
                {
                    MessageBox.Show("Username / Password masih kosong");
                }
                else
                {
                    MessageBox.Show("Username / Password yang dimasukkan salah");
                    textBoxUsername.Clear();
                    textBoxPassword.Clear();
                }
                sqlConnect.Close();
            }
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                sqlConnect.Open();
                DataTable dtLogin = new DataTable();
                sqlQuery = "select id_pegawai as 'id', nama_pegawai as 'nama', level_jabatan as 'jabatan', if( level_jabatan = 1,'Staff',if(level_jabatan = 2,'Cashier',if(level_jabatan = 3,'Manager',''))) as 'saveJabatan',concat(upper(left(substring_index(NAMA_PEGAWAI,' ',1),1)),lower(substring(substring_index(NAMA_PEGAWAI,' ',1),2))) as 'namadepan' from PEGAWAI where id_pegawai = '" + textBoxPassword.Text + "' and nama_pegawai = '" + textBoxUsername.Text + "' and status_delete = 0;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtLogin);
                if (dtLogin.Rows.Count > 0)
                {
                    saveID = dtLogin.Rows[0]["jabatan"].ToString();
                    saveNama = dtLogin.Rows[0]["nama"].ToString();
                    saveJabatan = dtLogin.Rows[0]["saveJabatan"].ToString();
                    saveIDPegawai = dtLogin.Rows[0]["id"].ToString();
                    saveNamaDepan = dtLogin.Rows[0]["namadepan"].ToString();
                    if (saveID == "1")
                    {
                        MessageBox.Show("Username / Password tidak terdaftar");
                    }
                    else
                    {
                        this.Hide();
                        FormOrder FormOrder = new FormOrder();
                        FormOrder.ShowDialog();
                        this.Close();
                    }
                }
                else if (textBoxPassword.Text == "" || textBoxUsername.Text == "")
                {
                    MessageBox.Show("Username / Password masih kosong");
                }
                else
                {
                    MessageBox.Show("Username / Password yang dimasukkan salah");
                    textBoxUsername.Clear();
                    textBoxPassword.Clear();
                }
                sqlConnect.Close();
            }
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShow.Checked == true)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void textBoxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                sqlConnect.Open();
                DataTable dtLogin = new DataTable();
                sqlQuery = "select id_pegawai as 'id', nama_pegawai as 'nama', level_jabatan as 'jabatan', if( level_jabatan = 1,'Staff',if(level_jabatan = 2,'Cashier',if(level_jabatan = 3,'Manager',''))) as 'saveJabatan',concat(upper(left(substring_index(NAMA_PEGAWAI,' ',1),1)),lower(substring(substring_index(NAMA_PEGAWAI,' ',1),2))) as 'namadepan' from PEGAWAI where id_pegawai = '" + textBoxPassword.Text + "' and nama_pegawai = '" + textBoxUsername.Text + "' and status_delete = 0;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtLogin);
                if (dtLogin.Rows.Count > 0)
                {
                    saveID = dtLogin.Rows[0]["jabatan"].ToString();
                    saveNama = dtLogin.Rows[0]["nama"].ToString();
                    saveJabatan = dtLogin.Rows[0]["saveJabatan"].ToString();
                    saveIDPegawai = dtLogin.Rows[0]["id"].ToString();
                    saveNamaDepan = dtLogin.Rows[0]["namadepan"].ToString();
                    if (saveID == "1")
                    {
                        MessageBox.Show("Username / Password tidak terdaftar");
                    }
                    else
                    {
                        this.Hide();
                        FormOrder FormOrder = new FormOrder();
                        FormOrder.ShowDialog();
                        this.Close();
                    }
                }
                else if (textBoxPassword.Text == "" || textBoxUsername.Text == "")
                {
                    MessageBox.Show("Username / Password masih kosong");
                }
                else
                {
                    MessageBox.Show("Username / Password yang dimasukkan salah");
                    textBoxUsername.Clear();
                    textBoxPassword.Clear();
                }
                sqlConnect.Close();
            }

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            textBoxUsername.Focus();
        }
    }
}
