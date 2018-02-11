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
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtCreateFirstname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCreateLastname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCreateSemester = new System.Windows.Forms.TextBox();
            this.listBoxMember = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtModifyFaculty = new System.Windows.Forms.TextBox();
            this.txtCreateFaculty = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(592, 232);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Löschen";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Semester";
            // 
            // txtModifySemester
            // 
            this.txtModifySemester.Location = new System.Drawing.Point(471, 138);
            this.txtModifySemester.Margin = new System.Windows.Forms.Padding(4);
            this.txtModifySemester.Name = "txtModifySemester";
            this.txtModifySemester.Size = new System.Drawing.Size(329, 22);
            this.txtModifySemester.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nachname";
            // 
            // txtModifyLastname
            // 
            this.txtModifyLastname.Location = new System.Drawing.Point(471, 84);
            this.txtModifyLastname.Margin = new System.Windows.Forms.Padding(4);
            this.txtModifyLastname.Name = "txtModifyLastname";
            this.txtModifyLastname.Size = new System.Drawing.Size(329, 22);
            this.txtModifyLastname.TabIndex = 25;
            // 
            // txtBookName
            // 
            this.txtBookName.AutoSize = true;
            this.txtBookName.Location = new System.Drawing.Point(378, 35);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(65, 17);
            this.txtBookName.TabIndex = 24;
            this.txtBookName.Text = "Vorname";
            // 
            // txtModifyFirstname
            // 
            this.txtModifyFirstname.Location = new System.Drawing.Point(471, 31);
            this.txtModifyFirstname.Margin = new System.Windows.Forms.Padding(4);
            this.txtModifyFirstname.Name = "txtModifyFirstname";
            this.txtModifyFirstname.Size = new System.Drawing.Size(329, 22);
            this.txtModifyFirstname.TabIndex = 23;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(700, 232);
            this.btnModify.Margin = new System.Windows.Forms.Padding(4);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(100, 28);
            this.btnModify.TabIndex = 22;
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(815, 284);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bearbeiten";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Mitglied";
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
            this.groupBox2.Location = new System.Drawing.Point(12, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(815, 273);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Erstellen";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(708, 238);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 28);
            this.btnCreate.TabIndex = 36;
            this.btnCreate.Text = "Erstellen";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtCreateFirstname
            // 
            this.txtCreateFirstname.Location = new System.Drawing.Point(471, 30);
            this.txtCreateFirstname.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreateFirstname.Name = "txtCreateFirstname";
            this.txtCreateFirstname.Size = new System.Drawing.Size(329, 22);
            this.txtCreateFirstname.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Vorname";
            // 
            // txtCreateLastname
            // 
            this.txtCreateLastname.Location = new System.Drawing.Point(471, 83);
            this.txtCreateLastname.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreateLastname.Name = "txtCreateLastname";
            this.txtCreateLastname.Size = new System.Drawing.Size(329, 22);
            this.txtCreateLastname.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(378, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 40;
            this.label6.Text = "Nachname";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(378, 141);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 42;
            this.label7.Text = "Semester";
            // 
            // txtCreateSemester
            // 
            this.txtCreateSemester.Location = new System.Drawing.Point(471, 137);
            this.txtCreateSemester.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreateSemester.Name = "txtCreateSemester";
            this.txtCreateSemester.Size = new System.Drawing.Size(329, 22);
            this.txtCreateSemester.TabIndex = 41;
            // 
            // listBoxMember
            // 
            this.listBoxMember.FormattingEnabled = true;
            this.listBoxMember.ItemHeight = 16;
            this.listBoxMember.Location = new System.Drawing.Point(26, 44);
            this.listBoxMember.Name = "listBoxMember";
            this.listBoxMember.Size = new System.Drawing.Size(250, 212);
            this.listBoxMember.TabIndex = 36;
            this.listBoxMember.SelectedIndexChanged += new System.EventHandler(this.listBoxMember_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 195);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 45;
            this.label4.Text = "Fakultät";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(378, 196);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 17);
            this.label12.TabIndex = 33;
            this.label12.Text = "Fakultät";
            // 
            // txtModifyFaculty
            // 
            this.txtModifyFaculty.Location = new System.Drawing.Point(471, 196);
            this.txtModifyFaculty.Margin = new System.Windows.Forms.Padding(4);
            this.txtModifyFaculty.Name = "txtModifyFaculty";
            this.txtModifyFaculty.Size = new System.Drawing.Size(329, 22);
            this.txtModifyFaculty.TabIndex = 37;
            // 
            // txtCreateFaculty
            // 
            this.txtCreateFaculty.Location = new System.Drawing.Point(471, 192);
            this.txtCreateFaculty.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreateFaculty.Name = "txtCreateFaculty";
            this.txtCreateFaculty.Size = new System.Drawing.Size(329, 22);
            this.txtCreateFaculty.TabIndex = 38;
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 589);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MemberForm";
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