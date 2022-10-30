namespace RSSReader
{
    partial class KategoriForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNamn = new System.Windows.Forms.TextBox();
            this.btnLaggTill_Upp = new System.Windows.Forms.Button();
            this.btnAvbryt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori-namn:";
            // 
            // tbxNamn
            // 
            this.tbxNamn.Location = new System.Drawing.Point(82, 72);
            this.tbxNamn.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNamn.Name = "tbxNamn";
            this.tbxNamn.Size = new System.Drawing.Size(349, 22);
            this.tbxNamn.TabIndex = 1;
            // 
            // btnLaggTill_Upp
            // 
            this.btnLaggTill_Upp.Location = new System.Drawing.Point(155, 117);
            this.btnLaggTill_Upp.Margin = new System.Windows.Forms.Padding(4);
            this.btnLaggTill_Upp.Name = "btnLaggTill_Upp";
            this.btnLaggTill_Upp.Size = new System.Drawing.Size(100, 28);
            this.btnLaggTill_Upp.TabIndex = 2;
            this.btnLaggTill_Upp.Text = "Lägg Till";
            this.btnLaggTill_Upp.UseVisualStyleBackColor = true;
            this.btnLaggTill_Upp.Click += new System.EventHandler(this.btnLaggTill_Upp_Click);
            // 
            // btnAvbryt
            // 
            this.btnAvbryt.Location = new System.Drawing.Point(263, 117);
            this.btnAvbryt.Margin = new System.Windows.Forms.Padding(4);
            this.btnAvbryt.Name = "btnAvbryt";
            this.btnAvbryt.Size = new System.Drawing.Size(100, 28);
            this.btnAvbryt.TabIndex = 3;
            this.btnAvbryt.Text = "Avbryt";
            this.btnAvbryt.UseVisualStyleBackColor = true;
            this.btnAvbryt.Click += new System.EventHandler(this.btnAvbryt_Click);
            // 
            // KategoriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 209);
            this.Controls.Add(this.btnAvbryt);
            this.Controls.Add(this.btnLaggTill_Upp);
            this.Controls.Add(this.tbxNamn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KategoriForm";
            this.Text = "KategoriForm";
            this.Load += new System.EventHandler(this.KategoriForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNamn;
        private System.Windows.Forms.Button btnLaggTill_Upp;
        private System.Windows.Forms.Button btnAvbryt;
    }
}