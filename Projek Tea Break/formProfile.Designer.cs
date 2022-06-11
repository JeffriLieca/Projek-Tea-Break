
namespace Projek_Tea_Break
{
    partial class formProfile
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
            this.buttonLogout = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbNama = new System.Windows.Forms.Label();
            this.lbJabatan = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Black;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Location = new System.Drawing.Point(156, 184);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(86, 33);
            this.buttonLogout.TabIndex = 0;
            this.buttonLogout.Text = "LogOut";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox3.Location = new System.Drawing.Point(-9, 232);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(416, 82);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // lbNama
            // 
            this.lbNama.AutoSize = true;
            this.lbNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNama.Location = new System.Drawing.Point(168, 113);
            this.lbNama.Name = "lbNama";
            this.lbNama.Size = new System.Drawing.Size(44, 16);
            this.lbNama.TabIndex = 13;
            this.lbNama.Text = "Nama";
            this.lbNama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbJabatan
            // 
            this.lbJabatan.AutoSize = true;
            this.lbJabatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJabatan.Location = new System.Drawing.Point(168, 146);
            this.lbJabatan.Name = "lbJabatan";
            this.lbJabatan.Size = new System.Drawing.Size(56, 16);
            this.lbJabatan.TabIndex = 14;
            this.lbJabatan.Text = "Jabatan";
            this.lbJabatan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox1.Location = new System.Drawing.Point(-9, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(416, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // formProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 303);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbJabatan);
            this.Controls.Add(this.lbNama);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.buttonLogout);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.formProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbNama;
        private System.Windows.Forms.Label lbJabatan;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

