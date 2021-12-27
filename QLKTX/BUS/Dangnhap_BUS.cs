using QLKTX.DAO;
using QLKTX.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX.BUS
{
    class Dangnhap_BUS
    {
        Dangnhap_DAO dnDao = new Dangnhap_DAO();
        public bool Login(string mNV,string mk)
        {
            if (dnDao.loadDangNhap(mNV, mk) == true)
                return true;
            return false;
        }
        public bool check(string mNV)
        {
            if (dnDao.checktk(mNV) == true)
                return true;
            return false;
        }
        public bool Sua(Dangnhap dn)
        {
            if (string.IsNullOrEmpty(dn.TaiKhoan))
                return false;
            dnDao.Update(dn);
            return true;
        }
    }
}
