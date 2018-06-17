using System;
using Shape.DTO;
using Shape.BUS;
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
    public partial class fNote : Form
    {
        int togMove;
        int MaxValX;
        int MaxValY;
        int oder;
        Note _note = null;
        public fNote(int x)
        {
            InitializeComponent();
            oder = x;


        }
        public fNote(int x,Note item)
        {
            InitializeComponent();
            oder = x;
            _note = item;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            FontDialog font = new FontDialog();
            if (font.ShowDialog() == DialogResult.OK)
            {
                txt_note.Font = font.Font;                
            }
       }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                txt_note.ForeColor = color.Color;
            }
        }

        StreamWriter sw;
        StreamReader sr;
        FileStream note;
        private void Form_note_Load(object sender, EventArgs e)
        {

            System.DateTime.Now.ToLocalTime().ToString("dd/MM/yyyy  hh:mm:ss tt");

            timer1.Start();
            if(oder == 0)
            {
                bg_Note.Visible = false;
                UnHideBG();
            }
            if (oder == 1)
            {
                readNote();
            }else if(oder == 2)
            {
                readNote("open");
            }
        }

        string filename = "";


        string currentDirectory = Environment.CurrentDirectory;
        private void createFile(string name)
        {
            string path;
            string filepath;
            string filename = null;
            Note mNote = new Note();
            if (txt_TieuDe.Text == "")
                filename = "Không tiêu đề";
            else
                filename = txt_TieuDe.Text;
            mNote.TaoNote(filename, txt_note.Text, lbTenTag.Text);

        }


        private void txt_writeNote_TextChanged(object sender, EventArgs e)
        {
          
        }

        OpenFileDialog ofd = new OpenFileDialog();
        
        public void SaveFile()
        {

        }

        public void readNote()
        {
            ofd.InitialDirectory = Path.Combine(currentDirectory, "Data");
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                double size;
                float size1;
                string text;
                
                FontStyle style;
                ofd.Filter = "TXT | *.txt";
                sr = new StreamReader(ofd.FileName);
                
                text = sr.ReadToEnd();
                txt_note.Text = text;
                string lastFolderName = Path.GetFileName(Path.GetDirectoryName(ofd.FileName));
                lbTenTag.Text = lastFolderName;
                //_path = ofd.FileName;
                string path_tieuDe = Path.GetFileName(ofd.FileName);
                string tieuDe = path_tieuDe.Substring(0, path_tieuDe.Length - 4);
                txt_TieuDe.Text = tieuDe;
                
                sr.Close();
            }
        }
         public void readNote(string oder)
        {

            txt_note.Text = _note._noiDung ;         
            lbTenTag.Text = _note._loaiTag;
            txt_TieuDe.Text = _note._tieuDe;
        }

        private void SaveNote()
        {
            Note mNote = new Note();
            //mNote.SaveNote(_path,txt_note.Text);
        }
        private void label1_Click(object sender, EventArgs e)
        {
            NoteBUS noteBUS = new NoteBUS();
         
            Note addNote = new Note();
            addNote._thoiGianTao = System.DateTime.Now.ToLocalTime().Date ;
            addNote._tieuDe = txt_TieuDe.Text;
            addNote._noiDung = txt_note.Text;
            addNote._loaiTag = lbTenTag.Text;

            addNote._font = "None";
            addNote._path = null;
            
            noteBUS.ThemNote(addNote);

            if (oder == 0)
            {
                string name = txt_TieuDe.Text;
                createFile(name);
            }
            else
            {
                SaveNote();
            }

            this.Close();
        }


        private void RemoveLetter()
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //panel2.Visible = true;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            //panel2.Visible = false;
            readNote();
        }        

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_date.Text =System.DateTime.Now.ToLocalTime().ToString("dd/MM/yyyy  hh:mm:ss tt");
        }




        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {

            togMove = 1;
            MaxValX = e.X;
            MaxValY = e.Y;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            togMove = 0;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (togMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MaxValX, MousePosition.Y - MaxValY);
            }
        }


        private void btnChonTag_Click(object sender, EventArgs e)
        {
            fTag f = new fTag(this);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        public void SetTenTag(string tenTag)
        {
            lbTenTag.Text = tenTag;
        }

        private void chọnMẫuNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnHideBG();
        }



        private void bg_note1_Click(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"Resources/note2.jpg");

            if (myimage ==null)
            {
                MessageBox.Show("Không có Resources");
            } 
            else
            {
                note_model.Image = myimage;
                HideBG();
            }
        }

        private void bg_note3_Click(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"Resources/note3.jpg");
            if (myimage == null)
            {
                MessageBox.Show("Không có Resources");
            }
            else
            {
                note_model.Image = myimage;
                HideBG();
            }
        }

        private void bg_note2_Click(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"Resources/note1.jpg");
            if (myimage == null)
            {
                MessageBox.Show("Không có Resources");
            }
            else
            {
                note_model.Image = myimage;
                HideBG();
            }
        }

        private void HideBG()
        {
            bg_note1.Hide();
            bg_note2.Hide();
            bg_note3.Hide();
            back_Ground.Hide();
            bg_note4.Hide();
            txt_ChonMauNote.Hide();
            bg_Note.Visible = true;
        }
        private void UnHideBG()
        {
            bg_Note.Hide();
            bg_note1.Visible = true;
            bg_note2.Visible = true;
            bg_note3.Visible = true;
            bg_note4.Visible = true;
            back_Ground.Visible = true;
            txt_ChonMauNote.Visible = true;

        }

        private void bg_note4_Click(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"Resources/Sticky Note Background.jpg");
            if (myimage == null)
            {
                MessageBox.Show("Không có Resources");
            }
            else
            {
                note_model.Image = myimage;
                HideBG();
            }
        }


    }
}