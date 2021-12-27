using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLKTX.DTO;

namespace QLKTX.DAO
{
    class Thongke_DAO:DataProvider
    {
        public DataTable loadThongKe(string nl)
        {
            string sqlString = @"select MAHD, HoTenNV, HoTen, TenPhong, LoaiHD, NgayLap, NgayBD, NgayKT, SoTien
                                    from PHONG Inner Join HOPDONG ON (PHONG.MaPhong=HOPDONG.MaPhong) 
                                    Inner join SINHVIEN ON (HOPDONG.MSSV=SINHVIEN.MSSV)
									Inner join NHANVIEN on (HOPDONG.MaNV=NHANVIEN.MaNV) where NgayLap = '" + nl + "'";
            return GetData(sqlString);
        }

        public void Backup(string fl)
        {
            string sql = string.Format(@"BACKUP DATABASE [QLKTX] TO DISK = '" + fl + "\\" + "backup" + "-" + DateTime.Now.ToString("yyyy-MM-dd") + ".bak' WITH INIT");
            Excute(sql);
        }

        public void Restore(string fl)
        {
            string str1 = string.Format("ALTER DATABASE [QLKTX] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
            Excute(str1);
            string str2 = "USE MASTER RESTORE DATABASE [QLKTX] FROM DISK='" + fl + "' WITH REPLACE";
            Excute(str2);
            string str3 = string.Format("ALTER DATABASE [QLKTX] SET MULTI_USER");
            Excute(str3);
        }

    }
}
