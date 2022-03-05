using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace speedster
{

    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        Mem m = new Mem();
        string speedAddress = "RallyTrophy.exe + 0x00163FDC, 284";
        double ts = 0.00d;

        public Form1()
        {
            InitializeComponent();
            this.TopMost = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {
            timer2.Interval = 10000;
            timer2.Start();
            int PID = m.GetProcIdFromName("RallyTrophy");
            if (PID > 0)
            {
                m.OpenProcess(PID);
                timer1.Interval = 1;
                timer1.Start();
            }

            Console.WriteLine(PID + "");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.TopMost = true;
            f.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);

            int a = (int)m.ReadFloat(speedAddress, "", false);

            if (a < 0)
            {
                label1.Text = a.ToString("00") + "Km/h";
            }
            else
            {
                label1.Text = a.ToString("000") + "Km/h";
            }

            if (a > ts)
            {
                ts = a;
                label2.Text = a.ToString("000") + "Km/h";
            }

            if (changeColorDependingOnSpeedToolStripMenuItem.Checked)
            {
                if (a < 30)
                {
                    label1.ForeColor = Color.Yellow;
                }
                else if (a > 30 && a < 50)
                {
                    label1.ForeColor = Color.Orange;
                }
                else if (a > 50 && a < 60)
                {
                    label1.ForeColor = Color.Red;
                }
                else if (a > 60 && a < 70)
                {
                    label1.ForeColor = Color.DarkRed;
                }
                else if (a >= 70)
                {
                    label1.ForeColor = Color.Black;
                }
            }
            else
            {
                label1.ForeColor = Color.Black;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void showHighestSpeedToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (showHighestSpeedToolStripMenuItem.Checked)
            {
                this.Size = new Size(415, 195);
            } else if (!showHighestSpeedToolStripMenuItem.Checked)
            {
                this.Size = new Size(415, 100);
            }
        }

        private void resetHighestSpeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ts = 0.00d;
            label2.Text = "000Km/h";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int PID = m.GetProcIdFromName("RallyTrophy");
            if (PID > 0)
            {
                m.OpenProcess(PID);
                timer1.Interval = 1;
                timer1.Start();
            }

            Console.WriteLine(PID + "");
        }
    }
}
