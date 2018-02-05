namespace UniBibliothek
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entfernenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.abrufeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bücherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genreToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aktionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ausleihenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bearbeitenToolStripMenuItem,
            this.aktionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(631, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hinzufügenToolStripMenuItem,
            this.entfernenToolStripMenuItem,
            this.abrufeToolStripMenuItem});
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.bearbeitenToolStripMenuItem.Text = "Daten";
            this.bearbeitenToolStripMenuItem.Click += new System.EventHandler(this.bearbeitenToolStripMenuItem_Click);
            // 
            // hinzufügenToolStripMenuItem
            // 
            this.hinzufügenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genreToolStripMenuItem,
            this.buchToolStripMenuItem});
            this.hinzufügenToolStripMenuItem.Name = "hinzufügenToolStripMenuItem";
            this.hinzufügenToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.hinzufügenToolStripMenuItem.Text = "Hinzufügen";
            // 
            // genreToolStripMenuItem
            // 
            this.genreToolStripMenuItem.Name = "genreToolStripMenuItem";
            this.genreToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.genreToolStripMenuItem.Text = "Genre";
            // 
            // buchToolStripMenuItem
            // 
            this.buchToolStripMenuItem.Name = "buchToolStripMenuItem";
            this.buchToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.buchToolStripMenuItem.Text = "Buch";
            // 
            // entfernenToolStripMenuItem
            // 
            this.entfernenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genreToolStripMenuItem1,
            this.buchToolStripMenuItem1});
            this.entfernenToolStripMenuItem.Name = "entfernenToolStripMenuItem";
            this.entfernenToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.entfernenToolStripMenuItem.Text = "Entfernen";
            // 
            // genreToolStripMenuItem1
            // 
            this.genreToolStripMenuItem1.Name = "genreToolStripMenuItem1";
            this.genreToolStripMenuItem1.Size = new System.Drawing.Size(123, 26);
            this.genreToolStripMenuItem1.Text = "Genre";
            // 
            // buchToolStripMenuItem1
            // 
            this.buchToolStripMenuItem1.Name = "buchToolStripMenuItem1";
            this.buchToolStripMenuItem1.Size = new System.Drawing.Size(123, 26);
            this.buchToolStripMenuItem1.Text = "Buch";
            // 
            // abrufeToolStripMenuItem
            // 
            this.abrufeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bücherToolStripMenuItem,
            this.genreToolStripMenuItem2});
            this.abrufeToolStripMenuItem.Name = "abrufeToolStripMenuItem";
            this.abrufeToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.abrufeToolStripMenuItem.Text = "Abrufen";
            this.abrufeToolStripMenuItem.Click += new System.EventHandler(this.abrufeToolStripMenuItem_Click);
            // 
            // bücherToolStripMenuItem
            // 
            this.bücherToolStripMenuItem.Name = "bücherToolStripMenuItem";
            this.bücherToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.bücherToolStripMenuItem.Text = "Bücher";
            // 
            // genreToolStripMenuItem2
            // 
            this.genreToolStripMenuItem2.Name = "genreToolStripMenuItem2";
            this.genreToolStripMenuItem2.Size = new System.Drawing.Size(181, 26);
            this.genreToolStripMenuItem2.Text = "Genre";
            // 
            // aktionToolStripMenuItem
            // 
            this.aktionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ausleihenToolStripMenuItem});
            this.aktionToolStripMenuItem.Name = "aktionToolStripMenuItem";
            this.aktionToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aktionToolStripMenuItem.Text = "Aktion";
            // 
            // ausleihenToolStripMenuItem
            // 
            this.ausleihenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripMenuItem});
            this.ausleihenToolStripMenuItem.Name = "ausleihenToolStripMenuItem";
            this.ausleihenToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.ausleihenToolStripMenuItem.Text = "Ausleihen";
            // 
            // neuToolStripMenuItem
            // 
            this.neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            this.neuToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.neuToolStripMenuItem.Text = "Neu";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 416);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hinzufügenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entfernenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genreToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem abrufeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bücherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genreToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aktionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ausleihenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuToolStripMenuItem;
    }
}

