using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Shape.DTO;
namespace Shape.DAO
{
    class NoteDAO
    {
        XL_DULIEU xlDuLieu = new XL_DULIEU();
        public DataTable LayDanhSachNote()
        {
            return xlDuLieu.LayDuLieu("Select * from Note");
        }

        public int ThemNote(Note note)
        {
            //Xử lý dữ liệu
            string sql = string.Format("Insert Into Note(TieuDe, NoiDung, ThoiGianTao,LoaiTag) Values('{0}','{1}','{2}','{3}')",note._tieuDe, note._noiDung, note._thoiGianTao, note._loaiTag);

            return xlDuLieu.ThucThi(sql);
        }
    }
}
