using QLKTX.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX.BUS
{
    class Thongke_BUS
    {
        Thongke_DAO tkDao = new Thongke_DAO();

        public DataTable GetList(string nl)
        {
            return tkDao.loadThongKe(nl);
        }

        public void Backup(string fl)
        {
            tkDao.Backup(fl);
        }

        public void Restore(string fl)
        {
            tkDao.Restore(fl);
        }
    }
}
