
namespace Projek_Tea_Break
{
    partial class formEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formEdit));
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.buttonEditMenu = new System.Windows.Forms.Button();
            this.buttonCashier = new System.Windows.Forms.Button();
            this.imageListMinuman = new System.Windows.Forms.ImageList(this.components);
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxID = new System.Windows.Forms.TextBox();
            this.tboxNama = new System.Windows.Forms.TextBox();
            this.tboxHarga = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pictureBoxAdd = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAddImage = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxIDgambar = new System.Windows.Forms.TextBox();
            this.textBoxNamagambar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonView = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.buttonAdmin);
            this.panel2.Controls.Add(this.buttonEditMenu);
            this.panel2.Controls.Add(this.buttonCashier);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(134, 524);
            this.panel2.TabIndex = 7;
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdmin.ForeColor = System.Drawing.Color.White;
            this.buttonAdmin.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdmin.Image")));
            this.buttonAdmin.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAdmin.Location = new System.Drawing.Point(32, 299);
            this.buttonAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(69, 77);
            this.buttonAdmin.TabIndex = 5;
            this.buttonAdmin.Text = "Admin";
            this.buttonAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAdmin.UseVisualStyleBackColor = false;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click_1);
            // 
            // buttonEditMenu
            // 
            this.buttonEditMenu.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonEditMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditMenu.ForeColor = System.Drawing.Color.White;
            this.buttonEditMenu.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditMenu.Image")));
            this.buttonEditMenu.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEditMenu.Location = new System.Drawing.Point(32, 202);
            this.buttonEditMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEditMenu.Name = "buttonEditMenu";
            this.buttonEditMenu.Size = new System.Drawing.Size(69, 77);
            this.buttonEditMenu.TabIndex = 4;
            this.buttonEditMenu.Text = "Edit Menu";
            this.buttonEditMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonEditMenu.UseVisualStyleBackColor = false;
            this.buttonEditMenu.Click += new System.EventHandler(this.buttonEditMenu_Click);
            // 
            // buttonCashier
            // 
            this.buttonCashier.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonCashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCashier.ForeColor = System.Drawing.Color.White;
            this.buttonCashier.Image = global::Projek_Tea_Break.Properties.Resources.shop_icon;
            this.buttonCashier.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCashier.Location = new System.Drawing.Point(32, 105);
            this.buttonCashier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCashier.Name = "buttonCashier";
            this.buttonCashier.Size = new System.Drawing.Size(69, 77);
            this.buttonCashier.TabIndex = 1;
            this.buttonCashier.Text = "Cashier";
            this.buttonCashier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonCashier.UseVisualStyleBackColor = false;
            this.buttonCashier.Click += new System.EventHandler(this.buttonCashier_Click);
            // 
            // imageListMinuman
            // 
            this.imageListMinuman.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMinuman.ImageStream")));
            this.imageListMinuman.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMinuman.Images.SetKeyName(0, "47-banana-milk.jpg");
            this.imageListMinuman.Images.SetKeyName(1, "25-taro2.jpg");
            this.imageListMinuman.Images.SetKeyName(2, "26-matcha-milk2.jpg");
            this.imageListMinuman.Images.SetKeyName(3, "27-chocolate-milk.jpg");
            this.imageListMinuman.Images.SetKeyName(4, "19-fresh-tea2.jpg");
            this.imageListMinuman.Images.SetKeyName(5, "20-dscf0316-jasmine-tea.jpg");
            this.imageListMinuman.Images.SetKeyName(6, "21-dscf0326-lychee-tea.jpg");
            this.imageListMinuman.Images.SetKeyName(7, "23-strawberry-tea.jpg");
            this.imageListMinuman.Images.SetKeyName(8, "22-magno-tea.jpg");
            this.imageListMinuman.Images.SetKeyName(9, "5-milktea2.jpg");
            // 
            // dgvMenu
            // 
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Location = new System.Drawing.Point(192, 20);
            this.dgvMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.RowHeadersWidth = 51;
            this.dgvMenu.RowTemplate.Height = 24;
            this.dgvMenu.Size = new System.Drawing.Size(470, 122);
            this.dgvMenu.TabIndex = 8;
            this.dgvMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenu_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 164);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID minuman";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 202);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nama minuman";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 233);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Harga minuman";
            // 
            // tboxID
            // 
            this.tboxID.Location = new System.Drawing.Point(316, 164);
            this.tboxID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tboxID.Name = "tboxID";
            this.tboxID.Size = new System.Drawing.Size(144, 20);
            this.tboxID.TabIndex = 10;
            // 
            // tboxNama
            // 
            this.tboxNama.Location = new System.Drawing.Point(316, 202);
            this.tboxNama.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tboxNama.Name = "tboxNama";
            this.tboxNama.Size = new System.Drawing.Size(144, 20);
            this.tboxNama.TabIndex = 10;
            // 
            // tboxHarga
            // 
            this.tboxHarga.Location = new System.Drawing.Point(316, 233);
            this.tboxHarga.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tboxHarga.Name = "tboxHarga";
            this.tboxHarga.Size = new System.Drawing.Size(144, 20);
            this.tboxHarga.TabIndex = 10;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(242, 275);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(61, 26);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(458, 275);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(73, 26);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pictureBoxAdd
            // 
            this.pictureBoxAdd.Image = global::Projek_Tea_Break.Properties.Resources._19_fresh_tea2;
            this.pictureBoxAdd.Location = new System.Drawing.Point(587, 176);
            this.pictureBoxAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxAdd.Name = "pictureBoxAdd";
            this.pictureBoxAdd.Size = new System.Drawing.Size(150, 162);
            this.pictureBoxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAdd.TabIndex = 14;
            this.pictureBoxAdd.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(530, 414);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 20);
            this.textBox1.TabIndex = 15;
            // 
            // buttonAddImage
            // 
            this.buttonAddImage.Location = new System.Drawing.Point(614, 343);
            this.buttonAddImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddImage.Name = "buttonAddImage";
            this.buttonAddImage.Size = new System.Drawing.Size(100, 34);
            this.buttonAddImage.TabIndex = 16;
            this.buttonAddImage.Text = "Add Image";
            this.buttonAddImage.UseVisualStyleBackColor = true;
            this.buttonAddImage.Click += new System.EventHandler(this.buttonAddImage_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(334, 275);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 26);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(298, 329);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 19);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(346, 391);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(56, 19);
            this.buttonSave.TabIndex = 19;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxIDgambar
            // 
            this.textBoxIDgambar.Location = new System.Drawing.Point(230, 392);
            this.textBoxIDgambar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxIDgambar.Name = "textBoxIDgambar";
            this.textBoxIDgambar.Size = new System.Drawing.Size(76, 20);
            this.textBoxIDgambar.TabIndex = 20;
            // 
            // textBoxNamagambar
            // 
            this.textBoxNamagambar.Location = new System.Drawing.Point(230, 414);
            this.textBoxNamagambar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNamagambar.Name = "textBoxNamagambar";
            this.textBoxNamagambar.Size = new System.Drawing.Size(76, 20);
            this.textBoxNamagambar.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 418);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "nama gambar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 396);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "ID gambar";
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(346, 414);
            this.buttonView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(56, 19);
            this.buttonView.TabIndex = 24;
            this.buttonView.Text = "View";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // formEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(782, 516);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNamagambar);
            this.Controls.Add(this.textBoxIDgambar);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.buttonAddImage);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBoxAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.tboxHarga);
            this.Controls.Add(this.tboxNama);
            this.Controls.Add(this.tboxID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMenu);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "formEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonCashier;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Button buttonEditMenu;
        private System.Windows.Forms.ImageList imageListMinuman;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxID;
        private System.Windows.Forms.TextBox tboxNama;
        private System.Windows.Forms.TextBox tboxHarga;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox pictureBoxAdd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAddImage;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxIDgambar;
        private System.Windows.Forms.TextBox textBoxNamagambar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonView;
    }
}