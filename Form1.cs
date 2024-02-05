using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Exception_Magnets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.Write("When it ");
            ExTestDrive.Zero("yes");
            Console.Write(" it ");
            ExTestDrive.Zero("no");
            Console.WriteLine(".");

        }
    }
}
