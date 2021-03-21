namespace NAKAKABOBO
{
    partial class OldPatient
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnfind = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.combogender = new System.Windows.Forms.ComboBox();
            this.txtadd = new System.Windows.Forms.TextBox();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.txtmiddle = new System.Windows.Forms.TextBox();
            this.txtfirst = new System.Windows.Forms.TextBox();
            this.txtlast = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtdate = new System.Windows.Forms.DateTimePicker();
            this.combomedicine = new System.Windows.Forms.ComboBox();
            this.combostatus = new System.Windows.Forms.ComboBox();
            this.combocondition = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnsumbit = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.btnfind);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 63);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Name";
            // 
            // btnfind
            // 
            this.btnfind.Location = new System.Drawing.Point(273, 20);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(88, 26);
            this.btnfind.TabIndex = 2;
            this.btnfind.Text = "FIND";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Silver;
            this.textBox2.Location = new System.Drawing.Point(95, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 23);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "First Name";
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Silver;
            this.textBox1.Location = new System.Drawing.Point(95, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Last Name";
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.txtid);
            this.groupBox2.Controls.Add(this.combogender);
            this.groupBox2.Controls.Add(this.txtadd);
            this.groupBox2.Controls.Add(this.txtcontact);
            this.groupBox2.Controls.Add(this.txtmiddle);
            this.groupBox2.Controls.Add(this.txtfirst);
            this.groupBox2.Controls.Add(this.txtlast);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 261);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(176, -4);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(10, 22);
            this.txtid.TabIndex = 12;
            this.txtid.Visible = false;
            // 
            // combogender
            // 
            this.combogender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combogender.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combogender.FormattingEnabled = true;
            this.combogender.Items.AddRange(new object[] {
            "<Select Gender>",
            "MALE",
            "FEMALE"});
            this.combogender.Location = new System.Drawing.Point(171, 118);
            this.combogender.Name = "combogender";
            this.combogender.Size = new System.Drawing.Size(172, 24);
            this.combogender.TabIndex = 11;
            // 
            // txtadd
            // 
            this.txtadd.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadd.Location = new System.Drawing.Point(171, 190);
            this.txtadd.Multiline = true;
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(172, 58);
            this.txtadd.TabIndex = 10;
            // 
            // txtcontact
            // 
            this.txtcontact.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontact.Location = new System.Drawing.Point(171, 154);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(172, 22);
            this.txtcontact.TabIndex = 9;
            // 
            // txtmiddle
            // 
            this.txtmiddle.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmiddle.Location = new System.Drawing.Point(171, 83);
            this.txtmiddle.Name = "txtmiddle";
            this.txtmiddle.Size = new System.Drawing.Size(172, 22);
            this.txtmiddle.TabIndex = 8;
            // 
            // txtfirst
            // 
            this.txtfirst.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfirst.Location = new System.Drawing.Point(171, 48);
            this.txtfirst.Name = "txtfirst";
            this.txtfirst.Size = new System.Drawing.Size(172, 22);
            this.txtfirst.TabIndex = 7;
            // 
            // txtlast
            // 
            this.txtlast.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlast.Location = new System.Drawing.Point(171, 17);
            this.txtlast.Name = "txtlast";
            this.txtlast.Size = new System.Drawing.Size(172, 22);
            this.txtlast.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contact Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Middle Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Last Name:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Silver;
            this.groupBox3.Controls.Add(this.dtdate);
            this.groupBox3.Controls.Add(this.combomedicine);
            this.groupBox3.Controls.Add(this.combostatus);
            this.groupBox3.Controls.Add(this.combocondition);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.btnsumbit);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(6, 333);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(368, 279);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // dtdate
            // 
            this.dtdate.CustomFormat = "MMMM dd, yyyy";
            this.dtdate.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtdate.Location = new System.Drawing.Point(171, 57);
            this.dtdate.Name = "dtdate";
            this.dtdate.Size = new System.Drawing.Size(183, 22);
            this.dtdate.TabIndex = 23;
            // 
            // combomedicine
            // 
            this.combomedicine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combomedicine.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combomedicine.FormattingEnabled = true;
            this.combomedicine.Items.AddRange(new object[] {
            "<Select Medicine>",
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
            this.combomedicine.Location = new System.Drawing.Point(171, 97);
            this.combomedicine.Name = "combomedicine";
            this.combomedicine.Size = new System.Drawing.Size(172, 24);
            this.combomedicine.TabIndex = 22;
            // 
            // combostatus
            // 
            this.combostatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combostatus.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combostatus.FormattingEnabled = true;
            this.combostatus.Items.AddRange(new object[] {
            "<Select Status>",
            "Treated",
            "Not Treated",
            "Referred"});
            this.combostatus.Location = new System.Drawing.Point(171, 176);
            this.combostatus.Name = "combostatus";
            this.combostatus.Size = new System.Drawing.Size(172, 24);
            this.combostatus.TabIndex = 21;
            this.combostatus.SelectedIndexChanged += new System.EventHandler(this.combostatus_SelectedIndexChanged);
            // 
            // combocondition
            // 
            this.combocondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combocondition.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combocondition.FormattingEnabled = true;
            this.combocondition.Items.AddRange(new object[] {
            "<Select Condition>",
            "COUGH",
            "FEVER",
            "DIARRHEA",
            "COLD",
            "DYSMENORHEA",
            "STOMACH ACHE",
            "HEAD ACHE",
            "MIGRAINE"});
            this.combocondition.Location = new System.Drawing.Point(182, 136);
            this.combocondition.Name = "combocondition";
            this.combocondition.Size = new System.Drawing.Size(172, 24);
            this.combocondition.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(168, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 16);
            this.label13.TabIndex = 20;
            this.label13.Text = "TIME";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::NAKAKABOBO.Properties.Resources.delete_40px;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(263, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 54);
            this.button2.TabIndex = 19;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnsumbit
            // 
            this.btnsumbit.BackColor = System.Drawing.Color.Transparent;
            this.btnsumbit.BackgroundImage = global::NAKAKABOBO.Properties.Resources.plus_40px;
            this.btnsumbit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsumbit.FlatAppearance.BorderSize = 0;
            this.btnsumbit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnsumbit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnsumbit.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsumbit.Location = new System.Drawing.Point(170, 212);
            this.btnsumbit.Name = "btnsumbit";
            this.btnsumbit.Size = new System.Drawing.Size(71, 54);
            this.btnsumbit.TabIndex = 18;
            this.btnsumbit.UseVisualStyleBackColor = false;
            this.btnsumbit.Click += new System.EventHandler(this.btnsumbit_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Status:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Medical Condition:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Medicine:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Date Visited:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Time Visited:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // OldPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(382, 619);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OldPatient";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox combogender;
        private System.Windows.Forms.TextBox txtadd;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.TextBox txtmiddle;
        private System.Windows.Forms.TextBox txtfirst;
        private System.Windows.Forms.TextBox txtlast;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnsumbit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combomedicine;
        private System.Windows.Forms.ComboBox combostatus;
        private System.Windows.Forms.ComboBox combocondition;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dtdate;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtid;
    }
}