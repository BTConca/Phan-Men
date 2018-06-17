using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Shape.MO
{

    class Note
    {
        string _tieuDe { get; set; }
        string _noiDung { get; set; }
        DateTime _thoiGianTao { get; set; }
        string[] _loaiTag { get; set; }
        bool _saoDanhDau { get;set;}

        StreamWriter _sw;
        StreamReader _sr;
        FileStream f_note;

        public Note TaoNote(string tieuDe,string text,string tag)
        {
            Note note = new Note();
            string path;
            string filepath;
            string filename;
            string currentDirectory = Environment.CurrentDirectory;
            string[] separators = { "," };
            _noiDung = text;
            _tieuDe = tieuDe;
            //Chia tag
            if (tag.Length != 0)
            {
                _loaiTag = tag.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                for (int index = 0; index < _loaiTag.Length; index++)
                {
                    _loaiTag[index] = _loaiTag[index].Trim();
                }
                

            }
            else
            {
                string[] none = { "None" };
                _loaiTag = none;
            }
            //Tao noi dung
            string item = String.Join( ",", _loaiTag);
            path = String.Concat(currentDirectory, "\\", "Data", "\\", item);
            filepath = String.Concat(path,"\\", _tieuDe,".txt");
            
            _thoiGianTao = System.DateTime.Now.ToLocalTime();

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

                f_note = File.Create(filepath);
                f_note.Close();
                _sw = new StreamWriter(filepath);
                _sw.Write(_noiDung);
                _sw.Close();
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

    }
}
