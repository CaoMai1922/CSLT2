using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Chuong4_Buoi1
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
            // Chọn form để hiển thị
         //   Form1 beginForm = new Form1();

            Calculator beginForm = new Calculator();
            // Thực thi form đã chọn
            Application.Run(beginForm);


        }
    }
}
