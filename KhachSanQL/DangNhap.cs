using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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
        string uid;


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

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            
            string tk = textBox1.Text;
            string mk = textBox2.Text;
            string sql = "select * from tb_Users where USERNAME = '" + tk + "' and PASSWORD = '" + mk + "' and UID = '"+ cmbPhanQuyen.SelectedValue.ToString().Trim() + "'";
            cmd = new SqlCommand(sql, con);
            dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                uid = cmbPhanQuyen.SelectedValue.ToString().Trim();
                if (uid == "1")
                {
                    CaiDatKS f = new CaiDatKS();
                    f.Show();
                    this.Hide();
                }
                if (uid == "2")
                {
                    GiaoDienKhachSan f = new GiaoDienKhachSan(textBox1.Text, uid);
                    f.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại tài khoản hay mật khẩu của bạn!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
            loadcmbUID();
        }
        private void loadcmbUID()
        {
            string sql = "SELECT * FROM tb_PhanQuyen";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbPhanQuyen.DataSource = dt;
            cmbPhanQuyen.DisplayMember = dt.Columns["TENQUYEN"].ToString();
            cmbPhanQuyen.ValueMember = dt.Columns["IDPHANQUYEN"].ToString();

        }

    }
}
