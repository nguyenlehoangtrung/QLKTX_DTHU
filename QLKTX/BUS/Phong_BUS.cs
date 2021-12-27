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
    class Phong_BUS
    {
        Phong_DAO ph = new Phong_DAO();

        public DataTable GetList()
        {
            return ph.loadPhong();
        }

        public int Them(Phong p)
        {
            if (string.IsNullOrEmpty(p.MaPhong))
                return 0;
            if (!ph.Insert(p))
                return -1;
            return 1;
        }

        public bool Sua(Phong p)
        {
            if (string.IsNullOrEmpty(p.MaPhong))
                return false;
            ph.Update(p);
            return true;
        }

        public void Xoa(string mp)
        {
            ph.Delete(mp);
        }

        public DataTable TimKiem(string _timkiem)
        {
            return ph.Search(_timkiem);
        }
    }
}
