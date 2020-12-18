namespace NAKAKABOBO
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbltime = new System.Windows.Forms.Label();
            this.txtadd = new System.Windows.Forms.TextBox();
            this.txtmiddle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtlast = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtdate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfirst = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.combostatus = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combomedicine = new System.Windows.Forms.ComboBox();
            this.combogender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.combocondition = new System.Windows.Forms.ComboBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnview = new System.Windows.Forms.Button();
            this.btnload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Maroon;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.Location = new System.Drawing.Point(300, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(903, 485);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Location = new System.Drawing.Point(164, 293);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(44, 17);
            this.lbltime.TabIndex = 31;
            this.lbltime.Text = "TIME";
            // 
            // txtadd
            // 
            this.txtadd.Location = new System.Drawing.Point(159, 219);
            this.txtadd.Multiline = true;
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(145, 56);
            this.txtadd.TabIndex = 5;
            // 
            // txtmiddle
            // 
            this.txtmiddle.Location = new System.Drawing.Point(159, 108);
            this.txtmiddle.Name = "txtmiddle";
            this.txtmiddle.Size = new System.Drawing.Size(145, 24);
            this.txtmiddle.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Middle Name";
            // 
            // txtlast
            // 
            this.txtlast.Location = new System.Drawing.Point(159, 36);
            this.txtlast.Name = "txtlast";
            this.txtlast.Size = new System.Drawing.Size(145, 24);
            this.txtlast.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name";
            // 
            // dtdate
            // 
            this.dtdate.CustomFormat = "MMMM dd, yyyy";
            this.dtdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtdate.Location = new System.Drawing.Point(159, 323);
            this.dtdate.Name = "dtdate";
            this.dtdate.Size = new System.Drawing.Size(143, 24);
            this.dtdate.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Last Name";
            // 
            // txtfirst
            // 
            this.txtfirst.Location = new System.Drawing.Point(159, 71);
            this.txtfirst.Name = "txtfirst";
            this.txtfirst.Size = new System.Drawing.Size(145, 24);
            this.txtfirst.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Contact #";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Time Visited";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 331);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 17);
            this.label12.TabIndex = 23;
            this.label12.Text = "Date Visited";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 374);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Medicine";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 417);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Medical Con.";
            // 
            // txtcontact
            // 
            this.txtcontact.Location = new System.Drawing.Point(159, 181);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(145, 24);
            this.txtcontact.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Status";
            // 
            // combostatus
            // 
            this.combostatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combostatus.FormattingEnabled = true;
            this.combostatus.Items.AddRange(new object[] {
            "Treated",
            "Not Treated",
            "Referred"});
            this.combostatus.Location = new System.Drawing.Point(160, 451);
            this.combostatus.Name = "combostatus";
            this.combostatus.Size = new System.Drawing.Size(143, 25);
            this.combostatus.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.combomedicine);
            this.groupBox1.Controls.Add(this.combogender);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.combocondition);
            this.groupBox1.Controls.Add(this.combostatus);
            this.groupBox1.Controls.Add(this.lbltime);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtadd);
            this.groupBox1.Controls.Add(this.txtcontact);
            this.groupBox1.Controls.Add(this.txtmiddle);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtlast);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtdate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtfirst);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(-10, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 530);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFORMATION HERE!!";
            // 
            // combomedicine
            // 
            this.combomedicine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combomedicine.FormattingEnabled = true;
            this.combomedicine.Items.AddRange(new object[] {
            "Laperamide",
            "Salbutamol",
            "Cetirizine",
            "Hydrite",
            "Hyoscine",
            "Kremil-S",
            "Gel-Macid",
            "Carbocisteine",
            "Butybromid",
            "Ambroxol",
            "Tuseran Forte",
            "Neozeop",
            "Symdex",
            "Mefenamic",
            "AC-Nex-Forte",
            "Paracetamol",
            "Saridon",
            "Kiddilets",
            "Bioflu",
            "Biogesic"});
            this.combomedicine.Location = new System.Drawing.Point(159, 366);
            this.combomedicine.Name = "combomedicine";
            this.combomedicine.Size = new System.Drawing.Size(143, 25);
            this.combomedicine.TabIndex = 35;
            // 
            // combogender
            // 
            this.combogender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combogender.FormattingEnabled = true;
            this.combogender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.combogender.Location = new System.Drawing.Point(159, 143);
            this.combogender.Name = "combogender";
            this.combogender.Size = new System.Drawing.Size(143, 25);
            this.combogender.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Gender";
            // 
            // combocondition
            // 
            this.combocondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combocondition.FormattingEnabled = true;
            this.combocondition.Items.AddRange(new object[] {
            "COUGH",
            "FEVER",
            "DIARRHEA",
            "COLD",
            "DYSMENORHEA",
            "STOMACH ACHE",
            "HEAD ACHE"});
            this.combocondition.Location = new System.Drawing.Point(159, 409);
            this.combocondition.Name = "combocondition";
            this.combocondition.Size = new System.Drawing.Size(143, 25);
            this.combocondition.TabIndex = 8;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(89, 9);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(213, 22);
            this.txtsearch.TabIndex = 35;
            this.txtsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            this.txtsearch.Enter += new System.EventHandler(this.txtsearch_Enter);
            this.txtsearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsearch_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(11, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "SEARCH";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Teal;
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.Black;
            this.btnupdate.Location = new System.Drawing.Point(308, 528);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(311, 40);
            this.btnupdate.TabIndex = 31;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.Color.Teal;
            this.btnview.FlatAppearance.BorderSize = 0;
            this.btnview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.ForeColor = System.Drawing.Color.White;
            this.btnview.Location = new System.Drawing.Point(1119, 8);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(84, 25);
            this.btnview.TabIndex = 37;
            this.btnview.Text = "VIEW ALL";
            this.btnview.UseVisualStyleBackColor = false;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // btnload
            // 
            this.btnload.BackColor = System.Drawing.Color.Teal;
            this.btnload.FlatAppearance.BorderSize = 0;
            this.btnload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnload.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnload.ForeColor = System.Drawing.Color.Black;
            this.btnload.Location = new System.Drawing.Point(634, 527);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(309, 40);
            this.btnload.TabIndex = 38;
            this.btnload.Text = "REFRESH";
            this.btnload.UseVisualStyleBackColor = false;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1205, 572);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient\'s List";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.TextBox txtadd;
        private System.Windows.Forms.TextBox txtmiddle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtlast;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfirst;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combostatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox combocondition;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.ComboBox combogender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.ComboBox combomedicine;
    }
}

