namespace Projek_Tea_Break
{
    partial class formToppingInsert
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
            this.labelAdd = new System.Windows.Forms.Label();
            this.dgvTopping = new System.Windows.Forms.DataGridView();
            this.btnCancelAdd = new System.Windows.Forms.Button();
            this.btnSaveAdd = new System.Windows.Forms.Button();
            this.tboxHarga = new System.Windows.Forms.TextBox();
            this.tboxNama = new System.Windows.Forms.TextBox();
            this.tboxID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopping)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdd.Location = new System.Drawing.Point(224, 15);
            this.labelAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(62, 29);
            this.labelAdd.TabIndex = 46;
            this.labelAdd.Text = "ADD";
            // 
            // dgvTopping
            // 
            this.dgvTopping.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTopping.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTopping.BackgroundColor = System.Drawing.Color.White;
            this.dgvTopping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopping.Location = new System.Drawing.Point(30, 58);
            this.dgvTopping.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvTopping.MultiSelect = false;
            this.dgvTopping.Name = "dgvTopping";
            this.dgvTopping.ReadOnly = true;
            this.dgvTopping.RowHeadersWidth = 51;
            this.dgvTopping.RowTemplate.Height = 24;
            this.dgvTopping.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTopping.Size = new System.Drawing.Size(470, 122);
            this.dgvTopping.TabIndex = 45;
            // 
            // btnCancelAdd
            // 
            this.btnCancelAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCancelAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAdd.ForeColor = System.Drawing.Color.White;
            this.btnCancelAdd.Location = new System.Drawing.Point(314, 343);
            this.btnCancelAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelAdd.Name = "btnCancelAdd";
            this.btnCancelAdd.Size = new System.Drawing.Size(84, 34);
            this.btnCancelAdd.TabIndex = 44;
            this.btnCancelAdd.Text = "Cancel";
            this.btnCancelAdd.UseVisualStyleBackColor = false;
            this.btnCancelAdd.Click += new System.EventHandler(this.btnCancelAdd_Click);
            // 
            // btnSaveAdd
            // 
            this.btnSaveAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSaveAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAdd.ForeColor = System.Drawing.Color.White;
            this.btnSaveAdd.Location = new System.Drawing.Point(152, 343);
            this.btnSaveAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveAdd.Name = "btnSaveAdd";
            this.btnSaveAdd.Size = new System.Drawing.Size(78, 34);
            this.btnSaveAdd.TabIndex = 43;
            this.btnSaveAdd.Text = "Add";
            this.btnSaveAdd.UseVisualStyleBackColor = false;
            this.btnSaveAdd.Click += new System.EventHandler(this.btnSaveAdd_Click);
            // 
            // tboxHarga
            // 
            this.tboxHarga.Location = new System.Drawing.Point(214, 286);
            this.tboxHarga.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tboxHarga.Name = "tboxHarga";
            this.tboxHarga.Size = new System.Drawing.Size(144, 20);
            this.tboxHarga.TabIndex = 3;
            // 
            // tboxNama
            // 
            this.tboxNama.Location = new System.Drawing.Point(214, 252);
            this.tboxNama.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tboxNama.Name = "tboxNama";
            this.tboxNama.Size = new System.Drawing.Size(144, 20);
            this.tboxNama.TabIndex = 2;
            // 
            // tboxID
            // 
            this.tboxID.Location = new System.Drawing.Point(214, 217);
            this.tboxID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tboxID.Name = "tboxID";
            this.tboxID.Size = new System.Drawing.Size(144, 20);
            this.tboxID.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(112, 289);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Harga Topping";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(114, 255);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Nama Topping";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(133, 220);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "ID Topping";
            // 
            // formToppingInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(532, 436);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelAdd);
            this.Controls.Add(this.dgvTopping);
            this.Controls.Add(this.btnCancelAdd);
            this.Controls.Add(this.btnSaveAdd);
            this.Controls.Add(this.tboxHarga);
            this.Controls.Add(this.tboxNama);
            this.Controls.Add(this.tboxID);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formToppingInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Topping";
            this.Load += new System.EventHandler(this.FormbtnAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopping)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.DataGridView dgvTopping;
        private System.Windows.Forms.Button btnCancelAdd;
        private System.Windows.Forms.Button btnSaveAdd;
        private System.Windows.Forms.TextBox tboxHarga;
        private System.Windows.Forms.TextBox tboxNama;
        private System.Windows.Forms.TextBox tboxID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}