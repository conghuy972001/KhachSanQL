using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhachSanQL
{
    public partial class CaiDatKS : Form
    {
        KhachSanBLL bllKS;
        public CaiDatKS()
        {
            InitializeComponent();
            bllKS = new KhachSanBLL();
        }

        public void ShowAllPhong()
        {
            DataTable dt = bllKS.getAllPhong();
            dataGridViewPhong.DataSource = dt;
        }


        private void CaiDatKS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKHACHSANDataSet.tb_Phong' table. You can move, or remove it, as needed.
            this.tb_PhongTableAdapter.Fill(this.qLKHACHSANDataSet.tb_Phong);
            // TODO: This line of code loads data into the 'qLKHACHSANDataSet.tb_LoaiPhong' table. You can move, or remove it, as needed.
            this.tb_LoaiPhongTableAdapter.Fill(this.qLKHACHSANDataSet.tb_LoaiPhong);
            // TODO: This line of code loads data into the 'qLKHACHSANDataSet.tb_PhanQuyen' table. You can move, or remove it, as needed.
            this.tb_PhanQuyenTableAdapter.Fill(this.qLKHACHSANDataSet.tb_PhanQuyen);
            // TODO: This line of code loads data into the 'qLKHACHSANDataSet.tb_Tang' table. You can move, or remove it, as needed.
            this.tb_TangTableAdapter.Fill(this.qLKHACHSANDataSet.tb_Tang);
            // TODO: This line of code loads data into the 'qLKHACHSANDataSet.tb_Tang' table. You can move, or remove it, as needed.
            this.tb_TangTableAdapter.Fill(this.qLKHACHSANDataSet.tb_Tang);
            //show all phong tren table data
            ShowAllPhong();
            ShowAllSanPham();
            ShowAllUsers();
            //loadCmbTang();


        }

        //private void loadCmbTang()
        //{
        //    SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-2HFFDEN; Initial Catalog=QLKHACHSAN; Integrated Security = True");
        //    con.Open();
        //    string sql = "select * from tb_Tang";
        //    SqlDataAdapter da = new SqlDataAdapter(sql, con);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    cmbTangPhong.DataSource = dt;
        //    cmbTangPhong.DisplayMember = dt.Columns["TENTANG"].ToString();
        //    cmbTangPhong.ValueMember = dt.Columns["IDTANG"].ToString();
        //}

        public bool Checkdata()
        {
            if (string.IsNullOrEmpty(textTenPhong.Text))
            {
                MessageBox.Show("Bạn chưa nhập Tên Phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textTenPhong.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textTrangThai.Text))
            {
                MessageBox.Show("Bạn chưa nhập Trạng Thái", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textTrangThai.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textIDTang.Text))
            {
                MessageBox.Show("Bạn chưa nhập ID Tầng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textIDTang.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textIDLoaiPhong.Text))
            {
                MessageBox.Show("Bạn chưa nhập ID Loại Phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textIDLoaiPhong.Focus();
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (Checkdata())
            {
                tb_Phong ph = new tb_Phong();
                ph.TENPHONG = textTenPhong.Text;
                ph.TRANGTHAI = textTrangThai.Text;
                ph.IDTANG = int.Parse(textIDTang.Text);
                ph.IDLOAIPHONG = int.Parse(textIDLoaiPhong.Text);
                

                if (bllKS.InsertPhong(ph))
                {
                    ShowAllPhong();
                    textTenPhong.Clear();
                    textTrangThai.Clear();
                    textIDTang.Clear();
                    textIDLoaiPhong.Clear();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
        }

        int ID;
        private void dataGridViewPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                ID = Int32.Parse(dataGridViewPhong.Rows[index].Cells["IDPHONG"].Value.ToString());
                textTenPhong.Text = dataGridViewPhong.Rows[index].Cells["TENPHONG"].Value.ToString();
                textTrangThai.Text = dataGridViewPhong.Rows[index].Cells["TRANGTHAI"].Value.ToString();
                textIDTang.Text = dataGridViewPhong.Rows[index].Cells["IDTANG"].Value.ToString();
                textIDLoaiPhong.Text = dataGridViewPhong.Rows[index].Cells["IDLOAIPHONG"].Value.ToString();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (Checkdata())
            {
                tb_Phong ph = new tb_Phong();
                ph.IDPHONG = ID;
                ph.TENPHONG = textTenPhong.Text;
                ph.TRANGTHAI = textTrangThai.Text;
                ph.IDTANG = int.Parse(textIDTang.Text);
                ph.IDLOAIPHONG = int.Parse(textIDLoaiPhong.Text);


                if (bllKS.UpdatePhong(ph))
                {
                    ShowAllPhong();
                    MessageBox.Show("Cập nhật thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textTenPhong.Clear();
                    textTrangThai.Clear();
                    textIDTang.Clear();
                    textIDLoaiPhong.Clear();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa hay không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tb_Phong ph = new tb_Phong();
                ph.IDPHONG = ID;
                if (bllKS.DeletePhong(ph))
                {
                    ShowAllPhong();
                    textTenPhong.Clear();
                    textTrangThai.Clear();
                    textIDTang.Clear();
                    textIDLoaiPhong.Clear();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void textFind_TextChanged(object sender, EventArgs e)
        {
            string value = textFind.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bllKS.FindPhong(value);
                dataGridViewPhong.DataSource = dt;
            }
            else
            {
                ShowAllPhong();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        /// <summary>
        /// ////////////////////////////////////   San Phẩm    //////////////////////////////////
        /// </summary>
        KhachSanDAL dal;
        public void ShowAllSanPham()
        {
            dal = new KhachSanDAL();
            try
            {
                //dataGridViewSP.DataSource = dal.getAllSanPham();
                DataTable dt = bllKS.getAllSanPham();
                dataGridViewSP.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            tb_SanPham sp = new tb_SanPham();
            sp.TENSP1 = textBoxTenSP.Text;
            sp.DONGIA1 = textBoxDonGia.Text;


            if (bllKS.InsertSanPham(sp))
            {
                ShowAllSanPham();
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tb_SanPham sp = new tb_SanPham();
                sp.IDSP1 = ID;
                if (bllKS.DeleteSanPham(sp))
                {
                    ShowAllSanPham();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void dataGridViewSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                ID = Int32.Parse(dataGridViewSP.Rows[index].Cells["IDSP"].Value.ToString());
                textBoxTenSP.Text = dataGridViewSP.Rows[index].Cells["TENSP"].Value.ToString();
                textBoxDonGia.Text = dataGridViewSP.Rows[index].Cells["DONGIA"].Value.ToString();

            }
        }

        private void btnCapNhapSP_Click(object sender, EventArgs e)
        {
            tb_SanPham sp = new tb_SanPham();
            sp.IDSP1 = ID;
            sp.TENSP1 = textBoxTenSP.Text;
            sp.DONGIA1 = textBoxDonGia.Text;


            if (bllKS.UpdateSanPham(sp))
            {
                ShowAllSanPham();
                MessageBox.Show("Cập nhật thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }


        ////////////////////////////    USER     //////////////////////////////
        public void ShowAllUsers()
        {
            DataTable dt = bllKS.getAllUsers();
            dataViewUser.DataSource = dt;
        }
        public bool CheckdataUsers()
        {
            if (string.IsNullOrEmpty(textFullNameUser.Text))
            {
                MessageBox.Show("Bạn chưa nhập Họ và Tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textFullNameUser.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textUserUser.Text))
            {
                MessageBox.Show("Bạn chưa nhập Username", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textUserUser.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textPasswordUser.Text))
            {
                MessageBox.Show("Bạn chưa nhập Password", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textPasswordUser.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textIDPhanQuyenUser.Text))
            {
                MessageBox.Show("Bạn chưa nhập ID Phân Quyền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textIDPhanQuyenUser.Focus();
                return false;
            }
            return true;
        }

        private void btnThemUser_Click(object sender, EventArgs e)
        {
            if (CheckdataUsers())
            {
                tb_Users us = new tb_Users();
                us.FULLNAME = textFullNameUser.Text;
                us.USERNAME = textUserUser.Text;
                us.PASSWORD = textPasswordUser.Text;
                us.IDPHANQUYEN = int.Parse(textIDPhanQuyenUser.Text);


                if (bllKS.InsertUsers(us))
                {
                    ShowAllUsers();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
        }

        
        private void btnXoaUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tb_Users us = new tb_Users();
                us.UID = ID;
                if (bllKS.DeleteUsers(us))
                {
                    ShowAllUsers();
                    //MessageBox.Show("Xoa thanh cong", "hi");
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void dataViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                ID = Int32.Parse(dataViewUser.Rows[index].Cells["UID"].Value.ToString());
                textFullNameUser.Text = dataViewUser.Rows[index].Cells["FULLNAME"].Value.ToString();
                textUserUser.Text = dataViewUser.Rows[index].Cells["USERNAME"].Value.ToString();
                textPasswordUser.Text = dataViewUser.Rows[index].Cells["PASSWORD"].Value.ToString();
                textIDPhanQuyenUser.Text = dataViewUser.Rows[index].Cells["IDPHANQUYEN"].Value.ToString();
            }
        }

        private void btnCapNhatUser_Click(object sender, EventArgs e)
        {
            if (CheckdataUsers())
            {
                tb_Users us = new tb_Users();
                us.UID = ID;
                us.FULLNAME = textFullNameUser.Text;
                us.USERNAME = textUserUser.Text;
                us.PASSWORD = textPasswordUser.Text;
                us.IDPHANQUYEN = int.Parse(textIDPhanQuyenUser.Text);


                if (bllKS.UpdateUsers(us))
                {
                    ShowAllUsers();
                    MessageBox.Show("Cập nhật thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
        }

    }
}
