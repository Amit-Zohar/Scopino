// Scope .NET application - combined with Arduino program
// 08/09/12 v1.0 by Amit Zohar
// 06/12/12 v1.1 by Amit Zohar - decimal (,) bug correction. Thanks Zoa
// 23/10/14 v2.0 by Amit Zohar - faster sampling using A2D register, GUI improvements
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.Specialized;

namespace scope
{
    public partial class Form1 : Form
    {
        int height;
        int width;
        const int startX = 70;
        const int startY = 30;
        const int maxVolt = 5;
        const int maxVoltSamp = 1023;
        const int maxSamps = 1000;
        const int maxChannel = 2;
        int[,] samples = new int[maxChannel, maxSamps];
        Pen[] penSamp = new Pen[maxChannel];
        Pen penGrid = new Pen(Color.Green);
        Pen penMouse = new Pen(Color.Aqua, 2);
        Font font = new Font("Microsoft Sans Serif", 10);
        SolidBrush brush = new SolidBrush(Color.LawnGreen);
        string buf = "";
        string interval1;
        double voltDiv = 5;
        double[] avgs = new double[2];
        int sampChannels = 1, sampInterval = 200, sampAmp = 2, sampCoup = 0, sampTrigThreshold = 0, sampTrigMode = 0, sampA2D;
        int samSpan, samNum, samChan, timeDiv;
        int mouse1x = -1, mouse1y, mouse2x, mouse2y;
        bool trackChange = false, triged = false, newData = false, initGui = false; // Triggers
        DateTime newDataDT;
        public Form1() // Init form
        {
            penSamp[0] = new Pen(Color.White, 2);
            penSamp[1] = new Pen(Color.Yellow, 2);
            InitializeComponent();
            Text = "Scopino v2.0" + "".PadLeft(30) + "by Amit Zohar" + "".PadLeft(30) + "0÷5V, 20µsec resolution " + "".PadLeft(30) + "Click & Drag mouse on screen to measure" + "".PadLeft(30);
            listBoxVoltDiv.Items.Add("".PadLeft(8) + ((double)0.1).ToString() + " V");
            listBoxVoltDiv.Items.Add("".PadLeft(8) + ((double)0.5).ToString() + " V");
            interval1 = listBoxTimeDiv.Items[0].ToString();
            comboBox1.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            string[] args = Environment.GetCommandLineArgs(); // First command line parameter is COM#
            if (args.Length > 1) tryCom("COM" + args[1]);
            height = panel1.Height - startY - 30;
            width = panel1.Width - startX - 30;
            trigSingle(false);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) // Form close
        {
            com.Close();
        }

        private void com_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e) // Get COM data
        {
            try { buf = com.ReadLine(); }
            catch { };
        }

        private void timer1_Tick(object sender, EventArgs e) // Process COM data
        {
            panel1.Refresh(); // Draw screen
            if (trackChange) // Track bar changed
            {
                buildCommand();
                trackChange = false;
            }
        }

