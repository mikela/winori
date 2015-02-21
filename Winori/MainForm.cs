﻿using MouseKeyboardActivityMonitor;
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
using System.Collections.Specialized;

namespace Winori
{
    public partial class MainForm : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        private KeyboardHookListener m_KeyboardHookManager;

        private int hw;
        private int hh;
        
        private ISet<Keys> currentKeysDown = new HashSet<Keys>();
        private ISet<Keys> dlCombo;
        private ISet<Keys> drCombo;
        private ISet<Keys> ulCombo;
        private ISet<Keys> urCombo;

        private bool changeUL = false;
        private bool changeUR = false;
        private bool changeDL = false;
        private bool changeDR = false;


        public MainForm()
        {
            InitializeComponent();
            
            m_KeyboardHookManager = new KeyboardHookListener(new GlobalHooker());
            m_KeyboardHookManager.Enabled = true;
            m_KeyboardHookManager.KeyDown += m_KeyboardHookManager_KeyDown;
            m_KeyboardHookManager.KeyUp += m_KeyboardHookManager_KeyUp;

            Rectangle screen = Screen.FromControl(this).WorkingArea;
            hw = screen.Width / 2;
            hh = screen.Height / 2;

            initKeyCombos();

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.WindowState = FormWindowState.Minimized;
        }

        private void initKeyCombos()
        {
            ulCombo = Properties.Settings.Default.ulComboSetting;
            if (ulCombo == null)
            {
                ulCombo = new HashSet<Keys>();
                ulCombo.Add(Keys.LWin);
                ulCombo.Add(Keys.NumPad7);
                Properties.Settings.Default.ulComboSetting = new HashSet<Keys>();
            }

            dlCombo = Properties.Settings.Default.dlComboSetting;
            if (dlCombo == null)
            {
                dlCombo = new HashSet<Keys>();
                dlCombo.Add(Keys.LWin);
                dlCombo.Add(Keys.NumPad1);
                Properties.Settings.Default.dlComboSetting = new HashSet<Keys>();
            }

            drCombo = Properties.Settings.Default.drComboSetting;
            if (drCombo == null)
            {
                drCombo = new HashSet<Keys>();
                drCombo.Add(Keys.LWin);
                drCombo.Add(Keys.NumPad3);
                Properties.Settings.Default.drComboSetting = new HashSet<Keys>();
            }

            urCombo = Properties.Settings.Default.urComboSetting;
            if (urCombo == null)
            {
                urCombo = new HashSet<Keys>();
                urCombo.Add(Keys.LWin);
                urCombo.Add(Keys.NumPad9);
                Properties.Settings.Default.urComboSetting = new HashSet<Keys>();
            }

            labelUL.Text = getString(ulCombo);
            labelUR.Text = getString(urCombo);
            labelDL.Text = getString(dlCombo);
            labelDR.Text = getString(drCombo);
        }

        private String getString(ISet<Keys> sk)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in sk)
            {
                sb.Append(item.ToString() + " ");
            }
            return sb.ToString();
        }

        void m_KeyboardHookManager_KeyUp(object sender, KeyEventArgs e)
        {
            if (changeUL || changeUR || changeDL || changeDR)
            {
                if (currentKeysDown.Count != 0)
                {
                    if (changeUL)
                    {
                        saveSet(currentKeysDown, ulCombo, Properties.Settings.Default.ulComboSetting);
                        labelUL.Text = getString(ulCombo);
                        changeUL = false;
                        buttonUL.Text = "Change";
                    }
                    else if (changeUR)
                    {
                        saveSet(currentKeysDown, urCombo, Properties.Settings.Default.urComboSetting);
                        labelUR.Text = getString(urCombo);
                        changeUR = false;
                        buttonUR.Text = "Change";
                    }
                    else if (changeDL)
                    {
                        saveSet(currentKeysDown, dlCombo, Properties.Settings.Default.dlComboSetting);
                        labelDL.Text = getString(dlCombo);
                        changeDL = false;
                        buttonDL.Text = "Change";
                    }
                    else if (changeDR)
                    {
                        saveSet(currentKeysDown, drCombo, Properties.Settings.Default.drComboSetting);
                        labelDR.Text = getString(drCombo);
                        changeDR = false;
                        buttonDR.Text = "Change";
                    }
                }
                currentKeysDown.Clear();
            }
            else
            {
                currentKeysDown.Remove(e.KeyCode);
            }
        }

        private void copySet(ISet<Keys> source, ISet<Keys> dest)
        {
            dest.Clear();
            foreach (Keys item in source)
            {
                dest.Add(item);
            }
        }
        private void saveSet(ISet<Keys> source, ISet<Keys> dest, ISet<Keys> setting)
        {
            dest.Clear();
            setting.Clear();
            foreach (Keys item in source)
            {
                dest.Add(item);
                setting.Add(item);
            }
            Properties.Settings.Default.Save();
        }

        void m_KeyboardHookManager_KeyDown(object sender, KeyEventArgs e)
        {
            currentKeysDown.Add(e.KeyCode);
            
            if (!(changeUL || changeUR || changeDL || changeDR))
            {
                if (currentKeysDown.SetEquals(dlCombo))
                {
                    moveWindow(0, hh);
                }
                else if (currentKeysDown.SetEquals(ulCombo))
                {
                    moveWindow(0, 0);
                }
                else if (currentKeysDown.SetEquals(drCombo))
                {
                    moveWindow(hw, hh);
                }
                else if (currentKeysDown.SetEquals(urCombo))
                {
                    moveWindow(hw, 0);
                }
            }
        }

        private void printKeysDown()
        {
            String combo = "";
            foreach (var item in currentKeysDown)
            {
                combo +=  item.ToString() + " ";
            }
            labelUL.Text = combo;
        }
                
        private void moveWindow(int x, int y)
        {
            IntPtr handle = GetForegroundWindow();
            Rectangle screen = Screen.FromHandle(handle).WorkingArea;
            hw = screen.Width / 2;
            hh = screen.Height / 2;
            if (!Screen.FromHandle(handle).Primary)
            {
                x += Screen.PrimaryScreen.Bounds.Width;
            }
            MoveWindow(handle, x, y, hw, hh, true);
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

        private void buttonUL_Click(object sender, EventArgs e)
        {
            buttonUL.Text = "Changing";
            changeUL = true;
        }

        private void buttonUR_Click(object sender, EventArgs e)
        {
            buttonUR.Text = "Changing";
            changeUR = true;
        }

        private void buttonDL_Click(object sender, EventArgs e)
        {
            buttonDL.Text = "Changing";
            changeDL = true;
        }

        private void buttonDR_Click(object sender, EventArgs e)
        {
            buttonDR.Text = "Changing";
            changeDR = true;
        }
                
    }
}
