namespace scope
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.com = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cTrigLevel = new System.Windows.Forms.TrackBar();
            this.channel2 = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelCom = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelSamp = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listBoxVoltDiv = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pAvg1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.tAvg1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pAvg2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tAvg2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxTimeDiv = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cTrigPulse = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cTrigRepeat = new System.Windows.Forms.CheckBox();
            this.cTrigSingle = new System.Windows.Forms.Button();
            this.cTrigBoth = new System.Windows.Forms.RadioButton();
            this.cTrigFall = new System.Windows.Forms.RadioButton();
            this.cTrigRise = new System.Windows.Forms.RadioButton();
            this.cFreeRun = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.cTrigLevel)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelCom.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pAvg1.SuspendLayout();
            this.pAvg2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // com
            // 
            this.com.BaudRate = 115200;
            this.com.PortName = "COM3";
            this.com.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.com_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cTrigLevel
            // 
            this.cTrigLevel.Enabled = false;
            this.cTrigLevel.LargeChange = 25;
            this.cTrigLevel.Location = new System.Drawing.Point(175, 10);
            this.cTrigLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cTrigLevel.Maximum = 1023;
            this.cTrigLevel.Minimum = 1;
            this.cTrigLevel.Name = "cTrigLevel";
            this.cTrigLevel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.cTrigLevel.Size = new System.Drawing.Size(56, 845);
            this.cTrigLevel.SmallChange = 25;
            this.cTrigLevel.TabIndex = 3;
            this.cTrigLevel.TabStop = false;
            this.cTrigLevel.Tag = "1";
            this.cTrigLevel.TickFrequency = 10;
            this.cTrigLevel.Value = 1;
            this.cTrigLevel.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.cTrigLevel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseUp);
            // 
            // channel2
            // 
            this.channel2.BackColor = System.Drawing.Color.Yellow;
            this.channel2.Enabled = false;
            this.channel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.channel2.Location = new System.Drawing.Point(33, 137);
            this.channel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.channel2.Name = "channel2";
            this.channel2.Size = new System.Drawing.Size(121, 25);
            this.channel2.TabIndex = 0;
            this.channel2.TabStop = false;
            this.channel2.Text = "Channel 2";
            this.channel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.channel2.UseVisualStyleBackColor = false;
            this.channel2.CheckedChanged += new System.EventHandler(this.settingChange);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1332, 869);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panelCom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(223, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 865);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // panelCom
            // 
            this.panelCom.BackColor = System.Drawing.Color.SkyBlue;
            this.panelCom.Controls.Add(this.label1);
            this.panelCom.Controls.Add(this.comboBox1);
            this.panelCom.Location = new System.Drawing.Point(307, 150);
            this.panelCom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCom.Name = "panelCom";
            this.panelCom.Size = new System.Drawing.Size(332, 161);
            this.panelCom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(57, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select COM port:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(100, 85);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 39);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelSamp);
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.channel2);
            this.panel2.Controls.Add(this.cTrigLevel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 865);
            this.panel2.TabIndex = 3;
            // 
            // labelSamp
            // 
            this.labelSamp.AutoSize = true;
            this.labelSamp.Enabled = false;
            this.labelSamp.Location = new System.Drawing.Point(23, 486);
            this.labelSamp.Name = "labelSamp";
            this.labelSamp.Size = new System.Drawing.Size(122, 17);
            this.labelSamp.TabIndex = 17;
            this.labelSamp.Text = "Sampling @ 5KHz";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listBoxVoltDiv);
            this.groupBox5.Enabled = false;
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox5.Location = new System.Drawing.Point(26, 216);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(131, 75);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Volt / Div";
            // 
            // listBoxVoltDiv
            // 
            this.listBoxVoltDiv.BackColor = System.Drawing.Color.CornflowerBlue;
            this.listBoxVoltDiv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxVoltDiv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxVoltDiv.FormattingEnabled = true;
            this.listBoxVoltDiv.ItemHeight = 20;
            this.listBoxVoltDiv.Location = new System.Drawing.Point(3, 21);
            this.listBoxVoltDiv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxVoltDiv.Name = "listBoxVoltDiv";
            this.listBoxVoltDiv.Size = new System.Drawing.Size(125, 52);
            this.listBoxVoltDiv.TabIndex = 0;
            this.listBoxVoltDiv.TabStop = false;
            this.listBoxVoltDiv.SelectedIndexChanged += new System.EventHandler(this.settingChange);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pAvg1);
            this.groupBox3.Controls.Add(this.pAvg2);
            this.groupBox3.Enabled = false;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox3.Location = new System.Drawing.Point(13, 10);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(153, 110);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DC level";
            // 
            // pAvg1
            // 
            this.pAvg1.Controls.Add(this.label7);
            this.pAvg1.Controls.Add(this.tAvg1);
            this.pAvg1.Controls.Add(this.label8);
            this.pAvg1.Location = new System.Drawing.Point(3, 20);
            this.pAvg1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pAvg1.Name = "pAvg1";
            this.pAvg1.Size = new System.Drawing.Size(136, 34);
            this.pAvg1.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(5, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Ch.1";
            // 
            // tAvg1
            // 
            this.tAvg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tAvg1.Location = new System.Drawing.Point(55, 4);
            this.tAvg1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tAvg1.Name = "tAvg1";
            this.tAvg1.ReadOnly = true;
            this.tAvg1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tAvg1.Size = new System.Drawing.Size(49, 26);
            this.tAvg1.TabIndex = 20;
            this.tAvg1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(111, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "V";
            // 
            // pAvg2
            // 
            this.pAvg2.Controls.Add(this.label3);
            this.pAvg2.Controls.Add(this.tAvg2);
            this.pAvg2.Controls.Add(this.label6);
            this.pAvg2.Location = new System.Drawing.Point(3, 60);
            this.pAvg2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pAvg2.Name = "pAvg2";
            this.pAvg2.Size = new System.Drawing.Size(136, 34);
            this.pAvg2.TabIndex = 23;
            this.pAvg2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(5, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ch.2";
            // 
            // tAvg2
            // 
            this.tAvg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tAvg2.Location = new System.Drawing.Point(55, 5);
            this.tAvg2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tAvg2.Name = "tAvg2";
            this.tAvg2.ReadOnly = true;
            this.tAvg2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tAvg2.Size = new System.Drawing.Size(49, 26);
            this.tAvg2.TabIndex = 20;
            this.tAvg2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(111, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "V";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(47, 828);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Trigger level =>";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxTimeDiv);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox2.Location = new System.Drawing.Point(26, 308);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(131, 176);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Time / Div";
            // 
            // listBoxTimeDiv
            // 
            this.listBoxTimeDiv.BackColor = System.Drawing.Color.CornflowerBlue;
            this.listBoxTimeDiv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxTimeDiv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTimeDiv.FormattingEnabled = true;
            this.listBoxTimeDiv.ItemHeight = 20;
            this.listBoxTimeDiv.Items.AddRange(new object[] {
            "        1 msec",
            "        2 msec",
            "        5 msec",
            "      10 msec",
            "      20 msec",
            "      50 msec",
            "    100 msec"});
            this.listBoxTimeDiv.Location = new System.Drawing.Point(3, 21);
            this.listBoxTimeDiv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxTimeDiv.Name = "listBoxTimeDiv";
            this.listBoxTimeDiv.Size = new System.Drawing.Size(125, 153);
            this.listBoxTimeDiv.TabIndex = 0;
            this.listBoxTimeDiv.SelectedIndexChanged += new System.EventHandler(this.settingChange);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.cTrigRepeat);
            this.groupBox1.Controls.Add(this.cTrigSingle);
            this.groupBox1.Controls.Add(this.cTrigBoth);
            this.groupBox1.Controls.Add(this.cTrigFall);
            this.groupBox1.Controls.Add(this.cTrigRise);
            this.groupBox1.Controls.Add(this.cFreeRun);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox1.Location = new System.Drawing.Point(13, 546);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(160, 278);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trigger";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cTrigPulse);
            this.panel3.Location = new System.Drawing.Point(85, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(21, 30);
            this.panel3.TabIndex = 16;
            // 
            // cTrigPulse
            // 
            this.cTrigPulse.AutoSize = true;
            this.cTrigPulse.FlatAppearance.BorderSize = 10;
            this.cTrigPulse.Location = new System.Drawing.Point(3, 2);
            this.cTrigPulse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cTrigPulse.Name = "cTrigPulse";
            this.cTrigPulse.Size = new System.Drawing.Size(17, 16);
            this.cTrigPulse.TabIndex = 16;
            this.cTrigPulse.TabStop = true;
            this.cTrigPulse.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(3, 59);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(153, 10);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            // 
            // cTrigRepeat
            // 
            this.cTrigRepeat.Checked = true;
            this.cTrigRepeat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cTrigRepeat.Enabled = false;
            this.cTrigRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cTrigRepeat.Image = ((System.Drawing.Image)(resources.GetObject("cTrigRepeat.Image")));
            this.cTrigRepeat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cTrigRepeat.Location = new System.Drawing.Point(20, 187);
            this.cTrigRepeat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cTrigRepeat.Name = "cTrigRepeat";
            this.cTrigRepeat.Size = new System.Drawing.Size(125, 43);
            this.cTrigRepeat.TabIndex = 17;
            this.cTrigRepeat.TabStop = false;
            this.cTrigRepeat.Text = "Repeat";
            this.cTrigRepeat.UseVisualStyleBackColor = true;
            this.cTrigRepeat.CheckStateChanged += new System.EventHandler(this.settingChange);
            // 
            // cTrigSingle
            // 
            this.cTrigSingle.Enabled = false;
            this.cTrigSingle.Image = ((System.Drawing.Image)(resources.GetObject("cTrigSingle.Image")));
            this.cTrigSingle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cTrigSingle.Location = new System.Drawing.Point(17, 228);
            this.cTrigSingle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cTrigSingle.Name = "cTrigSingle";
            this.cTrigSingle.Size = new System.Drawing.Size(128, 39);
            this.cTrigSingle.TabIndex = 16;
            this.cTrigSingle.TabStop = false;
            this.cTrigSingle.Text = "Single";
            this.cTrigSingle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cTrigSingle.UseVisualStyleBackColor = true;
            this.cTrigSingle.Click += new System.EventHandler(this.button1_Click);
            // 
            // cTrigBoth
            // 
            this.cTrigBoth.Image = ((System.Drawing.Image)(resources.GetObject("cTrigBoth.Image")));
            this.cTrigBoth.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cTrigBoth.Location = new System.Drawing.Point(20, 146);
            this.cTrigBoth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cTrigBoth.Name = "cTrigBoth";
            this.cTrigBoth.Size = new System.Drawing.Size(125, 43);
            this.cTrigBoth.TabIndex = 3;
            this.cTrigBoth.Text = "Both";
            this.cTrigBoth.UseVisualStyleBackColor = true;
            this.cTrigBoth.CheckedChanged += new System.EventHandler(this.settingChange);
            // 
            // cTrigFall
            // 
            this.cTrigFall.Image = ((System.Drawing.Image)(resources.GetObject("cTrigFall.Image")));
            this.cTrigFall.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cTrigFall.Location = new System.Drawing.Point(20, 110);
            this.cTrigFall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cTrigFall.Name = "cTrigFall";
            this.cTrigFall.Size = new System.Drawing.Size(125, 43);
            this.cTrigFall.TabIndex = 2;
            this.cTrigFall.Text = "Falling";
            this.cTrigFall.UseVisualStyleBackColor = true;
            this.cTrigFall.CheckedChanged += new System.EventHandler(this.settingChange);
            // 
            // cTrigRise
            // 
            this.cTrigRise.Image = ((System.Drawing.Image)(resources.GetObject("cTrigRise.Image")));
            this.cTrigRise.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cTrigRise.Location = new System.Drawing.Point(20, 74);
            this.cTrigRise.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cTrigRise.Name = "cTrigRise";
            this.cTrigRise.Size = new System.Drawing.Size(125, 43);
            this.cTrigRise.TabIndex = 1;
            this.cTrigRise.Text = "Rising";
            this.cTrigRise.UseVisualStyleBackColor = true;
            this.cTrigRise.CheckedChanged += new System.EventHandler(this.settingChange);
            // 
            // cFreeRun
            // 
            this.cFreeRun.Checked = true;
            this.cFreeRun.Image = ((System.Drawing.Image)(resources.GetObject("cFreeRun.Image")));
            this.cFreeRun.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cFreeRun.Location = new System.Drawing.Point(20, 23);
            this.cFreeRun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cFreeRun.Name = "cFreeRun";
            this.cFreeRun.Size = new System.Drawing.Size(136, 43);
            this.cFreeRun.TabIndex = 0;
            this.cFreeRun.TabStop = true;
            this.cFreeRun.Text = "Free run";
            this.cFreeRun.UseVisualStyleBackColor = true;
            this.cFreeRun.CheckedChanged += new System.EventHandler(this.settingChange);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 869);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Scopino";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.cTrigLevel)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelCom.ResumeLayout(false);
            this.panelCom.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.pAvg1.ResumeLayout(false);
            this.pAvg1.PerformLayout();
            this.pAvg2.ResumeLayout(false);
            this.pAvg2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort com;
        private System.Windows.Forms.TrackBar cTrigLevel;
        private System.Windows.Forms.CheckBox channel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton cTrigBoth;
        private System.Windows.Forms.RadioButton cTrigFall;
        private System.Windows.Forms.RadioButton cTrigRise;
        private System.Windows.Forms.RadioButton cFreeRun;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxTimeDiv;
        private System.Windows.Forms.Panel panelCom;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tAvg2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pAvg1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tAvg1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pAvg2;
        private System.Windows.Forms.Button cTrigSingle;
        private System.Windows.Forms.CheckBox cTrigRepeat;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton cTrigPulse;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox listBoxVoltDiv;
        private System.Windows.Forms.Label labelSamp;
    }
}

