namespace UniBibliothek
{
    partial class AuthorForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnModifyEntry = new System.Windows.Forms.Button();
            this.btnDeleteEntry = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModfiyAge = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.Label();
            this.txtModifyName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtSearchPhrase = new System.Windows.Forms.TextBox();
            this.listBoxModifyAuthor = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCreateEntry = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCreateAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCreateName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnModifyEntry);
            this.groupBox1.Controls.Add(this.btnDeleteEntry);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtModfiyAge);
            this.groupBox1.Controls.Add(this.txtBookName);
            this.groupBox1.Controls.Add(this.txtModifyName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtSearchPhrase);
            this.groupBox1.Controls.Add(this.listBoxModifyAuthor);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(755, 324);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bearbeiten";
            // 
            // btnModifyEntry
            // 
            this.btnModifyEntry.Location = new System.Drawing.Point(568, 219);
            this.btnModifyEntry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModifyEntry.Name = "btnModifyEntry";
            this.btnModifyEntry.Size = new System.Drawing.Size(169, 28);
            this.btnModifyEntry.TabIndex = 27;
            this.btnModifyEntry.Text = "Bearbeiten";
            this.btnModifyEntry.UseVisualStyleBackColor = true;
            // 
            // btnDeleteEntry
            // 
            this.btnDeleteEntry.Location = new System.Drawing.Point(407, 219);
            this.btnDeleteEntry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteEntry.Name = "btnDeleteEntry";
            this.btnDeleteEntry.Size = new System.Drawing.Size(153, 28);
            this.btnDeleteEntry.TabIndex = 26;
            this.btnDeleteEntry.Text = "Löschen";
            this.btnDeleteEntry.UseVisualStyleBackColor = true;
            this.btnDeleteEntry.Click += new System.EventHandler(this.btnDeleteEntry_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 180);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Alter";
            // 
            // txtModfiyAge
            // 
            this.txtModfiyAge.Location = new System.Drawing.Point(407, 176);
            this.txtModfiyAge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtModfiyAge.Name = "txtModfiyAge";
            this.txtModfiyAge.Size = new System.Drawing.Size(329, 22);
            this.txtModfiyAge.TabIndex = 24;
            // 
            // txtBookName
            // 
            this.txtBookName.AutoSize = true;
            this.txtBookName.Location = new System.Drawing.Point(313, 127);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(65, 17);
            this.txtBookName.TabIndex = 23;
            this.txtBookName.Text = "Vorname";
            // 
            // txtModifyName
            // 
            this.txtModifyName.Location = new System.Drawing.Point(407, 123);
            this.txtModifyName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtModifyName.Name = "txtModifyName";
            this.txtModifyName.Size = new System.Drawing.Size(329, 22);
            this.txtModifyName.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Autor";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 278);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(284, 28);
            this.button2.TabIndex = 17;
            this.button2.Text = "Suchen";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtSearchPhrase
            // 
            this.txtSearchPhrase.Location = new System.Drawing.Point(8, 246);
            this.txtSearchPhrase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchPhrase.Name = "txtSearchPhrase";
            this.txtSearchPhrase.Size = new System.Drawing.Size(283, 22);
            this.txtSearchPhrase.TabIndex = 16;
            // 
            // listBoxModifyAuthor
            // 
            this.listBoxModifyAuthor.FormattingEnabled = true;
            this.listBoxModifyAuthor.ItemHeight = 16;
            this.listBoxModifyAuthor.Location = new System.Drawing.Point(8, 58);
            this.listBoxModifyAuthor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxModifyAuthor.Name = "listBoxModifyAuthor";
            this.listBoxModifyAuthor.Size = new System.Drawing.Size(283, 180);
            this.listBoxModifyAuthor.TabIndex = 15;
            this.listBoxModifyAuthor.SelectedIndexChanged += new System.EventHandler(this.listBoxModifyAuthor_SelectedIndexChanged);
            this.listBoxModifyAuthor.SelectedValueChanged += new System.EventHandler(this.listBoxModifyAuthor_SelectedValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCreateEntry);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtCreateAge);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtCreateName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(16, 346);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(755, 190);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Erstellen";
            // 
            // btnCreateEntry
            // 
            this.btnCreateEntry.Location = new System.Drawing.Point(568, 140);
            this.btnCreateEntry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateEntry.Name = "btnCreateEntry";
            this.btnCreateEntry.Size = new System.Drawing.Size(169, 28);
            this.btnCreateEntry.TabIndex = 27;
            this.btnCreateEntry.Text = "Erstellen";
            this.btnCreateEntry.UseVisualStyleBackColor = true;
            this.btnCreateEntry.Click += new System.EventHandler(this.btnCreateEntry_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Alter";
            // 
            // txtCreateAge
            // 
            this.txtCreateAge.Location = new System.Drawing.Point(407, 108);
            this.txtCreateAge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCreateAge.Name = "txtCreateAge";
            this.txtCreateAge.Size = new System.Drawing.Size(329, 22);
            this.txtCreateAge.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Vorname";
            // 
            // txtCreateName
            // 
            this.txtCreateName.Location = new System.Drawing.Point(407, 55);
            this.txtCreateName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCreateName.Name = "txtCreateName";
            this.txtCreateName.Size = new System.Drawing.Size(329, 22);
            this.txtCreateName.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Autor";
            // 
            // AuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 543);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AuthorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autoren - Verwaltung";
            this.Load += new System.EventHandler(this.AuthorForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtSearchPhrase;
        private System.Windows.Forms.ListBox listBoxModifyAuthor;
        private System.Windows.Forms.Button btnModifyEntry;
        private System.Windows.Forms.Button btnDeleteEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModfiyAge;
        private System.Windows.Forms.Label txtBookName;
        private System.Windows.Forms.TextBox txtModifyName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCreateEntry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCreateAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCreateName;
        private System.Windows.Forms.Label label5;
    }
}