namespace ScanQRCode
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
            this.textBox1_barcode = new System.Windows.Forms.TextBox();
            this.textBox2_qrcode = new System.Windows.Forms.TextBox();
            this.pictureBox_BarCode = new System.Windows.Forms.PictureBox();
            this.pictureBox_QRCode = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BarCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_QRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1_barcode
            // 
            this.textBox1_barcode.Location = new System.Drawing.Point(32, 138);
            this.textBox1_barcode.Name = "textBox1_barcode";
            this.textBox1_barcode.Size = new System.Drawing.Size(279, 30);
            this.textBox1_barcode.TabIndex = 0;
            // 
            // textBox2_qrcode
            // 
            this.textBox2_qrcode.Location = new System.Drawing.Point(32, 282);
            this.textBox2_qrcode.Name = "textBox2_qrcode";
            this.textBox2_qrcode.Size = new System.Drawing.Size(279, 30);
            this.textBox2_qrcode.TabIndex = 1;
            // 
            // pictureBox_BarCode
            // 
            this.pictureBox_BarCode.Location = new System.Drawing.Point(355, 101);
            this.pictureBox_BarCode.Name = "pictureBox_BarCode";
            this.pictureBox_BarCode.Size = new System.Drawing.Size(250, 80);
            this.pictureBox_BarCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_BarCode.TabIndex = 2;
            this.pictureBox_BarCode.TabStop = false;
            // 
            // pictureBox_QRCode
            // 
            this.pictureBox_QRCode.Location = new System.Drawing.Point(382, 211);
            this.pictureBox_QRCode.Name = "pictureBox_QRCode";
            this.pictureBox_QRCode.Size = new System.Drawing.Size(200, 200);
            this.pictureBox_QRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_QRCode.TabIndex = 3;
            this.pictureBox_QRCode.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(638, 177);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(365, 168);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(404, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(760, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1032, 444);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox_QRCode);
            this.Controls.Add(this.pictureBox_BarCode);
            this.Controls.Add(this.textBox2_qrcode);
            this.Controls.Add(this.textBox1_barcode);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BarCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_QRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1_barcode;
        private System.Windows.Forms.TextBox textBox2_qrcode;
        private System.Windows.Forms.PictureBox pictureBox_BarCode;
        private System.Windows.Forms.PictureBox pictureBox_QRCode;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

