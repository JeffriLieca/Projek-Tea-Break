﻿
namespace Projek_Tea_Break
{
    partial class FormOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrder));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbProfil = new System.Windows.Forms.PictureBox();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.buttonEditMenu = new System.Windows.Forms.Button();
            this.buttonCashier = new System.Windows.Forms.Button();
            this.panelOrderMenu = new System.Windows.Forms.Panel();
            this.labelIDNota = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonOrderNow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.imageListMinuman = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelMinuman = new System.Windows.Forms.Panel();
            this.textBoxCariMinuman = new System.Windows.Forms.TextBox();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonT = new System.Windows.Forms.Button();
            this.buttonF = new System.Windows.Forms.Button();
            this.buttonS = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxNoHP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelTotalHargaBersih = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelDiskon = new System.Windows.Forms.Label();
            this.labelTotalHarga = new System.Windows.Forms.Label();
            this.labelPersen = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelNamaPegawai = new System.Windows.Forms.Label();
            this.buttonCanClose = new System.Windows.Forms.Button();
            this.buttonCanOpen = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(103, 524);
            this.panel2.TabIndex = 7;
            // 
            // pbProfil
            // 
            this.pbProfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbProfil.Image = global::Projek_Tea_Break.Properties.Resources.logo;
            this.pbProfil.Location = new System.Drawing.Point(0, 22);
            this.pbProfil.Name = "pbProfil";
            this.pbProfil.Size = new System.Drawing.Size(100, 32);
            this.pbProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfil.TabIndex = 20;
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
            this.buttonAdmin.Location = new System.Drawing.Point(20, 299);
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
            this.buttonEditMenu.Location = new System.Drawing.Point(20, 202);
            this.buttonEditMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.buttonCashier.Location = new System.Drawing.Point(20, 105);
            this.buttonCashier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCashier.Name = "buttonCashier";
            this.buttonCashier.Size = new System.Drawing.Size(69, 77);
            this.buttonCashier.TabIndex = 1;
            this.buttonCashier.Text = "Cashier";
            this.buttonCashier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonCashier.UseVisualStyleBackColor = false;
            this.buttonCashier.Click += new System.EventHandler(this.buttonCashier_Click);
            // 
            // panelOrderMenu
            // 
            this.panelOrderMenu.AutoScroll = true;
            this.panelOrderMenu.BackColor = System.Drawing.Color.White;
            this.panelOrderMenu.Location = new System.Drawing.Point(510, 57);
            this.panelOrderMenu.Name = "panelOrderMenu";
            this.panelOrderMenu.Size = new System.Drawing.Size(273, 319);
            this.panelOrderMenu.TabIndex = 8;
            // 
            // labelIDNota
            // 
            this.labelIDNota.AutoSize = true;
            this.labelIDNota.Location = new System.Drawing.Point(572, 32);
            this.labelIDNota.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIDNota.Name = "labelIDNota";
            this.labelIDNota.Size = new System.Drawing.Size(42, 17);
            this.labelIDNota.TabIndex = 3;
            this.labelIDNota.Text = "220608";
            this.labelIDNota.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(523, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "ID Nota:";
            // 
            // buttonOrderNow
            // 
            this.buttonOrderNow.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonOrderNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrderNow.ForeColor = System.Drawing.Color.White;
            this.buttonOrderNow.Location = new System.Drawing.Point(572, 436);
            this.buttonOrderNow.Name = "buttonOrderNow";
            this.buttonOrderNow.Size = new System.Drawing.Size(183, 49);
            this.buttonOrderNow.TabIndex = 1;
            this.buttonOrderNow.Text = "Order Now!!";
            this.buttonOrderNow.UseVisualStyleBackColor = false;
            this.buttonOrderNow.Click += new System.EventHandler(this.buttonOrderNow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(523, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Menu";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Menu Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Choose Order";
            // 
            // panelMinuman
            // 
            this.panelMinuman.AutoScroll = true;
            this.panelMinuman.Location = new System.Drawing.Point(110, 190);
            this.panelMinuman.Name = "panelMinuman";
            this.panelMinuman.Size = new System.Drawing.Size(394, 295);
            this.panelMinuman.TabIndex = 12;
            // 
            // textBoxCariMinuman
            // 
            this.textBoxCariMinuman.Location = new System.Drawing.Point(196, 164);
            this.textBoxCariMinuman.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCariMinuman.Name = "textBoxCariMinuman";
            this.textBoxCariMinuman.Size = new System.Drawing.Size(76, 20);
            this.textBoxCariMinuman.TabIndex = 14;
            this.textBoxCariMinuman.TextChanged += new System.EventHandler(this.textBoxCariMinuman_TextChanged);
            // 
            // buttonA
            // 
            this.buttonA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonA.BackgroundImage")));
            this.buttonA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonA.Location = new System.Drawing.Point(412, 57);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(60, 65);
            this.buttonA.TabIndex = 17;
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // buttonT
            // 
            this.buttonT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonT.BackgroundImage")));
            this.buttonT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonT.Location = new System.Drawing.Point(319, 57);
            this.buttonT.Name = "buttonT";
            this.buttonT.Size = new System.Drawing.Size(60, 65);
            this.buttonT.TabIndex = 16;
            this.buttonT.UseVisualStyleBackColor = false;
            this.buttonT.Click += new System.EventHandler(this.buttonT_Click);
            // 
            // buttonF
            // 
            this.buttonF.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonF.BackgroundImage")));
            this.buttonF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonF.Location = new System.Drawing.Point(225, 57);
            this.buttonF.Name = "buttonF";
            this.buttonF.Size = new System.Drawing.Size(60, 65);
            this.buttonF.TabIndex = 15;
            this.buttonF.UseVisualStyleBackColor = false;
            this.buttonF.Click += new System.EventHandler(this.buttonF_Click);
            // 
            // buttonS
            // 
            this.buttonS.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonS.BackgroundImage")));
            this.buttonS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonS.Location = new System.Drawing.Point(131, 57);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(60, 65);
            this.buttonS.TabIndex = 10;
            this.buttonS.UseVisualStyleBackColor = false;
            this.buttonS.Click += new System.EventHandler(this.buttonS_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Nama :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 167);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "No.Hp :";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(361, 141);
            this.textBoxNama.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(76, 20);
            this.textBoxNama.TabIndex = 20;
            // 
            // textBoxNoHP
            // 
            this.textBoxNoHP.Location = new System.Drawing.Point(361, 167);
            this.textBoxNoHP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNoHP.Name = "textBoxNoHP";
            this.textBoxNoHP.Size = new System.Drawing.Size(76, 20);
            this.textBoxNoHP.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(523, 417);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Total :";
            // 
            // labelTotalHargaBersih
            // 
            this.labelTotalHargaBersih.Location = new System.Drawing.Point(680, 417);
            this.labelTotalHargaBersih.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalHargaBersih.Name = "labelTotalHargaBersih";
            this.labelTotalHargaBersih.Size = new System.Drawing.Size(75, 19);
            this.labelTotalHargaBersih.TabIndex = 23;
            this.labelTotalHargaBersih.Text = "Rp. 0";
            this.labelTotalHargaBersih.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(514, 398);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Diskon :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(522, 379);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Total :";
            // 
            // labelDiskon
            // 
            this.labelDiskon.Location = new System.Drawing.Point(680, 398);
            this.labelDiskon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDiskon.Name = "labelDiskon";
            this.labelDiskon.Size = new System.Drawing.Size(75, 19);
            this.labelDiskon.TabIndex = 26;
            this.labelDiskon.Text = "Rp. 0";
            this.labelDiskon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTotalHarga
            // 
            this.labelTotalHarga.Location = new System.Drawing.Point(680, 379);
            this.labelTotalHarga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalHarga.Name = "labelTotalHarga";
            this.labelTotalHarga.Size = new System.Drawing.Size(75, 19);
            this.labelTotalHarga.TabIndex = 27;
            this.labelTotalHarga.Text = "Rp. 0";
            this.labelTotalHarga.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPersen
            // 
            this.labelPersen.AutoSize = true;
            this.labelPersen.Location = new System.Drawing.Point(563, 398);
            this.labelPersen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPersen.Name = "labelPersen";
            this.labelPersen.Size = new System.Drawing.Size(28, 13);
            this.labelPersen.TabIndex = 28;
            this.labelPersen.Text = "Disc";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(662, 32);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Kasir :";
            // 
            // labelNamaPegawai
            // 
            this.labelNamaPegawai.AutoSize = true;
            this.labelNamaPegawai.Location = new System.Drawing.Point(703, 32);
            this.labelNamaPegawai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNamaPegawai.Name = "labelNamaPegawai";
            this.labelNamaPegawai.Size = new System.Drawing.Size(76, 13);
            this.labelNamaPegawai.TabIndex = 30;
            this.labelNamaPegawai.Text = "NamaPegawai";
            // 
            // buttonCanClose
            // 
            this.buttonCanClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCanClose.BackgroundImage")));
            this.buttonCanClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCanClose.Location = new System.Drawing.Point(516, 436);
            this.buttonCanClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCanClose.Name = "buttonCanClose";
            this.buttonCanClose.Size = new System.Drawing.Size(45, 49);
            this.buttonCanClose.TabIndex = 31;
            this.buttonCanClose.UseVisualStyleBackColor = true;
            this.buttonCanClose.MouseEnter += new System.EventHandler(this.buttonCanClose_MouseEnter);
            // 
            // buttonCanOpen
            // 
            this.buttonCanOpen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCanOpen.BackgroundImage")));
            this.buttonCanOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCanOpen.Location = new System.Drawing.Point(516, 436);
            this.buttonCanOpen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCanOpen.Name = "buttonCanOpen";
            this.buttonCanOpen.Size = new System.Drawing.Size(45, 49);
            this.buttonCanOpen.TabIndex = 33;
            this.buttonCanOpen.UseVisualStyleBackColor = true;
            this.buttonCanOpen.Click += new System.EventHandler(this.buttonCanOpen_Click);
            this.buttonCanOpen.MouseLeave += new System.EventHandler(this.buttonCanOpen_MouseLeave);
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(782, 516);
            this.Controls.Add(this.buttonCanOpen);
            this.Controls.Add(this.labelNamaPegawai);
            this.Controls.Add(this.buttonCanClose);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelPersen);
            this.Controls.Add(this.labelTotalHarga);
            this.Controls.Add(this.labelDiskon);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelIDNota);
            this.Controls.Add(this.labelTotalHargaBersih);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOrderNow);
            this.Controls.Add(this.textBoxNoHP);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.buttonT);
            this.Controls.Add(this.buttonF);
            this.Controls.Add(this.textBoxCariMinuman);
            this.Controls.Add(this.panelMinuman);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelOrderMenu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonS);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormOrder_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonCashier;
        private System.Windows.Forms.Panel panelOrderMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonS;
        private System.Windows.Forms.Panel panelMinuman;
        private System.Windows.Forms.Button buttonOrderNow;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Button buttonEditMenu;
        private System.Windows.Forms.ImageList imageListMinuman;
        private System.Windows.Forms.TextBox textBoxCariMinuman;
        private System.Windows.Forms.Button buttonF;
        private System.Windows.Forms.Button buttonT;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Label labelIDNota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxNoHP;
        private System.Windows.Forms.PictureBox pbProfil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelTotalHargaBersih;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelDiskon;
        private System.Windows.Forms.Label labelTotalHarga;
        private System.Windows.Forms.Label labelPersen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelNamaPegawai;
        private System.Windows.Forms.Button buttonCanClose;
        private System.Windows.Forms.Button buttonCanOpen;
    }
}