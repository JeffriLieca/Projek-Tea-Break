﻿
namespace Projek_Tea_Break
{
    partial class FormAddMinuman
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
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelTopping = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelTopping = new System.Windows.Forms.Panel();
            this.imageListMinuman = new System.Windows.Forms.ImageList(this.components);
            this.labelMinuman = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGambar = new System.Windows.Forms.Button();
            this.buttonPlusQty = new System.Windows.Forms.Button();
            this.buttonMinQty = new System.Windows.Forms.Button();
            this.textBoxQty = new System.Windows.Forms.TextBox();
            this.rBSugarLess = new System.Windows.Forms.RadioButton();
            this.rBSugarNormal = new System.Windows.Forms.RadioButton();
            this.rBSugarMore = new System.Windows.Forms.RadioButton();
            this.rBIceLess = new System.Windows.Forms.RadioButton();
            this.rBIceNormal = new System.Windows.Forms.RadioButton();
            this.rBIceMore = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelIDNota = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOk.Location = new System.Drawing.Point(310, 306);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(148, 80);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelTopping
            // 
            this.labelTopping.AutoSize = true;
            this.labelTopping.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTopping.Location = new System.Drawing.Point(9, 141);
            this.labelTopping.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTopping.Name = "labelTopping";
            this.labelTopping.Size = new System.Drawing.Size(72, 19);
            this.labelTopping.TabIndex = 5;
            this.labelTopping.Text = "Topping";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Red;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(310, 401);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(148, 80);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // panelTopping
            // 
            this.panelTopping.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTopping.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelTopping.Location = new System.Drawing.Point(10, 172);
            this.panelTopping.Margin = new System.Windows.Forms.Padding(2);
            this.panelTopping.Name = "panelTopping";
            this.panelTopping.Size = new System.Drawing.Size(285, 308);
            this.panelTopping.TabIndex = 7;
            // 
            // imageListMinuman
            // 
            this.imageListMinuman.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListMinuman.ImageSize = new System.Drawing.Size(90, 90);
            this.imageListMinuman.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // labelMinuman
            // 
            this.labelMinuman.AutoSize = true;
            this.labelMinuman.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinuman.Location = new System.Drawing.Point(333, 172);
            this.labelMinuman.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinuman.Name = "labelMinuman";
            this.labelMinuman.Size = new System.Drawing.Size(111, 25);
            this.labelMinuman.TabIndex = 11;
            this.labelMinuman.Text = "Nama Minuman";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Jumlah :";
            // 
            // buttonGambar
            // 
            this.buttonGambar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGambar.Enabled = false;
            this.buttonGambar.Location = new System.Drawing.Point(308, 10);
            this.buttonGambar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGambar.Name = "buttonGambar";
            this.buttonGambar.Size = new System.Drawing.Size(150, 162);
            this.buttonGambar.TabIndex = 13;
            this.buttonGambar.Text = " ";
            this.buttonGambar.UseVisualStyleBackColor = true;
            // 
            // buttonPlusQty
            // 
            this.buttonPlusQty.Location = new System.Drawing.Point(420, 205);
            this.buttonPlusQty.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPlusQty.Name = "buttonPlusQty";
            this.buttonPlusQty.Size = new System.Drawing.Size(19, 20);
            this.buttonPlusQty.TabIndex = 14;
            this.buttonPlusQty.Text = "+";
            this.buttonPlusQty.UseCompatibleTextRendering = true;
            this.buttonPlusQty.UseVisualStyleBackColor = true;
            this.buttonPlusQty.Click += new System.EventHandler(this.buttonPlusQty_Click);
            // 
            // buttonMinQty
            // 
            this.buttonMinQty.Location = new System.Drawing.Point(374, 205);
            this.buttonMinQty.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMinQty.Name = "buttonMinQty";
            this.buttonMinQty.Size = new System.Drawing.Size(19, 20);
            this.buttonMinQty.TabIndex = 15;
            this.buttonMinQty.Text = "-";
            this.buttonMinQty.UseCompatibleTextRendering = true;
            this.buttonMinQty.UseVisualStyleBackColor = true;
            this.buttonMinQty.Click += new System.EventHandler(this.buttonMinQty_Click);
            // 
            // textBoxQty
            // 
            this.textBoxQty.Location = new System.Drawing.Point(397, 205);
            this.textBoxQty.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxQty.Name = "textBoxQty";
            this.textBoxQty.Size = new System.Drawing.Size(20, 20);
            this.textBoxQty.TabIndex = 16;
            this.textBoxQty.Text = "1";
            this.textBoxQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rBSugarLess
            // 
            this.rBSugarLess.AutoSize = true;
            this.rBSugarLess.Location = new System.Drawing.Point(10, 7);
            this.rBSugarLess.Margin = new System.Windows.Forms.Padding(2);
            this.rBSugarLess.Name = "rBSugarLess";
            this.rBSugarLess.Size = new System.Drawing.Size(47, 17);
            this.rBSugarLess.TabIndex = 17;
            this.rBSugarLess.Tag = "L";
            this.rBSugarLess.Text = "Less";
            this.rBSugarLess.UseVisualStyleBackColor = true;
            // 
            // rBSugarNormal
            // 
            this.rBSugarNormal.AutoSize = true;
            this.rBSugarNormal.Checked = true;
            this.rBSugarNormal.Location = new System.Drawing.Point(10, 40);
            this.rBSugarNormal.Margin = new System.Windows.Forms.Padding(2);
            this.rBSugarNormal.Name = "rBSugarNormal";
            this.rBSugarNormal.Size = new System.Drawing.Size(58, 17);
            this.rBSugarNormal.TabIndex = 18;
            this.rBSugarNormal.TabStop = true;
            this.rBSugarNormal.Tag = "N";
            this.rBSugarNormal.Text = "Normal";
            this.rBSugarNormal.UseVisualStyleBackColor = true;
            // 
            // rBSugarMore
            // 
            this.rBSugarMore.AutoSize = true;
            this.rBSugarMore.Location = new System.Drawing.Point(10, 72);
            this.rBSugarMore.Margin = new System.Windows.Forms.Padding(2);
            this.rBSugarMore.Name = "rBSugarMore";
            this.rBSugarMore.Size = new System.Drawing.Size(49, 17);
            this.rBSugarMore.TabIndex = 19;
            this.rBSugarMore.Tag = "M";
            this.rBSugarMore.Text = "More";
            this.rBSugarMore.UseVisualStyleBackColor = true;
            // 
            // rBIceLess
            // 
            this.rBIceLess.AutoSize = true;
            this.rBIceLess.Location = new System.Drawing.Point(8, 7);
            this.rBIceLess.Margin = new System.Windows.Forms.Padding(2);
            this.rBIceLess.Name = "rBIceLess";
            this.rBIceLess.Size = new System.Drawing.Size(47, 17);
            this.rBIceLess.TabIndex = 20;
            this.rBIceLess.Tag = "L";
            this.rBIceLess.Text = "Less";
            this.rBIceLess.UseVisualStyleBackColor = true;
            // 
            // rBIceNormal
            // 
            this.rBIceNormal.AutoSize = true;
            this.rBIceNormal.Checked = true;
            this.rBIceNormal.Location = new System.Drawing.Point(8, 40);
            this.rBIceNormal.Margin = new System.Windows.Forms.Padding(2);
            this.rBIceNormal.Name = "rBIceNormal";
            this.rBIceNormal.Size = new System.Drawing.Size(58, 17);
            this.rBIceNormal.TabIndex = 21;
            this.rBIceNormal.TabStop = true;
            this.rBIceNormal.Tag = "N";
            this.rBIceNormal.Text = "Normal";
            this.rBIceNormal.UseVisualStyleBackColor = true;
            // 
            // rBIceMore
            // 
            this.rBIceMore.AutoSize = true;
            this.rBIceMore.Location = new System.Drawing.Point(8, 72);
            this.rBIceMore.Margin = new System.Windows.Forms.Padding(2);
            this.rBIceMore.Name = "rBIceMore";
            this.rBIceMore.Size = new System.Drawing.Size(49, 17);
            this.rBIceMore.TabIndex = 22;
            this.rBIceMore.Tag = "M";
            this.rBIceMore.Text = "More";
            this.rBIceMore.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 10);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 19);
            this.label12.TabIndex = 23;
            this.label12.Text = "Sugar Level";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(172, 10);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 19);
            this.label13.TabIndex = 24;
            this.label13.Text = "Ice Level";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rBSugarLess);
            this.panel1.Controls.Add(this.rBSugarNormal);
            this.panel1.Controls.Add(this.rBSugarMore);
            this.panel1.Location = new System.Drawing.Point(16, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(81, 105);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rBIceNormal);
            this.panel2.Controls.Add(this.rBIceMore);
            this.panel2.Controls.Add(this.rBIceLess);
            this.panel2.Location = new System.Drawing.Point(176, 33);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(81, 105);
            this.panel2.TabIndex = 26;
            // 
            // labelIDNota
            // 
            this.labelIDNota.AutoSize = true;
            this.labelIDNota.Location = new System.Drawing.Point(337, 265);
            this.labelIDNota.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIDNota.Name = "labelIDNota";
            this.labelIDNota.Size = new System.Drawing.Size(44, 13);
            this.labelIDNota.TabIndex = 27;
            this.labelIDNota.Text = "ID Nota";
            this.labelIDNota.Visible = false;
            // 
            // FormAddMinuman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 490);
            this.Controls.Add(this.labelIDNota);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxQty);
            this.Controls.Add(this.buttonMinQty);
            this.Controls.Add(this.buttonPlusQty);
            this.Controls.Add(this.buttonGambar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelMinuman);
            this.Controls.Add(this.panelTopping);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelTopping);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAddMinuman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormAddMinuman_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelTopping;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panelTopping;
        private System.Windows.Forms.ImageList imageListMinuman;
        private System.Windows.Forms.Label labelMinuman;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGambar;
        private System.Windows.Forms.Button buttonPlusQty;
        private System.Windows.Forms.Button buttonMinQty;
        private System.Windows.Forms.TextBox textBoxQty;
        private System.Windows.Forms.RadioButton rBSugarLess;
        private System.Windows.Forms.RadioButton rBSugarNormal;
        private System.Windows.Forms.RadioButton rBSugarMore;
        private System.Windows.Forms.RadioButton rBIceLess;
        private System.Windows.Forms.RadioButton rBIceNormal;
        private System.Windows.Forms.RadioButton rBIceMore;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelIDNota;
    }
}