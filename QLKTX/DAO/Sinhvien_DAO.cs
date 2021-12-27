using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLKTX.DTO;

namespace QLKTX.DAO
{
    class Sinhvien_DAO : DataProvider
    {
        public DataTable loadSinhVien()
        {
            string sqlString = @"select * from SINHVIEN";
            return GetData(sqlString);
        }
        public bool Insert(Sinhvien sv)
        {
            if (GetData("select* from SINHVIEN where MSSV = '" + sv.MSSV + "'").Rows.Count > 0)
                return false;
            string sql = string.Format("Insert Into SINHVIEN values('{0}',N'{1}',N'{2}','{3}','{4}',N'{5}')",
                sv.MSSV, sv.HoTen, sv.GioiTinh, sv.NgaySinh, sv.SDT, sv.DiaChi);
            Excute(sql);
            return true;
        }

        public void Update(Sinhvien sv)
        {
            string sql = string.Format("Update SINHVIEN set MSSV='{0}', HoTen = N'{1}', GioiTinh = N'{2}', NgaySinh = '{3}', SDT = '{4}', DiaChi =N'{5}' where MSSV = '{0}'",
                sv.MSSV, sv.HoTen, sv.GioiTinh, sv.NgaySinh, sv.SDT, sv.DiaChi);
            Excute(sql);
        }

        public void Delete(string mSV)
        {
            Excute("delete from SINHVIEN where MSSV = '" + mSV + "'");
        }

        public DataTable Search(string _timkiem)
        {
            string sqlString = string.Format("select * from SINHVIEN where MSSV like N'%{0}%' or HoTen like N'%{0}%'", _timkiem);
            return GetData(sqlString);
        }
    }
}
