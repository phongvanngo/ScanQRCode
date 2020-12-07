using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;
using BarcodeLib;
using ZXing;

namespace ScanQRCode
{
    public partial class Form1 : Form
    {
        BarcodeLib.Barcode myBarcode;
        public Form1()
        {
            InitializeComponent();
            myBarcode = new Barcode();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image barCodeImage = myBarcode.Encode(BarcodeLib.TYPE.CODE128, textBox1_barcode.Text);
            pictureBox_BarCode.Image = barCodeImage;
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCode qrCode = new QRCode(qrGenerator.CreateQrCode(textBox2_qrcode.Text, QRCodeGenerator.ECCLevel.Q));
            pictureBox_QRCode.Image = qrCode.GetGraphic(2, Color.Black, Color.White, false);
            qrGenerator.Dispose();
            qrCode.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap imgBarCode = (Bitmap)pictureBox_BarCode.Image;
            if (imgBarCode!=null)
            {
                try
                {

                }
                catch(Exception ex)
                {

                }
            }
        }
    }
}
