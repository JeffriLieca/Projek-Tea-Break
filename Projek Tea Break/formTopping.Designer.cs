
namespace Projek_Tea_Break
{
    partial class formTopping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTopping));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbProfil = new System.Windows.Forms.PictureBox();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.buttonEditMenu = new System.Windows.Forms.Button();
            this.buttonCashier = new System.Windows.Forms.Button();
            this.imageListMinuman = new System.Windows.Forms.ImageList(this.components);
            this.dgvTopping = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxID = new System.Windows.Forms.TextBox();
            this.tboxNama = new System.Windows.Forms.TextBox();
            this.tboxHarga = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopping)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pbProfil);
            this.panel2.Controls.Add(this.buttonAdmin);
            this.panel2.Controls.Add(this.buttonEditMenu);
            this.panel2.Controls.Add(this.buttonCashier);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(134, 524);
            this.panel2.TabIndex = 7;
            // 
            // pbProfil
            // 
            this.pbProfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbProfil.Image = global::Projek_Tea_Break.Properties.Resources.logo;
            this.pbProfil.Location = new System.Drawing.Point(7, 37);
            this.pbProfil.Name = "pbProfil";
            this.pbProfil.Size = new System.Drawing.Size(124, 41);
            this.pbProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfil.TabIndex = 19;
            this.pbProfil.TabStop = false;
            this.pbProfil.Click += new System.EventHandler(this.pbProfil_Click);
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdmin.ForeColor = System.Drawing.Color.White;
            this.buttonAdmin.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdmin.Image")));
            this.buttonAdmin.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAdmin.Location = new System.Drawing.Point(32, 299);
            this.buttonAdmin.Margin = new System.Windows.Forms.Padding(2);
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
            this.buttonEditMenu.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditMenu.Name = "buttonEditMenu";
            this.buttonEditMenu.Size = new System.Drawing.Size(69, 77);
            this.buttonEditMenu.TabIndex = 4;
            this.buttonEditMenu.Text = "Edit";
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
            this.buttonCashier.Margin = new System.Windows.Forms.Padding(2);
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
            // dgvTopping
            // 
            this.dgvTopping.AllowUserToAddRows = false;
            this.dgvTopping.AllowUserToDeleteRows = false;
            this.dgvTopping.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTopping.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTopping.BackgroundColor = System.Drawing.Color.White;
            this.dgvTopping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopping.Location = new System.Drawing.Point(159, 37);
            this.dgvTopping.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTopping.MultiSelect = false;
            this.dgvTopping.Name = "dgvTopping";
            this.dgvTopping.ReadOnly = true;
            this.dgvTopping.RowHeadersWidth = 51;
            this.dgvTopping.RowTemplate.Height = 24;
            this.dgvTopping.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTopping.Size = new System.Drawing.Size(597, 145);
            this.dgvTopping.TabIndex = 8;
            this.dgvTopping.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTopping_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 302);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID Topping";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 337);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nama Topping";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 368);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Harga Topping";
            // 
            // tboxID
            // 
            this.tboxID.Location = new System.Drawing.Point(399, 299);
            this.tboxID.Margin = new System.Windows.Forms.Padding(2);
            this.tboxID.Name = "tboxID";
            this.tboxID.Size = new System.Drawing.Size(144, 20);
            this.tboxID.TabIndex = 10;
            // 
            // tboxNama
            // 
            this.tboxNama.Location = new System.Drawing.Point(399, 334);
            this.tboxNama.Margin = new System.Windows.Forms.Padding(2);
            this.tboxNama.Name = "tboxNama";
            this.tboxNama.Size = new System.Drawing.Size(144, 20);
            this.tboxNama.TabIndex = 10;
            // 
            // tboxHarga
            // 
            this.tboxHarga.Location = new System.Drawing.Point(399, 366);
            this.tboxHarga.Margin = new System.Windows.Forms.Padding(2);
            this.tboxHarga.Name = "tboxHarga";
            this.tboxHarga.Size = new System.Drawing.Size(144, 20);
            this.tboxHarga.TabIndex = 10;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(496, 202);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 41);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(363, 202);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 41);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(230, 202);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 41);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Edit";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // formTopping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(782, 516);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tboxHarga);
            this.Controls.Add(this.tboxNama);
            this.Controls.Add(this.tboxID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTopping);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formTopping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopping)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonCashier;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Button buttonEditMenu;
        private System.Windows.Forms.ImageList imageListMinuman;
        private System.Windows.Forms.DataGridView dgvTopping;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxID;
        private System.Windows.Forms.TextBox tboxNama;
        private System.Windows.Forms.TextBox tboxHarga;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pbProfil;
    }
}