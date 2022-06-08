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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();
            sqlQuery = "select nama_pegawai as 'Nama',  id_pegawai as 'Pass' from PEGAWAI where nama_pegawai = '" + textBoxUsername.Text + "' and id_pegawai = '" + textBoxPassword.Text + "' and status_delete = 0;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            MySqlDataReader sqlReader = sqlCommand.ExecuteReader();
            if (sqlReader.Read())
            {
                saveID = textBoxPassword.Text;
                FormOrder FormOrder = new FormOrder();
                FormOrder.Show();
                this.Hide();
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

        private void buttonLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                sqlConnect.Open();
                sqlQuery = "select nama_pegawai as 'Nama',  id_pegawai as 'Pass' from PEGAWAI where nama_pegawai = '" + textBoxUsername.Text + "' and id_pegawai = '" + textBoxPassword.Text + "' and status_delete = 0;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                MySqlDataReader sqlReader = sqlCommand.ExecuteReader();
                if (sqlReader.Read())
                {
                    saveID = textBoxPassword.Text;
                    FormOrder FormOrder = new FormOrder();
                    FormOrder.Show();
                    this.Hide();
                }
                else if (textBoxPassword.Text == "" || textBoxUsername.Text == "")
                {
                    SystemSounds.Exclamation.Play();
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
                sqlQuery = "select nama_pegawai as 'Nama',  id_pegawai as 'Pass' from PEGAWAI where nama_pegawai = '" + textBoxUsername.Text + "' and id_pegawai = '" + textBoxPassword.Text + "' and status_delete = 0;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                MySqlDataReader sqlReader = sqlCommand.ExecuteReader();
                if (sqlReader.Read())
                {
                    e.Handled = true;
                    saveID = textBoxPassword.Text;
                    FormOrder FormOrder = new FormOrder();
                    FormOrder.Show();
                    this.Hide();
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
                sqlQuery = "select nama_pegawai as 'Nama',  id_pegawai as 'Pass' from PEGAWAI where nama_pegawai = '" + textBoxUsername.Text + "' and id_pegawai = '" + textBoxPassword.Text + "' and status_delete = 0;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                MySqlDataReader sqlReader = sqlCommand.ExecuteReader();
                if (sqlReader.Read())
                {
                    e.Handled = true;
                    saveID = textBoxPassword.Text;
                    FormOrder FormOrder = new FormOrder();
                    FormOrder.Show();
                    this.Hide();
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
