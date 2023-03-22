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

        public static string sqlConnection = "server=127.0.0.1;uid=root;pwd=;database=db_tea_break";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public static string sqlQuery;



        private void buttonLogout_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
            this.Close();
        }

        private void formProfile_Load(object sender, EventArgs e)
        {
            lbNama.Text = FormLogin.saveNama;
            lbJabatan.Text = FormLogin.saveJabatan;
            lbNama.Size = new Size(385, 20);
            lbJabatan.Size = new Size(385, 20);
            lbNama.AutoSize = false;
            lbJabatan.AutoSize = false;
        }
    }
}
