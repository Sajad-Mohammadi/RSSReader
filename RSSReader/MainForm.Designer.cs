namespace RSSReader
{
    partial class MainForm
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
            this.gbKategroi = new System.Windows.Forms.GroupBox();
            this.lbKategori = new System.Windows.Forms.ListBox();
            this.btnTaBortKategori = new System.Windows.Forms.Button();
            this.btnUppdateraKategori = new System.Windows.Forms.Button();
            this.btnLaggTillKategori = new System.Windows.Forms.Button();
            this.clbKategori = new System.Windows.Forms.CheckedListBox();
            this.gbArtikel = new System.Windows.Forms.GroupBox();
            this.lvArtikel = new System.Windows.Forms.ListView();
            this.columnTitel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAvsnitt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnKategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTaBortFeed = new System.Windows.Forms.Button();
            this.btnUppdateraFeed = new System.Windows.Forms.Button();
            this.btnLaggTillFeed = new System.Windows.Forms.Button();
            this.gbAvsnitt = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxBeskrivning = new System.Windows.Forms.TextBox();
            this.cbbAvsnitt = new System.Windows.Forms.ComboBox();
            this.gbKategroi.SuspendLayout();
            this.gbArtikel.SuspendLayout();
            this.gbAvsnitt.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbKategroi
            // 
            this.gbKategroi.Controls.Add(this.lbKategori);
            this.gbKategroi.Controls.Add(this.btnTaBortKategori);
            this.gbKategroi.Controls.Add(this.btnUppdateraKategori);
            this.gbKategroi.Controls.Add(this.btnLaggTillKategori);
            this.gbKategroi.Controls.Add(this.clbKategori);
            this.gbKategroi.Location = new System.Drawing.Point(13, 13);
            this.gbKategroi.Margin = new System.Windows.Forms.Padding(4);
            this.gbKategroi.Name = "gbKategroi";
            this.gbKategroi.Padding = new System.Windows.Forms.Padding(4);
            this.gbKategroi.Size = new System.Drawing.Size(297, 518);
            this.gbKategroi.TabIndex = 0;
            this.gbKategroi.TabStop = false;
            this.gbKategroi.Text = "Kategori";
            // 
            // lbKategori
            // 
            this.lbKategori.FormattingEnabled = true;
            this.lbKategori.ItemHeight = 16;
            this.lbKategori.Location = new System.Drawing.Point(9, 257);
            this.lbKategori.Name = "lbKategori";
            this.lbKategori.Size = new System.Drawing.Size(281, 212);
            this.lbKategori.TabIndex = 4;
            this.lbKategori.SelectedIndexChanged += new System.EventHandler(this.lbKategori_SelectedIndexChanged);
            // 
            // btnTaBortKategori
            // 
            this.btnTaBortKategori.Location = new System.Drawing.Point(200, 482);
            this.btnTaBortKategori.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaBortKategori.Name = "btnTaBortKategori";
            this.btnTaBortKategori.Size = new System.Drawing.Size(89, 28);
            this.btnTaBortKategori.TabIndex = 3;
            this.btnTaBortKategori.Text = "Ta Bort";
            this.btnTaBortKategori.UseVisualStyleBackColor = true;
            this.btnTaBortKategori.Click += new System.EventHandler(this.btnTaBortKategori_Click);
            // 
            // btnUppdateraKategori
            // 
            this.btnUppdateraKategori.Location = new System.Drawing.Point(104, 482);
            this.btnUppdateraKategori.Margin = new System.Windows.Forms.Padding(4);
            this.btnUppdateraKategori.Name = "btnUppdateraKategori";
            this.btnUppdateraKategori.Size = new System.Drawing.Size(89, 28);
            this.btnUppdateraKategori.TabIndex = 2;
            this.btnUppdateraKategori.Text = "Uppdatera";
            this.btnUppdateraKategori.UseVisualStyleBackColor = true;
            this.btnUppdateraKategori.Click += new System.EventHandler(this.btnUppdateraKategori_Click);
            // 
            // btnLaggTillKategori
            // 
            this.btnLaggTillKategori.Location = new System.Drawing.Point(8, 482);
            this.btnLaggTillKategori.Margin = new System.Windows.Forms.Padding(4);
            this.btnLaggTillKategori.Name = "btnLaggTillKategori";
            this.btnLaggTillKategori.Size = new System.Drawing.Size(89, 28);
            this.btnLaggTillKategori.TabIndex = 1;
            this.btnLaggTillKategori.Text = "Lägg Till";
            this.btnLaggTillKategori.UseVisualStyleBackColor = true;
            this.btnLaggTillKategori.Click += new System.EventHandler(this.btnLaggTillKategori_Click);
            // 
            // clbKategori
            // 
            this.clbKategori.FormattingEnabled = true;
            this.clbKategori.Location = new System.Drawing.Point(8, 23);
            this.clbKategori.Margin = new System.Windows.Forms.Padding(4);
            this.clbKategori.Name = "clbKategori";
            this.clbKategori.Size = new System.Drawing.Size(281, 446);
            this.clbKategori.TabIndex = 0;
            this.clbKategori.SelectedIndexChanged += new System.EventHandler(this.clbKategori_SelectedIndexChanged);
            // 
            // gbArtikel
            // 
            this.gbArtikel.Controls.Add(this.lvArtikel);
            this.gbArtikel.Controls.Add(this.btnTaBortFeed);
            this.gbArtikel.Controls.Add(this.btnUppdateraFeed);
            this.gbArtikel.Controls.Add(this.btnLaggTillFeed);
            this.gbArtikel.Location = new System.Drawing.Point(365, 13);
            this.gbArtikel.Margin = new System.Windows.Forms.Padding(4);
            this.gbArtikel.Name = "gbArtikel";
            this.gbArtikel.Padding = new System.Windows.Forms.Padding(4);
            this.gbArtikel.Size = new System.Drawing.Size(314, 518);
            this.gbArtikel.TabIndex = 4;
            this.gbArtikel.TabStop = false;
            this.gbArtikel.Text = "Artikel";
            // 
            // lvArtikel
            // 
            this.lvArtikel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTitel,
            this.columnAvsnitt,
            this.columnKategori});
            this.lvArtikel.FullRowSelect = true;
            this.lvArtikel.HideSelection = false;
            this.lvArtikel.Location = new System.Drawing.Point(8, 23);
            this.lvArtikel.Name = "lvArtikel";
            this.lvArtikel.Size = new System.Drawing.Size(298, 446);
            this.lvArtikel.TabIndex = 4;
            this.lvArtikel.UseCompatibleStateImageBehavior = false;
            this.lvArtikel.View = System.Windows.Forms.View.Details;
            this.lvArtikel.SelectedIndexChanged += new System.EventHandler(this.lvArtikel_SelectedIndexChanged);
            // 
            // columnTitel
            // 
            this.columnTitel.Text = "Titel";
            this.columnTitel.Width = 150;
            // 
            // columnAvsnitt
            // 
            this.columnAvsnitt.Text = "Avsnitt";
            // 
            // columnKategori
            // 
            this.columnKategori.Text = "Kategori";
            this.columnKategori.Width = 80;
            // 
            // btnTaBortFeed
            // 
            this.btnTaBortFeed.Location = new System.Drawing.Point(216, 482);
            this.btnTaBortFeed.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaBortFeed.Name = "btnTaBortFeed";
            this.btnTaBortFeed.Size = new System.Drawing.Size(89, 28);
            this.btnTaBortFeed.TabIndex = 3;
            this.btnTaBortFeed.Text = "Ta Bort";
            this.btnTaBortFeed.UseVisualStyleBackColor = true;
            this.btnTaBortFeed.Click += new System.EventHandler(this.btnTaBortFeed_Click);
            // 
            // btnUppdateraFeed
            // 
            this.btnUppdateraFeed.Location = new System.Drawing.Point(112, 482);
            this.btnUppdateraFeed.Margin = new System.Windows.Forms.Padding(4);
            this.btnUppdateraFeed.Name = "btnUppdateraFeed";
            this.btnUppdateraFeed.Size = new System.Drawing.Size(89, 28);
            this.btnUppdateraFeed.TabIndex = 2;
            this.btnUppdateraFeed.Text = "Uppdatera";
            this.btnUppdateraFeed.UseVisualStyleBackColor = true;
            this.btnUppdateraFeed.Click += new System.EventHandler(this.btnUppdateraFeed_Click);
            // 
            // btnLaggTillFeed
            // 
            this.btnLaggTillFeed.Location = new System.Drawing.Point(8, 482);
            this.btnLaggTillFeed.Margin = new System.Windows.Forms.Padding(4);
            this.btnLaggTillFeed.Name = "btnLaggTillFeed";
            this.btnLaggTillFeed.Size = new System.Drawing.Size(89, 28);
            this.btnLaggTillFeed.TabIndex = 1;
            this.btnLaggTillFeed.Text = "Lägg Till";
            this.btnLaggTillFeed.UseVisualStyleBackColor = true;
            this.btnLaggTillFeed.Click += new System.EventHandler(this.btnLaggTillFeed_Click);
            // 
            // gbAvsnitt
            // 
            this.gbAvsnitt.Controls.Add(this.label1);
            this.gbAvsnitt.Controls.Add(this.label2);
            this.gbAvsnitt.Controls.Add(this.tbxBeskrivning);
            this.gbAvsnitt.Controls.Add(this.cbbAvsnitt);
            this.gbAvsnitt.Location = new System.Drawing.Point(734, 13);
            this.gbAvsnitt.Margin = new System.Windows.Forms.Padding(4);
            this.gbAvsnitt.Name = "gbAvsnitt";
            this.gbAvsnitt.Padding = new System.Windows.Forms.Padding(4);
            this.gbAvsnitt.Size = new System.Drawing.Size(297, 518);
            this.gbAvsnitt.TabIndex = 4;
            this.gbAvsnitt.TabStop = false;
            this.gbAvsnitt.Text = "Avsnitt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 488);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Powered by";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 476);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 34);
            this.label2.TabIndex = 7;
            this.label2.Text = "Group 23";
            // 
            // tbxBeskrivning
            // 
            this.tbxBeskrivning.Location = new System.Drawing.Point(8, 65);
            this.tbxBeskrivning.Multiline = true;
            this.tbxBeskrivning.Name = "tbxBeskrivning";
            this.tbxBeskrivning.Size = new System.Drawing.Size(281, 404);
            this.tbxBeskrivning.TabIndex = 5;
            // 
            // cbbAvsnitt
            // 
            this.cbbAvsnitt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAvsnitt.FormattingEnabled = true;
            this.cbbAvsnitt.Location = new System.Drawing.Point(8, 23);
            this.cbbAvsnitt.Name = "cbbAvsnitt";
            this.cbbAvsnitt.Size = new System.Drawing.Size(281, 24);
            this.cbbAvsnitt.TabIndex = 4;
            this.cbbAvsnitt.SelectedIndexChanged += new System.EventHandler(this.cbbAvsnitt_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 536);
            this.Controls.Add(this.gbAvsnitt);
            this.Controls.Add(this.gbArtikel);
            this.Controls.Add(this.gbKategroi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSS Läsare";
            this.gbKategroi.ResumeLayout(false);
            this.gbArtikel.ResumeLayout(false);
            this.gbAvsnitt.ResumeLayout(false);
            this.gbAvsnitt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKategroi;
        private System.Windows.Forms.Button btnTaBortKategori;
        private System.Windows.Forms.Button btnUppdateraKategori;
        private System.Windows.Forms.Button btnLaggTillKategori;
        private System.Windows.Forms.CheckedListBox clbKategori;
        private System.Windows.Forms.GroupBox gbArtikel;
        private System.Windows.Forms.ListView lvArtikel;
        private System.Windows.Forms.ColumnHeader columnTitel;
        private System.Windows.Forms.ColumnHeader columnAvsnitt;
        private System.Windows.Forms.ColumnHeader columnKategori;
        private System.Windows.Forms.Button btnTaBortFeed;
        private System.Windows.Forms.Button btnUppdateraFeed;
        private System.Windows.Forms.Button btnLaggTillFeed;
        private System.Windows.Forms.GroupBox gbAvsnitt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxBeskrivning;
        private System.Windows.Forms.ComboBox cbbAvsnitt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbKategori;
    }
}

