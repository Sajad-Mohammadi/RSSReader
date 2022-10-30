namespace RSSReader
{
    partial class URLForm
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
            this.tbxURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNamn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbKategori = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAvbryt = new System.Windows.Forms.Button();
            this.btnLaggTill_Upp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxURL
            // 
            this.tbxURL.Location = new System.Drawing.Point(17, 73);
            this.tbxURL.Margin = new System.Windows.Forms.Padding(5);
            this.tbxURL.Name = "tbxURL";
            this.tbxURL.Size = new System.Drawing.Size(191, 22);
            this.tbxURL.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "URL:";
            // 
            // tbxNamn
            // 
            this.tbxNamn.Location = new System.Drawing.Point(229, 73);
            this.tbxNamn.Margin = new System.Windows.Forms.Padding(5);
            this.tbxNamn.Name = "tbxNamn";
            this.tbxNamn.Size = new System.Drawing.Size(134, 22);
            this.tbxNamn.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Namn:";
            // 
            // cbbKategori
            // 
            this.cbbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKategori.FormattingEnabled = true;
            this.cbbKategori.Location = new System.Drawing.Point(384, 71);
            this.cbbKategori.Name = "cbbKategori";
            this.cbbKategori.Size = new System.Drawing.Size(121, 24);
            this.cbbKategori.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kategori:";
            // 
            // btnAvbryt
            // 
            this.btnAvbryt.Location = new System.Drawing.Point(263, 117);
            this.btnAvbryt.Margin = new System.Windows.Forms.Padding(4);
            this.btnAvbryt.Name = "btnAvbryt";
            this.btnAvbryt.Size = new System.Drawing.Size(100, 28);
            this.btnAvbryt.TabIndex = 13;
            this.btnAvbryt.Text = "Avbryt";
            this.btnAvbryt.UseVisualStyleBackColor = true;
            this.btnAvbryt.Click += new System.EventHandler(this.btnAvbryt_Click);
            // 
            // btnLaggTill_Upp
            // 
            this.btnLaggTill_Upp.Location = new System.Drawing.Point(155, 117);
            this.btnLaggTill_Upp.Margin = new System.Windows.Forms.Padding(4);
            this.btnLaggTill_Upp.Name = "btnLaggTill_Upp";
            this.btnLaggTill_Upp.Size = new System.Drawing.Size(100, 28);
            this.btnLaggTill_Upp.TabIndex = 12;
            this.btnLaggTill_Upp.Text = "Lägg Till";
            this.btnLaggTill_Upp.UseVisualStyleBackColor = true;
            this.btnLaggTill_Upp.Click += new System.EventHandler(this.btnLaggTill_Upp_Click);
            // 
            // URLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 209);
            this.Controls.Add(this.btnAvbryt);
            this.Controls.Add(this.btnLaggTill_Upp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbKategori);
            this.Controls.Add(this.tbxNamn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxURL);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "URLForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "URLForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.URLForm_FormClosed);
            this.Load += new System.EventHandler(this.URLForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNamn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbKategori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAvbryt;
        private System.Windows.Forms.Button btnLaggTill_Upp;
    }
}