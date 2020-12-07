using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using QRCoder;
using BarcodeLib;

namespace BaiTapBuoi12
{
    public partial class Form1 : Form
    {
        BarcodeLib.Barcode myBarcode;

        DataTable SinhVienTable = new DataTable();
        List<Student> StudentList = new List<Student>();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns.Clear();
            SinhVienTable.Columns.Add("Mã số sinh viên", typeof(string));
            SinhVienTable.Columns.Add("Tên sinh viên", typeof(string));
            dataGridView1.DataSource = SinhVienTable;
        }

        public object TextBoxContent { get; private set; }

        private void button1_import_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);
                string content = sr.ReadToEnd();
                //TextBoxContent.Text = content;
                //textBoxfilename.Text = ofd.SafeFileName;
                //textBoxfilepath.Text = ofd.FileName;
                string[] sinhvien_list = content.Split('\n');
                for (int i = 0; i <= sinhvien_list.Length; i++)
                {
                    Student newStudent = new Student();
                    try
                    {
                        string[] detail = sinhvien_list[i].Split('*');
                        newStudent.Name = detail[1];
                        newStudent.Mssv = detail[0];
                        StudentList.Add(newStudent);
                        SinhVienTable.Rows.Add(newStudent.Mssv, newStudent.Name);
                    }
                    catch (Exception)
                    {

                    }



                }
                sr.Close();
            }
        }

        class Student
        {
            string name;
            string mssv;

            public string Name { get => name; set => name = value; }
            public string Mssv { get => mssv; set => mssv = value; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var sinhvien in StudentList)
            {

                    myBarcode = new Barcode();
                    Image barCodeImage = myBarcode.Encode(BarcodeLib.TYPE.CODE128, sinhvien.Mssv);

                    SinhVienCode svBarCode = new SinhVienCode(sinhvien.Mssv, barCodeImage);
                    flowLayoutPanel1_barCode.Controls.Add(svBarCode);

                    QRCodeGenerator qrGenerator = new QRCodeGenerator();
                    QRCode qrCode = new QRCode(qrGenerator.CreateQrCode(sinhvien.Name, QRCodeGenerator.ECCLevel.Q));
                    Image image = qrCode.GetGraphic(2, Color.Black, Color.White, false);
                    SinhVienCode svQRCode = new SinhVienCode(sinhvien.Name, image);
                    flowLayoutPanel2_Qrcode.Controls.Add(svQRCode);

            };
        }
    }
}
