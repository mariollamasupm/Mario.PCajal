using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace provadisperata
{
    public partial class Form1 : Form
    {
        String serialDataIn;
        sbyte indexOfA, indexOfB, indexOfC, indexOfD, indexOfE, indexOfF;
        string dataSensor1, dataSensor2, dataSensor3, dataSensor4, dataSensor5, dataSensor6;
        string filePath = @"C:\Users\Usuario\Documents\Cajal\Prácticas\Calibrar Presión\Test_VS\test1.txt";

        private void textBoxS1_TextChanged(object sender, EventArgs e)
        {

        }

        List<string> allData = new List<string>();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_open.Enabled = true;
            button_close.Enabled = false;
            progressBar_statusCOM.Value = 0;
            comboBox_baudRate.Text = "115200";

        }

        private void button_open_Click(object sender, EventArgs e)
        {
            try
            {
                
                serialPort1.PortName = comboBox_comPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBox_baudRate.Text);
                serialPort1.Open();

                button_open.Enabled = false;
                button_close.Enabled = true;
                progressBar_statusCOM.Value = 100;
                label10.Text = "COM OPENED";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();

                button_open.Enabled = true;
                button_close.Enabled = false;
                progressBar_statusCOM.Value = 0;
                label10.Text = "COM CLOSED";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void comboBox_baudRate_DropDown(object sender, EventArgs e)
        {
            
        }

        private void comboBox_comPort_DropDown(object sender, EventArgs e)
        {
            
            string[] portLists = SerialPort.GetPortNames();
            comboBox_comPort.Items.Clear();
            comboBox_comPort.Items.AddRange(portLists);
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                serialPort1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            serialDataIn = serialPort1.ReadLine();
            this.BeginInvoke(new EventHandler(ProcessData));

        }

        private void ProcessData(object sender, EventArgs e)
        {
            try
            {
                indexOfA = Convert.ToSByte(serialDataIn.IndexOf("A"));
                indexOfB = Convert.ToSByte(serialDataIn.IndexOf("B"));
                indexOfC = Convert.ToSByte(serialDataIn.IndexOf("C"));
                indexOfD = Convert.ToSByte(serialDataIn.IndexOf("D"));
                indexOfE = Convert.ToSByte(serialDataIn.IndexOf("E"));
                indexOfF = Convert.ToSByte(serialDataIn.IndexOf("F"));

                dataSensor1 = serialDataIn.Substring(0, indexOfA);
                dataSensor2 = serialDataIn.Substring(indexOfA + 1, (indexOfB - indexOfA) - 1);
                dataSensor3 = serialDataIn.Substring(indexOfB + 1, (indexOfC - indexOfB) - 1);
                dataSensor4 = serialDataIn.Substring(indexOfC + 1, (indexOfD - indexOfC) - 1);
                dataSensor5 = serialDataIn.Substring(indexOfD + 1, (indexOfE - indexOfD) - 1);
                dataSensor6 = serialDataIn.Substring(indexOfE + 1, (indexOfF - indexOfE) - 1);

                textBoxS1.Text = dataSensor1;
                textBoxS2.Text = dataSensor2;
                textBoxS3.Text = dataSensor3;
                textBoxS4.Text = dataSensor4;
                textBoxS5.Text = dataSensor5;
                textBoxS6.Text = dataSensor6;

                progressBarS1.Value = Convert.ToInt16(dataSensor1);
                progressBarS2.Value = Convert.ToInt16(dataSensor2);
                progressBarS3.Value = Convert.ToInt16(dataSensor3);
                progressBarS4.Value = Convert.ToInt16(dataSensor4);
                progressBarS5.Value = Convert.ToInt16(dataSensor5);
                progressBarS6.Value = Convert.ToInt16(dataSensor6);
                
                
                //allData.Add(dataSensor1);
                //allData.Add(dataSensor2);
                //allData.Add(dataSensor3);
                //allData.Add(dataSensor4);
                //allData.Add(dataSensor5);
                //allData.Add(dataSensor6);

                //File.WriteAllLines(filePath, allData);
          
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
