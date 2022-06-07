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

namespace Projek_Tea_Break
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public static string sqlConnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_11_TEABREAK";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public static string sqlQuery;

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();
            sqlQuery = "select nama_pegawai as 'Nama',  id_pegawai as 'Pass' from PEGAWAI where nama_pegawai = '" + textBoxUsername.Text + "' and id_pegawai = '" + textBoxPassword.Text + "';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            MySqlDataReader sqlReader = sqlCommand.ExecuteReader();
            if (sqlReader.Read())
            {
                FormOrder FormOrder = new FormOrder();
                FormOrder.Show();
            }
            else
            {
                MessageBox.Show("Data yang dimasukkan salah");
                textBoxUsername.Clear();
                textBoxPassword.Clear();
            }
            sqlConnect.Close();
        }
    }
}
