
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
            this.pbProfil = new System.Windows.Forms.PictureBox();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.buttonEditMenu = new System.Windows.Forms.Button();
            this.buttonCashier = new System.Windows.Forms.Button();
            this.imageListMinuman = new System.Windows.Forms.ImageList(this.components);
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tboxHarga = new System.Windows.Forms.TextBox();
            this.tboxNama = new System.Windows.Forms.TextBox();
            this.tboxID = new System.Windows.Forms.TextBox();
            this.labelHarga = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.pictureBoxAdd = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).BeginInit();
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
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 645);
            this.panel2.TabIndex = 7;
            // 
            // pbProfil
            // 
            this.pbProfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbProfil.Image = global::Projek_Tea_Break.Properties.Resources.logo;
            this.pbProfil.Location = new System.Drawing.Point(9, 46);
            this.pbProfil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbProfil.Name = "pbProfil";
            this.pbProfil.Size = new System.Drawing.Size(165, 50);
            this.pbProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfil.TabIndex = 6;
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
            this.buttonAdmin.Location = new System.Drawing.Point(43, 368);
            this.buttonAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(92, 95);
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
            this.buttonEditMenu.Location = new System.Drawing.Point(43, 249);
            this.buttonEditMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditMenu.Name = "buttonEditMenu";
            this.buttonEditMenu.Size = new System.Drawing.Size(92, 95);
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
            this.buttonCashier.Location = new System.Drawing.Point(43, 129);
            this.buttonCashier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCashier.Name = "buttonCashier";
            this.buttonCashier.Size = new System.Drawing.Size(92, 95);
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
            this.dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Location = new System.Drawing.Point(235, 15);
            this.dgvMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvMenu.MultiSelect = false;
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.ReadOnly = true;
            this.dgvMenu.RowHeadersWidth = 51;
            this.dgvMenu.RowTemplate.Height = 24;
            this.dgvMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenu.Size = new System.Drawing.Size(748, 150);
            this.dgvMenu.TabIndex = 8;
            this.dgvMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenu_CellContentClick);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(232, 217);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(115, 50);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(576, 217);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 50);
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
            this.btnAdd.Location = new System.Drawing.Point(397, 217);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 50);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // tboxHarga
            // 
            this.tboxHarga.Location = new System.Drawing.Point(461, 417);
            this.tboxHarga.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxHarga.Name = "tboxHarga";
            this.tboxHarga.Size = new System.Drawing.Size(191, 22);
            this.tboxHarga.TabIndex = 24;
            // 
            // tboxNama
            // 
            this.tboxNama.Location = new System.Drawing.Point(461, 374);
            this.tboxNama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxNama.Name = "tboxNama";
            this.tboxNama.Size = new System.Drawing.Size(191, 22);
            this.tboxNama.TabIndex = 25;
            // 
            // tboxID
            // 
            this.tboxID.Location = new System.Drawing.Point(461, 332);
            this.tboxID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxID.Name = "tboxID";
            this.tboxID.Size = new System.Drawing.Size(191, 22);
            this.tboxID.TabIndex = 26;
            // 
            // labelHarga
            // 
            this.labelHarga.AutoSize = true;
            this.labelHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHarga.Location = new System.Drawing.Point(296, 417);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(121, 17);
            this.labelHarga.TabIndex = 21;
            this.labelHarga.Text = "Harga minuman";
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.Location = new System.Drawing.Point(299, 378);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(118, 17);
            this.labelNama.TabIndex = 22;
            this.labelNama.Text = "Nama minuman";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(324, 336);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(92, 17);
            this.labelID.TabIndex = 23;
            this.labelID.Text = "ID minuman";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // pictureBoxAdd
            // 
            this.pictureBoxAdd.Location = new System.Drawing.Point(761, 303);
            this.pictureBoxAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxAdd.Name = "pictureBoxAdd";
            this.pictureBoxAdd.Size = new System.Drawing.Size(200, 199);
            this.pictureBoxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAdd.TabIndex = 14;
            this.pictureBoxAdd.TabStop = false;
            // 
            // formEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1043, 635);
            this.Controls.Add(this.pictureBoxAdd);
            this.Controls.Add(this.tboxHarga);
            this.Controls.Add(this.tboxNama);
            this.Controls.Add(this.tboxID);
            this.Controls.Add(this.labelHarga);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvMenu);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
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
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox pictureBoxAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tboxHarga;
        private System.Windows.Forms.TextBox tboxNama;
        private System.Windows.Forms.TextBox tboxID;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelID;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.PictureBox pbProfil;
    }
}