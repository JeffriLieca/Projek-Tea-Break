﻿namespace Projek_Tea_Break
{
    partial class formPromoUpdate
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
            this.tboxBesar = new System.Windows.Forms.TextBox();
            this.tboxNama = new System.Windows.Forms.TextBox();
            this.tboxID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.dgvPromo = new System.Windows.Forms.DataGridView();
            this.labelEdit = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromo)).BeginInit();
            this.SuspendLayout();
            // 
            // tboxBesar
            // 
            this.tboxBesar.Location = new System.Drawing.Point(183, 359);
            this.tboxBesar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxBesar.Name = "tboxBesar";
            this.tboxBesar.Size = new System.Drawing.Size(191, 22);
            this.tboxBesar.TabIndex = 30;
            this.tboxBesar.TextChanged += new System.EventHandler(this.tboxBesar_TextChanged);
            this.tboxBesar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxBesar_KeyPress);
            // 
            // tboxNama
            // 
            this.tboxNama.Location = new System.Drawing.Point(183, 320);
            this.tboxNama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxNama.Name = "tboxNama";
            this.tboxNama.Size = new System.Drawing.Size(191, 22);
            this.tboxNama.TabIndex = 31;
            // 
            // tboxID
            // 
            this.tboxID.Location = new System.Drawing.Point(183, 281);
            this.tboxID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxID.Name = "tboxID";
            this.tboxID.Size = new System.Drawing.Size(188, 22);
            this.tboxID.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(64, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Besar Promo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(64, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nama Promo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(87, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "ID Promo";
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSaveEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveEdit.ForeColor = System.Drawing.Color.White;
            this.btnSaveEdit.Location = new System.Drawing.Point(457, 345);
            this.btnSaveEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(163, 52);
            this.btnSaveEdit.TabIndex = 33;
            this.btnSaveEdit.Text = "Save";
            this.btnSaveEdit.UseVisualStyleBackColor = false;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCancelEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelEdit.ForeColor = System.Drawing.Color.White;
            this.btnCancelEdit.Location = new System.Drawing.Point(457, 423);
            this.btnCancelEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(163, 52);
            this.btnCancelEdit.TabIndex = 34;
            this.btnCancelEdit.Text = "Cancel";
            this.btnCancelEdit.UseVisualStyleBackColor = false;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // dgvPromo
            // 
            this.dgvPromo.AllowUserToAddRows = false;
            this.dgvPromo.AllowUserToDeleteRows = false;
            this.dgvPromo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPromo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPromo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPromo.Location = new System.Drawing.Point(37, 66);
            this.dgvPromo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPromo.MultiSelect = false;
            this.dgvPromo.Name = "dgvPromo";
            this.dgvPromo.ReadOnly = true;
            this.dgvPromo.RowHeadersWidth = 51;
            this.dgvPromo.RowTemplate.Height = 24;
            this.dgvPromo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPromo.Size = new System.Drawing.Size(583, 185);
            this.dgvPromo.TabIndex = 35;
            this.dgvPromo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPromo_CellContentClick);
            // 
            // labelEdit
            // 
            this.labelEdit.AutoSize = true;
            this.labelEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.labelEdit.Location = new System.Drawing.Point(173, 15);
            this.labelEdit.Name = "labelEdit";
            this.labelEdit.Size = new System.Drawing.Size(311, 52);
            this.labelEdit.TabIndex = 36;
            this.labelEdit.Text = "EDIT PROMO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(53, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Periode Promo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(87, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "from";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(101, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "to";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(160, 438);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(153, 22);
            this.dtpFrom.TabIndex = 40;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(160, 474);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(153, 22);
            this.dtpTo.TabIndex = 41;
            // 
            // formPromoUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(652, 585);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelEdit);
            this.Controls.Add(this.dgvPromo);
            this.Controls.Add(this.btnCancelEdit);
            this.Controls.Add(this.btnSaveEdit);
            this.Controls.Add(this.tboxBesar);
            this.Controls.Add(this.tboxNama);
            this.Controls.Add(this.tboxID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formPromoUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Promo";
            this.Load += new System.EventHandler(this.FormbtnEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxBesar;
        private System.Windows.Forms.TextBox tboxNama;
        private System.Windows.Forms.TextBox tboxID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.DataGridView dgvPromo;
        private System.Windows.Forms.Label labelEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
    }
}