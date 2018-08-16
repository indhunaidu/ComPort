using System;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;


using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ComPort
{
    public partial class Form1 : Form
    {
        string dataOUT;
        string sendWith;
        string  dataIN;
       private string temptb;
     

        public object ch { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            String[] ports = SerialPort.GetPortNames();
            cBoxComPort.Items.AddRange(ports);


            chBoxDtrEnable.Checked = false;
            serialPort1.DtrEnable = false;
            chBoxRTSEnable.Checked = false;
            serialPort1.RtsEnable = false;
            btnSendData.Enabled = false;
            chBoxWriteLine.Checked = false;
            chBoxWrite.Checked = true;
            sendWith = "Write";

            chBoxAddToOldData.Checked = true;
            chBoxAlwayasUpdate.Checked = false;
            chBoxsubstring.Checked = true;
            checkBox1.Checked = false;
            
            
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cBoxComPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(CBoxBaudRate.Text);
                serialPort1.DataBits = Convert.ToInt32(cBoxDataBits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxStopBits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxParityBits.Text);

                serialPort1.Open();
                progressBar1.Value = 100;
                progressBar2.Value = 0;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
           
                    serialPort1.Close();
                    progressBar2.Value = 100;
                    progressBar1.Value = 0;
                tBoxDataIN.Enabled = false;
              
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                dataOUT = tBoxDataOut.Text;
                if(sendWith == "WriteLine")
                {
                    serialPort1.WriteLine(dataOUT);
                }
                 else if(sendWith == "Write")
                {
                    serialPort1.Write(dataOUT);
                }
               
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void chBoxDtrEnable_CheckedChanged(object sender, EventArgs e)
        {
            if(chBoxDtrEnable.Checked)
            {
                serialPort1.DtrEnable = true;
                MessageBox.Show("DTR Enable", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else { serialPort1.DtrEnable = false; }
        }

        private void chBoxRTSEnable_CheckedChanged(object sender, EventArgs e)
        {
            if(chBoxRTSEnable.Checked)
            {
                serialPort1.RtsEnable = true;
                MessageBox.Show("RTS Enable", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else { serialPort1.RtsEnable = false; }
        }

        private void tBoxDataOut_TextChanged(object sender, EventArgs e)
        {
            int dataOUTLength = tBoxDataOut.TextLength;
            lblDataOutLength.Text = string.Format("{0:00}", dataOUTLength);
            if(chBoxUsingEnter.Checked)
            {
                tBoxDataOut.Text = tBoxDataOut.Text.Replace(Environment.NewLine, "");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblDataOut(object sender, EventArgs e)
        {

        }

        private void chBoxUsingButton_CheckedChanged(object sender, EventArgs e)
        {
            if(chBoxUsingButton.Checked)
            {
                btnSendData.Enabled = true;
            }
            else { btnSendData.Enabled = false; }
        }

        private void tBoxDataOut_KeyDown(object sender, KeyEventArgs e)
        {
            if(chBoxUsingEnter.Checked)
            {
                if(e.KeyCode == Keys.Enter)
                {
                    if (serialPort1.IsOpen)
                    {
                        dataOUT = tBoxDataOut.Text;
                        if (sendWith == "WriteLine")
                        {
                            serialPort1.WriteLine(dataOUT);
                        }
                        else if (sendWith == "Write")
                        {
                            serialPort1.Write(dataOUT);
                        }
                    }
                }
            }
        }

        private void chBoxWriteLine_CheckedChanged(object sender, EventArgs e)
        {
            if(chBoxWriteLine.Checked)
            {
                sendWith = "WriteLine";
                chBoxWrite.Checked = false;
                chBoxWriteLine.Checked = true;
            }
        }

        private void chBoxWrite_CheckedChanged(object sender, EventArgs e)
        {
            if(chBoxWrite.Checked)
            {
                sendWith = "Write";
                chBoxWrite.Checked = true;
                chBoxWriteLine.Checked = false;
            }
        }

        private void btnClearDataOut_Click(object sender, EventArgs e)
        {
            if(tBoxDataOut.Text != "")
            {
                tBoxDataOut.Text = "";
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIN = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData));
        }

        private void ShowData(object sender, EventArgs e)
        {
            int dataINLength = dataIN.Length;
            lblDataLength.Text = string.Format("{0:00}",dataINLength);
            if(chBoxAlwayasUpdate.Checked)
            {
                tBoxDataIN.Text = dataIN;
            }
            else if(chBoxAddToOldData.Checked)
            {
                tBoxDataIN.Text += dataIN;
            }
            
        }

        private void chBoxAlwayasUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if(chBoxAlwayasUpdate.Checked)
            {
                chBoxAlwayasUpdate.Checked = true;
                chBoxAddToOldData.Checked = false;
               
            }
            else { chBoxAddToOldData.Checked = true; }
            
        }

        private void chBoxAddToOldData_CheckedChanged(object sender, EventArgs e)
        {
            if(chBoxAddToOldData.Checked)
            {
                chBoxAlwayasUpdate.Checked = false;
               
                chBoxAddToOldData.Checked = true;
            }
            else
            {
                chBoxAddToOldData.Checked = false;
                chBoxsubstring.Checked = true; }
        }

        private void btnClearDataIN_Click(object sender, EventArgs e)
        {
            if(tBoxDataIN.Text != "")
            {
                tBoxDataIN.Text = "";
            }
        }

        private void tBoxDataIN_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                float i;


                tBoxDataIN.Text = tBoxDataIN.Text.Trim();

                if (!string.IsNullOrEmpty(tBoxDataIN.Text))

                {


                    if (float.TryParse(tBoxDataIN.Text, out i))
                    {
                        temptb = tBoxDataIN.Text;
                    }
                    else
                    {
                        tBoxDataIN.Text = temptb;
                    }
                }


                else
                {
                    temptb = "";
                }

                tBoxDataIN.SelectionStart = tBoxDataIN.Text.Length;

                


            }

            if (chBoxsubstring.Checked)
            {

              
                {
                    string myString = tBoxDataIN.Text;
                    System.Console.WriteLine("The String Before Trimming : (" + myString + "*");
                    System.Console.WriteLine("The String After Trimming : (" + myString.Trim() + "$");
                    Console.Read();
                }
                
                
                    string cs = @"\bS\S*";
                string s;
                s = tBoxDataIN.Text;

                MatchCollection mc = Regex.Matches(tBoxDataIN.Text, cs);

                System.Console.WriteLine("welcome");
                foreach (Match m in mc)
                {
                    Console.WriteLine(m);
                }

            

                


            }



        }

        private void chBoxAddToOldData_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void chBoxAlwayasUpdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void tBoxDataIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(ch == 46 && tBoxDataIN.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if(!char.IsDigit(ch) && ch !=8 && ch!=46)
            {
                e.Handled = true;
            }

        }

        private void tBoxDataIN_ReadOnlyChanged(object sender, EventArgs e)
        {
            tBoxDataIN.ReadOnly = true;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form2 frm = new Form2( tBoxDataIN.Text);
            frm.Show();
            if (btnOpen.Enabled)
            {
                Form2 form = new Form2(tBoxDataIN.Enabled = true);
                
            }
            else if(btnClose.Enabled)
            {
                Form2 form = new Form2(tBoxDataIN.Enabled = false);
                
            }
  
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
             float i;


             tBoxDataIN.Text = tBoxDataIN.Text.Trim();



            if (!string.IsNullOrEmpty(tBoxDataIN.Text))
            {


                if (float.TryParse(tBoxDataIN.Text, out i))
                {
                    temptb = tBoxDataIN.Text;
                }
                else
                {
                    tBoxDataIN.Text = temptb;
                }
            }
            else
            {
                temptb = "";
            }

                tBoxDataIN.SelectionStart = tBoxDataIN.Text.Length;
            




        }
       
        private void checkBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

       

        private void tBoxDataIN_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private static void match(string str,string exp)
        {

        }
        private void chBoxsubstring_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToString("dd-MM-yyyy   hh:mm:ss");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void chBoxsubstring_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (chBoxsubstring.Checked)
            {
                string myString = tBoxDataIN.Text;
                System.Console.WriteLine("The String Before Trimming : (" + myString + "*");
                System.Console.WriteLine("The String After Trimming : (" + myString.Trim() + "$");
                Console.Read();
            }


        }
    }
}
