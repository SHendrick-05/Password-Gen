using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Password_Generator
{
    public partial class Main : Form
    {
        // Draggable
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Drag(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // Set up form
        public Main()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // Password gen
        private void genButton_Click(object sender, EventArgs e)
        {
            output.Text = numberGen.genPassword((int)len.Value, lower.Checked, upper.Checked, number.Checked, symb.Checked);
        }
    }
}
