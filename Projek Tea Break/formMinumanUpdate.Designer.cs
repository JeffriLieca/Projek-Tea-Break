namespace Projek_Tea_Break
{
    partial class formMinumanUpdate
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
            this.tboxHarga = new System.Windows.Forms.TextBox();
            this.tboxNama = new System.Windows.Forms.TextBox();
            this.tboxID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.labelEdit = new System.Windows.Forms.Label();
            this.buttonAddImage = new System.Windows.Forms.Button();
            this.pictureBoxAdd = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tboxHarga
            // 
            this.tboxHarga.Location = new System.Drawing.Point(156, 279);
            this.tboxHarga.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tboxHarga.Name = "tboxHarga";
            this.tboxHarga.Size = new System.Drawing.Size(144, 20);
            this.tboxHarga.TabIndex = 30;
            // 
            // tboxNama
            // 
            this.tboxNama.Location = new System.Drawing.Point(156, 248);
            this.tboxNama.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tboxNama.Name = "tboxNama";
            this.tboxNama.Size = new System.Drawing.Size(144, 20);
            this.tboxNama.TabIndex = 31;
            // 
            // tboxID
            // 
            this.tboxID.Location = new System.Drawing.Point(156, 210);
            this.tboxID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tboxID.Name = "tboxID";
            this.tboxID.Size = new System.Drawing.Size(144, 20);
            this.tboxID.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 279);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Harga minuman";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 248);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nama minuman";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 210);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "ID minuman";
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSaveEdit.ForeColor = System.Drawing.Color.White;
            this.btnSaveEdit.Location = new System.Drawing.Point(52, 330);
            this.btnSaveEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(78, 34);
            this.btnSaveEdit.TabIndex = 33;
            this.btnSaveEdit.Text = "SAVE";
            this.btnSaveEdit.UseVisualStyleBackColor = false;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCancelEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelEdit.ForeColor = System.Drawing.Color.White;
            this.btnCancelEdit.Location = new System.Drawing.Point(214, 330);
            this.btnCancelEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(84, 34);
            this.btnCancelEdit.TabIndex = 34;
            this.btnCancelEdit.Text = "Cancel";
            this.btnCancelEdit.UseVisualStyleBackColor = false;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // dgvMenu
            // 
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.AllowUserToDeleteRows = false;
            this.dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Location = new System.Drawing.Point(34, 59);
            this.dgvMenu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvMenu.MultiSelect = false;
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.ReadOnly = true;
            this.dgvMenu.RowHeadersWidth = 51;
            this.dgvMenu.RowTemplate.Height = 24;
            this.dgvMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenu.Size = new System.Drawing.Size(470, 122);
            this.dgvMenu.TabIndex = 35;
            this.dgvMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenu_CellContentClick);
            // 
            // labelEdit
            // 
            this.labelEdit.AutoSize = true;
            this.labelEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdit.Location = new System.Drawing.Point(228, 16);
            this.labelEdit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEdit.Name = "labelEdit";
            this.labelEdit.Size = new System.Drawing.Size(68, 29);
            this.labelEdit.TabIndex = 36;
            this.labelEdit.Text = "EDIT";
            // 
            // buttonAddImage
            // 
            this.buttonAddImage.Location = new System.Drawing.Point(53, 182);
            this.buttonAddImage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonAddImage.Name = "buttonAddImage";
            this.buttonAddImage.Size = new System.Drawing.Size(100, 34);
            this.buttonAddImage.TabIndex = 38;
            this.buttonAddImage.Text = "Add Image";
            this.buttonAddImage.UseVisualStyleBackColor = true;
            this.buttonAddImage.Click += new System.EventHandler(this.buttonAddImage_Click);
            // 
            // pictureBoxAdd
            // 
            this.pictureBoxAdd.Location = new System.Drawing.Point(27, 14);
            this.pictureBoxAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBoxAdd.Name = "pictureBoxAdd";
            this.pictureBoxAdd.Size = new System.Drawing.Size(150, 162);
            this.pictureBoxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAdd.TabIndex = 37;
            this.pictureBoxAdd.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.buttonAddImage);
            this.panel1.Controls.Add(this.pictureBoxAdd);
            this.panel1.Location = new System.Drawing.Point(322, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 239);
            this.panel1.TabIndex = 39;
            // 
            // formMinumanUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 436);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelEdit);
            this.Controls.Add(this.dgvMenu);
            this.Controls.Add(this.btnCancelEdit);
            this.Controls.Add(this.btnSaveEdit);
            this.Controls.Add(this.tboxHarga);
            this.Controls.Add(this.tboxNama);
            this.Controls.Add(this.tboxID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "formMinumanUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormbtnEdit";
            this.Load += new System.EventHandler(this.FormbtnEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxHarga;
        private System.Windows.Forms.TextBox tboxNama;
        private System.Windows.Forms.TextBox tboxID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.Label labelEdit;
        private System.Windows.Forms.Button buttonAddImage;
        private System.Windows.Forms.PictureBox pictureBoxAdd;
        private System.Windows.Forms.Panel panel1;
    }
}