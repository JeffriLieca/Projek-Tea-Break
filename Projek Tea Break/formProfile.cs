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
    public partial class formProfile : Form
    {
        public formProfile()
        {
            InitializeComponent();
        }

        public static string sqlConnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_11_TEABREAK";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public static string sqlQuery;
        public static string saveID = "";

       

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void buttonLogout_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                sqlConnect.Open();
                DataTable dtLogin = new DataTable();
                sqlQuery = "select id_pegawai as 'id', nama_pegawai as 'nama', level_jabatan as 'jabatan' from PEGAWAI where id_pegawai = '" + textBoxPassword.Text + "' and nama_pegawai = '" + textBoxUsername.Text + "' and status_delete = 0;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtLogin);
                if (dtLogin.Rows.Count > 0)
                {
                    saveID = dtLogin.Rows[0]["jabatan"].ToString();
                    if (saveID == "1")
                    {
                        MessageBox.Show("Username / Password tidak terdaftar");
                    }
                    else
                    {
                        FormOrder FormOrder = new FormOrder();
                        FormOrder.Show();
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
                sqlQuery = "select id_pegawai as 'id', nama_pegawai as 'nama', level_jabatan as 'jabatan' from PEGAWAI where id_pegawai = '" + textBoxPassword.Text + "' and nama_pegawai = '" + textBoxUsername.Text + "' and status_delete = 0;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtLogin);
                if (dtLogin.Rows.Count > 0)
                {
                    saveID = dtLogin.Rows[0]["jabatan"].ToString();
                    if (saveID == "1")
                    {
                        MessageBox.Show("Username / Password tidak terdaftar");
                    }
                    else
                    {
                        FormOrder FormOrder = new FormOrder();
                        FormOrder.Show();
                        this.Hide();
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

        private void textBoxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                sqlConnect.Open();
                DataTable dtLogin = new DataTable();
                sqlQuery = "select id_pegawai as 'id', nama_pegawai as 'nama', level_jabatan as 'jabatan' from PEGAWAI where id_pegawai = '" + textBoxPassword.Text + "' and nama_pegawai = '" + textBoxUsername.Text + "' and status_delete = 0;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtLogin);
                if (dtLogin.Rows.Count > 0)
                {
                    saveID = dtLogin.Rows[0]["jabatan"].ToString();
                    if (saveID == "1")
                    {
                        MessageBox.Show("Username / Password tidak terdaftar");
                    }
                    else
                    {
                        FormOrder FormOrder = new FormOrder();
                        FormOrder.Show();
                        this.Hide();
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
    }
}
