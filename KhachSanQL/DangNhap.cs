using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhachSanQL
{
    public partial class DangNhap : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;
        string chuoiketnoi = "Data Source = DESKTOP-2HFFDEN; Initial Catalog=QLKHACHSAN; Integrated Security = True";
        SqlConnection con = new SqlConnection();


        public DangNhap()
        {
            InitializeComponent();
        }
        private void ketnoicsdl()
        {
            try
            {
                con = new SqlConnection(chuoiketnoi);
                con.Open();
            }
            catch
            {
                MessageBox.Show("Lỗi rồi anh zai ơi!!!!");
            }
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            checkquyen();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }
        public void checkquyen()
        {
            string tk = textBox1.Text;
            string mk = textBox2.Text;
            string sql = "SELECT IDPHANQUYEN,UID,FULLNAME FROM tb_Users where USERNAME = '" + tk + "' and PASSWORD = '" + mk + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                int ktquyen = Convert.ToInt32(dt.Rows[0][0].ToString());
                string userid = dt.Rows[0][1].ToString();
                string fullname = dt.Rows[0][2].ToString();

                if (ktquyen == 1)
                {
                    CaiDatKS f = new CaiDatKS();
                    this.Hide();
                    f.ShowDialog();
                    this.Close();
                }
                if (ktquyen == 2)
                {
                    GiaoDienKhachSan f = new GiaoDienKhachSan();
                    f.username = textBox1.Text;
                    f.userid = userid;
                    f.fullname = fullname;
                    this.Hide();
                    f.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Chưa cấp phép sử dụng quyền này");
                }
            }
            else
            {
                MessageBox.Show("Bạn vui lòng kiểm tra lại tài khoản và mật khẩu","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }

    }
}
