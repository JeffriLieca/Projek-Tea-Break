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
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
        }

        public static string sqlConnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_11_TEABREAK";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public static string sqlQuery;
        public static int posisiX = 0;
        public static int posisiY = 0;

        public static string sqlInsert;
        public static int nomorMinuman;
        private void FormOrder_Load(object sender, EventArgs e)
        {
            sqlConnect.Open();
            buttonEditMenu.BackColor = Color.Transparent;
            buttonAdmin.BackColor = Color.Transparent;
            buttonCashier.BackColor = Color.ForestGreen;
            InvisText();
            buttonCashier.Text = "Cashier";

            sqlConnect.Open();
            sqlQuery = "select id_pegawai as 'id', NAMA_PEGAWAI as 'pegawai', level_jabatan as 'jabatan' from PEGAWAI where STATUS_DELETE = 0 and LEVEL_JABATAN = 2 and id_pegawai ='"+FormLogin.saveID+"';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            MySqlDataReader sqlReader = sqlCommand.ExecuteReader();
            if (sqlReader.Read())
            {
                buttonAdmin.Enabled = false;
            }                        
            sqlConnect.Close();

            sqlConnect.Open();
            sqlQuery = "select id_pegawai as 'id', NAMA_PEGAWAI as 'pegawai', level_jabatan as 'jabatan' from PEGAWAI where STATUS_DELETE = 0 and LEVEL_JABATAN = 1 and id_pegawai ='" + FormLogin.saveID + "';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlReader = sqlCommand.ExecuteReader();
            if (sqlReader.Read())
            {
                buttonEditMenu.Enabled = false;
                buttonAdmin.Enabled = false;
            }
            sqlConnect.Close();
            LoadMinuman();

            buttonA.FlatAppearance.BorderSize = 0;
            buttonS.FlatAppearance.BorderSize = 0;
            buttonF.FlatAppearance.BorderSize = 0;
            buttonT.FlatAppearance.BorderSize = 0;

            sqlQuery = "select right(n.ID_NOTA,2) as urut,left(n.ID_NOTA,6) as tanggal from NOTA_SEMENTARA_JI n where left(n.ID_NOTA,6)= date_format(now(),\"%y%m%d\") order by 1 desc;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable dtidNota = new DataTable();
            sqlAdapter.Fill(dtidNota);
            string idNota="";
            string nomorNota = "";
            if (dtidNota.Rows.Count == 0)
            {

                sqlInsert = "insert into NOTA_SEMENTARA_JI (ID_NOTA,ID_CUST,ID_PEGAWAI,ID_PROMO,TGL_NOTA,NAMA_CUST,TOTAL_HARGA,URUTAN,STATUS_DELETE) values (concat(date_format(now(),\"%y%m%d\"),'0001'),'CUSTO','PEGA','PROMO',now(),'Jeffri',50000,1,0);";
                sqlCommand = new MySqlCommand(sqlInsert, sqlConnect);
                sqlCommand.ExecuteNonQuery();

                sqlInsert = "insert into DETAIL_MINUMAN_SEMENTARA_JI (ID_NOTA,ID_MINUMAN,QTY_MINUMAN,HARGA_MINUMAN,SUBTOTAL_MINUMAN,SUGAR_LEVEL,ICE_LEVEL,STATUS_DELETE) values (concat(date_format(now(),\"%y%m%d\"),'01'),'F002',2,10000,20000,'N','N',0);";
                sqlCommand = new MySqlCommand(sqlInsert, sqlConnect);
                sqlCommand.ExecuteNonQuery();
            }
            else
            {
                nomorNota = (Convert.ToInt32(dtidNota.Rows[0][0].ToString()) + 1).ToString();
                for (int i = 0; i < nomorNota.Length; i++)
                {
                    nomorNota="0"+nomorNota;
                }
                idNota = dtidNota.Rows[0][1].ToString() + nomorNota;

                sqlInsert = "insert into DETAIL_MINUMAN_SEMENTARA_JI (ID_NOTA,ID_MINUMAN,QTY_MINUMAN,HARGA_MINUMAN,SUBTOTAL_MINUMAN,SUGAR_LEVEL,ICE_LEVEL,STATUS_DELETE) values ('" + idNota + "','F002',2,10000,20000,'N','N',0);";
                sqlCommand = new MySqlCommand(sqlInsert, sqlConnect);
                sqlCommand.ExecuteNonQuery();
            }
            labelIDNota.Text = idNota;
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
            buttonEditMenu.Text = "Edit Menu";
        }

        private void buttonAdmin_Click_1(object sender, EventArgs e)
        {
            buttonCashier.BackColor = Color.Transparent;
            buttonEditMenu.BackColor = Color.Transparent;
            buttonAdmin.BackColor = Color.ForestGreen;
            InvisText();
            buttonAdmin.Text = "Admin";
            
        }

        public void InvisText()
        {
            buttonCashier.Text = " ";
            buttonEditMenu.Text = " ";
            buttonAdmin.Text = " ";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            LoadMinuman();
        }

        public void LoadMinuman()
        {
            panelMinuman.Controls.OfType<Button>().ToList().ForEach(btn => btn.Dispose());
            DataTable dtMinuman = new DataTable();
            try
            {
                sqlQuery = "select m.ID_MINUMAN as id, m.NAMA_MINUMAN as nama, concat('Rp. ',m.HARGA_MINUMAN) as harga, m.INDEX_GAMBAR as 'index' from MINUMAN m where m.NAMA_MINUMAN like '%"+textBoxCariMinuman.Text+"%';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtMinuman);
            }
            catch (Exception)
            {

            }
            nomorMinuman = 0;
            for (int j = 0; j < dtMinuman.Rows.Count / 3 + 1; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (nomorMinuman < dtMinuman.Rows.Count)
                    {
                        Button buttonhu = new Button();
                        panelMinuman.Controls.Add(buttonhu);
                        buttonhu.Size = new Size(110, 140);
                        buttonhu.Location = new Point(posisiX, posisiY);
                        buttonhu.Text = $"{dtMinuman.Rows[nomorMinuman][1].ToString()}\n{dtMinuman.Rows[nomorMinuman][2].ToString()}";
                        buttonhu.Visible = true;
                        buttonhu.BringToFront();
                        buttonhu.Tag = dtMinuman.Rows[nomorMinuman][0].ToString();
                        buttonhu.ImageList = imageListMinuman;
                        buttonhu.ImageIndex = Convert.ToInt16(dtMinuman.Rows[nomorMinuman][3]);
                        buttonhu.TextImageRelation = TextImageRelation.ImageAboveText;
                        buttonhu.TextAlign = ContentAlignment.MiddleRight;
                        buttonhu.ImageAlign = ContentAlignment.MiddleCenter;
                        buttonhu.Click += Buttonhu_Click;
                        buttonhu.FlatStyle = FlatStyle.Flat;
                        buttonhu.ForeColor = Color.Black;
                        posisiX += 120;
                        if (posisiX > 300)
                        {
                            posisiX = 0;
                        }
                        nomorMinuman++;
                    }
                }
                posisiY += 150;
            }
            posisiX = 0;
            posisiY = 0;
        }

        private void Buttonhu_Click(object sender, EventArgs e)
        {
            Button buttonhu = (sender as Button);
            FormAddMinuman formadd = new FormAddMinuman();
            formadd.PassingData = buttonhu.Tag.ToString();
            formadd.PassingImageList = imageListMinuman;
            formadd.PassingIndex = buttonhu.ImageIndex;
            formadd.Show();
        }

        private void textBoxCariMinuman_TextChanged(object sender, EventArgs e)
        {
            LoadMinuman();
        }


        private void buttonOrderNow_Click(object sender, EventArgs e)
        {
            FormAddMinuman formadd = new FormAddMinuman();
            formadd.Show();
        }
    }
}
