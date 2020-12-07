using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapBuoi12
{
    public partial class SinhVienCode : UserControl
    {
        public SinhVienCode(string content,Image CodeImage)
        {
            InitializeComponent();
            label1_content.Text = content;
            pictureBox1_code.Image = CodeImage;
        }
    }
}
