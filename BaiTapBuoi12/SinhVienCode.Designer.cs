namespace BaiTapBuoi12
{
    partial class SinhVienCode
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1_code = new System.Windows.Forms.PictureBox();
            this.label1_content = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_code)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1_code
            // 
            this.pictureBox1_code.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1_code.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1_code.Name = "pictureBox1_code";
            this.pictureBox1_code.Size = new System.Drawing.Size(142, 127);
            this.pictureBox1_code.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1_code.TabIndex = 0;
            this.pictureBox1_code.TabStop = false;
            // 
            // label1_content
            // 
            this.label1_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1_content.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1_content.Location = new System.Drawing.Point(0, 127);
            this.label1_content.Name = "label1_content";
            this.label1_content.Size = new System.Drawing.Size(142, 40);
            this.label1_content.TabIndex = 2;
            this.label1_content.Text = "label1";
            this.label1_content.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SinhVienCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1_content);
            this.Controls.Add(this.pictureBox1_code);
            this.Name = "SinhVienCode";
            this.Size = new System.Drawing.Size(142, 167);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_code)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1_code;
        private System.Windows.Forms.Label label1_content;
    }
}
