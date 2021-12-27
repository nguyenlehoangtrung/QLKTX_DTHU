using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLKTX.DAO;
using QLKTX.DTO;

namespace QLKTX.BUS
{
    class Sinhvien_BUS
    {
        Sinhvien_DAO svDao = new Sinhvien_DAO();

        public DataTable GetList()
        {
            return svDao.loadSinhVien();
        }
        public void Xoa(string mSV)
        {
            svDao.Delete(mSV);
        }
        public bool Sua(Sinhvien sv)
        {
            if (string.IsNullOrEmpty(sv.MSSV))
                return false;
            svDao.Update(sv);
            return true;
        }
        public int Them(Sinhvien sv)
        {
            if (string.IsNullOrEmpty(sv.MSSV))
                return 0;
            if (!svDao.Insert(sv))
                return -1;
            return 1;
        }
        public DataTable TimKiem(string _timkiem)
        {
            return svDao.Search(_timkiem);
        }
    }
}
