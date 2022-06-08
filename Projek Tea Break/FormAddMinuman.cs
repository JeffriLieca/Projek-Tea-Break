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

        public static string sqlConnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_11_TEABREAK";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public static string sqlQuery;
        public string PassingData { get; set; }
        public int PassingIndex { get; set; }
        public ImageList PassingImageList { get; set; }

        FormOrder formOrder = new FormOrder();

        public static string SugarLevel = "N";
        public static string IceLevel = "N";

        private void FormAddMinuman_Load(object sender, EventArgs e)
        {
            LoadKetMinuman();
            

   //         //string fileFoto = @"C: \Users\ASUS\source\repos\Projek Tea Break\assets\29 - love - me2.jpg";
   //         LoadTopping();
   //         //imageListMinuman.Images.Add(fromfi)
   //         //[] GalleryArray = System.IO.Directory.GetFiles();
   //         OpenFileDialog open = new OpenFileDialog();
   //         //Image img = Image.FromFile("29 - love - me2.jpg");
   //         //pictureBox1.Image = img;
   //         //imageListMinuman.Images.Add(img);
   //         button3.ImageIndex = 0;
   //         pictureBox1.Image = imageListMinuman.Images[PassingIndex];
            
            
   ////         pictureBox1.Image = Image.FromFile
   ////(System.Environment.GetFolderPath
   ////(System.Environment.SpecialFolder.MyPictures)
   ////+ @"C: \Users\ASUS\source\repos\Projek Tea Break\assets\29 - love - me2.jpg.txt");
   //         // image filters  
   //         open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
   //         if (open.ShowDialog() == DialogResult.OK)
   //         {
   //             // display image in picture box  
   //             pictureBox1.Image = new Bitmap(open.FileName);
   //             //pictureBox2.Image = new Bitmap(@"C: \Users\ASUS\source\repos\Projek Tea Break\assets\29 - love - me2.jpg");
   //             Image img = new Bitmap(open.FileName);
   //             imageListMinuman.Images.Add(img);
   //             string path=Path.GetFullPath(open.FileName);
   //             label1.Text = path;
   //             pictureBox2.Image = Image.FromFile(path);
   //             // image file path  
   //             textBox1.Text = open.FileName;
            //}
        }

        public void LoadKetMinuman()
        {
            DataTable dtKetMinuman = new DataTable();
            sqlQuery = "select m.ID_MINUMAN as id, m.NAMA_MINUMAN as nama, concat('Rp. ',m.HARGA_MINUMAN) as harga, m.INDEX_GAMBAR as 'index' from MINUMAN m where m.ID_MINUMAN = '" + PassingData + "';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtKetMinuman);
            labelMinuman.Text = dtKetMinuman.Rows[0][1].ToString();
            buttonGambar.BackgroundImage = PassingImageList.Images[PassingIndex];
            buttonGambar.Location = new Point(300, 0);
            labelMinuman.Location = new Point(340, buttonGambar.Height+5);

        }
        ////////public void LoadTopping()
        ////////{
        ////////    DataTable dtTopping = new DataTable();
        ////////    try
        ////////    {
        ////////        dtTopping = new DataTable();
        ////////        sqlQuery = "select t.ID_TOPPING as id, t.NAMA_TOPPING as nama, concat('Rp. ',t.HARGA_TOPPING) as harga from TOPPING t;";
        ////////        sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
        ////////        sqlAdapter = new MySqlDataAdapter(sqlCommand);
        ////////        sqlAdapter.Fill(dtTopping);

        ////////    }
        ////////    catch (Exception)
        ////////    {

        ////////    }

        ////////    int posisiX = 200;
        ////////    int posisiY = 10;

        ////////    List<TextBox> listTB = new List<TextBox>();

        ////////    //labelTopping.Location = new Point(10, posisiY - 40);
        ////////    for (int i = 0; i < dtTopping.Rows.Count; i++)
        ////////    {
        ////////        posisiX = 170;

        ////////        Label newLabel = new Label();
        ////////        newLabel.Text = dtTopping.Rows[i][1].ToString();
        ////////        newLabel.Location = new Point(10, posisiY+2);
        ////////        panelTopping.Controls.Add(newLabel);
        ////////        newLabel.Width = 150;
        ////////        //newLabel.AutoSize = true;

        ////////        TextBox newTextBox = new TextBox();
        ////////        newTextBox.Text = 0.ToString();
        ////////        newTextBox.TextAlign = HorizontalAlignment.Center;
        ////////        newTextBox.Tag = "tb" + i;
        ////////        newTextBox.Size = new Size(20, 20);
        ////////        newTextBox.Location = new Point(posisiX+25, posisiY);
        ////////        panelTopping.Controls.Add(newTextBox);
        ////////        listTB.Add(newTextBox);

        ////////        Button newButtonMin = new Button();
        ////////        newButtonMin.Text = "-";
        ////////        newButtonMin.TextAlign = ContentAlignment.MiddleCenter;
        ////////        newButtonMin.Tag = "abc" + i;
        ////////        newButtonMin.Size = new Size(20, 20);
        ////////        newButtonMin.Location = new Point(posisiX, posisiY);
        ////////        newButtonMin.FlatStyle = FlatStyle.Flat;
        ////////        newButtonMin.ForeColor = Color.Black;
        ////////        newButtonMin.UseCompatibleTextRendering = true;
        ////////        newButtonMin.Parent=newTextBox;
        ////////        panelTopping.Controls.Add(newButtonMin);
        ////////        newButtonMin.Click += NewButtonMin_Click;
        ////////        posisiX += 50;



        ////////        //TextBox[] newTextBox = new System.Windows.Forms.TextBox[9];
        ////////        //newTextBox[i].Text = "0";
        ////////        //newTextBox[i].TextAlign = HorizontalAlignment.Center;
        ////////        //newTextBox[i].Tag = "tb" + i;
        ////////        //newTextBox[i].Size = new Size(20, 20);
        ////////        //newTextBox[i].Location = new Point(posisiX, posisiY);
        ////////        //panelTopping.Controls.Add(newTextBox[i]);
        ////////        //posisiX += 25;

        ////////        Button newButtonPlus = new Button();
        ////////        newButtonPlus.Text = "+";
        ////////        newButtonPlus.TextAlign = ContentAlignment.MiddleCenter;
        ////////        newButtonPlus.Tag = "tb" + i;
        ////////        newButtonPlus.Size = new Size(20, 20);
        ////////        newButtonPlus.Location = new Point(posisiX, posisiY);
        ////////        newButtonPlus.FlatStyle = FlatStyle.Flat;
        ////////        newButtonPlus.ForeColor = Color.Black;
        ////////        newButtonPlus.UseCompatibleTextRendering = true;
        ////////        newButtonPlus.Parent = newTextBox;
        ////////        panelTopping.Controls.Add(newButtonPlus);
        ////////        newButtonPlus.Click += NewButtonPlus_Click;
        ////////        posisiX += 25;

        ////////        posisiY += 25;
        ////////    }
        ////////}

        ////////private void NewButtonMin_Click(object sender, EventArgs e)
        ////////{
        ////////    Button newButtonMin = (sender as Button);
        ////////    string Angka = newButtonMin.Parent.Text;
        ////////    try
        ////////    {
        ////////        int Jumlah = Convert.ToInt32(Angka);
        ////////        newButtonMin.Parent.Text = Jumlah.ToString();
        ////////    }
        ////////    catch (Exception)
        ////////    {

        ////////    }
        ////////}

        ////////private void NewButtonPlus_Click(object sender, EventArgs e)
        ////////{
        ////////    //Button newButtonPlus = (sender as Button);
        ////////    ////MessageBox.Show(newButtonPlus.Tag.ToString());
        ////////    //List<TextBox> listTB = (sender as List<TextBox>);
        ////////    //TextBox newTextBox = (sender as TextBox);
        ////////    //foreach(TextBox SingleItem in listTB)
        ////////    //{
        ////////    //    if (newTextBox.Tag == newButtonPlus.Tag)
        ////////    //    {
        ////////    //        newTextBox.Text = "1";
        ////////    //    }
        ////////    //}
        ////////    Button newButtonPlus = (sender as Button);
        ////////    newButtonPlus.Parent.Text = (Convert.ToInt32(newButtonPlus.Parent.Text) + 1).ToString();
        ////////}

        private void buttonMinBub_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxBub.Text) > 0)
            {
                textBoxBub.Text = (Convert.ToInt32(textBoxBub.Text) - 1).ToString();
            }
        }

        private void buttonPlusBub_Click(object sender, EventArgs e)
        {
            textBoxBub.Text = (Convert.ToInt32(textBoxBub.Text) + 1).ToString();
        }

        private void buttonMinGras_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxGra.Text) > 0)
            {
                textBoxGra.Text = (Convert.ToInt32(textBoxGra.Text) - 1).ToString();
            }
        }

        private void butttonPlusGra_Click(object sender, EventArgs e)
        {
            textBoxGra.Text = (Convert.ToInt32(textBoxGra.Text) + 1).ToString();
        }

        private void buttonMinBro_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxBro.Text) > 0)
            {
                textBoxBro.Text = (Convert.ToInt32(textBoxBro.Text) - 1).ToString();
            }
        }

        private void buttonPlusBro_Click(object sender, EventArgs e)
        {
            textBoxBro.Text = (Convert.ToInt32(textBoxBro.Text) + 1).ToString();
        }

        private void buttonMinPud_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxPud.Text) > 0)
            {
                textBoxPud.Text = (Convert.ToInt32(textBoxPud.Text) - 1).ToString();
            }
        }

        private void buttonPlusPud_Click(object sender, EventArgs e)
        {
        textBoxPud.Text = (Convert.ToInt32(textBoxPud.Text) + 1).ToString();
        }

        private void buttonMinChe_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxChe.Text) > 0)
            {
                textBoxChe.Text = (Convert.ToInt32(textBoxChe.Text) - 1).ToString();
            }
        }

        private void buttonPlusChe_Click(object sender, EventArgs e)
        {
            textBoxChe.Text = (Convert.ToInt32(textBoxChe.Text) + 1).ToString();
        }

        private void buttonMinRai_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxRai.Text) > 0)
            {
                textBoxRai.Text = (Convert.ToInt32(textBoxRai.Text) - 1).ToString();
            }
        }

        private void buttonPlusRai_Click(object sender, EventArgs e)
        {
        textBoxRai.Text = (Convert.ToInt32(textBoxRai.Text) + 1).ToString();
        }

        private void buttonMinPL_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxPL.Text) > 0)
            {
                textBoxPL.Text = (Convert.ToInt32(textBoxPL.Text) - 1).ToString();
            }
        }

        private void buttonPlusPL_Click(object sender, EventArgs e)
        {
            textBoxPL.Text = (Convert.ToInt32(textBoxPL.Text) + 1).ToString();
        }

        private void buttonMinPM_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxPM.Text) > 0)
            {
                textBoxPM.Text = (Convert.ToInt32(textBoxPM.Text) - 1).ToString();
            }
        }

        private void buttonPlusPM_Click(object sender, EventArgs e)
        {
            textBoxPM.Text = (Convert.ToInt32(textBoxPM.Text) + 1).ToString();
        }

        private void buttonMinPS_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxPS.Text) > 0)
            {
                textBoxPS.Text = (Convert.ToInt32(textBoxPS.Text) - 1).ToString();
            }
        }

        private void buttonPlusPS_Click(object sender, EventArgs e)
        {
            textBoxPS.Text = (Convert.ToInt32(textBoxPS.Text) + 1).ToString();
        }

        private void buttonMinQty_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxQty.Text) > 1)
            {
                textBoxQty.Text = (Convert.ToInt32(textBoxQty.Text) - 1).ToString();
            }
        }

        private void buttonPlusQty_Click(object sender, EventArgs e)
        {
            textBoxQty.Text = (Convert.ToInt32(textBoxQty.Text) + 1).ToString();
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

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