        private void trigSingle(bool enable)
        {
            if (cTrigRepeat.Checked) enable = false;
            if (enable)
            {
                cTrigSingle.Enabled = true;
                cTrigSingle.Font = new Font(cTrigSingle.Font, FontStyle.Bold);
            }
            else
            {
                cTrigSingle.Enabled = false;
                cTrigSingle.Font = new Font(cTrigSingle.Font, FontStyle.Regular);
            }
        }
        private void button1_Click(object sender, EventArgs e) // Arm trigger
        {
            trigSingle(false);
            triged = false;
            buildCommand();
        }

        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            sampTrigThreshold = Convert.ToInt32(cTrigLevel.Value);
            trackChange = true;
        }

        private void trackBar1_Scroll(object sender, EventArgs e) // Track bar = trigger level
        {
            //            sampTrigThreshold = Convert.ToInt32(trackBar1.Value);
            //            trackChange = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e) // Update display
        {
            try
            {
                if ((buf != "") && ((cFreeRun.Checked) || (!cFreeRun.Checked &&
                    ((!triged) || (cTrigRepeat.Checked))))) // Update only if "free run" or human trigger
                {
                    newData = true;
                    triged = true;
                    int samp;
                    // Protocol: *Channel>Time resolution:Sample1,Sample2...,
                    if (buf.IndexOf("*") == -1) return; // Start of data
                    buf = buf.Remove(0, buf.IndexOf("*") + 1);
                    samChan = Convert.ToInt32(buf.Substring(0, buf.IndexOf(':'))); // Channel
                    buf = buf.Remove(0, buf.IndexOf(":") + 1);
                    samSpan = Convert.ToInt32(buf.Substring(0, buf.IndexOf('>'))); // Samples resolution
                    buf = buf.Remove(0, buf.IndexOf(">") + 1);

                    if (panelCom.Visible) // We have data from COM port
                    {
                        comboBox1.Enabled = false;
                        panelCom.Visible = false; // COM port selection - disappear
                        foreach (Control c in panel2.Controls) if (c.Tag == null) c.Enabled = true; // Enable controls
                        label2.ForeColor = DefaultForeColor;
                        listBoxVoltDiv.SelectedIndex = 1;
                        listBoxTimeDiv.SelectedIndex = 3;
                        initGui = true;
                    }
                    string[] samString = buf.Split(','); // Samples
                    samNum = samString.Length - 1;

                    float avg = 0;
                    for (int i = 0; i < samNum; i++) // Save sample points
                    {
                        samp = Convert.ToInt32(samString[i], 16); // Samples in HEX
                        samples[samChan - 1, i] = samp;
                        avg += samp;
                    }
                    avgs[samChan - 1] = avg / samNum / maxVoltSamp * maxVolt;

                    if (samChan < sampChannels - 1) return; // Wait for last sample
                }

                //////////////////// Paint screen
                if ((com.IsOpen) && (!panelCom.Visible))
                {
                    if (newData) // Data beat
                    {
                        if (((TimeSpan)(DateTime.Now - newDataDT)).Milliseconds > 200)
                        {
                            trigSingle(true);
                            cTrigPulse.Checked = !cTrigPulse.Checked;
                            newData = false;
                            newDataDT = DateTime.Now;
                        }
                    }
                    for (int i = 0; i <= 10; i++) // Grid
                    {
                        string label;
                        SizeF stringSize = new SizeF();
                        e.Graphics.DrawLine(penGrid, startX + i * width / 10, startY + height, startX + i * width / 10, startY); // Vertical
                        label = ((float)(samSpan * i) / 20).ToString(); // Time labels
                        if (i > 0) label += "ms";
                        stringSize = e.Graphics.MeasureString(label, font);
                        e.Graphics.DrawString(label, font, brush, startX + i * width / 10 - stringSize.Width / 2, startY + height + 5);
                        e.Graphics.DrawLine(penGrid, startX, startY + height - i * height / 10, startX + 10 * width / 10, startY + height - i * height / 10); // Horizontal
                        label = ((float)(i) * voltDiv / 10).ToString() + "V"; // Voltage labels
                        stringSize = e.Graphics.MeasureString(label, font);
                        e.Graphics.DrawString(label, font, brush, startX - stringSize.Width - 5, startY + height - i * height / 10 - stringSize.Height / 2);
                    }

                    Point[] samPoints = new Point[samNum]; // Prepare sample points
                    for (int ch = sampChannels - 1; ch >= 0; ch--) // Scan all channels
                    {
                        for (int i = 0; i < samNum; i++)
                            samPoints[i] = new Point(startX + i * width / (samNum - 1), startY + height - samples[ch, i] * height * maxVolt / maxVoltSamp / (int)(voltDiv));
                        e.Graphics.DrawLines(penSamp[ch], samPoints); // Samples
                    }
                    if (mouse1x > -1) // User draws rectangle
                    {
                        e.Graphics.DrawLine(penMouse, mouse1x, mouse1y, mouse1x, mouse2y); // 1|
                        e.Graphics.DrawLine(penMouse, mouse2x, mouse1y, mouse2x, mouse2y); // 2|
                        e.Graphics.DrawLine(penMouse, mouse1x, mouse1y, mouse2x, mouse1y); // 1-
                        e.Graphics.DrawLine(penMouse, mouse1x, mouse2y, mouse2x, mouse2y); // 2-
                    }

                    switch (samChan) // Update average voltage
                    {
                        case 1: tAvg1.Text = avgs[0].ToString("0.00"); break;
                        case 2: tAvg2.Text = avgs[1].ToString("0.00"); break;
                    }
                }
            }
            catch { };
            buf = "";
        }

        ///////////////////////// Process serial input
        // Protocol: *C<channel>T<time resolution>A<A2D register>S<samples division>V<voltage amp.>P<voltage coupling>G<trigger value>H<trigger mode>E
        // (C) Channel: 1-2
        // (T) Time resolution: at least 20uSec per channel
        // (A) A2D sampling speed: 0-7
        // (S) Samples division: divide # of samples for speed. Used only for multiple channels
        // (V) Voltage amp.: 1=amplified (H/W), 2=0-5V as-is, 3=0-50V attenuated by 10 (H/W)
        // (P) Voltage coupling: 0=DC, 1=AC (H/W)
        // (G) Trigger value: value needed to be crossed for trigger (0-1023)
        // (H) Trigger mode: 0=free run, 1=positive slope, 2=negative slope, 3=both slopes
        // Example: *C10T5S333V8P1G1H2E
        // Default: *C1T200S1V2P0G0H0E
        private void buildCommand() // To send Arduino
        {
            if (!initGui) return;
            if (channel2.Checked) sampChannels = 2; // Read controls. Channels and samp division are the same after achieving faster sampling
            else sampChannels = 1;

            if (cFreeRun.Checked) sampTrigMode = 0;
            if (cTrigRise.Checked) sampTrigMode = 1;
            if (cTrigFall.Checked) sampTrigMode = 2;
            if (cTrigBoth.Checked) sampTrigMode = 3;
            string sel;
            sel = listBoxVoltDiv.Text.Trim(); // Volt/Div
            sel = sel.Substring(0, sel.IndexOf(' '));
            voltDiv = Convert.ToDouble(sel) * 10;
            cTrigLevel.Maximum = maxVoltSamp * (int)(voltDiv) / maxVolt;

            sel = listBoxTimeDiv.Text.Trim(); // Time/Div
            sel = sel.Substring(0, sel.IndexOf(' '));
            timeDiv = Convert.ToInt32(sel);

            if (timeDiv < 10) sampA2D = 3; // Faster sampling rate
            else sampA2D = 7; // Default sampling rate

            sampInterval = timeDiv * 20 * sampChannels;
            labelSamp.Text = "Sampling @ " + Convert.ToDecimal(1000) / Convert.ToDecimal(sampInterval) + "KHz";

            string command = "*C" + sampChannels + "T" + sampInterval + "A" + sampA2D + "S" + sampChannels + "V" + sampAmp + "P" + sampCoup + "G" + sampTrigThreshold + "H" + sampTrigMode + "E";
            com.Write(command);
        }

        private void settingChange(object sender, EventArgs e) // Commit setting changes
        {
            if (channel2.Checked) pAvg2.Visible = true; // Show/hide Ch.2 average
            else pAvg2.Visible = false;
            //            switch (sampAmp) // H/W
            //            {
            //            }
            if (cFreeRun.Checked) // Triggers
            {
                trigSingle(false);
                cTrigRepeat.Enabled = false;
                cTrigLevel.Enabled = false;
            }
            else
            {
                cTrigRepeat.Enabled = true;
                trigSingle(true);
                cTrigLevel.Enabled = true;
            }
            buildCommand();
        }

        void tryCom(string comName) // Try to communicate with Arduino
        {
            com.Close();
            com.PortName = comName;
            com.Open();
            buildCommand();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // Select COM port
        {
            tryCom(comboBox1.Text);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e) // Mouse mark
        {
            mouse1x = mouse2x = e.X;
            mouse1y = mouse2y = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if ((com.IsOpen) && (!panelCom.Visible) && (mouse1x > -1))
            {
                mouse2x = e.X;
                mouse2y = e.Y;
                float dt = Math.Abs((float)((mouse2x - mouse1x) * timeDiv * 10) / width);
                string msg = "Voltage = " + (Math.Abs((float)((mouse2y - mouse1y) * voltDiv) / height)).ToString("0.000") + " V" +
                    "\nTime = " + dt.ToString() + " msec";
                if (dt > 0)
                {
                    if (dt > 1) msg = msg + "\nFreq = " + (1 / dt * 1000).ToString("0.0") + " Hz";
                    else msg = msg + "\nFreq = " + (1 / dt).ToString("0.00") + " KHz";
                }
                MessageBox.Show(msg);
            }
            mouse1x = -1;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.X < 0) || (e.Y < 0) || (e.X > (sender as Panel).Width) || (e.Y > (sender as Panel).Height)) mouse1x = -1; // Out of range
            else
            {
                mouse2x = e.X;
                mouse2y = e.Y;
            }
        }

        protected override CreateParams CreateParams // No flicker !!!
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private const int WM_SYSCOMMAND = 0x0112; // Prevent minimize
        private const int SC_MINIMIZE = 0xf020;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_SYSCOMMAND)
            {
                if (m.WParam.ToInt32() == SC_MINIMIZE)
                {
                    m.Result = IntPtr.Zero;
                    return;
                }
            }
            base.WndProc(ref m);
        }
    }
}
