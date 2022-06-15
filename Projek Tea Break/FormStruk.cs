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
    public partial class FormStruk : Form
    {

        public static string sqlConnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_11_TEABREAK";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public FormStruk()
        {
            InitializeComponent();
        }


        private void FormStruk_Load(object sender, EventArgs e)
        {
            LoadOrderMenu();
        }

        public void LoadOrderMenu()
        {

            try
            {
                string sqlQuery = "select n.ID_NOTA as id, c.NAMA_CUST as nama, p.NAMA_PEGAWAI as kasir, n.URUTAN as urutan, format(n.TOTAL_HARGA_KOTOR,0) as bruto, format(n.DISKON,0) as disc, format(n.TOTAL_HARGA_BERSIH,0) as netto,date_format(n.TGL_NOTA,'%d %M %Y') as tgl,date_format(n.TGL_NOTA,'%H.%i') as jam from NOTA n,CUSTOMER c,PEGAWAI p where n.ID_CUST=c.ID_CUST and n.ID_PEGAWAI=p.ID_PEGAWAI order by 1 desc;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                DataTable dtNota = new DataTable();
                sqlAdapter.Fill(dtNota);

                labelTanggal.Text = dtNota.Rows[0]["tgl"].ToString();
                labelJam.Text = dtNota.Rows[0]["jam"].ToString();
                labelKasir.Text = dtNota.Rows[0]["kasir"].ToString();
                labelIDNota.Text = dtNota.Rows[0]["id"].ToString();
                labelNetto.Text = dtNota.Rows[0]["netto"].ToString();
                labelDiskon.Text = dtNota.Rows[0]["disc"].ToString();
                labelBruto.Text = dtNota.Rows[0]["bruto"].ToString();
                labelCustomer.Text = dtNota.Rows[0]["nama"].ToString();
                labelUrutan.Text = dtNota.Rows[0]["urutan"].ToString();

                DataTable dtDetail = new DataTable();
                string sqlQueryDetail = "select DM.INDEX_MINUMAN AS `INDEX`, DM.ID_MINUMAN AS ID, M.NAMA_MINUMAN as NAMA ,DM.QTY_MINUMAN AS QTY, format(DM.HARGA_MINUMAN,0) AS HARGA,DM.HARGA_MINUMAN, format(DM.SUBTOTAL_MINUMAN,0) AS SUBTOTAL, DM.NOTE_MINUMAN AS NOTE, DM.SUGAR_LEVEL AS SUGAR, ICE_LEVEL AS ICE from DETAIL_MINUMAN DM, MINUMAN M where  M.ID_MINUMAN=DM.ID_MINUMAN and DM.ID_NOTA='" + labelIDNota.Text + "' and DM.STATUS_DELETE=0 order by 1 ;  ";
                sqlCommand = new MySqlCommand(sqlQueryDetail, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtDetail);


                Label[] labelMinuman = new Label[dtDetail.Rows.Count];
                Label[] labelHargaSubtotal = new Label[dtDetail.Rows.Count];
                Label[] labelSugar = new Label[dtDetail.Rows.Count];
                Label[] labelIce = new Label[dtDetail.Rows.Count];
                int[] Subtotal = new int[dtDetail.Rows.Count];

                int posisiY = 240;
                int posisiYHarga = 250;

                for (int i = 0; i < dtDetail.Rows.Count; i++)
                {
                    posisiY += 10;
                    posisiYHarga = posisiY;
                    string[] detailTopping = dtDetail.Rows[i][7].ToString().Split(',');
                    labelMinuman[i] = new System.Windows.Forms.Label();
                    this.Controls.Add(labelMinuman[i]);
                    labelMinuman[i].Text = dtDetail.Rows[i][2].ToString() + " " + dtDetail.Rows[i][3] + " x @ " + dtDetail.Rows[i][4].ToString();
                    labelMinuman[i].Location = new Point(50, posisiY);
                    labelMinuman[i].UseCompatibleTextRendering = true;
                    labelMinuman[i].Size = new Size(150, 15);
                    Label[] labelTopping = new Label[detailTopping.Length];
                    posisiY += 15;

                    Subtotal[i] = Convert.ToInt32(dtDetail.Rows[i][5]) * Convert.ToInt32(dtDetail.Rows[i][3]);


                    for (int j = 0; j < detailTopping.Length; j++)
                    {



                        string[] pisahTopping = detailTopping[j].Split('-');

                        DataTable dtTopping = new DataTable();
                        string sqlQueryPisahTopping = "select NAMA_TOPPING,HARGA_TOPPING, format(HARGA_TOPPING,0) FROM TOPPING WHERE ID_TOPPING='" + pisahTopping[0] + "';";
                        sqlCommand = new MySqlCommand(sqlQueryPisahTopping, sqlConnect);
                        sqlAdapter = new MySqlDataAdapter(sqlCommand);
                        sqlAdapter.Fill(dtTopping);

                        labelTopping[j] = new System.Windows.Forms.Label();
                        this.Controls.Add(labelTopping[j]);
                        //labelTopping[j].Text = detailTopping[j];
                        if (dtTopping.Rows.Count > 0)
                        {

                            labelTopping[j].Text = dtTopping.Rows[0][0].ToString() + " " + pisahTopping[1] + " x @ " + dtTopping.Rows[0][2].ToString();
                            labelTopping[j].Font = new Font(labelTopping[j].Font.ToString(), 7);
                            labelTopping[j].UseCompatibleTextRendering = true;
                            labelTopping[j].Size = new Size(150, 15);
                            labelTopping[j].Location = new Point(70, posisiY);
                            posisiY += 15;

                            Subtotal[i] += Convert.ToInt32(dtTopping.Rows[0][1]) * Convert.ToInt32(pisahTopping[1]);

                        }



                    }

                    if (dtDetail.Rows[i][8].ToString() == "L")
                    {
                        labelSugar[i] = new System.Windows.Forms.Label();
                        this.Controls.Add(labelSugar[i]);
                        labelSugar[i].Text = "(Less Sugar)";
                        labelSugar[i].Location = new Point(70, posisiY);
                        labelSugar[i].UseCompatibleTextRendering = true;
                        labelSugar[i].Font = new Font(labelSugar[i].Font.ToString(), 7);
                        labelSugar[i].Size = new Size(150, 15);
                        posisiY += 15;
                    }
                    else if (dtDetail.Rows[i][8].ToString() == "M")
                    {
                        labelSugar[i] = new System.Windows.Forms.Label();
                        this.Controls.Add(labelSugar[i]);
                        labelSugar[i].Text = "(More Sugar)";
                        labelSugar[i].Location = new Point(70, posisiY);
                        labelSugar[i].UseCompatibleTextRendering = true;
                        labelSugar[i].Font = new Font(labelSugar[i].Font.ToString(), 7);
                        labelSugar[i].Size = new Size(150, 15);
                        posisiY += 15;
                    }
                    else { }

                    if (dtDetail.Rows[i][9].ToString() == "L")
                    {
                        labelIce[i] = new System.Windows.Forms.Label();
                        this.Controls.Add(labelIce[i]);
                        labelIce[i].Text = "(Less Ice)";
                        labelIce[i].Location = new Point(70, posisiY);
                        labelIce[i].UseCompatibleTextRendering = true;
                        labelIce[i].Font = new Font(labelIce[i].Font.ToString(), 7);
                        labelIce[i].Size = new Size(150, 15);
                        posisiY += 15;
                    }
                    else if (dtDetail.Rows[i][9].ToString() == "M")
                    {
                        labelIce[i] = new System.Windows.Forms.Label();
                        this.Controls.Add(labelIce[i]);
                        labelIce[i].Text = "(More Ice)";
                        labelIce[i].Location = new Point(70, posisiY);
                        labelIce[i].UseCompatibleTextRendering = true;
                        labelIce[i].Font = new Font(labelIce[i].Font.ToString(), 7);
                        labelIce[i].Size = new Size(150, 15);
                        posisiY += 15;
                    }
                    else { }

                    labelHargaSubtotal[i] = new System.Windows.Forms.Label();
                    this.Controls.Add(labelHargaSubtotal[i]);

                    string tambahkoma = "select format('" + Subtotal[i] + "',0);";
                    sqlCommand = new MySqlCommand(tambahkoma, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    DataTable dtsubtotal = new DataTable();
                    sqlAdapter.Fill(dtsubtotal);
                    labelHargaSubtotal[i].Text = dtsubtotal.Rows[0][0].ToString();
                    labelHargaSubtotal[i].Location = new Point(250, posisiYHarga);
                    labelHargaSubtotal[i].UseCompatibleTextRendering = true;
                    labelHargaSubtotal[i].Size = new Size(60, 15);


                }
                posisiYHarga = posisiY;
                posisiYHarga += 10;
                labelStrip.Location = new Point(35, posisiYHarga);
                posisiYHarga += 20;
                labelketSub.Location = new Point(150, posisiYHarga);
                labelBruto.Location = new Point(225, posisiYHarga);
                posisiYHarga += 20;
                labelKetDis.Location = new Point(150, posisiYHarga);
                labelDiskon.Location = new Point(225, posisiYHarga);
                posisiYHarga += 20;
                labelKetTot.Location = new Point(150, posisiYHarga);
                labelNetto.Location = new Point(225, posisiYHarga);
                labelInvis.Location = new Point(225, posisiYHarga + 30);
                //labelInvis.Visible = false;
            }
            catch (Exception)
            {

            }
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
