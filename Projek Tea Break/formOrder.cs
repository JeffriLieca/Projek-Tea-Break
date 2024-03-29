﻿using System;
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

        public static string sqlConnection = "server=127.0.0.1;uid=root;pwd=;database=db_tea_break";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public static string sqlQuery;
        public static string sqlInsert;
        public static int nomorMinuman;
        public static string Kategori = "";
        public static int Total = 0;
        public static int Netto = 0;
        public static int Diskon = 0;
        public static string IDCustomer = "";
        public static string IDPromo = "";
        public static string IDPegawai = "";
        public static string NamaPegawai = "";
        public static string nomorNota = "";
        public static string urutan = "";

        public int IndexMinuman { get; set; }

        public void InvisText()
        {
            buttonCashier.Text = " ";
            buttonEditMenu.Text = " ";
            buttonAdmin.Text = " ";
        }



        public static int posisiX = 0;
        public static int posisiY = 0;
        public void LoadMinuman()
        {

            posisiX = 13;
            posisiY = 10;
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
                        buttonhu.Size = new Size(110, 150);
                        buttonhu.Location = new Point(posisiX, posisiY);
                        buttonhu.Text = $"\n{dtMinuman.Rows[nomorMinuman][1].ToString()}\n{dtMinuman.Rows[nomorMinuman][2].ToString()}";
                        buttonhu.Visible = true;
                        buttonhu.BringToFront();
                        buttonhu.Tag = dtMinuman.Rows[nomorMinuman][0].ToString();
                        //buttonhu.Image = Image.FromStream(mstream);
                        buttonhu.ImageList = imageListMinuman;
                        buttonhu.ImageIndex = nomorMinuman;
                        buttonhu.BackColor = Color.White;
                        buttonhu.TextImageRelation = TextImageRelation.ImageAboveText;
                        buttonhu.TextAlign = ContentAlignment.MiddleRight;
                        buttonhu.ImageAlign = ContentAlignment.MiddleCenter;
                        buttonhu.Click += Buttonhu_Click;
                        buttonhu.FlatStyle = FlatStyle.Flat;
                        buttonhu.ForeColor = Color.Black;
                        posisiX += 120;
                        if (posisiX > 300)
                        {
                            posisiX = 13;
                        }
                        nomorMinuman++;
                    }
                }
                posisiY += 160;
            }
            sqlConnect.Close();
        }

        public void LoadOrderMenu()
        {
            panelOrderMenu.Controls.Clear();

            
            DataTable dtDetail = new DataTable();
            string sqlQueryDetail = "select DM.INDEX_MINUMAN AS `INDEX`, DM.ID_MINUMAN AS ID, M.NAMA_MINUMAN as NAMA ,DM.QTY_MINUMAN AS QTY, DM.HARGA_MINUMAN AS HARGA, DM.SUBTOTAL_MINUMAN AS SUBTOTAL, DM.NOTE_MINUMAN AS NOTE, DM.SUGAR_LEVEL AS SUGAR, ICE_LEVEL AS ICE from DETAIL_MINUMAN_SEMENTARA DM, MINUMAN M where  M.ID_MINUMAN=DM.ID_MINUMAN and DM.ID_NOTA='" + labelIDNota.Text + "' and DM.STATUS_DELETE=0 order by 1 ;  ";
            sqlCommand = new MySqlCommand(sqlQueryDetail, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtDetail);


            Label[] labelMinuman = new Label[dtDetail.Rows.Count];
            Label[] labelHargaSubtotal = new Label[dtDetail.Rows.Count];
            Label[] labelSugar = new Label[dtDetail.Rows.Count];
            Label[] labelIce = new Label[dtDetail.Rows.Count];
            Button[] buttonSilang = new Button[dtDetail.Rows.Count];
            int[] Subtotal = new int[dtDetail.Rows.Count];

            int posisiY = 5;
            int posisiYHarga = 5;

            Total = 0;
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
                labelMinuman[i].Size = new Size(150, 15);
                Label[] labelTopping = new Label[detailTopping.Length];
                posisiY += 15;

                Subtotal[i] = Convert.ToInt32(dtDetail.Rows[i][4]) * Convert.ToInt32(dtDetail.Rows[i][3]);


                for (int j = 0; j < detailTopping.Length; j++)
                {



                    string[] pisahTopping = detailTopping[j].Split('-');

                    DataTable dtTopping = new DataTable();
                    string sqlQueryPisahTopping = "select NAMA_TOPPING, HARGA_TOPPING FROM TOPPING WHERE ID_TOPPING='" + pisahTopping[0] + "';";
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


                buttonSilang[i] = new System.Windows.Forms.Button();
                panelOrderMenu.Controls.Add(buttonSilang[i]);
                buttonSilang[i].Text = "X";
                buttonSilang[i].Tag = dtDetail.Rows[i][0];
                buttonSilang[i].Location = new Point(5, posisiYHarga);
                buttonSilang[i].UseCompatibleTextRendering = true;
                buttonSilang[i].TextAlign = ContentAlignment.MiddleCenter;
                buttonSilang[i].BringToFront();
                buttonSilang[i].Size = new Size(15, 15);
                buttonSilang[i].Font = new Font(buttonSilang[i].Font.ToString(), 5);
                buttonSilang[i].Click += buttonSilang_Click;

                Total += Subtotal[i];
                labelTotalHarga.Text = "Rp. " + Total.ToString();
            }

            sqlConnect.Close();
            GetDiscount();
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
            nomorNota = "";
            if (dtidNota.Rows.Count == 0)
            {
                idNota = dtTanggalNota.Rows[0][0].ToString() + "0001";
                urutan = "1";
            }
            else
            {
                nomorNota = (Convert.ToInt32(dtidNota.Rows[0][0].ToString()) + 1).ToString();
                urutan = nomorNota;
                for (int i = 0; i < 6 - nomorNota.Length; i++)
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
            sqlConnect.Open();
            string sqlQueryDetail = "select ID_NOTA as IDNOTA,INDEX_MINUMAN AS IND, ID_MINUMAN AS IDMINUMAN,QTY_MINUMAN AS QTY,HARGA_MINUMAN AS HARGA, SUBTOTAL_MINUMAN AS SUBTOTAL, NOTE_MINUMAN AS NOTE,SUGAR_LEVEL AS SUGAR,ICE_LEVEL AS ICE,STATUS_DELETE AS STAT FROM DETAIL_MINUMAN_SEMENTARA WHERE STATUS_DELETE=0;  ";
            sqlCommand = new MySqlCommand(sqlQueryDetail, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable dtInsert = new DataTable();
            sqlAdapter.Fill(dtInsert);

            for (int i = 0; i < dtInsert.Rows.Count; i++)
            {
                string sqlInsert = "insert into DETAIL_MINUMAN values('" + dtInsert.Rows[i][0].ToString() + "','" + i + "','" + dtInsert.Rows[i][2].ToString() + "','" + dtInsert.Rows[i][3].ToString() + "','" + dtInsert.Rows[i][4].ToString() + "','" + dtInsert.Rows[i][5].ToString() + "','" + dtInsert.Rows[i][6].ToString() + "','" + dtInsert.Rows[i][7].ToString() + "','" + dtInsert.Rows[i][8].ToString() + "','0');";
                sqlCommand = new MySqlCommand(sqlInsert, sqlConnect);
                sqlCommand.ExecuteNonQuery();
            }
            sqlConnect.Close();
        }

        public void DeleteData()
        {
            string sqlDelete = "delete from DETAIL_MINUMAN_SEMENTARA;";
            sqlCommand = new MySqlCommand(sqlDelete, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
        }

        public void GetDiscount()
        {
            try
            {

                sqlConnect.Open();
                DataTable dtPromo = new DataTable();
                string sqlQuery = "select ID_PROMO,BESAR_PROMO from PROMO where TGL_PROMO<now() and END_PROMO>now() order by 2 desc;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPromo);
                sqlConnect.Close();

                if (dtPromo.Rows.Count > 0)
                {
                    Diskon = Convert.ToInt32(dtPromo.Rows[0][1]) * Total / 100;
                    labelDiskon.Text = "-Rp. " + Diskon.ToString();
                    labelPersen.Text = dtPromo.Rows[0][1].ToString() + "%";
                    Netto = Total - Diskon;
                    labelTotalHargaBersih.Text = "Rp. " + Netto.ToString();
                    IDPromo = dtPromo.Rows[0][0].ToString();
                }
                else
                {
                    Diskon = 0;
                    labelDiskon.Text = "- Rp. " + Diskon.ToString();
                    labelPersen.Text = "0%";
                    Netto = Total - Diskon;
                    labelTotalHargaBersih.Text = "Rp. " + Netto.ToString();
                    IDPromo = "";
                }
            }
            catch (Exception)
            {
            }
        }

        public void Reload()
        {
            Total = 0;
            Netto = 0;
            Diskon = 0;
            labelTotalHarga.Text = "Rp. 0";

            RefreshPencarian();

            textBoxNama.Text = "";
            textBoxNoHP.Text = "";
            LoadOrderMenu();
            DapatIDNota();
        }

        public void RefreshPencarian()
        {
            Kategori = "";
            textBoxCariMinuman.Text = "";
            LoadMinuman();
            buttonA.BackColor = Color.Transparent;
            buttonS.BackColor = Color.Transparent;
            buttonF.BackColor = Color.Transparent;
            buttonT.BackColor = Color.Transparent;
        }

        public void GetIDCustomer()
        {
            sqlConnect.Open();
            string sqlQueryDetail = "select left(ID_CUST,1) as abjad, substring(ID_CUST,2,7) as nomor from CUSTOMER order by 2 desc limit 1;  ";
            sqlCommand = new MySqlCommand(sqlQueryDetail, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable dtIDCust = new DataTable();
            sqlAdapter.Fill(dtIDCust);

            string nomor = dtIDCust.Rows[0][1].ToString();
            nomor = (Convert.ToInt32(nomor) + 1).ToString();
            for (int i = nomor.Length; i < 7; i++)
            {
                nomor = "0" + nomor;
            }
            string nomorCust = dtIDCust.Rows[0][0].ToString() + nomor;
            IDCustomer = nomorCust;
            //MessageBox.Show("IDCustomer=" + IDCustomer);
            sqlConnect.Close();
        }

        public void InsertNota()
        {
            sqlConnect.Close();
            sqlConnect.Open();
            string sqlQueryNota = "insert into NOTA values('" + idNota + "', '" + IDCustomer + "', '" + IDPegawai + "', '" + IDPromo + "', now(), '"+ textBoxNama.Text+"','" + Total + "', '" + Diskon + "','" + (Total - Diskon) + "', '" + urutan + "' , '0'); ";
            sqlCommand = new MySqlCommand(sqlQueryNota, sqlConnect);
            // MessageBox.Show($"{idNota},{IDCustomer},{IDPegawai},{IDPromo},now(),{Total},{Diskon},{Total-Diskon},{urutan},'0'");
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
        }

        public void InsertNota_Topping()
        {
            sqlConnect.Open();
            DataTable dtDetail = new DataTable();
            string sqlQueryDetail = "select DM.INDEX_MINUMAN AS `INDEX`, DM.ID_MINUMAN AS ID, M.NAMA_MINUMAN as NAMA ,DM.QTY_MINUMAN AS QTY, DM.HARGA_MINUMAN AS HARGA, DM.SUBTOTAL_MINUMAN AS SUBTOTAL, DM.NOTE_MINUMAN AS NOTE, DM.SUGAR_LEVEL AS SUGAR, ICE_LEVEL AS ICE from DETAIL_MINUMAN_SEMENTARA DM, MINUMAN M where  M.ID_MINUMAN=DM.ID_MINUMAN and DM.ID_NOTA='" + labelIDNota.Text + "' and DM.STATUS_DELETE=0 order by 1 ;  ";
            sqlCommand = new MySqlCommand(sqlQueryDetail, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtDetail);
            sqlConnect.Close();


            for (int i = 0; i < dtDetail.Rows.Count; i++)
            {
                string[] detailTopping = dtDetail.Rows[i][6].ToString().Split(',');

                for (int j = 0; j < detailTopping.Length; j++)
                {


                    sqlConnect.Open();
                    string[] pisahTopping = detailTopping[j].Split('-');

                    DataTable dtTopping = new DataTable();
                    string sqlQueryPisahTopping = "select NAMA_TOPPING, HARGA_TOPPING FROM TOPPING WHERE ID_TOPPING='" + pisahTopping[0] + "';";
                    sqlCommand = new MySqlCommand(sqlQueryPisahTopping, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(dtTopping);


                    // Insert
                    string sqlInserNota_Topping = "insert into NOTA_TOPPING values('" + idNota + "'," + i + ",'" + pisahTopping[0].ToString() + "'," + pisahTopping[1] + "," + dtTopping.Rows[0][1] + "," + Convert.ToInt32(pisahTopping[1]) * Convert.ToInt32(dtTopping.Rows[0][1]) + ",'0');";
                    sqlCommand = new MySqlCommand(sqlInserNota_Topping, sqlConnect);
                    //MessageBox.Show(sqlInserNota_Topping);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();
                }
            }
        }

        public void InsertCustomer()
        {
            sqlConnect.Close();
            sqlConnect.Open();
            string sqlInsertCustomer = "insert into CUSTOMER values('" + IDCustomer + "','" + textBoxNama.Text + "','" + textBoxNoHP.Text + "','0');";
            sqlCommand = new MySqlCommand(sqlInsertCustomer, sqlConnect);
            //MessageBox.Show(sqlInsertCustomer);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            buttonCanOpen.Visible = false;
            this.FormClosed += FormOrder_FormClosed;
            labelNamaPegawai.AutoSize = false;

            DapatIDNota();
            GetIDCustomer();
            
            buttonEditMenu.BackColor = Color.Transparent;
            buttonAdmin.BackColor = Color.Transparent;
            buttonCashier.BackColor = Color.ForestGreen;
            InvisText();
            buttonCashier.Text = "Cashier";

            if (FormLogin.saveID == "2")
            {
                buttonAdmin.Enabled = false;
                buttonEditMenu.Enabled = false;
            }
            IDPegawai = FormLogin.saveIDPegawai;
            NamaPegawai = FormLogin.saveNamaDepan;
            labelNamaPegawai.Text = NamaPegawai;
            labelNamaPegawai.UseCompatibleTextRendering = true;
            labelNamaPegawai.Size = new Size(70, 17);


            LoadMinuman();
            LoadOrderMenu();

            buttonA.FlatAppearance.BorderSize = 0;
            buttonS.FlatAppearance.BorderSize = 0;
            buttonF.FlatAppearance.BorderSize = 0;
            buttonT.FlatAppearance.BorderSize = 0;

        }

        private void FormOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            Reload();
            RefreshPencarian();
            DeleteData();
        }

        private void buttonCashier_Click(object sender, EventArgs e)
        {
            buttonEditMenu.BackColor = Color.Transparent;
            buttonAdmin.BackColor = Color.Transparent;
            buttonCashier.BackColor = Color.ForestGreen;
            InvisText();
            buttonCashier.Text = "Cashier";
            LoadOrderMenu();
        }


        private void buttonEditMenu_Click(object sender, EventArgs e)
        {
            buttonCashier.BackColor = Color.Transparent;
            buttonAdmin.BackColor = Color.Transparent;
            buttonEditMenu.BackColor = Color.ForestGreen;
            InvisText();
            buttonEditMenu.Text = "Edit Menu";

            DataTable dtCekNotaSementara = new DataTable();
            sqlQuery = "select * from DETAIL_MINUMAN_SEMENTARA where status_delete = '0'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtCekNotaSementara);
            if (dtCekNotaSementara.Rows.Count > 0)
            {
                buttonEditMenu.BackColor = Color.Transparent;
                buttonAdmin.BackColor = Color.Transparent;
                buttonCashier.BackColor = Color.ForestGreen;
                InvisText();
                buttonCashier.Text = "Cashier";
                MessageBox.Show("Order sedang berlangsung");
            }
            else
            {
                this.Hide();
                formEditPilih formPilih = new formEditPilih();
                formPilih.ShowDialog();
                this.Close();
            }
        }

        private void buttonAdmin_Click_1(object sender, EventArgs e)
        {
            buttonCashier.BackColor = Color.Transparent;
            buttonEditMenu.BackColor = Color.Transparent;
            buttonAdmin.BackColor = Color.ForestGreen;
            InvisText();
            buttonAdmin.Text = "Admin";

            DataTable dtCekNotaSementara = new DataTable();
            sqlQuery = "select * from DETAIL_MINUMAN_SEMENTARA where status_delete = '0'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtCekNotaSementara);
            if (dtCekNotaSementara.Rows.Count > 0)
            {
                buttonEditMenu.BackColor = Color.Transparent;
                buttonAdmin.BackColor = Color.Transparent;
                buttonCashier.BackColor = Color.ForestGreen;
                InvisText();
                buttonCashier.Text = "Cashier";
                MessageBox.Show("Order sedang berlangsung");
            }
            else
            {
                this.Hide();
                formAdmin formAdmin = new formAdmin();
                formAdmin.ShowDialog();
                this.Close();
            }
        }


        private void Buttonhu_Click(object sender, EventArgs e)
        {
            Button buttonhu = (sender as Button);
            FormAddMinuman formadd = new FormAddMinuman();
            formadd.PassingData = buttonhu.Tag.ToString();
            formadd.PassingImageList = imageListMinuman;
            formadd.PassingIndex = buttonhu.ImageIndex;
            formadd.ShowDialog();
            LoadOrderMenu();
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
            else
            {
                InsertCustomer();
                InsertNota();
                InsertData();
                InsertNota_Topping();
                DeleteData();
                Reload();

                FormStruk cetakStruk = new FormStruk();
                cetakStruk.ShowDialog();
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
        

        private void buttonSilang_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();
            Button btnSilang = (sender as Button);
            sqlQuery = "update DETAIL_MINUMAN_SEMENTARA set STATUS_DELETE=1 where INDEX_MINUMAN='"+btnSilang.Tag.ToString()+"';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            DataTable dtidNota = new DataTable();
            MessageBox.Show(btnSilang.Tag.ToString());
            sqlConnect.Close();
            Reload();
        }

        private void pbProfil_Click(object sender, EventArgs e)
        {
            formProfile formProfil = new formProfile();
            formProfil.ShowDialog();
        }

        

        private void buttonCanClose_MouseEnter(object sender, EventArgs e)
        {
            buttonCanOpen.Visible = true;
        }

        private void buttonCanOpen_MouseLeave(object sender, EventArgs e)
        {
            buttonCanOpen.Visible = false;
        }

        private void buttonCanOpen_Click(object sender, EventArgs e)
        {
            DeleteData();
            LoadOrderMenu();
            Reload();
        }
    }
}





