using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Shape.GUI;
using Shape.BUS;
using Shape.DTO;

namespace Shape.GUI
{

    public partial class fListNotes : Form
    {
        public fListNotes()
        {

            InitializeComponent();

        }

        ImageList imgListSmall;

        string _currentDirectory = Environment.CurrentDirectory;
        private void LoadImageList()
        {
            imgListSmall = new ImageList()
            {
                ImageSize = new Size(16, 16)
            };
            imgListSmall.Images.Add(new Icon(Application.StartupPath + "\\Resources\\tag.ico"));
        }
     
        public int Count(string path)
        {
            int sum = 0;
            string[] items = Directory.GetFiles(path);
            if (items == null)
                return -1;
            foreach (string temp in items)
            {
                sum++;
            }
            return sum;
        }

        string currentDirectory = Environment.CurrentDirectory;

        ListViewItem mtag;
        
        private void LoadTags(int a)
        {
            listTagNote.Items.Clear();

            NoteBUS noteBUS = new NoteBUS();
         
            int j = 0;
            ListViewItem item = null;
            DataTable data = noteBUS.LayDanhSachNote();
            LoadImageList();
            Note temp = new Note() ;
            listTagNote.SmallImageList = imgListSmall;
            foreach (DataRow row in data.Rows)
            {
                
                    temp._maNote = int.Parse(row[0].ToString());
                    temp._tieuDe = row[1].ToString();
                    temp._noiDung = row[2].ToString();
                    temp._loaiTag = row[4].ToString();
                
                if (a == 1)
                    item = new ListViewItem(row[4].ToString());
                else if (a == 0)
                    item = new ListViewItem(row[1].ToString());
                item.Tag = temp;
                listTagNote.Items.Add(item);
                item.ImageIndex++;
                j++;
            }
        }

        private void open_Note()
        {

        }
        private void listTag(object sender, EventArgs e)
        {

        }

        public void Click_ListNotes(object sender, EventArgs e)
        {
            LoadTags(0);
        }

        private void click_ListTags(object sender, EventArgs e)
        {
            LoadTags(1);
         
        }


        
        private void listTagNote_DoubleClick(object sender, EventArgs e)
        {
            NoteBUS noteBUS = new NoteBUS();
            DataTable data = noteBUS.LayDanhSachNote();
            

            Note note = (Note)listTagNote.SelectedItems[0].Tag;
          
            fNote newnote = new fNote(2,note);
            newnote.Show();

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

           
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {


        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

           

        }       
    }
}
