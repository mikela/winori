using MouseKeyboardActivityMonitor;
using MouseKeyboardActivityMonitor.WinApi;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winori
{
    public partial class MainForm : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        private KeyboardHookListener m_KeyboardHookManager;

        private char preKeyDown = ' ';
        private int hw;
        private int hh;

        public MainForm()
        {
            InitializeComponent();

            m_KeyboardHookManager = new KeyboardHookListener(new GlobalHooker());
            m_KeyboardHookManager.Enabled = true;
            m_KeyboardHookManager.KeyPress += HookManager_KeyPress;

            Rectangle screen = Screen.FromControl(this).WorkingArea;
            hw = screen.Width / 2;
            hh = screen.Height / 2;

            this.WindowState = FormWindowState.Minimized;
        }
        
        private void HookManager_KeyPress(object sender, KeyPressEventArgs e)
        {
            // QQ: move up left
            if (preKeyDown == 'Q' && e.KeyChar == 'Q')
            {
                preKeyDown = ' ';
                moveWindow(0, 0);
            }
            // WW: move up right
            else if (preKeyDown == 'W' && e.KeyChar == 'W')
            {
                preKeyDown = ' ';
                moveWindow(hw, 0);
            }
            // AA: move down left
            else if (preKeyDown == 'A' && e.KeyChar == 'A')
            {
                preKeyDown = ' ';
                moveWindow(0, hh);
            }
            // SS: move down right
            else if (preKeyDown == 'S' && e.KeyChar == 'S')
            {
                preKeyDown = ' ';
                moveWindow(hw, hh);
            }
            else
            {
                preKeyDown = e.KeyChar;
            }            
        }
        
        private void moveWindow(int x, int y)
        {
            MoveWindow(GetForegroundWindow(), x, y, hw, hh, true);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon.ShowBalloonTip(3000);
                this.ShowInTaskbar = false;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        private void pictureBoxCC_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://creativecommons.org/licenses/by-sa/4.0/");
        }

    }
}
