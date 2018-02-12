namespace UniBibliothek
{
    partial class LendingModify
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
            this.groupBoxDateTimes = new System.Windows.Forms.GroupBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMemberSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMemberSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxMembers = new System.Windows.Forms.ListBox();
            this.listBoxExemplars = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBoxDateTimes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDateTimes
            // 
            this.groupBoxDateTimes.Controls.Add(this.btnDelete);
            this.groupBoxDateTimes.Controls.Add(this.btnModify);
            this.groupBoxDateTimes.Controls.Add(this.label6);
            this.groupBoxDateTimes.Controls.Add(this.dateTimePickerTo);
            this.groupBoxDateTimes.Controls.Add(this.label5);
            this.groupBoxDateTimes.Controls.Add(this.dateTimePickerFrom);
            this.groupBoxDateTimes.Location = new System.Drawing.Point(12, 331);
            this.groupBoxDateTimes.Name = "groupBoxDateTimes";
            this.groupBoxDateTimes.Size = new System.Drawing.Size(713, 147);
            this.groupBoxDateTimes.TabIndex = 8;
            this.groupBoxDateTimes.TabStop = false;
            this.groupBoxDateTimes.Text = "Daten";
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(568, 110);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(124, 23);
            this.btnModify.TabIndex = 4;
            this.btnModify.Text = "Bearbeiten";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Bis";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(445, 73);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(248, 20);
            this.dateTimePickerTo.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Von";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(445, 34);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(248, 20);
            this.dateTimePickerFrom.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMemberSearch);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.listBoxExemplars);
            this.groupBox1.Controls.Add(this.textBoxMemberSearch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listBoxMembers);
            this.groupBox1.Location = new System.Drawing.Point(11, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 302);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auswahl";
            // 
            // btnMemberSearch
            // 
            this.btnMemberSearch.Location = new System.Drawing.Point(72, 261);
            this.btnMemberSearch.Name = "btnMemberSearch";
            this.btnMemberSearch.Size = new System.Drawing.Size(248, 23);
            this.btnMemberSearch.TabIndex = 11;
            this.btnMemberSearch.Text = "Suchen";
            this.btnMemberSearch.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Suche";
            // 
            // textBoxMemberSearch
            // 
            this.textBoxMemberSearch.Location = new System.Drawing.Point(72, 234);
            this.textBoxMemberSearch.Name = "textBoxMemberSearch";
            this.textBoxMemberSearch.Size = new System.Drawing.Size(248, 20);
            this.textBoxMemberSearch.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ausgeliehen\r\nExemplare";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mitglied";
            // 
            // listBoxMembers
            // 
            this.listBoxMembers.FormattingEnabled = true;
            this.listBoxMembers.Location = new System.Drawing.Point(72, 26);
            this.listBoxMembers.Name = "listBoxMembers";
            this.listBoxMembers.Size = new System.Drawing.Size(248, 199);
            this.listBoxMembers.TabIndex = 1;
            this.listBoxMembers.SelectedValueChanged += new System.EventHandler(this.listBoxMembers_SelectedValueChanged);
            // 
            // listBoxExemplars
            // 
            this.listBoxExemplars.FormattingEnabled = true;
            this.listBoxExemplars.Location = new System.Drawing.Point(428, 26);
            this.listBoxExemplars.Name = "listBoxExemplars";
            this.listBoxExemplars.Size = new System.Drawing.Size(248, 199);
            this.listBoxExemplars.TabIndex = 0;
            this.listBoxExemplars.SelectedValueChanged += new System.EventHandler(this.listBoxExemplars_SelectedValueChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(445, 110);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Löschen";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // LendingModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 492);
            this.Controls.Add(this.groupBoxDateTimes);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LendingModify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LendingModify";
            this.Load += new System.EventHandler(this.LendingModify_Load);
            this.groupBoxDateTimes.ResumeLayout(false);
            this.groupBoxDateTimes.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDateTimes;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMemberSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMemberSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxMembers;
        private System.Windows.Forms.ListBox listBoxExemplars;
        private System.Windows.Forms.Button btnDelete;
    }
}