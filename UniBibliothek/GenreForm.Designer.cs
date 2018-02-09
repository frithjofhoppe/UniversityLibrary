namespace UniBibliothek
{
    partial class GenreForm
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
            this.listBoxGenres = new System.Windows.Forms.ListBox();
            this.btnGenreSuchen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBokksAfterGenres = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGenreToCreate = new System.Windows.Forms.TextBox();
            this.createGenre = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxGenres
            // 
            this.listBoxGenres.FormattingEnabled = true;
            this.listBoxGenres.Location = new System.Drawing.Point(15, 32);
            this.listBoxGenres.Name = "listBoxGenres";
            this.listBoxGenres.Size = new System.Drawing.Size(170, 173);
            this.listBoxGenres.TabIndex = 0;
            // 
            // btnGenreSuchen
            // 
            this.btnGenreSuchen.Location = new System.Drawing.Point(15, 211);
            this.btnGenreSuchen.Name = "btnGenreSuchen";
            this.btnGenreSuchen.Size = new System.Drawing.Size(169, 23);
            this.btnGenreSuchen.TabIndex = 1;
            this.btnGenreSuchen.Text = "Bücher abrufen";
            this.btnGenreSuchen.UseVisualStyleBackColor = true;
            this.btnGenreSuchen.Click += new System.EventHandler(this.btnGenreSuchen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBokksAfterGenres);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listBoxGenres);
            this.groupBox1.Controls.Add(this.btnGenreSuchen);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 248);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Abrufen";
            // 
            // listBokksAfterGenres
            // 
            this.listBokksAfterGenres.FormattingEnabled = true;
            this.listBokksAfterGenres.Location = new System.Drawing.Point(213, 32);
            this.listBokksAfterGenres.Name = "listBokksAfterGenres";
            this.listBokksAfterGenres.Size = new System.Drawing.Size(301, 173);
            this.listBokksAfterGenres.TabIndex = 5;
            this.listBokksAfterGenres.SelectedIndexChanged += new System.EventHandler(this.listBokksAfterGenres_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Buch";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Genre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGenreToCreate);
            this.groupBox2.Controls.Add(this.createGenre);
            this.groupBox2.Location = new System.Drawing.Point(12, 267);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 72);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Erfassen";
            // 
            // txtGenreToCreate
            // 
            this.txtGenreToCreate.Location = new System.Drawing.Point(15, 33);
            this.txtGenreToCreate.Name = "txtGenreToCreate";
            this.txtGenreToCreate.Size = new System.Drawing.Size(169, 20);
            this.txtGenreToCreate.TabIndex = 1;
            // 
            // createGenre
            // 
            this.createGenre.Location = new System.Drawing.Point(213, 33);
            this.createGenre.Name = "createGenre";
            this.createGenre.Size = new System.Drawing.Size(75, 23);
            this.createGenre.TabIndex = 0;
            this.createGenre.Text = "Erstellen";
            this.createGenre.UseVisualStyleBackColor = true;
            this.createGenre.Click += new System.EventHandler(this.button1_Click);
            // 
            // GenreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 359);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GenreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genre - Verwaltung";
            this.Load += new System.EventHandler(this.GenreForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxGenres;
        private System.Windows.Forms.Button btnGenreSuchen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtGenreToCreate;
        private System.Windows.Forms.Button createGenre;
        private System.Windows.Forms.ListBox listBokksAfterGenres;
    }
}