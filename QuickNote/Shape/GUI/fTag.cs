using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Shape.GUI
{
    public partial class fTag : Form
    {
        private fNote formNote = null;
        public fTag(fNote f)
        {
            InitializeComponent();
            formNote = f;
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

        private void LoadTags(int a)
        {

            int numNotes = 0;
            string textnumNotes = null;
            LoadImageList();
            lvTags.SmallImageList = imgListSmall;
            string currentDirectory = Environment.CurrentDirectory;
            string path = String.Concat(currentDirectory, "\\Data\\");
            string[] tags;
            string[] notes;
            string notepath;
            tags = Directory.GetDirectories(path);
            lvTags.Clear();
            foreach (string item in tags)
            {
                ListViewItem mtag = new ListViewItem();

                mtag.Text = Path.GetFileName(item);
                if (a == 1)
                {
                    string temp = String.Concat(item, "\\");
                    numNotes = Count(temp);
                    textnumNotes = Convert.ToString(numNotes);
                    //mtag.Text = string.Concat(mtag.Text, " Notes:", textnumNotes);
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
                lvTags.Items.Add(mtag);
                mtag.ImageIndex++;

            }
        }

        private void fTag_Load(object sender, EventArgs e)
        {
            LoadTags(1);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            formNote.SetTenTag(lvTags.SelectedItems[0].Text);
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
