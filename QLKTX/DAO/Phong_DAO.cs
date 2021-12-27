using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLKTX.DTO;
using System.Data.OleDb;

namespace QLKTX.DAO
{
    class Phong_DAO : DataProvider
    {
        public DataTable loadPhong()
        {
            string sqlString = @"select * from PHONG";
            return GetData(sqlString);
        }

        public bool Insert(Phong p)
        {
            if (GetData("select * from PHONG where MaPhong = '" + p.MaPhong + "'").Rows.Count > 0)
                return false;
            string sql = string.Format("Insert Into PHONG values('{0}',N'{1}',N'{2}','{3}',N'{4}')",
                p.MaPhong, p.TenPhong, p.KichThuoc, p.DayPhong, p.LoaiGiuong);

            Excute(sql);
            return true;
        }

        public void Update(Phong p)
        {
            string sql = string.Format("Update PHONG set MaPhong='{0}', TenPhong = N'{1}', KichThuoc= N'{2}', DayPhong = '{3}', LoaiGiuong = N'{4}' where MaPhong = '{0}'",
                p.MaPhong, p.TenPhong, p.KichThuoc, p.DayPhong, p.LoaiGiuong);
            Excute(sql);
        }

        public void Delete(string mp)
        {
            Excute("delete from PHONG where MaPhong = '" + mp + "'");
        }

        public DataTable Search(string _timkiem)
        {
            string sqlString = string.Format("select * from PHONG where MaPhong like N'%{0}%' or TenPhong like N'%{0}%'", _timkiem);
            return GetData(sqlString);
        }
    }
}
