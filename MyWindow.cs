using System;
using System.Windows.Forms;

namespace MyFrmApp
{
    class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            Application.Run(new MyForm());
        }

    }
}