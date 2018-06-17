using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Shape.GUI;
using Shape.MO;

namespace Shape
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fMenu());
            //Application.Run(new Form_note());
           
        }
    }
}