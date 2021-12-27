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
    class Hopdong_BUS
    {
        Hopdong_DAO hdDao = new Hopdong_DAO();

        public DataTable GetList()
        {
            return hdDao.loadHopDong();
        }
        public void Xoa(string mHD)
        {
            hdDao.Delete(mHD);
        }
        public bool Sua(Hopdong hd)
        {
            if (string.IsNullOrEmpty(hd.MaHD))
                return false;
            hdDao.Update(hd);
            return true;
        }
        public int Them(Hopdong hd)
        {
            if (string.IsNullOrEmpty(hd.MaHD))
                return 0;
            if (!hdDao.Insert(hd))
                return -1;
            return 1;
        }
        public DataTable TimKiem(string _timkiem)
        {
            return hdDao.Search(_timkiem);
        }
    }
}
