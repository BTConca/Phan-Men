using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Shape.DTO
{

    public class Note
    {
        public string[] _loaiTag1 { get; set; }
        public bool _saoDanhDau { get;set;}
        public int _maNote { get; set; }
        public  string _tieuDe { get; set; }
        public string _noiDung { get; set; }
        public DateTime _thoiGianTao { get; set; }
        public string _loaiTag { get; set; }
        public  string _font { get; set; }
        public string _thoiGianThongBao { get; set; }
        public string _ngayChinhSuaGanNhat { get; set; }
        public string _path { get; set; }
        public DateTime _thoiGianTao1 { get; set; }
        StreamWriter _sw;
        StreamReader _sr;
        FileStream f_note;
        string currentDirectory = Environment.CurrentDirectory;
        string filepath;
        string filename;
        public Note TaoNote(string tieuDe,string text,string tag)
        {
            Note note = new Note();
            string path;

           
            _noiDung = text;
            _tieuDe = tieuDe;
            //Chia tag

            string item = XuliChuoi(tag, _loaiTag1);
            //
            path = String.Concat(currentDirectory, "\\", "Data", "\\", item);
            filepath = String.Concat(path,"\\", _tieuDe,".txt");
            
            _thoiGianTao1 = System.DateTime.Now.ToLocalTime();

            bool existFile = File.Exists(filepath);
            bool existDir = File.Exists(path);
            if (String.Compare(_tieuDe, "Không tiêu đề") == 0)
                existFile = false;

            if (!(existDir))
            {
                Directory.CreateDirectory(path);
            }

            if (!(existFile))
            {
                if (MessageBox.Show("Ban có muốn SAVE FILE không?", "Exit", MessageBoxButtons.YesNo) ==
    System.Windows.Forms.DialogResult.Yes)
                {
                    f_note = File.Create(filepath);
                    f_note.Close();
                    _sw = new StreamWriter(filepath);
                    _sw.Write(_noiDung);
                    _sw.Close();
                }
            }
            else
            {
                if (MessageBox.Show("File trùng tên. Bạn có muốn thay thế?", "Exit", MessageBoxButtons.YesNo) ==
    System.Windows.Forms.DialogResult.Yes)
                {
                    _sw = new StreamWriter(filepath);
                    _sw.Write(_noiDung);
                    _sw.Close();
                }
            }

                return note;
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
        public bool TuyChinhNote()
        {
            return true;
        }

        public DateTime DatThoiGianThongBao(DateTime tg)
        {
            DateTime time = new DateTime();
            return time;  
        }
        public bool HuyNOte()
        {
            return true;
        }
        public bool GanSaoDanhDau()
        {
            return true;
        }
        public bool LuuNote()
        {
            return true;
        }
        public bool SaveNote(string path,string text)
        {
            if (MessageBox.Show("Ban có muốn SAVE FILE không?", "Exit", MessageBoxButtons.YesNo) ==
System.Windows.Forms.DialogResult.Yes)
            {
                _sw = new StreamWriter(path);
                _sw.Write(text);
                _sw.Close();
                return true;
            }
            else
                return false;
            
        }
    }
}
