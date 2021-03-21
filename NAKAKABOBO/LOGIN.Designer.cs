namespace NAKAKABOBO
{
    partial class LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            this.txtuser = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.ForeColor = System.Drawing.Color.Black;
            this.txtuser.Location = new System.Drawing.Point(60, 103);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(147, 19);
            this.txtuser.TabIndex = 0;
            this.txtuser.Text = "username";
            this.txtuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtuser.Click += new System.EventHandler(this.txtuser_Click);
            this.txtuser.TextChanged += new System.EventHandler(this.txtuser_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Location = new System.Drawing.Point(28, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Location = new System.Drawing.Point(27, 201);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 3;
            // 
            // txtlogin
            // 
            this.txtlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtlogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtlogin.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlogin.ForeColor = System.Drawing.Color.Black;
            this.txtlogin.Location = new System.Drawing.Point(67, 176);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.PasswordChar = '*';
            this.txtlogin.Size = new System.Drawing.Size(129, 20);
            this.txtlogin.TabIndex = 2;
            this.txtlogin.Text = "********";
            this.txtlogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtlogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtlogin_KeyDown);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnlogin.FlatAppearance.BorderSize = 0;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(82, 238);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(102, 35);
            this.btnlogin.TabIndex = 7;
            this.btnlogin.Text = "LOG IN";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.btnexit);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 53);
            this.panel3.TabIndex = 10;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Transparent;
            this.btnexit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnexit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnexit.Location = new System.Drawing.Point(227, 14);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(32, 26);
            this.btnexit.TabIndex = 11;
            this.btnexit.Text = "X";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN USER";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::NAKAKABOBO.Properties.Resources.user_male_30px;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(28, 95);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 30);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::NAKAKABOBO.Properties.Resources.key_64px;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(28, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 30);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(269, 314);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.txtuser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LOGIN_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnexit;
    }
}