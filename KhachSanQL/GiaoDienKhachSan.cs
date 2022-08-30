using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;

namespace KhachSanQL
{
    public partial class GiaoDienKhachSan : Form
    {

        public string username,userid, fullname;
        public GiaoDienKhachSan()
        {
            InitializeComponent();
        }
        public GiaoDienKhachSan(string user, string uid)
        {
            InitializeComponent();
        }
        string chuoiketnoi = "Data Source = DESKTOP-2HFFDEN; Initial Catalog=QLKHACHSAN; Integrated Security = True";
        SqlConnection con = new SqlConnection();

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

        private void ShowAllPhongGD()
        {
            string sql = "SELECT ph.TENPHONG, ph.TRANGTHAI, ph.GIATIEN, tg.TENTANG, lph.TENLOAIPHONG FROM tb_Phong ph INNER JOIN tb_Tang tg ON ph.IDTANG = tg.IDTANG INNER JOIN tb_LoaiPhong lph ON ph.IDLOAIPHONG = lph.IDLOAIPHONG";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataViewPhongGD.DataSource = dt;

        }
        private void ShowAllKhachHangGD()
        {
            string sql = "SELECT * FROM tb_KhachHang";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataViewKhachhang.DataSource = dt;
            
        }


        private void loadcmbSanPham()
        {
            string sql = "SELECT * FROM tb_SanPham";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbSanPham.DataSource = dt;
            cmbSanPham.DisplayMember = dt.Columns["TENSP"].ToString();
            cmbSanPham.ValueMember = dt.Columns["IDSP"].ToString();
            
        }
        private void loadcmbSoPhong()
        {
            string sql = "SELECT * FROM tb_Phong";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbSoPhong.DataSource = dt;
            cmbSoPhong.DisplayMember = dt.Columns["TENPHONG"].ToString();
            cmbSoPhong.ValueMember = dt.Columns["IDPHONG"].ToString();
        }




