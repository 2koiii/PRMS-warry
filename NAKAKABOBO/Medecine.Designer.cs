namespace NAKAKABOBO
{
    partial class Medecine
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmedicine = new System.Windows.Forms.TextBox();
            this.txtdes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combostatus = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtconsumed = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtstocks = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(961, 400);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Medicine Name:";
            // 
            // txtmedicine
            // 
            this.txtmedicine.Location = new System.Drawing.Point(117, 422);
            this.txtmedicine.Name = "txtmedicine";
            this.txtmedicine.Size = new System.Drawing.Size(173, 20);
            this.txtmedicine.TabIndex = 2;
            // 
            // txtdes
            // 
            this.txtdes.Location = new System.Drawing.Point(117, 459);
            this.txtdes.Name = "txtdes";
            this.txtdes.Size = new System.Drawing.Size(173, 20);
            this.txtdes.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description:";
            // 
            // combostatus
            // 
            this.combostatus.AutoSize = true;
            this.combostatus.Location = new System.Drawing.Point(332, 466);
            this.combostatus.Name = "combostatus";
            this.combostatus.Size = new System.Drawing.Size(40, 13);
            this.combostatus.TabIndex = 5;
            this.combostatus.Text = "Status:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(442, 426);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(173, 20);
            this.textBox5.TabIndex = 10;
            // 
            // txtconsumed
            // 
            this.txtconsumed.AutoSize = true;
            this.txtconsumed.Location = new System.Drawing.Point(332, 433);
            this.txtconsumed.Name = "txtconsumed";
            this.txtconsumed.Size = new System.Drawing.Size(35, 13);
            this.txtconsumed.TabIndex = 9;
            this.txtconsumed.Text = "Used:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(442, 458);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // txtstocks
            // 
            this.txtstocks.Location = new System.Drawing.Point(762, 426);
            this.txtstocks.Name = "txtstocks";
            this.txtstocks.Size = new System.Drawing.Size(173, 20);
            this.txtstocks.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(652, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Stockes:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 503);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(117, 503);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 36);
            this.button2.TabIndex = 15;
            this.button2.Text = "NEW";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(409, 503);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 36);
            this.button3.TabIndex = 16;
            this.button3.Text = "LOAD";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(577, 503);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 36);
            this.button4.TabIndex = 17;
            this.button4.Text = "EXIT";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(961, 315);
            this.reportViewer1.TabIndex = 18;
            // 
            // Medecine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 551);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtstocks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtconsumed);
            this.Controls.Add(this.combostatus);
            this.Controls.Add(this.txtdes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmedicine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Medecine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medecine";
            this.Load += new System.EventHandler(this.Medecine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmedicine;
        private System.Windows.Forms.TextBox txtdes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label combostatus;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label txtconsumed;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtstocks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}