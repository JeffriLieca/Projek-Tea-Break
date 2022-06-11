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
        public static string sqlInsert;
        public static int nomorMinuman;
        public static string Kategori = "";
        public static int Total = 0;

        public int IndexMinuman { get; set; }

        private void FormOrder_Load(object sender, EventArgs e)
        {

            DapatIDNota(); 

            //sqlConnect.Open();
            buttonEditMenu.BackColor = Color.Transparent;
            buttonAdmin.BackColor = Color.Transparent;
            buttonCashier.BackColor = Color.ForestGreen;
            InvisText();
            buttonCashier.Text = "Cashier";
            //sqlConnect.Close();

            if (FormLogin.saveID == "2")
            {
                buttonAdmin.Enabled = false;
                buttonEditMenu.Enabled = false;
            }


            sqlConnect.Open();
            LoadMinuman();
            LoadOrderMenu();

            buttonA.FlatAppearance.BorderSize = 0;
            buttonS.FlatAppearance.BorderSize = 0;
            buttonF.FlatAppearance.BorderSize = 0;
            buttonT.FlatAppearance.BorderSize = 0;

            //sqlQuery = "select right(n.ID_NOTA,2) as urut,left(n.ID_NOTA,6) as tanggal from NOTA_SEMENTARA_JI n where left(n.ID_NOTA,6)= date_format(now(),\"%y%m%d\") order by 1 desc;";
            //sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            //sqlAdapter = new MySqlDataAdapter(sqlCommand);
            //DataTable dtidNota = new DataTable();
            //sqlAdapter.Fill(dtidNota);
            //string idNota="";
            //string nomorNota = "";
            //if (dtidNota.Rows.Count == 0)
            //{

            //    sqlInsert = "insert into NOTA_SEMENTARA_JI (ID_NOTA,ID_CUST,ID_PEGAWAI,ID_PROMO,TGL_NOTA,NAMA_CUST,TOTAL_HARGA,URUTAN,STATUS_DELETE) values (concat(date_format(now(),\"%y%m%d\"),'0001'),'CUSTO','PEGA','PROMO',now(),'Jeffri',50000,1,0);";
            //    sqlCommand = new MySqlCommand(sqlInsert, sqlConnect);
            //    sqlCommand.ExecuteNonQuery();

            //    sqlInsert = "insert into DETAIL_MINUMAN_SEMENTARA_JI (ID_NOTA,ID_MINUMAN,QTY_MINUMAN,HARGA_MINUMAN,SUBTOTAL_MINUMAN,SUGAR_LEVEL,ICE_LEVEL,STATUS_DELETE) values (concat(date_format(now(),\"%y%m%d\"),'01'),'F002',2,10000,20000,'N','N',0);";
            //    sqlCommand = new MySqlCommand(sqlInsert, sqlConnect);
            //    sqlCommand.ExecuteNonQuery();
            //}
            //else
            //{
            //    nomorNota = (Convert.ToInt32(dtidNota.Rows[0][0].ToString()) + 1).ToString();
            //    for (int i = 0; i < nomorNota.Length; i++)
            //    {
            //        nomorNota="0"+nomorNota;
            //    }
            //    idNota = dtidNota.Rows[0][1].ToString() + nomorNota;

            //    sqlInsert = "insert into DETAIL_MINUMAN_SEMENTARA_JI (ID_NOTA,ID_MINUMAN,QTY_MINUMAN,HARGA_MINUMAN,SUBTOTAL_MINUMAN,SUGAR_LEVEL,ICE_LEVEL,STATUS_DELETE) values ('" + idNota + "','F002',2,10000,20000,'N','N',0);";
            //    sqlCommand = new MySqlCommand(sqlInsert, sqlConnect);
            //    sqlCommand.ExecuteNonQuery();
            //}
            //labelIDNota.Text = idNota;
            // sqlConnect.Close();



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

            this.Hide();
            formEditPilih formPilih = new formEditPilih();
            formPilih.ShowDialog();
            this.Close();
        }

        private void buttonAdmin_Click_1(object sender, EventArgs e)
        {
            buttonCashier.BackColor = Color.Transparent;
            buttonEditMenu.BackColor = Color.Transparent;
            buttonAdmin.BackColor = Color.ForestGreen;
            InvisText();
            buttonAdmin.Text = "Admin";

            this.Hide();
            formAdmin formAdmin = new formAdmin();
            formAdmin.ShowDialog();
            this.Close();
        }

        public void InvisText()
        {
            buttonCashier.Text = " ";
            buttonEditMenu.Text = " ";
            buttonAdmin.Text = " ";
        }


        public static int posisiX = 0;
        public static int posisiY = 0;
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
                if (Kategori == "")
                {
                    sqlQuery = "select m.ID_MINUMAN as id, m.NAMA_MINUMAN as nama, concat('Rp. ',m.HARGA_MINUMAN) as harga, m.GAMBAR as image from MINUMAN m where m.NAMA_MINUMAN like '%" + textBoxCariMinuman.Text + "%' and m.STATUS_DELETE='0'";
                }
                else
                {
                    sqlQuery = "select m.ID_MINUMAN as id, m.NAMA_MINUMAN as nama, concat('Rp. ',m.HARGA_MINUMAN) as harga, m.GAMBAR as image from MINUMAN m where m.NAMA_MINUMAN like '%" + textBoxCariMinuman.Text + "%' and left(ID_MINUMAN,1)='" + Kategori + "' and m.STATUS_DELETE='0'; ";
                }
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtMinuman);
            }
            catch (Exception)
            {

            }
            nomorMinuman = 0;
            imageListMinuman.Images.Clear();
            for (int j = 0; j < dtMinuman.Rows.Count / 3 + 1; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (nomorMinuman < dtMinuman.Rows.Count)
                    {


                        byte[] images = (byte[])dtMinuman.Rows[nomorMinuman][3];
                        MemoryStream mstream = new MemoryStream(images);
                        //Array.Clear(images,0, Convert.ToInt32(dtMinuman.Rows[i][3]));
                        //pictureBoxAdd.Image = Image.FromStream(mstream);

                        string path = dtMinuman.Rows[nomorMinuman][3].ToString();
                        imageListMinuman.Images.Add(Image.FromStream(mstream));

                        Button buttonhu = new Button();
                        panelMinuman.Controls.Add(buttonhu);
                        buttonhu.Size = new Size(110, 140);
                        buttonhu.Location = new Point(posisiX, posisiY);
                        buttonhu.Text = $"{dtMinuman.Rows[nomorMinuman][1].ToString()}\n{dtMinuman.Rows[nomorMinuman][2].ToString()}";
                        buttonhu.Visible = true;
                        buttonhu.BringToFront();
                        buttonhu.Tag = dtMinuman.Rows[nomorMinuman][0].ToString();
                        //buttonhu.Image = Image.FromStream(mstream);
                        buttonhu.ImageList = imageListMinuman;
                        buttonhu.ImageIndex = nomorMinuman;
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
            formadd.ShowDialog();
        }

        private void textBoxCariMinuman_TextChanged(object sender, EventArgs e)
        {
            LoadMinuman();
        }


        private void buttonOrderNow_Click(object sender, EventArgs e)
        {
            if (textBoxNama.Text == "")
            {
                MessageBox.Show("Nama Customer harus diisi");
            }
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            Kategori = "S";
            LoadMinuman();
            buttonA.BackColor = Color.Transparent;
            buttonS.BackColor = Color.LightGreen;
            buttonF.BackColor = Color.Transparent;
            buttonT.BackColor = Color.Transparent;
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            Kategori = "F";
            LoadMinuman();
            buttonA.BackColor = Color.Transparent;
            buttonS.BackColor = Color.Transparent;
            buttonF.BackColor = Color.LightGreen;
            buttonT.BackColor = Color.Transparent;
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            Kategori = "T";
            LoadMinuman();
            buttonA.BackColor = Color.Transparent;
            buttonS.BackColor = Color.Transparent;
            buttonF.BackColor = Color.Transparent;
            buttonT.BackColor = Color.LightGreen;
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            Kategori = "";
            LoadMinuman();
            buttonA.BackColor = Color.LightGreen;
            buttonS.BackColor = Color.Transparent;
            buttonF.BackColor = Color.Transparent;
            buttonT.BackColor = Color.Transparent;
        }
        public void LoadOrderMenu()
        {

            DataTable dtDetail = new DataTable();
            string sqlQueryDetail = "select DM.INDEX_MINUMAN AS `INDEX`, DM.ID_MINUMAN AS ID, M.NAMA_MINUMAN as NAMA ,DM.QTY_MINUMAN AS QTY, DM.HARGA_MINUMAN AS HARGA, DM.SUBTOTAL_MINUMAN AS SUBTOTAL, DM.NOTE_MINUMAN AS NOTE, DM.SUGAR_LEVEL AS SUGAR, ICE_LEVEL AS ICE from DETAIL_MINUMAN_SEMENTARA DM, MINUMAN M where  M.ID_MINUMAN=DM.ID_MINUMAN and DM.ID_NOTA='"+labelIDNota.Text+"' order by 1 ;  ";
            sqlCommand = new MySqlCommand(sqlQueryDetail, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtDetail);


            Label[] labelMinuman = new Label[dtDetail.Rows.Count];
            Label[] labelHargaSubtotal = new Label[dtDetail.Rows.Count];
            Label[] labelSugar = new Label[dtDetail.Rows.Count];
            Label[] labelIce = new Label[dtDetail.Rows.Count];
            int[] Subtotal = new int[dtDetail.Rows.Count];

            int posisiY = 40;
            int posisiYHarga = 40;
            for (int i = 0; i < dtDetail.Rows.Count; i++)
            {
                posisiY += 10;
                posisiYHarga = posisiY;
                string[] detailTopping = dtDetail.Rows[i][6].ToString().Split(',');
                labelMinuman[i] = new System.Windows.Forms.Label();
                panelOrderMenu.Controls.Add(labelMinuman[i]);
                labelMinuman[i].Text = dtDetail.Rows[i][2].ToString() + " " + dtDetail.Rows[i][3] + " x @ " + dtDetail.Rows[i][4].ToString();
                labelMinuman[i].Location = new Point(20, posisiY);
                labelMinuman[i].UseCompatibleTextRendering = true;
                labelMinuman[i].Size = new Size(150,15);
                Label[] labelTopping = new Label[detailTopping.Length];
                posisiY += 15;

                Subtotal[i] = Convert.ToInt32(dtDetail.Rows[i][4])*Convert.ToInt32(dtDetail.Rows[i][3]);

                
                for (int j = 0; j < detailTopping.Length; j++)
                {
                    string[] pisahTopping = detailTopping[j].Split('-');

                    DataTable dtTopping = new DataTable();
                    string sqlQueryPisahTopping = "select NAMA_TOPPING, HARGA_TOPPING FROM TOPPING WHERE ID_TOPPING='"+pisahTopping[0]+"';";
                    sqlCommand = new MySqlCommand(sqlQueryPisahTopping, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(dtTopping);

                    labelTopping[j] = new System.Windows.Forms.Label();
                    panelOrderMenu.Controls.Add(labelTopping[j]);
                    //labelTopping[j].Text = detailTopping[j];
                    if (dtTopping.Rows.Count > 0)
                    {

                        labelTopping[j].Text = dtTopping.Rows[0][0].ToString() + " " + pisahTopping[1] + " x @ " + dtTopping.Rows[0][1].ToString();
                        labelTopping[j].Font = new Font(labelTopping[j].Font.ToString(), 7);
                        labelTopping[j].UseCompatibleTextRendering = true;
                        labelTopping[j].Size = new Size(150, 15);
                        labelTopping[j].Location = new Point(40, posisiY);
                        posisiY += 15;

                        Subtotal[i] += Convert.ToInt32(dtTopping.Rows[0][1]) * Convert.ToInt32(pisahTopping[1]);
                    }
                }

                if (dtDetail.Rows[i][7].ToString() == "L")
                {
                    labelSugar[i] = new System.Windows.Forms.Label();
                    panelOrderMenu.Controls.Add(labelSugar[i]);
                    labelSugar[i].Text = "(Less Sugar)";
                    labelSugar[i].Location = new Point(40, posisiY);
                    labelSugar[i].UseCompatibleTextRendering = true;
                    labelSugar[i].Font = new Font(labelSugar[i].Font.ToString(), 7);
                    labelSugar[i].Size = new Size(150, 15);
                    posisiY += 15;
                }
                else if (dtDetail.Rows[i][7].ToString() == "M")
                {
                    labelSugar[i] = new System.Windows.Forms.Label();
                    panelOrderMenu.Controls.Add(labelSugar[i]);
                    labelSugar[i].Text = "(More Sugar)";
                    labelSugar[i].Location = new Point(40, posisiY);
                    labelSugar[i].UseCompatibleTextRendering = true;
                    labelSugar[i].Font = new Font(labelSugar[i].Font.ToString(), 7);
                    labelSugar[i].Size = new Size(150, 15);
                    posisiY += 15;
                }
                else { }

                if (dtDetail.Rows[i][8].ToString() == "L")
                {
                    labelIce[i] = new System.Windows.Forms.Label();
                    panelOrderMenu.Controls.Add(labelIce[i]);
                    labelIce[i].Text = "(Less Ice)";
                    labelIce[i].Location = new Point(40, posisiY);
                    labelIce[i].UseCompatibleTextRendering = true;
                    labelIce[i].Font = new Font(labelIce[i].Font.ToString(), 7);
                    labelIce[i].Size = new Size(150, 15);
                    posisiY += 15;
                }
                else if (dtDetail.Rows[i][8].ToString() == "M")
                {
                    labelIce[i] = new System.Windows.Forms.Label();
                    panelOrderMenu.Controls.Add(labelIce[i]);
                    labelIce[i].Text = "(More Ice)";
                    labelIce[i].Location = new Point(40, posisiY);
                    labelIce[i].UseCompatibleTextRendering = true;
                    labelIce[i].Font = new Font(labelIce[i].Font.ToString(), 7);
                    labelIce[i].Size = new Size(150, 15);
                    posisiY += 15;
                }
                else { }

                labelHargaSubtotal[i] = new System.Windows.Forms.Label();
                panelOrderMenu.Controls.Add(labelHargaSubtotal[i]);
                labelHargaSubtotal[i].Text = "Rp. " + Subtotal[i].ToString();
                labelHargaSubtotal[i].Location = new Point(180, posisiYHarga);
                labelHargaSubtotal[i].UseCompatibleTextRendering = true;
                labelHargaSubtotal[i].Size = new Size(60, 15);

                Total += Subtotal[i];
                labelTotalHarga.Text = "Rp. " + Total.ToString();
            }


        }
        private void pbProfil_Click(object sender, EventArgs e)
        {
            formProfile formProfil = new formProfile();
            formProfil.ShowDialog();
        }

        private void panelOrderMenu_Paint(object sender, PaintEventArgs e)
        {

        }
        public static string idNota = "";
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
                for (int i = 0; i < nomorNota.Length; i++)
                {
                    nomorNota = "0" + nomorNota;
                }
                idNota = dtidNota.Rows[0][1].ToString() + nomorNota;
            }
            labelIDNota.Text = idNota;
            sqlConnect.Close();
        }
    }
}





