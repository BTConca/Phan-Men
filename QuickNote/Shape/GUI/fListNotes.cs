using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Shape.GUI;

namespace Shape.GUI
{

    public partial class fListNotes : Form
    {
        public fListNotes()
        {

            InitializeComponent();

        }

        ImageList imgListSmall;

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
        private void LoadTags(int a)
        {
            
            int numNotes = 0;
            string textnumNotes = null;
            LoadImageList();
            listTagNote.SmallImageList = imgListSmall;
            string path = String.Concat(currentDirectory, "\\Data\\");
            string[] tags;
            string[] notes;
            string notepath;
            tags = Directory.GetDirectories(path);
            listTagNote.Clear();
            foreach (string item in tags)
            {
                ListViewItem mtag = new ListViewItem();

              
               mtag.Tag = item;
               if (a == 1)
               {
                   mtag.Text = Path.GetFileName(item);
                   string temp = String.Concat(item,"\\");
                   numNotes = Count(temp);
                   textnumNotes = Convert.ToString(numNotes);
                   mtag.Text = string.Concat(mtag.Text, " Số lượng:", textnumNotes);
               }
               else
               {
                   notepath = String.Concat(item, "\\");
                   notes = Directory.GetFiles(notepath);
                   
                   foreach (string note in notes)
                   {
                       mtag.Text = Path.GetFileName(note);
                   }
                   
               }
                listTagNote.Items.Add(mtag);
                mtag.ImageIndex++;
               
            }
        }

        private void open_Note()
        {

        }
        private void listTag(object sender, EventArgs e)
        {

        }

        private void Click_ListNotes(object sender, EventArgs e)
        {
            LoadTags(0);
        }

        private void click_ListTags(object sender, EventArgs e)
        {
            LoadTags(1);
        }



        private void listTagNote_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem mtag = new ListViewItem();
            string selectedFile = listTagNote.SelectedItems[0].Text;
            string[] notes;
            string tag = (string)listTagNote.SelectedItems[0].Tag;

            string notepath = String.Concat(tag, "\\");
            string path = Path.Combine(tag, selectedFile);
            if (File.Exists(path))
            {
                try
                {
                    fNote opf = new fNote(2, path);
                    opf.Show();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if(Directory.Exists(notepath))
            {
                listTagNote.Clear();
                notes = Directory.GetFiles(notepath);

                foreach (string note in notes)
                {
                    mtag.Text = Path.GetFileName(note);
                    mtag.Tag = tag;
                    listTagNote.Items.Add(mtag);
                    mtag.ImageIndex++;
                }
            }
            

        }

    }
}
