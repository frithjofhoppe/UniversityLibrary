namespace UniBibliothek
{
    partial class MemberForm
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModifySemester = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModifyLastname = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.Label();
            this.txtModifyFirstname = new System.Windows.Forms.TextBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtModifyFaculty = new System.Windows.Forms.TextBox();
            this.listBoxMember = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCreateFaculty = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtCreateFirstname = new System.Windows.Forms.TextBox();
            this.txtCreateSemester = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCreateLastname = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(444, 188);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Löschen";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Semester";
            // 
            // txtModifySemester
            // 
            this.txtModifySemester.Location = new System.Drawing.Point(353, 112);
            this.txtModifySemester.Name = "txtModifySemester";
            this.txtModifySemester.Size = new System.Drawing.Size(248, 20);
            this.txtModifySemester.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nachname";
            // 
            // txtModifyLastname
            // 
            this.txtModifyLastname.Location = new System.Drawing.Point(353, 68);
            this.txtModifyLastname.Name = "txtModifyLastname";
            this.txtModifyLastname.Size = new System.Drawing.Size(248, 20);
            this.txtModifyLastname.TabIndex = 2;
            // 
            // txtBookName
            // 
            this.txtBookName.AutoSize = true;
            this.txtBookName.Location = new System.Drawing.Point(284, 28);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(49, 13);
            this.txtBookName.TabIndex = 24;
            this.txtBookName.Text = "Vorname";
            // 
            // txtModifyFirstname
            // 
            this.txtModifyFirstname.Location = new System.Drawing.Point(353, 25);
            this.txtModifyFirstname.Name = "txtModifyFirstname";
            this.txtModifyFirstname.Size = new System.Drawing.Size(248, 20);
            this.txtModifyFirstname.TabIndex = 1;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(525, 188);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 6;
            this.btnModify.Text = "Ändern";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtModifyFaculty);
            this.groupBox1.Controls.Add(this.listBoxMember);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnModify);
            this.groupBox1.Controls.Add(this.txtModifyFirstname);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtBookName);
            this.groupBox1.Controls.Add(this.txtModifyLastname);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtModifySemester);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(611, 231);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bearbeiten";
            // 
            // txtModifyFaculty
            // 
            this.txtModifyFaculty.Location = new System.Drawing.Point(353, 159);
            this.txtModifyFaculty.Name = "txtModifyFaculty";
            this.txtModifyFaculty.Size = new System.Drawing.Size(248, 20);
            this.txtModifyFaculty.TabIndex = 4;
            // 
            // listBoxMember
            // 
            this.listBoxMember.FormattingEnabled = true;
            this.listBoxMember.Location = new System.Drawing.Point(20, 36);
            this.listBoxMember.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxMember.Name = "listBoxMember";
            this.listBoxMember.Size = new System.Drawing.Size(188, 173);
            this.listBoxMember.TabIndex = 36;
            this.listBoxMember.SelectedIndexChanged += new System.EventHandler(this.listBoxMember_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Mitglied";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(284, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Fakultät";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCreateFaculty);
            this.groupBox2.Controls.Add(this.btnCreate);
            this.groupBox2.Controls.Add(this.txtCreateFirstname);
            this.groupBox2.Controls.Add(this.txtCreateSemester);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtCreateLastname);
            this.groupBox2.Location = new System.Drawing.Point(9, 246);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(611, 222);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Erstellen";
            // 
            // txtCreateFaculty
            // 
            this.txtCreateFaculty.Location = new System.Drawing.Point(353, 156);
            this.txtCreateFaculty.Name = "txtCreateFaculty";
            this.txtCreateFaculty.Size = new System.Drawing.Size(248, 20);
            this.txtCreateFaculty.TabIndex = 4;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(531, 193);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Erstellen";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtCreateFirstname
            // 
            this.txtCreateFirstname.Location = new System.Drawing.Point(353, 24);
            this.txtCreateFirstname.Name = "txtCreateFirstname";
            this.txtCreateFirstname.Size = new System.Drawing.Size(248, 20);
            this.txtCreateFirstname.TabIndex = 1;
            // 
            // txtCreateSemester
            // 
            this.txtCreateSemester.Location = new System.Drawing.Point(353, 111);
            this.txtCreateSemester.Name = "txtCreateSemester";
            this.txtCreateSemester.Size = new System.Drawing.Size(248, 20);
            this.txtCreateSemester.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Fakultät";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(284, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Semester";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Vorname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Nachname";
            // 
            // txtCreateLastname
            // 
            this.txtCreateLastname.Location = new System.Drawing.Point(353, 67);
            this.txtCreateLastname.Name = "txtCreateLastname";
            this.txtCreateLastname.Size = new System.Drawing.Size(248, 20);
            this.txtCreateLastname.TabIndex = 2;
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 479);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mitglied - Verwaltung";
            this.Load += new System.EventHandler(this.MemberForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModifySemester;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModifyLastname;
        private System.Windows.Forms.Label txtBookName;
        private System.Windows.Forms.TextBox txtModifyFirstname;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtCreateFirstname;
        private System.Windows.Forms.TextBox txtCreateSemester;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCreateLastname;
        private System.Windows.Forms.ListBox listBoxMember;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtModifyFaculty;
        private System.Windows.Forms.TextBox txtCreateFaculty;
    }
}