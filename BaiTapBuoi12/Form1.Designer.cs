namespace BaiTapBuoi12
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1_barCode = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2_Qrcode = new System.Windows.Forms.FlowLayoutPanel();
            this.button1_import = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Location = new System.Drawing.Point(0, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(407, 653);
            this.dataGridView1.TabIndex = 0;
            // 
            // flowLayoutPanel1_barCode
            // 
            this.flowLayoutPanel1_barCode.AutoScroll = true;
            this.flowLayoutPanel1_barCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel1_barCode.Location = new System.Drawing.Point(413, 104);
            this.flowLayoutPanel1_barCode.Name = "flowLayoutPanel1_barCode";
            this.flowLayoutPanel1_barCode.Size = new System.Drawing.Size(613, 653);
            this.flowLayoutPanel1_barCode.TabIndex = 1;
            // 
            // flowLayoutPanel2_Qrcode
            // 
            this.flowLayoutPanel2_Qrcode.AutoScroll = true;
            this.flowLayoutPanel2_Qrcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel2_Qrcode.Location = new System.Drawing.Point(1032, 104);
            this.flowLayoutPanel2_Qrcode.Name = "flowLayoutPanel2_Qrcode";
            this.flowLayoutPanel2_Qrcode.Size = new System.Drawing.Size(512, 653);
            this.flowLayoutPanel2_Qrcode.TabIndex = 2;
            // 
            // button1_import
            // 
            this.button1_import.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1_import.Location = new System.Drawing.Point(12, 40);
            this.button1_import.Name = "button1_import";
            this.button1_import.Size = new System.Drawing.Size(203, 44);
            this.button1_import.TabIndex = 0;
            this.button1_import.Text = "Import File";
            this.button1_import.UseVisualStyleBackColor = false;
            this.button1_import.Click += new System.EventHandler(this.button1_import_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(330, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 44);
            this.button2.TabIndex = 3;
            this.button2.Text = "To Code";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1539, 757);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1_import);
            this.Controls.Add(this.flowLayoutPanel2_Qrcode);
            this.Controls.Add(this.flowLayoutPanel1_barCode);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1_barCode;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2_Qrcode;
        private System.Windows.Forms.Button button1_import;
        private System.Windows.Forms.Button button2;
    }
}

