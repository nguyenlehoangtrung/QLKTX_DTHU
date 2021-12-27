using QLKTX.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX.DAO
{
    class Dangnhap_DAO : DataProvider
    {
        public bool loadDangNhap(string mNV, string mk)
        {
            if (GetData("select * from DANGNHAP where MaNV='" + mNV + "'AND MatKhau='" + mk + "'").Rows.Count > 0)
                return true;
           return false;
        }

        public bool checktk(string mNV)
        {
            if (GetData("select * from DANGNHAP where MaNV='" + mNV + "'").Rows.Count > 0)
                return true;
            return false;
        }

        public void Update(Dangnhap dn)
        {
            string sql = string.Format("Update DANGNHAP set MaNV='{0}', MatKhau = N'{1}' where MaNV = '{0}'",
                dn.TaiKhoan, dn.MatKhau);
            Excute(sql);
        }
    }
}
