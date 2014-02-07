using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            TopMost = true;
            Cursor.Hide();
            richTextBox1.Text = ("A problem has been detected and windows has been shut down to prevent damage\nto you computer.\n\nIRQ_LESS_THAN_EQUAL\n\nIf this is the first time you have seen this Stop error screen,\nrestart your computer. if this screen appears again, follow\nthese steps:\n\nCheck to make sure any new hardware or software is properly installed.\nIf this is a new installation, ask your hardware or software manutacturer\nfor any windows updates you might need.\n\nIf problems continue, disable or remove any newly installed hardware\nor software. Disable BIOS memory options such as cashing or shadowing.\nIf you need to use Safe Mode to remove to disable components, restart\nyour computer, press F8 to select Advanced Startup Options, and then\nselect safemode.\n\nTechnical information:\n\n***STOP: 0x000000050 (0xFD3094C2,0xFBFE716,x000000000)\n\n\n***SPCMDCON.SYS - Adress FBFE7617 base at FBFE5000, DateStamp 3d6dd67c");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
