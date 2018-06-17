namespace Shape.GUI
{
    partial class fListNotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fListNotes));
            this.button2 = new System.Windows.Forms.Button();
            this.listTagNote = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tag = new System.Windows.Forms.ImageList(this.components);
            this.Note = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.txt_Tag = new System.Windows.Forms.TextBox();
            this.lb_Tag = new System.Windows.Forms.Label();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Shape.Properties.Resources.blank_sticky_note;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(175, 22);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Note";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Click_ListNotes);
            // 
            // listTagNote
            // 
            this.listTagNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listTagNote.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listTagNote.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTagNote.GridLines = true;
            this.listTagNote.LargeImageList = this.Tag;
            this.listTagNote.Location = new System.Drawing.Point(17, 56);
            this.listTagNote.Margin = new System.Windows.Forms.Padding(2);
            this.listTagNote.Name = "listTagNote";
            this.listTagNote.Size = new System.Drawing.Size(240, 279);
            this.listTagNote.SmallImageList = this.Tag;
            this.listTagNote.TabIndex = 2;
            this.listTagNote.UseCompatibleStateImageBehavior = false;
            this.listTagNote.View = System.Windows.Forms.View.Tile;
            this.listTagNote.SelectedIndexChanged += new System.EventHandler(this.listTag);
            this.listTagNote.DoubleClick += new System.EventHandler(this.listTagNote_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Tag";
            this.columnHeader1.Width = 50;
            // 
            // Tag
            // 
            this.Tag.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Tag.ImageStream")));
            this.Tag.TransparentColor = System.Drawing.Color.Transparent;
            this.Tag.Images.SetKeyName(0, "tag.ico");
            // 
            // Note
            // 
            this.Note.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Note.ImageStream")));
            this.Note.TransparentColor = System.Drawing.Color.Transparent;
            this.Note.Images.SetKeyName(0, "294.png");
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.BackgroundImage = global::Shape.Properties.Resources.TagGamesLogo_JustTag_WhiteOutline;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(80, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 30);
            this.button1.TabIndex = 0;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.click_ListTags);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1.Location = new System.Drawing.Point(14, 28);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 17);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Sort by:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox2.Location = new System.Drawing.Point(142, 28);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(27, 17);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Or";
            // 
            // btn_Exit
            // 
            this.btn_Exit.AutoSize = true;
            this.btn_Exit.BackColor = System.Drawing.Color.White;
            this.btn_Exit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.Purple;
            this.btn_Exit.Location = new System.Drawing.Point(503, -1);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(27, 32);
            this.btn_Exit.TabIndex = 10;
            this.btn_Exit.Text = "x";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(262, 56);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(84, 40);
            this.btn_Them.TabIndex = 11;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(262, 102);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(84, 40);
            this.btn_Sua.TabIndex = 12;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(262, 148);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(84, 40);
            this.btn_Xoa.TabIndex = 13;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // txt_Tag
            // 
            this.txt_Tag.Location = new System.Drawing.Point(404, 77);
            this.txt_Tag.Name = "txt_Tag";
            this.txt_Tag.Size = new System.Drawing.Size(116, 20);
            this.txt_Tag.TabIndex = 14;
            // 
            // lb_Tag
            // 
            this.lb_Tag.AutoSize = true;
            this.lb_Tag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tag.Location = new System.Drawing.Point(352, 72);
            this.lb_Tag.Name = "lb_Tag";
            this.lb_Tag.Size = new System.Drawing.Size(43, 24);
            this.lb_Tag.TabIndex = 15;
            this.lb_Tag.Text = "Tag";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số Lượng Notes";
            this.columnHeader2.Width = 30;
            // 
            // fListNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 349);
            this.Controls.Add(this.lb_Tag);
            this.Controls.Add(this.txt_Tag);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listTagNote);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fListNotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ListNotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listTagNote;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ImageList Tag;
        private System.Windows.Forms.ImageList Note;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label btn_Exit;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.TextBox txt_Tag;
        private System.Windows.Forms.Label lb_Tag;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}