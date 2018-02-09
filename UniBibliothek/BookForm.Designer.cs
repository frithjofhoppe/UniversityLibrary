namespace UniBibliothek
{
    partial class BookForm
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
            this.label15 = new System.Windows.Forms.Label();
            this.txtModifyEdition = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBoxModifyAuthor = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboModifyLocation = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnModifyDelete = new System.Windows.Forms.Button();
            this.listBoxGenreModify = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtSearchPhrase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModifyExemplar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModifyPagination = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModifyISBN = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.Label();
            this.txtModifyName = new System.Windows.Forms.TextBox();
            this.btnModifyModify = new System.Windows.Forms.Button();
            this.listBoxBookModify = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCreateEdition = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.listBoxCreateAuthor = new System.Windows.Forms.ListBox();
            this.comboCreateLocation = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxGenreCreate = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCreatePagination = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCretaeISBN = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCreateName = new System.Windows.Forms.TextBox();
            this.btnCreateBook = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtModifyEdition);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.listBoxModifyAuthor);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.comboModifyLocation);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnModifyDelete);
            this.groupBox1.Controls.Add(this.listBoxGenreModify);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtSearchPhrase);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtModifyExemplar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtModifyPagination);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtModifyISBN);
            this.groupBox1.Controls.Add(this.txtBookName);
            this.groupBox1.Controls.Add(this.txtModifyName);
            this.groupBox1.Controls.Add(this.btnModifyModify);
            this.groupBox1.Controls.Add(this.listBoxBookModify);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1106, 328);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bearbeiten";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(771, 218);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Ausgabe";
            // 
            // txtModifyEdition
            // 
            this.txtModifyEdition.Location = new System.Drawing.Point(841, 214);
            this.txtModifyEdition.Name = "txtModifyEdition";
            this.txtModifyEdition.Size = new System.Drawing.Size(248, 20);
            this.txtModifyEdition.TabIndex = 20;
            this.txtModifyEdition.TextChanged += new System.EventHandler(this.modiyTextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(493, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Autor/en";
            // 
            // listBoxModifyAuthor
            // 
            this.listBoxModifyAuthor.FormattingEnabled = true;
            this.listBoxModifyAuthor.Location = new System.Drawing.Point(496, 46);
            this.listBoxModifyAuthor.Name = "listBoxModifyAuthor";
            this.listBoxModifyAuthor.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxModifyAuthor.Size = new System.Drawing.Size(213, 147);
            this.listBoxModifyAuthor.TabIndex = 18;
            this.listBoxModifyAuthor.SelectedValueChanged += new System.EventHandler(this.modifyListBox);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(771, 257);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Standort";
            // 
            // comboModifyLocation
            // 
            this.comboModifyLocation.FormattingEnabled = true;
            this.comboModifyLocation.Location = new System.Drawing.Point(841, 252);
            this.comboModifyLocation.Name = "comboModifyLocation";
            this.comboModifyLocation.Size = new System.Drawing.Size(248, 21);
            this.comboModifyLocation.TabIndex = 16;
            this.comboModifyLocation.SelectedValueChanged += new System.EventHandler(this.modiyTextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Genre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Buch-Exemplar";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnModifyDelete
            // 
            this.btnModifyDelete.Location = new System.Drawing.Point(930, 283);
            this.btnModifyDelete.Name = "btnModifyDelete";
            this.btnModifyDelete.Size = new System.Drawing.Size(75, 23);
            this.btnModifyDelete.TabIndex = 13;
            this.btnModifyDelete.Text = "Löschen";
            this.btnModifyDelete.UseVisualStyleBackColor = true;
            this.btnModifyDelete.Click += new System.EventHandler(this.btnModifyDelete_Click);
            // 
            // listBoxGenreModify
            // 
            this.listBoxGenreModify.FormattingEnabled = true;
            this.listBoxGenreModify.Location = new System.Drawing.Point(251, 46);
            this.listBoxGenreModify.Name = "listBoxGenreModify";
            this.listBoxGenreModify.Size = new System.Drawing.Size(213, 147);
            this.listBoxGenreModify.TabIndex = 12;
            this.listBoxGenreModify.SelectedValueChanged += new System.EventHandler(this.modifyListBox);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Suchen";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtSearchPhrase
            // 
            this.txtSearchPhrase.Location = new System.Drawing.Point(7, 199);
            this.txtSearchPhrase.Name = "txtSearchPhrase";
            this.txtSearchPhrase.Size = new System.Drawing.Size(213, 20);
            this.txtSearchPhrase.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(771, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Exemplar";
            // 
            // txtModifyExemplar
            // 
            this.txtModifyExemplar.Location = new System.Drawing.Point(841, 175);
            this.txtModifyExemplar.Name = "txtModifyExemplar";
            this.txtModifyExemplar.ReadOnly = true;
            this.txtModifyExemplar.Size = new System.Drawing.Size(248, 20);
            this.txtModifyExemplar.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(771, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Seiten";
            // 
            // txtModifyPagination
            // 
            this.txtModifyPagination.Location = new System.Drawing.Point(841, 130);
            this.txtModifyPagination.Name = "txtModifyPagination";
            this.txtModifyPagination.Size = new System.Drawing.Size(248, 20);
            this.txtModifyPagination.TabIndex = 6;
            this.txtModifyPagination.TextChanged += new System.EventHandler(this.modiyTextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(771, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ISBN";
            // 
            // txtModifyISBN
            // 
            this.txtModifyISBN.Location = new System.Drawing.Point(841, 86);
            this.txtModifyISBN.Name = "txtModifyISBN";
            this.txtModifyISBN.Size = new System.Drawing.Size(248, 20);
            this.txtModifyISBN.TabIndex = 4;
            this.txtModifyISBN.TextChanged += new System.EventHandler(this.modiyTextChanged);
            // 
            // txtBookName
            // 
            this.txtBookName.AutoSize = true;
            this.txtBookName.Location = new System.Drawing.Point(771, 46);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(35, 13);
            this.txtBookName.TabIndex = 3;
            this.txtBookName.Text = "Name";
            // 
            // txtModifyName
            // 
            this.txtModifyName.Location = new System.Drawing.Point(841, 43);
            this.txtModifyName.Name = "txtModifyName";
            this.txtModifyName.Size = new System.Drawing.Size(248, 20);
            this.txtModifyName.TabIndex = 2;
            this.txtModifyName.TextChanged += new System.EventHandler(this.modiyTextChanged);
            // 
            // btnModifyModify
            // 
            this.btnModifyModify.Location = new System.Drawing.Point(1011, 283);
            this.btnModifyModify.Name = "btnModifyModify";
            this.btnModifyModify.Size = new System.Drawing.Size(75, 23);
            this.btnModifyModify.TabIndex = 1;
            this.btnModifyModify.Text = "Ändern";
            this.btnModifyModify.UseVisualStyleBackColor = true;
            this.btnModifyModify.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxBookModify
            // 
            this.listBoxBookModify.FormattingEnabled = true;
            this.listBoxBookModify.Location = new System.Drawing.Point(7, 46);
            this.listBoxBookModify.Name = "listBoxBookModify";
            this.listBoxBookModify.Size = new System.Drawing.Size(213, 147);
            this.listBoxBookModify.TabIndex = 0;
            this.listBoxBookModify.SelectedIndexChanged += new System.EventHandler(this.listBoxBookModify_SelectedIndexChanged);
            this.listBoxBookModify.SelectedValueChanged += new System.EventHandler(this.listBoxBookModify_SelectedValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtCreateEdition);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.listBoxCreateAuthor);
            this.groupBox2.Controls.Add(this.comboCreateLocation);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.listBoxGenreCreate);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtCreatePagination);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtCretaeISBN);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtCreateName);
            this.groupBox2.Controls.Add(this.btnCreateBook);
            this.groupBox2.Location = new System.Drawing.Point(12, 347);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1105, 280);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Erstellen";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(768, 171);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Auflage";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtCreateEdition
            // 
            this.txtCreateEdition.Location = new System.Drawing.Point(838, 168);
            this.txtCreateEdition.Name = "txtCreateEdition";
            this.txtCreateEdition.Size = new System.Drawing.Size(248, 20);
            this.txtCreateEdition.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(248, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Autor/en";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(768, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Standort";
            // 
            // listBoxCreateAuthor
            // 
            this.listBoxCreateAuthor.FormattingEnabled = true;
            this.listBoxCreateAuthor.Location = new System.Drawing.Point(251, 50);
            this.listBoxCreateAuthor.Name = "listBoxCreateAuthor";
            this.listBoxCreateAuthor.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxCreateAuthor.Size = new System.Drawing.Size(213, 147);
            this.listBoxCreateAuthor.TabIndex = 20;
            // 
            // comboCreateLocation
            // 
            this.comboCreateLocation.FormattingEnabled = true;
            this.comboCreateLocation.Location = new System.Drawing.Point(838, 211);
            this.comboCreateLocation.Name = "comboCreateLocation";
            this.comboCreateLocation.Size = new System.Drawing.Size(248, 21);
            this.comboCreateLocation.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Genre";
            // 
            // listBoxGenreCreate
            // 
            this.listBoxGenreCreate.FormattingEnabled = true;
            this.listBoxGenreCreate.Location = new System.Drawing.Point(9, 53);
            this.listBoxGenreCreate.Name = "listBoxGenreCreate";
            this.listBoxGenreCreate.Size = new System.Drawing.Size(213, 147);
            this.listBoxGenreCreate.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(768, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Seiten";
            // 
            // txtCreatePagination
            // 
            this.txtCreatePagination.Location = new System.Drawing.Point(838, 128);
            this.txtCreatePagination.Name = "txtCreatePagination";
            this.txtCreatePagination.Size = new System.Drawing.Size(248, 20);
            this.txtCreatePagination.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(768, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "ISBN";
            // 
            // txtCretaeISBN
            // 
            this.txtCretaeISBN.Location = new System.Drawing.Point(838, 84);
            this.txtCretaeISBN.Name = "txtCretaeISBN";
            this.txtCretaeISBN.Size = new System.Drawing.Size(248, 20);
            this.txtCretaeISBN.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(768, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Name";
            // 
            // txtCreateName
            // 
            this.txtCreateName.Location = new System.Drawing.Point(838, 41);
            this.txtCreateName.Name = "txtCreateName";
            this.txtCreateName.Size = new System.Drawing.Size(248, 20);
            this.txtCreateName.TabIndex = 17;
            // 
            // btnCreateBook
            // 
            this.btnCreateBook.Location = new System.Drawing.Point(1011, 238);
            this.btnCreateBook.Name = "btnCreateBook";
            this.btnCreateBook.Size = new System.Drawing.Size(75, 23);
            this.btnCreateBook.TabIndex = 16;
            this.btnCreateBook.Text = "Erstellen";
            this.btnCreateBook.UseVisualStyleBackColor = true;
            this.btnCreateBook.Click += new System.EventHandler(this.button5_Click);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 638);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buch - Verwaltung";
            this.Load += new System.EventHandler(this.BookForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtSearchPhrase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModifyExemplar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModifyPagination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModifyISBN;
        private System.Windows.Forms.Label txtBookName;
        private System.Windows.Forms.TextBox txtModifyName;
        private System.Windows.Forms.Button btnModifyModify;
        private System.Windows.Forms.ListBox listBoxBookModify;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnModifyDelete;
        private System.Windows.Forms.ListBox listBoxGenreModify;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxGenreCreate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCreatePagination;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCretaeISBN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCreateName;
        private System.Windows.Forms.Button btnCreateBook;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboModifyLocation;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboCreateLocation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBoxModifyAuthor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox listBoxCreateAuthor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCreateEdition;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtModifyEdition;
    }
}