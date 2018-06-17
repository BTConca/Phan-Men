using Shape.GUI;
using System;
using System.Windows.Forms;
using Shape.MO;

namespace Shape.GUI
{

    public partial class fMenu : Form
    {
        int togMove;
        int MaxValX;
        int MaxValY;

        public fMenu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void NewNote_Click(object sender, EventArgs e)
        {
            fNote newnote = new fNote(0);

            newnote.Show();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            togMove = 1;
            MaxValX = e.X;
            MaxValY = e.Y;

        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if(togMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MaxValX, MousePosition.Y - MaxValY);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            togMove = 0;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ListData(object sender, EventArgs e)
        {
            fListNotes listview = new fListNotes();

            listview.Show();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            fNote newnote = new fNote(1);

            newnote.Show();
        }
    }
}