        private void GiaoDienKhachSan_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
            ShowAllPhongGD();
            loadcmbSanPham();
            loadcmbSoPhong();
            label7.Text = username;
            label8.Text = userid;
            labelFullName.Text = fullname;
            ShowAllKhachHangGD();
            loadgiatienDichVu();


        }

        
        public void dataViewPhongGD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbSoPhong.Text = dataViewPhongGD.Rows[e.RowIndex].Cells[0].Value.ToString();
            textGiaPhong.Text = dataViewPhongGD.Rows[e.RowIndex].Cells["GIATIEN"].Value.ToString();


        }
        private void btncheckSDT_Click(object sender, EventArgs e)
        {
            string sdt = textSDTKH.Text;
            string sql = "SELECT * FROM tb_KhachHang WHERE DIENTHOAI =" + sdt;
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataViewCheckKH.DataSource = dt;

        }


        private void btnThemKH_Click(object sender, EventArgs e)
        {
            string sqlthemKH = "INSERT INTO tb_KhachHang VALUES (N'" + textHoTen.Text + "','" + textSDTKH.Text + "','" + textCCCD.Text + "','" + textEmail.Text + "',N'" + textDiaChi.Text + "')";
            try
            {
                SqlCommand sqlcmd = new SqlCommand(sqlthemKH, con);
                sqlcmd.ExecuteNonQuery();
                ShowAllPhongGD();
                MessageBox.Show("Thành công thêm khách hàng");
                textHoTen.Clear();
                textCCCD.Clear();
                textDiaChi.Clear();
                textEmail.Clear();
                textSDTKH.Clear();
            }
            catch
            {
                MessageBox.Show("Lõi rồi bạn ơi!!!!!");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ShowAllKhachHangGD();
        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            string sqldoidata = "UPDATE tb_Phong SET TRANGTHAI = N'trống' WHERE IDPHONG = " + cmbSoPhong.SelectedValue.ToString().Trim();
            try
            {
                SqlCommand sqlcmd = new SqlCommand(sqldoidata, con);
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Thành công");
                ShowAllPhongGD();
            }
            catch
            {
                MessageBox.Show("Loi roi ");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataViewCheckKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                textSDTKhachHang.Text = dataViewCheckKH.Rows[index].Cells["DIENTHOAI1"].Value.ToString();               
            }
        }




        private void datphongandtraphong()
        {
            string sqldoidata = "UPDATE tb_Phong SET TRANGTHAI = N'đã đặt phòng' WHERE IDPHONG = " + cmbSoPhong.SelectedValue.ToString().Trim();
            try
            {
                SqlCommand sqlcmd1 = new SqlCommand(sqldoidata, con);
                sqlcmd1.ExecuteNonQuery();
                //MessageBox.Show("Thành công");
                ShowAllPhongGD();
                Report f = new Report();
                f.sdt = textSDTKhachHang.Text;
                f.luutru = textSoNgayLuuTru.Text;
                f.giadv = textGiaDichVu.Text;
                f.giaphong = textGiaPhong.Text;
                f.tendv = cmbSanPham.Text;
                f.tenphong = cmbSoPhong.Text;
                f.tennv = labelFullName.Text;
                f.tongtien = textTongTien.Text;
                f.ngaydat = dateTimeCheckin.Text;
                f.ngayra = dateTimeCheckOut.Text;
                ////////////////////////////////////////////////////
                f.Show();
                textSDTKhachHang.Clear();
                textSoNgayLuuTru.Clear();
            }
            catch
            {
                MessageBox.Show("Loi roi ");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        public void loadgiatienDichVu()
        {
            string loadgiaSP = "select DONGIA from tb_SanPham where IDSP= " + cmbSanPham.SelectedValue.ToString().Trim();
            SqlDataAdapter da = new SqlDataAdapter(loadgiaSP, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            BindingSource bd = new BindingSource();
            bd.DataSource = dt;
            textGiaDichVu.DataBindings.Clear();
            textGiaDichVu.DataBindings.Add("text", bd, "DONGIA");
            //int giadv = int.Parse(textGiaDichVu.Text);
            //string tongtien = giadv + giaphong;
            

        }


        private void cmbSanPham_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadgiatienDichVu();
        }

        private void btnDXuat_Click(object sender, EventArgs e)
        {
            DangNhap f = new DangNhap();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btnDP_Click(object sender, EventArgs e)
        {
            dieukiendatphong();
        }

        public void dieukiendatphong()
        {
            int x = cmbSoPhong.SelectedValue.GetHashCode();
            string y = x.ToString(); 
            string sql = "SELECT TRANGTHAI FROM tb_Phong WHERE IDPHONG =" + x;
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string dieukhien = dt.Rows[0][0].ToString();
            if (dieukhien == "đã đặt phòng")
            {
                MessageBox.Show("Phòng đã có người đặt", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                
                datphong();
            }

        }


        public void datphong()
        {
            //int giadv = int.Parse(textGiaDichVu.Text);
            //int giaphong = int.Parse(textGiaPhong.Text);
            //int tongtien = giadv + giaphong;
            //textTongTien.Text = tongtien.ToString();
            if (Checkdata())
            {

                string sqldatphong = "INSERT INTO tb_DatPhong VALUES ('" + cmbSoPhong.SelectedValue.ToString().Trim() + "','" + textSDTKhachHang.Text
                    + "','" + dateTimeCheckin.Text + "','" + dateTimeCheckOut.Text + "','"
                    + textSoNgayLuuTru.Text + "','" + textTongTien.Text+ "','" + userid + "','" + cmbSanPham.SelectedValue.ToString().Trim() + "')";
                try
                {
                    SqlCommand sqlcmd = new SqlCommand(sqldatphong, con);
                    sqlcmd.ExecuteNonQuery();
                    ShowAllPhongGD();
                    textSDTKH.Clear();
                    //textSoNgayLuuTru.Clear();
                    MessageBox.Show("Đặt Phòng thành công");
                    datphongandtraphong();
                }
                catch
                {
                    MessageBox.Show("Loi roi ban oi!!");
                }
            }
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            //textGiaPhong.Text = "0";
            int giadv = int.Parse(textGiaDichVu.Text);
            int giaphong = int.Parse(textGiaPhong.Text);
            int tongtien = giadv + giaphong;
            textTongTien.Text = tongtien.ToString();
        }

        public bool Checkdata()
        {

            if (string.IsNullOrEmpty(textSDTKhachHang.Text))
            {
                MessageBox.Show("Bạn chưa nhập Số điện thoại Khách Hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textSDTKhachHang.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textSoNgayLuuTru.Text))
            {
                MessageBox.Show("Bạn chưa nhập Số ngày lưu trữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textSoNgayLuuTru.Focus();
                return false;
            }

            return true;
        }

    }
}
