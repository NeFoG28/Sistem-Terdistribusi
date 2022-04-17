
namespace clientservice_1180
{
    partial class Form1
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
            this.txtNomor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWarna = new System.Windows.Forms.TextBox();
            this.btnProses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNomor
            // 
            this.txtNomor.Location = new System.Drawing.Point(153, 21);
            this.txtNomor.Name = "txtNomor";
            this.txtNomor.Size = new System.Drawing.Size(100, 20);
            this.txtNomor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nomor Urut";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Warna";
            // 
            // txtWarna
            // 
            this.txtWarna.Location = new System.Drawing.Point(120, 138);
            this.txtWarna.Name = "txtWarna";
            this.txtWarna.Size = new System.Drawing.Size(133, 20);
            this.txtWarna.TabIndex = 3;
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(29, 73);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(224, 25);
            this.btnProses.TabIndex = 4;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 194);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.txtWarna);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomor);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warna Pelangi";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWarna;
        private System.Windows.Forms.Button btnProses;
    }
}

