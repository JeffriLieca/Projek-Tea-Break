
namespace Projek_Tea_Break
{
    partial class FormPilihan
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
            this.buttonManager = new System.Windows.Forms.Button();
            this.buttonKasir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonManager
            // 
            this.buttonManager.Location = new System.Drawing.Point(159, 91);
            this.buttonManager.Name = "buttonManager";
            this.buttonManager.Size = new System.Drawing.Size(75, 30);
            this.buttonManager.TabIndex = 0;
            this.buttonManager.Text = "Manager";
            this.buttonManager.UseVisualStyleBackColor = true;
            // 
            // buttonKasir
            // 
            this.buttonKasir.Location = new System.Drawing.Point(159, 162);
            this.buttonKasir.Name = "buttonKasir";
            this.buttonKasir.Size = new System.Drawing.Size(75, 28);
            this.buttonKasir.TabIndex = 1;
            this.buttonKasir.Text = "Kasir";
            this.buttonKasir.UseVisualStyleBackColor = true;
            // 
            // FormPilihan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 281);
            this.Controls.Add(this.buttonKasir);
            this.Controls.Add(this.buttonManager);
            this.Name = "FormPilihan";
            this.Text = "FormPilihan";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonManager;
        private System.Windows.Forms.Button buttonKasir;
    }
}