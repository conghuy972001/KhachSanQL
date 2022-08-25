using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhachSanQL
{
    internal class KhachSanDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;

        public KhachSanDAL()
        {
            dc = new DataConnection();
        }

        public DataTable getAllPhong()
        {
            //lenh sql
            string sql = "select * from tb_Phong";
            // tao ket noi den sql
            SqlConnection con = dc.getConnect();
            //khoi tao doi tuong lop sqldataadapter
            da = new SqlDataAdapter(sql, con);
            //mo ket noi sql
            con.Open();
            //đổ dữ liệu từ DataAdepter vào DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);
            //đóng kết nối
            con.Close();
            return dt;
        }


        public bool InsertPhong(tb_Phong ph)
        {
            string sql = "INSERT INTO tb_Phong( TENPHONG, TRANGTHAI, GIATIEN, IDTANG, IDLOAIPHONG) VALUES ( @TENPHONG, @TRANGTHAI, @GIATIEN, @IDTANG, @IDLOAIPHONG)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                //cmd.Parameters.Add("@IDPHONG", SqlDbType.Int).Value = ph.IDPHONG;
                cmd.Parameters.Add("@TENPHONG", SqlDbType.NVarChar).Value = ph.TENPHONG;
                cmd.Parameters.Add("@TRANGTHAI", SqlDbType.NVarChar).Value = ph.TRANGTHAI;
                cmd.Parameters.Add("@GIATIEN", SqlDbType.Int).Value = ph.GIATIEN;
                cmd.Parameters.Add("@IDTANG", SqlDbType.Int).Value = ph.IDTANG;
                cmd.Parameters.Add("@IDLOAIPHONG", SqlDbType.Int).Value = ph.IDLOAIPHONG;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;

        }

        public bool UpdatePhong(tb_Phong ph)
        {
            string sql = "UPDATE tb_Phong SET TENPHONG=@TENPHONG, TRANGTHAI=@TRANGTHAI, GIATIEN=@GIATIEN, IDTANG=@IDTANG, IDLOAIPHONG=@IDLOAIPHONG  WHERE IDPHONG =@IDPHONG";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();

                cmd.Parameters.Add("@IDPHONG", SqlDbType.Int).Value = ph.IDPHONG;
                cmd.Parameters.Add("@TENPHONG", SqlDbType.NVarChar).Value = ph.TENPHONG;
                cmd.Parameters.Add("@TRANGTHAI", SqlDbType.NVarChar).Value = ph.TRANGTHAI;
                cmd.Parameters.Add("@GIATIEN", SqlDbType.Int).Value = ph.GIATIEN;
                cmd.Parameters.Add("@IDTANG", SqlDbType.Int).Value = ph.IDTANG;
                cmd.Parameters.Add("@IDLOAIPHONG", SqlDbType.Int).Value = ph.IDLOAIPHONG;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool DeletePhong(tb_Phong ph)
        {
            string sql = "DELETE tb_Phong WHERE IDPHONG=@IDPHONG";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@IDPHONG", SqlDbType.Int).Value = ph.IDPHONG;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public DataTable FindPhong(string ph)
        {
            string sql = "SELECT * FROM tb_Phong WHERE TENPHONG like N'%" + ph + "%'";
            // tao ket noi den sql
            SqlConnection con = dc.getConnect();
            //khoi tao doi tuong lop sqldataadapter
            da = new SqlDataAdapter(sql, con);
            //mo ket noi sql
            con.Open();
            //đổ dữ liệu từ DataAdepter vào DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);
            //đóng kết nối
            con.Close();
            return dt;
        }

        public DataTable getAllSanPham()
        {
            DataTable dt = new DataTable();
            string sql = "select * from tb_SanPham";
            using (SqlConnection con = dc.getConnect())
            {
                con.Open();
                da = new SqlDataAdapter(sql, con);
                da.Fill(dt);
                con.Close();
            }
            return dt;
        }

        public bool InsertSanPham(tb_SanPham sp)
        {
            string sql = "INSERT INTO tb_SanPham( TENSP, DONGIA) VALUES ( @TENSP, @DONGIA)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                
                cmd.Parameters.Add("@TENSP", SqlDbType.NVarChar).Value = sp.TENSP1;
                cmd.Parameters.Add("@DONGIA", SqlDbType.NVarChar).Value = sp.DONGIA1;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;


        }
        public bool DeleteSanPham(tb_SanPham sp)
        {
            string sql = "DELETE tb_SanPham WHERE IDSP=@IDSP";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@IDSP", SqlDbType.Int).Value = sp.IDSP1;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool UpdateSanPham(tb_SanPham sp)
        {
            string sql = "UPDATE tb_SanPham SET TENSP=@TENSP, DONGIA=@DONGIA WHERE IDSP =@IDSP";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();

                cmd.Parameters.Add("@IDSP", SqlDbType.Int).Value = sp.IDSP1;
                cmd.Parameters.Add("@TENSP", SqlDbType.NVarChar).Value = sp.TENSP1;
                cmd.Parameters.Add("@DONGIA", SqlDbType.NVarChar).Value = sp.DONGIA1;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }


        //////////////////////////////////////////////     USER   //////////////////////////////////////////////
        public DataTable getAllUsers()
        {
            DataTable dt = new DataTable();
            string sql = "select * from tb_Users";
            using (SqlConnection con = dc.getConnect())
            {
                con.Open();
                da = new SqlDataAdapter(sql, con);
                da.Fill(dt);
                con.Close();
            }
            return dt;
        }
        public bool InsertUsers(tb_Users us)
        {
            string sql = "INSERT INTO tb_Users( FULLNAME, USERNAME, PASSWORD, IDPHANQUYEN) VALUES ( @FULLNAME, @USERNAME, @PASSWORD, @IDPHANQUYEN)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();

                cmd.Parameters.Add("@FULLNAME", SqlDbType.NVarChar).Value = us.FULLNAME;
                cmd.Parameters.Add("@USERNAME", SqlDbType.NVarChar).Value = us.USERNAME;
                cmd.Parameters.Add("@PASSWORD", SqlDbType.Int).Value = us.PASSWORD;
                cmd.Parameters.Add("@IDPHANQUYEN", SqlDbType.Int).Value = us.IDPHANQUYEN;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;

        }
        public bool DeleteUsers(tb_Users us)
        {
            string sql = "DELETE tb_Users WHERE UID=@UID";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@UID", SqlDbType.Int).Value = us.UID;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool UpdateUsers(tb_Users us)
        {
            string sql = "UPDATE tb_Users SET FULLNAME=@FULLNAME, USERNAME=@USERNAME, PASSWORD=@PASSWORD, IDPHANQUYEN=@IDPHANQUYEN  WHERE UID =@UID";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();

                cmd.Parameters.Add("@UID", SqlDbType.Int).Value = us.UID;
                cmd.Parameters.Add("@FULLNAME", SqlDbType.NVarChar).Value = us.FULLNAME;
                cmd.Parameters.Add("@USERNAME", SqlDbType.NVarChar).Value = us.USERNAME;
                cmd.Parameters.Add("@PASSWORD", SqlDbType.Int).Value = us.PASSWORD;
                cmd.Parameters.Add("@IDPHANQUYEN", SqlDbType.Int).Value = us.IDPHANQUYEN;
                cmd.ExecuteNonQuery();
                con.Close();
                
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public DataTable getAllDatPhong()
        {
            string sql = "SELECT * FROM tb_DatPhong";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool DeleteDatPhong(tb_DatPhong dp)
        {
            string sql = "DELETE tb_DatPhong WHERE IDDATPHONG=@IDDATPHONG";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@IDDATPHONG", SqlDbType.Int).Value = dp.IDDATPHONG;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }


    }
}
