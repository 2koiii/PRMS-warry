namespace NAKAKABOBO
{
    partial class MAINPAGE
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
            this.lbltime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnstats = new System.Windows.Forms.Button();
            this.btnhistory = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.Color.Black;
            this.lbltime.Location = new System.Drawing.Point(69, 200);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(48, 18);
            this.lbltime.TabIndex = 4;
            this.lbltime.Text = "TIME";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(81, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(650, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "PATIENT  RECORD MANAGEMENT SYSTEM";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(6, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 134);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Transparent;
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnadd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Image = global::NAKAKABOBO.Properties.Resources.add_user_group_woman_man_48px;
            this.btnadd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnadd.Location = new System.Drawing.Point(14, 26);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(177, 86);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "ADD PATIENT";
            this.btnadd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 61);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = global::NAKAKABOBO.Properties.Resources.business_report_48px1;
            this.button3.Location = new System.Drawing.Point(615, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 101);
            this.button3.TabIndex = 3;
            this.button3.Text = "REPORT";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = global::NAKAKABOBO.Properties.Resources.documents_48px;
            this.button2.Location = new System.Drawing.Point(230, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 122);
            this.button2.TabIndex = 7;
            this.button2.Text = "PATIENT\' S LIST / UPDATE";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnstats
            // 
            this.btnstats.BackColor = System.Drawing.Color.Transparent;
            this.btnstats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnstats.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnstats.FlatAppearance.BorderSize = 0;
            this.btnstats.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnstats.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnstats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstats.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstats.ForeColor = System.Drawing.Color.Black;
            this.btnstats.Image = global::NAKAKABOBO.Properties.Resources.increase_48px;
            this.btnstats.Location = new System.Drawing.Point(630, 78);
            this.btnstats.Name = "btnstats";
            this.btnstats.Size = new System.Drawing.Size(101, 97);
            this.btnstats.TabIndex = 5;
            this.btnstats.Text = "STATISTICS";
            this.btnstats.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnstats.UseVisualStyleBackColor = false;
            this.btnstats.Click += new System.EventHandler(this.btnstats_Click);
            // 
            // btnhistory
            // 
            this.btnhistory.BackColor = System.Drawing.Color.Transparent;
            this.btnhistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnhistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhistory.FlatAppearance.BorderSize = 0;
            this.btnhistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnhistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnhistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhistory.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhistory.ForeColor = System.Drawing.Color.Black;
            this.btnhistory.Image = global::NAKAKABOBO.Properties.Resources.time_machine_40px;
            this.btnhistory.Location = new System.Drawing.Point(419, 63);
            this.btnhistory.Name = "btnhistory";
            this.btnhistory.Size = new System.Drawing.Size(159, 125);
            this.btnhistory.TabIndex = 6;
            this.btnhistory.Text = "PRODUCE MEDICAL HISTORY";
            this.btnhistory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnhistory.UseVisualStyleBackColor = false;
            this.btnhistory.Click += new System.EventHandler(this.btnhistory_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button4.BackgroundImage = global::NAKAKABOBO.Properties.Resources.button_icon_clipart_2;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(58, 300);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(51, 38);
            this.button4.TabIndex = 4;
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(40, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "LOG OUT";
            // 
            // MAINPAGE
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(770, 416);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnstats);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnhistory);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MAINPAGE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAINPAGE";
            this.Load += new System.EventHandler(this.MAINPAGE_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnstats;
        private System.Windows.Forms.Button btnhistory;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
    }
}