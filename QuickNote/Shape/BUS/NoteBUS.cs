using Shape.DAO;
using Shape.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape.BUS
{
    public class NoteBUS
    {
        NoteDAO noteDAO = new NoteDAO();

        public DataTable LayDanhSachNote()
        {
            try
            {
                return noteDAO.LayDanhSachNote();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string XuliChuoi(string chuoi, string[] loaiTag)
        {

            string[] separators = { "," };

            if (chuoi.Length != 0)
            {
                loaiTag = chuoi.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                for (int index = 0; index < loaiTag.Length; index++)
                {
                    loaiTag[index] = loaiTag[index].Trim();
                }


            }
            else
            {
                string[] none = { "None" };
                loaiTag = none;
            }

            string item = String.Join(",", loaiTag);
            return item;
        }

        public int ThemNote(Note note)
        {
            string [] temp = null;
            if(string.IsNullOrWhiteSpace(note._tieuDe))
            {
                note._tieuDe = "Không tiêu đề";
            }
            note._loaiTag = XuliChuoi(note._loaiTag, temp);
            
            //Xử lý chính(nghiệp vụ)
            //if (!note.CMND.ToLower().Contains("vn")) return -1;

            //Xử lý dữ liệu
            return noteDAO.ThemNote(note);
        }


    }
}
