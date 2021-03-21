namespace NAKAKABOBO
{
    partial class CHOOSE_STATS
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnprocede = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "<Select Graph>",
            "Line Graph",
            "Bar Graph",
            "Pie Chart"});
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnprocede
            // 
            this.btnprocede.BackColor = System.Drawing.Color.Teal;
            this.btnprocede.FlatAppearance.BorderSize = 0;
            this.btnprocede.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprocede.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprocede.ForeColor = System.Drawing.Color.White;
            this.btnprocede.Location = new System.Drawing.Point(11, 39);
            this.btnprocede.Name = "btnprocede";
            this.btnprocede.Size = new System.Drawing.Size(89, 23);
            this.btnprocede.TabIndex = 1;
            this.btnprocede.Text = "PROCEED";
            this.btnprocede.UseVisualStyleBackColor = false;
            this.btnprocede.Click += new System.EventHandler(this.btnprocede_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Teal;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(106, 39);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(89, 23);
            this.btnexit.TabIndex = 2;
            this.btnexit.Text = "E&XIT";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // CHOOSE_STATS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 73);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnprocede);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CHOOSE_STATS";
            this.Text = "CHOOSE_STATS";
            this.Load += new System.EventHandler(this.CHOOSE_STATS_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnprocede;
        private System.Windows.Forms.Button btnexit;
    }
}