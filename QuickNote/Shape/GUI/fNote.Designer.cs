namespace Shape.GUI
{
    partial class fNote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chọnMẫuNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_ChonMauNote = new System.Windows.Forms.Label();
            this.bg_note4 = new System.Windows.Forms.PictureBox();
            this.bg_note3 = new System.Windows.Forms.PictureBox();
            this.bg_note2 = new System.Windows.Forms.PictureBox();
            this.bg_note1 = new System.Windows.Forms.PictureBox();
            this.bg_Note = new System.Windows.Forms.Panel();
            this.txt_TieuDe = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChonTag = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbTenTag = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.txt_note = new System.Windows.Forms.RichTextBox();
            this.note_model = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTieuDe = new System.Windows.Forms.Label();
            this.back_Ground = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bg_note4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg_note3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg_note2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg_note1)).BeginInit();
            this.bg_Note.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.note_model)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_Ground)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chọnMẫuNoteToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 52);
            // 
            // chọnMẫuNoteToolStripMenuItem
            // 
            this.chọnMẫuNoteToolStripMenuItem.Name = "chọnMẫuNoteToolStripMenuItem";
            this.chọnMẫuNoteToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.chọnMẫuNoteToolStripMenuItem.Text = "Chọn mẫu note";
            this.chọnMẫuNoteToolStripMenuItem.Click += new System.EventHandler(this.chọnMẫuNoteToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // txt_ChonMauNote
            // 
            this.txt_ChonMauNote.AutoSize = true;
            this.txt_ChonMauNote.BackColor = System.Drawing.Color.White;
            this.txt_ChonMauNote.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ChonMauNote.Location = new System.Drawing.Point(474, -1);
            this.txt_ChonMauNote.Name = "txt_ChonMauNote";
            this.txt_ChonMauNote.Size = new System.Drawing.Size(251, 35);
            this.txt_ChonMauNote.TabIndex = 9;
            this.txt_ChonMauNote.Text = "Chọn một mẫu note";
            // 
            // bg_note4
            // 
            this.bg_note4.Image = global::Shape.Properties.Resources.Sticky_Note_Background;
            this.bg_note4.Location = new System.Drawing.Point(654, 54);
            this.bg_note4.Margin = new System.Windows.Forms.Padding(2);
            this.bg_note4.Name = "bg_note4";
            this.bg_note4.Size = new System.Drawing.Size(286, 240);
            this.bg_note4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bg_note4.TabIndex = 10;
            this.bg_note4.TabStop = false;
            this.bg_note4.Visible = false;
            this.bg_note4.Click += new System.EventHandler(this.bg_note4_Click);
            // 
            // bg_note3
            // 
            this.bg_note3.Image = global::Shape.Properties.Resources.note3;
            this.bg_note3.Location = new System.Drawing.Point(654, 314);
            this.bg_note3.Margin = new System.Windows.Forms.Padding(2);
            this.bg_note3.Name = "bg_note3";
            this.bg_note3.Size = new System.Drawing.Size(286, 240);
            this.bg_note3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bg_note3.TabIndex = 6;
            this.bg_note3.TabStop = false;
            this.bg_note3.Visible = false;
            this.bg_note3.Click += new System.EventHandler(this.bg_note3_Click);
            // 
            // bg_note2
            // 
            this.bg_note2.Image = global::Shape.Properties.Resources.note2;
            this.bg_note2.Location = new System.Drawing.Point(340, 314);
            this.bg_note2.Margin = new System.Windows.Forms.Padding(2);
            this.bg_note2.Name = "bg_note2";
            this.bg_note2.Size = new System.Drawing.Size(286, 238);
            this.bg_note2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bg_note2.TabIndex = 7;
            this.bg_note2.TabStop = false;
            this.bg_note2.Visible = false;
            this.bg_note2.Click += new System.EventHandler(this.bg_note2_Click);
            // 
            // bg_note1
            // 
            this.bg_note1.Image = global::Shape.Properties.Resources.note1;
            this.bg_note1.Location = new System.Drawing.Point(340, 54);
            this.bg_note1.Margin = new System.Windows.Forms.Padding(2);
            this.bg_note1.Name = "bg_note1";
            this.bg_note1.Size = new System.Drawing.Size(286, 240);
            this.bg_note1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bg_note1.TabIndex = 5;
            this.bg_note1.TabStop = false;
            this.bg_note1.Visible = false;
            this.bg_note1.Click += new System.EventHandler(this.bg_note1_Click);
            // 
            // bg_Note
            // 
            this.bg_Note.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bg_Note.BackgroundImage = global::Shape.Properties.Resources.fantasy_game_background_by_seiorai_d8d7yts;
            this.bg_Note.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bg_Note.ContextMenuStrip = this.contextMenuStrip1;
            this.bg_Note.Controls.Add(this.txt_TieuDe);
            this.bg_Note.Controls.Add(this.panel1);
            this.bg_Note.Controls.Add(this.label1);
            this.bg_Note.Controls.Add(this.lbTieuDe);
            this.bg_Note.Location = new System.Drawing.Point(0, 0);
            this.bg_Note.Margin = new System.Windows.Forms.Padding(2);
            this.bg_Note.Name = "bg_Note";
            this.bg_Note.Size = new System.Drawing.Size(335, 341);
            this.bg_Note.TabIndex = 4;
            this.bg_Note.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.bg_Note.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.bg_Note.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // txt_TieuDe
            // 
            this.txt_TieuDe.BackColor = System.Drawing.SystemColors.Window;
            this.txt_TieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TieuDe.Location = new System.Drawing.Point(83, 8);
            this.txt_TieuDe.Name = "txt_TieuDe";
            this.txt_TieuDe.Size = new System.Drawing.Size(189, 26);
            this.txt_TieuDe.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnChonTag);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lbl_date);
            this.panel1.Controls.Add(this.txt_note);
            this.panel1.Controls.Add(this.note_model);
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 300);
            this.panel1.TabIndex = 3;
            // 
            // btnChonTag
            // 
            this.btnChonTag.Location = new System.Drawing.Point(238, 248);
            this.btnChonTag.Name = "btnChonTag";
            this.btnChonTag.Size = new System.Drawing.Size(63, 23);
            this.btnChonTag.TabIndex = 10;
            this.btnChonTag.Text = "Chọn Tag";
            this.btnChonTag.UseVisualStyleBackColor = true;
            this.btnChonTag.Click += new System.EventHandler(this.btnChonTag_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lbTenTag);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Location = new System.Drawing.Point(46, 245);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(172, 26);
            this.panel3.TabIndex = 8;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lbTenTag
            // 
            this.lbTenTag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbTenTag.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbTenTag.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenTag.Location = new System.Drawing.Point(38, 0);
            this.lbTenTag.Margin = new System.Windows.Forms.Padding(2);
            this.lbTenTag.Name = "lbTenTag";
            this.lbTenTag.Size = new System.Drawing.Size(134, 16);
            this.lbTenTag.TabIndex = 0;
            this.lbTenTag.TextChanged += new System.EventHandler(this.tagNote);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox2.Font = new System.Drawing.Font("Lucida Handwriting", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Purple;
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(39, 19);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Tag:";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.Color.White;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_date.Location = new System.Drawing.Point(163, 273);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(30, 13);
            this.lbl_date.TabIndex = 5;
            this.lbl_date.Text = "Date";
            this.lbl_date.Click += new System.EventHandler(this.lbl_date_Click);
            // 
            // txt_note
            // 
            this.txt_note.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_note.BackColor = System.Drawing.Color.White;
            this.txt_note.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_note.ContextMenuStrip = this.contextMenuStrip1;
            this.txt_note.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_note.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_note.Location = new System.Drawing.Point(16, 44);
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(285, 196);
            this.txt_note.TabIndex = 0;
            this.txt_note.Text = "";
            this.txt_note.TextChanged += new System.EventHandler(this.txt_note_TextChanged);
            // 
            // note_model
            // 
            this.note_model.ContextMenuStrip = this.contextMenuStrip1;
            this.note_model.Image = global::Shape.Properties.Resources.Sticky_Note_Background;
            this.note_model.InitialImage = null;
            this.note_model.Location = new System.Drawing.Point(3, 0);
            this.note_model.Name = "note_model";
            this.note_model.Size = new System.Drawing.Size(332, 300);
            this.note_model.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.note_model.TabIndex = 1;
            this.note_model.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(306, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "x";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.AutoSize = true;
            this.lbTieuDe.BackColor = System.Drawing.Color.White;
            this.lbTieuDe.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDe.Location = new System.Drawing.Point(-1, 11);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(76, 23);
            this.lbTieuDe.TabIndex = 5;
            this.lbTieuDe.Text = "Tiêu Đề";
            // 
            // back_Ground
            // 
            this.back_Ground.BackgroundColor = System.Drawing.Color.White;
            this.back_Ground.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.back_Ground.Location = new System.Drawing.Point(340, 41);
            this.back_Ground.Name = "back_Ground";
            this.back_Ground.Size = new System.Drawing.Size(600, 513);
            this.back_Ground.TabIndex = 11;
            this.back_Ground.Visible = false;
            // 
            // fNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1095, 658);
            this.Controls.Add(this.bg_note4);
            this.Controls.Add(this.txt_ChonMauNote);
            this.Controls.Add(this.bg_note3);
            this.Controls.Add(this.bg_note2);
            this.Controls.Add(this.bg_note1);
            this.Controls.Add(this.bg_Note);
            this.Controls.Add(this.back_Ground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fNote";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Note";
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            this.Load += new System.EventHandler(this.Form_note_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bg_note4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg_note3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg_note2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg_note1)).EndInit();
            this.bg_Note.ResumeLayout(false);
            this.bg_Note.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.note_model)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_Ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox note_model;
        private System.Windows.Forms.RichTextBox txt_note;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel bg_Note;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox lbTenTag;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChonTag;
        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.TextBox txt_TieuDe;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chọnMẫuNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.PictureBox bg_note2;
        private System.Windows.Forms.PictureBox bg_note1;
        private System.Windows.Forms.PictureBox bg_note3;
        private System.Windows.Forms.Label txt_ChonMauNote;
        private System.Windows.Forms.PictureBox bg_note4;
        private System.Windows.Forms.DataGridView back_Ground;
    }
}

