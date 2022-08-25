using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhachSanQL
{
    internal class KhachSanBLL
    {
        KhachSanDAL dalKS;

        public KhachSanBLL()
        {
            dalKS = new KhachSanDAL();
        }

        public DataTable getAllPhong()
        {
            return dalKS.getAllPhong();
        }

        public bool InsertPhong(tb_Phong ph)
        {
            return dalKS.InsertPhong(ph);
        }
        public bool UpdatePhong(tb_Phong ph)
        {
            return dalKS.UpdatePhong(ph);
        }
        public bool DeletePhong(tb_Phong ph)
        {
            return dalKS.DeletePhong(ph);
        }
        public DataTable FindPhong(string ph)
        {
            return dalKS.FindPhong(ph);
        }
        public DataTable getAllSanPham()
        {
            return dalKS.getAllSanPham();
        }
        public bool InsertSanPham(tb_SanPham sp)
        {
            return dalKS.InsertSanPham(sp);
        }
        public bool DeleteSanPham(tb_SanPham sp)
        {
            return dalKS.DeleteSanPham(sp);
        }
        public bool UpdateSanPham(tb_SanPham sp)
        {
            return dalKS.UpdateSanPham(sp);
        }
        public DataTable getAllUsers()
        {
            return dalKS.getAllUsers();
        }
        public bool InsertUsers(tb_Users us)
        {
            return dalKS.InsertUsers(us);
        }
        public bool DeleteUsers(tb_Users us)
        {
            return dalKS.DeleteUsers(us);
        }
        public bool UpdateUsers(tb_Users us)
        {
            return dalKS.UpdateUsers(us);
        }
        public DataTable getAllDatPhong()
        {
            return dalKS.getAllDatPhong();
        }
        public bool DeleteDatPhong(tb_DatPhong dp)
        {
            return dalKS.DeleteDatPhong(dp);
        }




    }
}
