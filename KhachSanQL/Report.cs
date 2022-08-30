using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhachSanQL
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
            
        }


        public string sdt, tendv, giadv, giaphong, tongtien, tenphong, tennv, ngaydat, ngayra, luutru;

        private void Report_Load(object sender, EventArgs e)
        {
            label16.Text = tenphong;
            label15.Text = sdt;
            label14.Text = ngaydat;
            label18.Text = ngayra;
            label13.Text = luutru;
            label12.Text = tendv;
            label11.Text = giadv;
            label10.Text = giaphong;
            label9.Text = tongtien;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("HÓA ĐƠN THANH TOÁN", new Font("Arial", 24, FontStyle.Bold), Brushes.Black, new Point(250, 25));
            e.Graphics.DrawString("Ngày:   " + DateTime.Now, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(340 , 70));
            e.Graphics.DrawString("Tên Khách Hàng:   " + sdt, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(45, 115));
            e.Graphics.DrawString("SDT:   " + sdt, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(45, 140));

            e.Graphics.DrawString("Dịch vụ" , new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(45, 165));
            e.Graphics.DrawString("Thành tiền" , new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(400, 165));
            e.Graphics.DrawString("Phòng "+tenphong, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(45, 190));
            e.Graphics.DrawString( giaphong, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 190));
            e.Graphics.DrawString("Số ngày lưu trú:   " + luutru, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(45, 215));
            e.Graphics.DrawString( tendv, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(45, 240));
            e.Graphics.DrawString( giadv, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 240));
            e.Graphics.DrawString("Tổng tiền:", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(45, 290));
            e.Graphics.DrawString( tongtien, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 290));
            e.Graphics.DrawString("Tên nhân viên", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(570, 350));
            e.Graphics.DrawString( tennv, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(580, 375));
            e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(45, 400));
            e.Graphics.DrawString("KHÁCH SẠN 123 ZÔ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(370, 425));
            e.Graphics.DrawString("Địa chỉ: 1000 Bùi Viện, Quận 1, Hồ Chí Minh, Việt Nam", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(200, 450));
            e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(45,475 ));

            e.Graphics.DrawString("Cảm ơn Quý Khách", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(370, 500));
            e.Graphics.DrawString("Password wifi: anhemmaidinh", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(340, 525));



        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
