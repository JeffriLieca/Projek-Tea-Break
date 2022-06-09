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


            string fileFoto = @"C:\Users\ASUS\source\repos\Projek Tea Break\assets\29 - love - me2.jpg";
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
            labelMinuman.Location = new Point(340, buttonGambar.Height + 5);

        }

        //public void LoadTopping()
        //{
        //    DataTable dtTopping = new DataTable();
        //    sqlQuery = "select t.ID_TOPPING as id, t.NAMA_TOPPING as nama, concat('Rp. ',t.HARGA_TOPPING) as harga from TOPPING t;";
        //    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
        //    sqlAdapter = new MySqlDataAdapter(sqlCommand);
        //    sqlAdapter.Fill(dtTopping);

        //    TextBox[] txtbox = new TextBox[dtTopping.Rows.Count];

        //    foreach (TextBox box in txtbox)
        //    {
        //        int posisiY = 20;
        //        int counter = 0;
        //        box.Text = "aaaaaaaaaaaa" + counter;
        //        box.Tag = counter;
        //        counter++;
        //        box.Location = new Point(20, posisiY);
        //        posisiY += 30;
        //    }

        //    Button[] btn = new Button[dtTopping.Rows.Count];
        //    foreach (Button bt in btn)
        //    {
        //        int posisiY = 20;
        //        int counter = 0;
        //        bt.Text = "+";
        //        bt.Tag = counter;
        //        counter++;
        //        bt.Location = new Point(100, posisiY);
        //        posisiY += 30;
        //    }



        //}




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

        TextBox[] txtbox = new TextBox[9];
        Button[] btn = new Button[9];
        public void LoadTopping()
        {




            //for (int i = 0; i < 9; i++)
            //{
            //    int posisiY = 20;
            //    //int counter = 0;
            //    //txtbox[i].Text = counter.ToString();
            //    //txtbox[i].Tag = counter;
            //    //counter++;
            //    txtbox[i].Location = new Point(20, posisiY);
            //    posisiY += 30;
            //}
            int posisiY = 20;
            for (int i = 0; i < 9; i++)
            {
                txtbox[i] = new System.Windows.Forms.TextBox();
                this.Controls.Add(txtbox[i]);
                txtbox[i].Location = new Point(20, posisiY);
                txtbox[i].Text = "0";
                txtbox[i].Tag = i;
                posisiY += 50;
            }




            posisiY = 20;
            for (int i = 0; i < 9; i++)
            {
                btn[i] = new System.Windows.Forms.Button();
                string namaButton = "btn" + i.ToString();
                btn[i].Name = namaButton;
                this.Controls.Add(btn[i]);

                btn[i].Location = new Point(200, posisiY);
                btn[i].Size = new Size(30, 30);
                btn[i].Text = "+";
                btn[i].Tag = i;
                posisiY += 50;
                btn[i].Click += new EventHandler(button_plus);
            }

            //Button[] btn = new Button[9];
            //foreach (Button bt in btn)
            //{
            //    int posisiY = 20;
            //    int counter = 0;
            //    bt.Text = "+";
            //    bt.Tag = counter;
            //    counter++;
            //    bt.Location = new Point(100, posisiY);
            //    posisiY += 30;
            //}



        }



        private void button_plus(object sender, EventArgs e)
        {
            Button bts = (Button)sender;
            int posisiTekan = Convert.ToInt32(bts.Tag);
            txtbox[posisiTekan].Text = (Convert.ToInt32(txtbox[posisiTekan].Text) + 1).ToString();
        } 
        }
    }
