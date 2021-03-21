namespace NAKAKABOBO
{
    partial class Rport_Viewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rport_Viewer));
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btngo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnprint = new System.Windows.Forms.Button();
            this.tblfinal2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblfinal2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(65, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date From:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(36, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 23);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(370, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date To:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(326, 41);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(168, 23);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // btngo
            // 
            this.btngo.BackColor = System.Drawing.Color.Teal;
            this.btngo.FlatAppearance.BorderSize = 0;
            this.btngo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngo.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngo.ForeColor = System.Drawing.Color.Black;
            this.btngo.Location = new System.Drawing.Point(904, 32);
            this.btngo.Name = "btngo";
            this.btngo.Size = new System.Drawing.Size(87, 31);
            this.btngo.TabIndex = 2;
            this.btngo.Text = "VIEW";
            this.btngo.UseVisualStyleBackColor = false;
            this.btngo.Click += new System.EventHandler(this.btngo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(997, 469);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.Transparent;
            this.btnprint.BackgroundImage = global::NAKAKABOBO.Properties.Resources.print_48px;
            this.btnprint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnprint.FlatAppearance.BorderSize = 0;
            this.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnprint.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.ForeColor = System.Drawing.Color.Teal;
            this.btnprint.Location = new System.Drawing.Point(925, 545);
            this.btnprint.Name = "btnprint";
            this.btnprint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnprint.Size = new System.Drawing.Size(66, 50);
            this.btnprint.TabIndex = 4;
            this.btnprint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnprint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // tblfinal2BindingSource
            // 
            this.tblfinal2BindingSource.DataMember = "tbl_final2";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Rport_Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1003, 598);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btngo);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Name = "Rport_Viewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rport_Viewer";
            this.Load += new System.EventHandler(this.Rport_Viewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblfinal2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btngo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tblfinal2BindingSource;
        private System.Windows.Forms.Button btnprint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}