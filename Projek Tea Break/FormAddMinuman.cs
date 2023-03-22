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
    public partial class FormAddMinuman : Form
    {
        public FormAddMinuman()
        {
            InitializeComponent();
        }

        public static string sqlConnection = "server=127.0.0.1;uid=root;pwd=;database=db_tea_break";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public static string sqlQuery;
        public string PassingData { get; set; }
        public int PassingIndex { get; set; }

        public static int PassingIndexMinuman = 0;


        public ImageList PassingImageList { get; set; }

        FormOrder formOrder = new FormOrder();

        public static string SugarLevel = "N";
        public static string IceLevel = "N";
        public static int QtyMinuman = 1;
        public static int HargaMinuman = 0;
        public static string idNota = "";
        public static string GabunganTopping = "";


        private void FormAddMinuman_Load(object sender, EventArgs e)
        {
            LoadKetMinuman();
            LoadTopping();
            DapatIDNota();

        }

        public void LoadKetMinuman()
        {
            DataTable dtKetMinuman = new DataTable();
            sqlQuery = "select m.ID_MINUMAN as id, m.NAMA_MINUMAN as nama, concat('Rp. ',m.HARGA_MINUMAN) as harga,m.HARGA_MINUMAN as price, m.GAMBAR as path from MINUMAN m where m.ID_MINUMAN = '" + PassingData + "';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtKetMinuman);
            labelMinuman.Text = dtKetMinuman.Rows[0][1].ToString();
            labelMinuman.Tag = dtKetMinuman.Rows[0][0].ToString();
            HargaMinuman = Convert.ToInt32(dtKetMinuman.Rows[0][3]);
            buttonGambar.BackgroundImage = PassingImageList.Images[PassingIndex];
            buttonGambar.Location = new Point(300, 0);
            labelMinuman.Location = new Point(340, buttonGambar.Height + 5);

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (rBSugarLess.Checked)
            {
                SugarLevel = rBSugarLess.Tag.ToString();
            }
            else if (rBSugarNormal.Checked)
            {
                SugarLevel = rBSugarNormal.Tag.ToString();
            }
            else if (rBSugarMore.Checked)
            {
                SugarLevel = rBSugarMore.Tag.ToString();
            }

            if (rBIceLess.Checked)
            {
                IceLevel = rBIceLess.Tag.ToString();
            }
            else if (rBIceNormal.Checked)
            {
                IceLevel = rBIceNormal.Tag.ToString();
            }
            else if (rBIceMore.Checked)
            {
                IceLevel = rBIceMore.Tag.ToString();
            }
            HitungTopping();
            InsertData();
            RunOrderMenu();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Label[] lbl = new Label[100];
        Button[] btnMin = new Button[100];
        TextBox[] txtbox = new TextBox[100];
        Button[] btnPlus = new Button[100];
        string[] ToppingNote = new string[100];
        string[] JumlahTopping = new string[100];


        DataTable dtTopping = new DataTable();
        public void LoadTopping()
        {


            DataTable dtTopping = new DataTable();
            sqlQuery = "select t.ID_TOPPING as id, t.NAMA_TOPPING as nama, concat('Rp. ',t.HARGA_TOPPING) as harga from TOPPING t where t.STATUS_DELETE=0;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTopping);

            Label[] lbl = new Label[dtTopping.Rows.Count];

            int posisiY = 20;
            for (int i = 0; i < dtTopping.Rows.Count; i++)
            {
                // label
                lbl[i] = new System.Windows.Forms.Label();
                panelTopping.Controls.Add(lbl[i]);
                lbl[i].Location = new Point(20, posisiY);
                lbl[i].Text = dtTopping.Rows[i][1].ToString();
                lbl[i].Tag = dtTopping.Rows[i][0].ToString();
                ToppingNote[i] = lbl[i].Tag.ToString();

                // btn Min
                btnMin[i] = new System.Windows.Forms.Button();
                panelTopping.Controls.Add(btnMin[i]);
                btnMin[i].Location = new Point(200, posisiY);
                btnMin[i].Size = new Size(20, 20);
                btnMin[i].Text = "-";
                btnMin[i].Tag = i;
                btnMin[i].TextAlign = ContentAlignment.MiddleCenter;
                btnMin[i].UseCompatibleTextRendering = true;
                btnMin[i].Click += new EventHandler(button_min);

                // txt box
                txtbox[i]= new System.Windows.Forms.TextBox();
                panelTopping.Controls.Add(txtbox[i]);
                txtbox[i].Location = new Point(225, posisiY);
                txtbox[i].Size = new Size(20, 20);
                txtbox[i].Text = "0";
                txtbox[i].Tag = i;
                txtbox[i].TextAlign = HorizontalAlignment.Center;

                // btn Plus
                btnPlus[i] = new System.Windows.Forms.Button();
                panelTopping.Controls.Add(btnPlus[i]);
                btnPlus[i].Location = new Point(250, posisiY);
                btnPlus[i].Size = new Size(20, 20);
                btnPlus[i].Text = "+";
                btnPlus[i].Tag = i;
                btnPlus[i].TextAlign = ContentAlignment.MiddleCenter;
                btnPlus[i].UseCompatibleTextRendering = true;
                btnPlus[i].Click += new EventHandler(button_plus);

                posisiY += 25;

            }
        }


        private void button_plus(object sender, EventArgs e)
        {
            Button bts = (Button)sender;
            int posisiTekan = Convert.ToInt32(bts.Tag);
            txtbox[posisiTekan].Text = (Convert.ToInt32(txtbox[posisiTekan].Text) + 1).ToString();
            JumlahTopping[posisiTekan] = txtbox[posisiTekan].Text;
        }

        private void button_min(object sender, EventArgs e)
        {
            
            Button bts = (Button)sender;
            int posisiTekan = Convert.ToInt32(bts.Tag);
            if (Convert.ToInt32(txtbox[posisiTekan].Text )> 0)
            {
                txtbox[posisiTekan].Text = (Convert.ToInt32(txtbox[posisiTekan].Text) - 1).ToString();
                JumlahTopping[posisiTekan] = txtbox[posisiTekan].Text;
            }
        }

        private void buttonPlusQty_Click(object sender, EventArgs e)
        {
            textBoxQty.Text = (Convert.ToInt32(textBoxQty.Text) + 1).ToString();
            QtyMinuman = Convert.ToInt32(textBoxQty.Text);
        }

        private void buttonMinQty_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxQty.Text) > 1)
            {
                textBoxQty.Text = (Convert.ToInt32(textBoxQty.Text) - 1).ToString();
            }
            QtyMinuman = Convert.ToInt32(textBoxQty.Text);
        }

        public void HitungTopping()
        {
            GabunganTopping = "";
            for(int i = 0; i < ToppingNote.Length; i++)
            {
                if(Convert.ToInt32(JumlahTopping[i])>0)
                    GabunganTopping += ToppingNote[i]+"-"+JumlahTopping[i]+",";
            }
            if (GabunganTopping.Length > 0)
            {
                GabunganTopping = GabunganTopping.Substring(0, GabunganTopping.Length - 1);
            }
            else
            {
                GabunganTopping = null;
            }
            //MessageBox.Show(GabunganTopping);
        }

        public void DapatIDNota()
        {
            sqlConnect.Open();
            sqlQuery = "select right(n.ID_NOTA,4) as urut,left(n.ID_NOTA,6) as tanggal from NOTA n where left(n.ID_NOTA,6)= date_format(now(),\"%y%m%d\") order by 1 desc;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable dtidNota = new DataTable();
            sqlAdapter.Fill(dtidNota);

            sqlQuery = "select date_format(now(),\"%y%m%d\");";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable dtTanggalNota = new DataTable();
            sqlAdapter.Fill(dtTanggalNota);

            idNota = "";
            string nomorNota = "";
            if (dtidNota.Rows.Count == 0)
            {
                idNota = dtTanggalNota.Rows[0][0].ToString() + "0001";
            }
            else
            {
                nomorNota = (Convert.ToInt32(dtidNota.Rows[0][0].ToString()) + 1).ToString();
                for (int i = 0; i < 6-nomorNota.Length; i++)
                {
                    nomorNota = "0" + nomorNota;
                }
                idNota = dtidNota.Rows[0][1].ToString() + nomorNota;
            }
            labelIDNota.Text = idNota;
            sqlConnect.Close();
        }

        public void InsertData()
        {
            FormOrder orderform = new FormOrder();
            int Index = orderform.IndexMinuman;
            orderform.IndexMinuman++;
            
            sqlConnect.Open();
            string sqlInsert = "insert into DETAIL_MINUMAN_SEMENTARA values('"+idNota+"','"+PassingIndexMinuman+"','"+labelMinuman.Tag.ToString()+"','"+QtyMinuman+"','"+HargaMinuman+"','"+QtyMinuman*HargaMinuman+"','"+GabunganTopping+"','"+SugarLevel+"','"+IceLevel+"','0');";
            sqlCommand = new MySqlCommand(sqlInsert, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            //MessageBox.Show(sqlInsert);
            orderform.IndexMinuman++;
            PassingIndexMinuman++;
        }

        public void RunOrderMenu()
        {
            var TampilkanOrderMenu = Application.OpenForms.OfType<FormOrder>().FirstOrDefault();
            TampilkanOrderMenu.LoadOrderMenu();
            TampilkanOrderMenu.RefreshPencarian();
        }

    }
}
