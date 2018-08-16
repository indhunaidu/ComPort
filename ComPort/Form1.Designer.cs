namespace ComPort
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chBoxRTSEnable = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chBoxDtrEnable = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxParityBits = new System.Windows.Forms.ComboBox();
            this.cBoxStopBits = new System.Windows.Forms.ComboBox();
            this.cBoxDataBits = new System.Windows.Forms.ComboBox();
            this.CBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.cBoxComPort = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.IbIStatusCom = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnSendData = new System.Windows.Forms.Button();
            this.tBoxDataOut = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblDataOutLength = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chBoxWrite = new System.Windows.Forms.CheckBox();
            this.chBoxWriteLine = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chBoxUsingEnter = new System.Windows.Forms.CheckBox();
            this.chBoxUsingButton = new System.Windows.Forms.CheckBox();
            this.btnClearDataOut = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.chBoxsubstring = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chBoxAddToOldData = new System.Windows.Forms.CheckBox();
            this.chBoxAlwayasUpdate = new System.Windows.Forms.CheckBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.lblDataLength = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClearDataIN = new System.Windows.Forms.Button();
            this.tBoxDataIN = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.chBoxRTSEnable);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.chBoxDtrEnable);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBoxParityBits);
            this.groupBox1.Controls.Add(this.cBoxStopBits);
            this.groupBox1.Controls.Add(this.cBoxDataBits);
            this.groupBox1.Controls.Add(this.CBoxBaudRate);
            this.groupBox1.Controls.Add(this.cBoxComPort);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com Port Control";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "PARITY BITS";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // chBoxRTSEnable
            // 
            this.chBoxRTSEnable.AutoSize = true;
            this.chBoxRTSEnable.Location = new System.Drawing.Point(157, 173);
            this.chBoxRTSEnable.Name = "chBoxRTSEnable";
            this.chBoxRTSEnable.Size = new System.Drawing.Size(93, 17);
            this.chBoxRTSEnable.TabIndex = 5;
            this.chBoxRTSEnable.Text = "RTS ENABLE";
            this.chBoxRTSEnable.UseVisualStyleBackColor = true;
            this.chBoxRTSEnable.CheckedChanged += new System.EventHandler(this.chBoxRTSEnable_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "STOP BITS";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // chBoxDtrEnable
            // 
            this.chBoxDtrEnable.AutoSize = true;
            this.chBoxDtrEnable.Location = new System.Drawing.Point(6, 173);
            this.chBoxDtrEnable.Name = "chBoxDtrEnable";
            this.chBoxDtrEnable.Size = new System.Drawing.Size(94, 17);
            this.chBoxDtrEnable.TabIndex = 4;
            this.chBoxDtrEnable.Text = "DTR ENABLE";
            this.chBoxDtrEnable.UseVisualStyleBackColor = true;
            this.chBoxDtrEnable.CheckedChanged += new System.EventHandler(this.chBoxDtrEnable_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "DATA BITS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "BAUD RATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "COM PORT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cBoxParityBits
            // 
            this.cBoxParityBits.FormattingEnabled = true;
            this.cBoxParityBits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cBoxParityBits.Location = new System.Drawing.Point(88, 134);
            this.cBoxParityBits.Name = "cBoxParityBits";
            this.cBoxParityBits.Size = new System.Drawing.Size(121, 21);
            this.cBoxParityBits.TabIndex = 4;
            this.cBoxParityBits.Text = "None";
            this.cBoxParityBits.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // cBoxStopBits
            // 
            this.cBoxStopBits.FormattingEnabled = true;
            this.cBoxStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cBoxStopBits.Location = new System.Drawing.Point(88, 107);
            this.cBoxStopBits.Name = "cBoxStopBits";
            this.cBoxStopBits.Size = new System.Drawing.Size(121, 21);
            this.cBoxStopBits.TabIndex = 3;
            this.cBoxStopBits.Text = "One";
            this.cBoxStopBits.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // cBoxDataBits
            // 
            this.cBoxDataBits.FormattingEnabled = true;
            this.cBoxDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cBoxDataBits.Location = new System.Drawing.Point(88, 80);
            this.cBoxDataBits.Name = "cBoxDataBits";
            this.cBoxDataBits.Size = new System.Drawing.Size(121, 21);
            this.cBoxDataBits.TabIndex = 2;
            this.cBoxDataBits.Text = "8";
            // 
            // CBoxBaudRate
            // 
            this.CBoxBaudRate.FormattingEnabled = true;
            this.CBoxBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600"});
            this.CBoxBaudRate.Location = new System.Drawing.Point(88, 53);
            this.CBoxBaudRate.Name = "CBoxBaudRate";
            this.CBoxBaudRate.Size = new System.Drawing.Size(121, 21);
            this.CBoxBaudRate.TabIndex = 1;
            this.CBoxBaudRate.Text = "9600";
            // 
            // cBoxComPort
            // 
            this.cBoxComPort.FormattingEnabled = true;
            this.cBoxComPort.Items.AddRange(new object[] {
            "COM3"});
            this.cBoxComPort.Location = new System.Drawing.Point(88, 26);
            this.cBoxComPort.Name = "cBoxComPort";
            this.cBoxComPort.Size = new System.Drawing.Size(121, 21);
            this.cBoxComPort.TabIndex = 0;
            this.cBoxComPort.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar2);
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Location = new System.Drawing.Point(12, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 206);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(6, 174);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(270, 23);
            this.progressBar2.TabIndex = 4;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.IbIStatusCom);
            this.groupBox8.Location = new System.Drawing.Point(88, 25);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(188, 84);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "groupBox8";
            this.groupBox8.Enter += new System.EventHandler(this.groupBox8_Enter);
            // 
            // IbIStatusCom
            // 
            this.IbIStatusCom.AutoSize = true;
            this.IbIStatusCom.Location = new System.Drawing.Point(66, 39);
            this.IbIStatusCom.Name = "IbIStatusCom";
            this.IbIStatusCom.Size = new System.Drawing.Size(27, 13);
            this.IbIStatusCom.TabIndex = 0;
            this.IbIStatusCom.Text = "OFF";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(7, 73);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(6, 25);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 127);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(270, 23);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(6, 19);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(85, 29);
            this.btnSendData.TabIndex = 2;
            this.btnSendData.Text = "SEND DATA";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // tBoxDataOut
            // 
            this.tBoxDataOut.Location = new System.Drawing.Point(10, 25);
            this.tBoxDataOut.Multiline = true;
            this.tBoxDataOut.Name = "tBoxDataOut";
            this.tBoxDataOut.Size = new System.Drawing.Size(297, 146);
            this.tBoxDataOut.TabIndex = 3;
            this.tBoxDataOut.TextChanged += new System.EventHandler(this.tBoxDataOut_TextChanged);
            this.tBoxDataOut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxDataOut_KeyDown);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.tBoxDataOut);
            this.groupBox3.Location = new System.Drawing.Point(300, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 395);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transmitter control";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox7);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.btnSendData);
            this.groupBox4.Controls.Add(this.btnClearDataOut);
            this.groupBox4.Location = new System.Drawing.Point(16, 193);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(297, 185);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblDataOutLength);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Location = new System.Drawing.Point(20, 108);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(251, 56);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            // 
            // lblDataOutLength
            // 
            this.lblDataOutLength.AutoSize = true;
            this.lblDataOutLength.Location = new System.Drawing.Point(154, 24);
            this.lblDataOutLength.Name = "lblDataOutLength";
            this.lblDataOutLength.Size = new System.Drawing.Size(19, 13);
            this.lblDataOutLength.TabIndex = 2;
            this.lblDataOutLength.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Data OUT Length:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chBoxWrite);
            this.groupBox6.Controls.Add(this.chBoxWriteLine);
            this.groupBox6.Location = new System.Drawing.Point(202, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(89, 83);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            // 
            // chBoxWrite
            // 
            this.chBoxWrite.AutoSize = true;
            this.chBoxWrite.Location = new System.Drawing.Point(3, 45);
            this.chBoxWrite.Name = "chBoxWrite";
            this.chBoxWrite.Size = new System.Drawing.Size(51, 17);
            this.chBoxWrite.TabIndex = 1;
            this.chBoxWrite.Text = "Write";
            this.chBoxWrite.UseVisualStyleBackColor = true;
            this.chBoxWrite.CheckedChanged += new System.EventHandler(this.chBoxWrite_CheckedChanged);
            // 
            // chBoxWriteLine
            // 
            this.chBoxWriteLine.AutoSize = true;
            this.chBoxWriteLine.Location = new System.Drawing.Point(0, 16);
            this.chBoxWriteLine.Name = "chBoxWriteLine";
            this.chBoxWriteLine.Size = new System.Drawing.Size(74, 17);
            this.chBoxWriteLine.TabIndex = 0;
            this.chBoxWriteLine.Text = "Write Line";
            this.chBoxWriteLine.UseVisualStyleBackColor = true;
            this.chBoxWriteLine.CheckedChanged += new System.EventHandler(this.chBoxWriteLine_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chBoxUsingEnter);
            this.groupBox5.Controls.Add(this.chBoxUsingButton);
            this.groupBox5.Location = new System.Drawing.Point(97, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(99, 83);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // chBoxUsingEnter
            // 
            this.chBoxUsingEnter.AutoSize = true;
            this.chBoxUsingEnter.Location = new System.Drawing.Point(3, 45);
            this.chBoxUsingEnter.Name = "chBoxUsingEnter";
            this.chBoxUsingEnter.Size = new System.Drawing.Size(81, 17);
            this.chBoxUsingEnter.TabIndex = 1;
            this.chBoxUsingEnter.Text = "Using Enter";
            this.chBoxUsingEnter.UseVisualStyleBackColor = true;
            // 
            // chBoxUsingButton
            // 
            this.chBoxUsingButton.AutoSize = true;
            this.chBoxUsingButton.Location = new System.Drawing.Point(3, 16);
            this.chBoxUsingButton.Name = "chBoxUsingButton";
            this.chBoxUsingButton.Size = new System.Drawing.Size(87, 17);
            this.chBoxUsingButton.TabIndex = 0;
            this.chBoxUsingButton.Text = "Using Button";
            this.chBoxUsingButton.UseVisualStyleBackColor = true;
            this.chBoxUsingButton.CheckedChanged += new System.EventHandler(this.chBoxUsingButton_CheckedChanged);
            // 
            // btnClearDataOut
            // 
            this.btnClearDataOut.Location = new System.Drawing.Point(8, 54);
            this.btnClearDataOut.Name = "btnClearDataOut";
            this.btnClearDataOut.Size = new System.Drawing.Size(83, 29);
            this.btnClearDataOut.TabIndex = 7;
            this.btnClearDataOut.Text = "Clear Data OUT";
            this.btnClearDataOut.UseVisualStyleBackColor = true;
            this.btnClearDataOut.Click += new System.EventHandler(this.btnClearDataOut_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.groupBox10);
            this.groupBox9.Controls.Add(this.tBoxDataIN);
            this.groupBox9.Location = new System.Drawing.Point(625, 12);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(320, 396);
            this.groupBox9.TabIndex = 7;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Receiver Control";
            this.groupBox9.Enter += new System.EventHandler(this.groupBox9_Enter);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.button1);
            this.groupBox10.Controls.Add(this.groupBox12);
            this.groupBox10.Controls.Add(this.groupBox11);
            this.groupBox10.Controls.Add(this.btnClearDataIN);
            this.groupBox10.Location = new System.Drawing.Point(6, 194);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(308, 185);
            this.groupBox10.TabIndex = 9;
            this.groupBox10.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "PASS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.chBoxsubstring);
            this.groupBox12.Controls.Add(this.checkBox1);
            this.groupBox12.Controls.Add(this.chBoxAddToOldData);
            this.groupBox12.Controls.Add(this.chBoxAlwayasUpdate);
            this.groupBox12.Location = new System.Drawing.Point(97, 14);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(125, 98);
            this.groupBox12.TabIndex = 11;
            this.groupBox12.TabStop = false;
            // 
            // chBoxsubstring
            // 
            this.chBoxsubstring.AutoSize = true;
            this.chBoxsubstring.Location = new System.Drawing.Point(3, 54);
            this.chBoxsubstring.Name = "chBoxsubstring";
            this.chBoxsubstring.Size = new System.Drawing.Size(68, 17);
            this.chBoxsubstring.TabIndex = 3;
            this.chBoxsubstring.Text = "substring";
            this.chBoxsubstring.UseVisualStyleBackColor = true;
            this.chBoxsubstring.CheckedChanged += new System.EventHandler(this.chBoxsubstring_CheckedChanged);
            this.chBoxsubstring.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chBoxsubstring_KeyPress);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 75);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "ACCEPT ";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkBox1_KeyPress);
            // 
            // chBoxAddToOldData
            // 
            this.chBoxAddToOldData.AutoSize = true;
            this.chBoxAddToOldData.Location = new System.Drawing.Point(3, 33);
            this.chBoxAddToOldData.Name = "chBoxAddToOldData";
            this.chBoxAddToOldData.Size = new System.Drawing.Size(106, 17);
            this.chBoxAddToOldData.TabIndex = 1;
            this.chBoxAddToOldData.Text = "Add To Old Data";
            this.chBoxAddToOldData.UseVisualStyleBackColor = true;
            this.chBoxAddToOldData.CheckedChanged += new System.EventHandler(this.chBoxAddToOldData_CheckedChanged);
            this.chBoxAddToOldData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chBoxAddToOldData_KeyPress);
            // 
            // chBoxAlwayasUpdate
            // 
            this.chBoxAlwayasUpdate.AutoSize = true;
            this.chBoxAlwayasUpdate.Location = new System.Drawing.Point(3, 15);
            this.chBoxAlwayasUpdate.Name = "chBoxAlwayasUpdate";
            this.chBoxAlwayasUpdate.Size = new System.Drawing.Size(97, 17);
            this.chBoxAlwayasUpdate.TabIndex = 0;
            this.chBoxAlwayasUpdate.Text = "Always Update";
            this.chBoxAlwayasUpdate.UseVisualStyleBackColor = true;
            this.chBoxAlwayasUpdate.CheckedChanged += new System.EventHandler(this.chBoxAlwayasUpdate_CheckedChanged);
            this.chBoxAlwayasUpdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chBoxAlwayasUpdate_KeyPress);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.lblDataLength);
            this.groupBox11.Controls.Add(this.label8);
            this.groupBox11.Location = new System.Drawing.Point(20, 108);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(251, 56);
            this.groupBox11.TabIndex = 10;
            this.groupBox11.TabStop = false;
            // 
            // lblDataLength
            // 
            this.lblDataLength.AutoSize = true;
            this.lblDataLength.Location = new System.Drawing.Point(154, 23);
            this.lblDataLength.Name = "lblDataLength";
            this.lblDataLength.Size = new System.Drawing.Size(19, 13);
            this.lblDataLength.TabIndex = 1;
            this.lblDataLength.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Data IN Length:";
            // 
            // btnClearDataIN
            // 
            this.btnClearDataIN.Location = new System.Drawing.Point(8, 18);
            this.btnClearDataIN.Name = "btnClearDataIN";
            this.btnClearDataIN.Size = new System.Drawing.Size(83, 83);
            this.btnClearDataIN.TabIndex = 7;
            this.btnClearDataIN.Text = "Clear Data IN";
            this.btnClearDataIN.UseVisualStyleBackColor = true;
            this.btnClearDataIN.Click += new System.EventHandler(this.btnClearDataIN_Click);
            // 
            // tBoxDataIN
            // 
            this.tBoxDataIN.Location = new System.Drawing.Point(6, 26);
            this.tBoxDataIN.Multiline = true;
            this.tBoxDataIN.Name = "tBoxDataIN";
            this.tBoxDataIN.Size = new System.Drawing.Size(308, 146);
            this.tBoxDataIN.TabIndex = 0;
            this.tBoxDataIN.ReadOnlyChanged += new System.EventHandler(this.tBoxDataIN_ReadOnlyChanged);
            this.tBoxDataIN.TextChanged += new System.EventHandler(this.tBoxDataIN_TextChanged);
            this.tBoxDataIN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxDataIN_KeyDown);
            this.tBoxDataIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxDataIN_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(669, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "date and time";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "C# COM PORT SERIAL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cBoxParityBits;
        private System.Windows.Forms.ComboBox cBoxStopBits;
        private System.Windows.Forms.ComboBox cBoxDataBits;
        private System.Windows.Forms.ComboBox CBoxBaudRate;
        private System.Windows.Forms.ComboBox cBoxComPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.TextBox tBoxDataOut;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.CheckBox chBoxDtrEnable;
        private System.Windows.Forms.CheckBox chBoxRTSEnable;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClearDataOut;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox chBoxWrite;
        private System.Windows.Forms.CheckBox chBoxWriteLine;
        private System.Windows.Forms.CheckBox chBoxUsingEnter;
        private System.Windows.Forms.CheckBox chBoxUsingButton;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label IbIStatusCom;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox tBoxDataIN;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label lblDataLength;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnClearDataIN;
        private System.Windows.Forms.Label lblDataOutLength;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.CheckBox chBoxAddToOldData;
        private System.Windows.Forms.CheckBox chBoxAlwayasUpdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox chBoxsubstring;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
    }
}

