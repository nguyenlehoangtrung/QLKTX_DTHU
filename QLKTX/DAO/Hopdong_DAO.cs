using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLKTX.DTO;

namespace QLKTX.DAO
{
    class Hopdong_DAO : DataProvider
    {
        public DataTable loadHopDong()
        {
            string sqlString = @"select MAHD, MaNV, MSSV, MaPhong, LoaiHD, NgayLap, NgayBD, NgayKT, SoTien from HOPDONG ";
            return GetData(sqlString);
        }
        public bool Insert(Hopdong hd)
        {
            if (GetData("select * from HOPDONG where MAHD = '" + hd.MaHD + "'").Rows.Count > 0)
                return false;
            string sql = string.Format("Insert Into HOPDONG values('{0}',N'{1}',N'{2}','{3}','{4}','{5}',N'{6}','{7}',N'{8}')",
                hd.MaHD, hd.MaNV, hd.MSSV, hd.MaPhong, hd.NgayBD, hd.NgayKT, hd.LoaiHD, hd.NgayLap, hd.SoTien);
            Excute(sql);
            return true;
        }

        public void Update(Hopdong hd)
        {
            string sql = string.Format("Update HOPDONG set MAHD='{0}', MaNV = N'{1}', MSSV = N'{2}', MaPhong = '{3}', NgayBD = '{4}', NgayKT = '{5}', LoaiHD = N'{6}', NgayLap = '{7}', SoTien = '{8}' where MAHD = '{0}'",
                hd.MaHD, hd.MaNV, hd.MSSV, hd.MaPhong, hd.NgayBD, hd.NgayKT, hd.LoaiHD, hd.NgayLap,  hd.SoTien);
            Excute(sql);
        }

        public void Delete(string mHD)
        {
            Excute("delete from HOPDONG where MAHD = '" + mHD + "'");
        }

        public DataTable Search(string _timkiem)
        {
            string sqlString = string.Format("select * from HOPDONG where MAHD like N'%{0}%' or MSSV like N'%{0}%' or MaNV like N'%{0}%' or MaPhong like N'%{0}%'", _timkiem);
            return GetData(sqlString);
        }
    }
}
