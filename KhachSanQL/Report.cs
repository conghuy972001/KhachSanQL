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


        public string sdt, tendv, giadv, giaphong, tongtien, tenphong, tennv;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Hóa đơn Khách Sạn 123 Zô", new Font("Arial", 24, FontStyle.Bold), Brushes.Black, new Point(200, 25));
            e.Graphics.DrawString("Ngày:   " + DateTime.Now, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(45 , 90));
            e.Graphics.DrawString("Tên Khách Hàng:   " + sdt, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(45, 115));
            e.Graphics.DrawString("SDT:   " + sdt, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(45, 140));
            e.Graphics.DrawString("Số phòng:   " + tenphong, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(45, 165));
            e.Graphics.DrawString("Giá phòng:   " + giaphong, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(45, 190));
            e.Graphics.DrawString("Dịch vụ:   " + tendv, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(45, 215));
            e.Graphics.DrawString("Tiền dịch vụ:   " + giadv, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(45, 240));
            e.Graphics.DrawString("Tổng tiền:   " + tongtien, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(45, 265));
            e.Graphics.DrawString("Tên nhân viên", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(570, 320));
            e.Graphics.DrawString( tennv, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(550, 345));


        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
