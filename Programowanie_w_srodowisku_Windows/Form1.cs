using System;
using System.Timers;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; 

// nie ciągnąć w dół przy wysyłaniu ACK
namespace Programowanie_w_srodowisku_Windows
{
    public partial class Form1_serial_port_communication : Form
    {
        static SerialPort serialPort = new SerialPort();
        string[] ports = SerialPort.GetPortNames();
        Queue data_queue = new Queue();
        Queue byte_Queue = new Queue();
        private Queue<byte> RxData = new Queue<byte>();
        byte[] byteBuffer;
        List<byte> frame = new List<byte>();
        List<byte> frame_gotowa = new List<byte>();
        private static System.Timers.Timer aTimer;
        Thread thread;
        private STATE BUFFER_STATE;

        private enum STATE
        {
            LOOKING_FOR_BEGIN,
            LOOKING_FOR_LEN,
            LOOKING_FOR_COMAND_CODE,
            LOOKING_FOR_DATA_COLLECTING,
            LOOKING_FOR_CHECK_BYTE_ONE,
            LOOKING_FOR_CHECK_BYTE_TWO,

        }

        public Form1_serial_port_communication()
        {
            InitializeComponent();
            foreach (string port in ports)
            {
                comboBox1_com_ports.Items.Add(port);
            }
            serialPort.DataReceived += new SerialDataReceivedEventHandler(responseHandler);
        }

        private static void SetTimer(int time)
        {

            aTimer = new System.Timers.Timer(time);
            aTimer.Enabled = true;
        }

        private void create_frame(byte[] tab, byte V)
        {
            byte len = Convert.ToByte(tab.Length);
            byte[] frame = new byte[5 + tab.Length];
            int index = 0;
            frame[index++] = 0x02;
        }

        public void ramka()
        {
            while (true)
            {
                switch (BUFFER_STATE)
                {
                    case STATE.LOOKING_FOR_BEGIN:
                        if (byte_Queue.Count != 0)
                        {
                            byte received = Convert.ToByte(byte_Queue.Dequeue());
                            if (received == 0x02 || received == 0x03)
                            {
                                // frame_gotowa.Add(received);
                                BUFFER_STATE = STATE.LOOKING_FOR_LEN;
                                Console.WriteLine("mam poczatek");
                                Thread.Sleep(1000);
                            }
                        }
                        break;

                    case STATE.LOOKING_FOR_LEN:
                        if (data_queue.Count != 0)
                        {
                            byte c = Convert.ToByte(byte_Queue.Dequeue());
                            frame_gotowa.Add(c);
                            Console.WriteLine("MAM DLUGOSC");
                            BUFFER_STATE = STATE.LOOKING_FOR_COMAND_CODE;
                        }
                        break;

                    case STATE.LOOKING_FOR_COMAND_CODE:
                        if (byte_Queue.Count != 0)
                        {

                            byte c = Convert.ToByte(byte_Queue.Dequeue());
                            frame_gotowa.Add(c);
                            Console.WriteLine("mam cc");
                            BUFFER_STATE = STATE.LOOKING_FOR_DATA_COLLECTING;


                        }
                        break;

                    case STATE.LOOKING_FOR_DATA_COLLECTING:
                        if (byte_Queue.Count != 0)
                        {
                            byte c = Convert.ToByte(byte_Queue.Dequeue());
                            if (c == 0x00)
                            {
                                Console.WriteLine("mam date");
                                BUFFER_STATE = STATE.LOOKING_FOR_CHECK_BYTE_ONE;
                            }
                            else
                            {
                                frame_gotowa.Add(c);
                            }


                        }
                        break;
                    case STATE.LOOKING_FOR_CHECK_BYTE_ONE:
                        if (byte_Queue.Count != 0)
                        {
                            byte c = Convert.ToByte(byte_Queue.Dequeue());

                            byte suma = 0;

                            foreach (byte indeks in frame_gotowa)
                            {
                                suma += indeks;
                            }
                            Console.WriteLine(suma.ToString());
                            if (c == suma)
                            {
                                BUFFER_STATE = STATE.LOOKING_FOR_CHECK_BYTE_TWO;
                                Console.WriteLine("Suma sie zgadza");
                            }




                        }
                        break;

                    case STATE.LOOKING_FOR_CHECK_BYTE_TWO:
                        if (byte_Queue.Count != 0)
                        {
                            byte c = Convert.ToByte(byte_Queue.Dequeue());
                            if (c == 0x00)
                            {
                                Console.WriteLine("mam koniec");
                                
                                byte[] sendArray = { 0x06 };
                                serialPort.Write(sendArray, 0, sendArray.Length);
                                BUFFER_STATE = STATE.LOOKING_FOR_BEGIN;
                            }

                        }
                        break;

                }
            }
        }


        private void responseHandler(object sender, SerialDataReceivedEventArgs args)
        {
            try
            {

                int intBuffer;
                intBuffer = serialPort.BytesToRead;
                 byteBuffer = new byte[intBuffer];
                serialPort.Read(byteBuffer, 0, intBuffer);

                string res = ByteArrayToString(byteBuffer);

                foreach (byte x in byteBuffer)
                {
                    byte_Queue.Enqueue(x);
                }
                thread = new Thread(ramka);
                thread.Start();
            }
            catch (Exception ex) { }
        }


        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int intBuffer;
            intBuffer = serialPort.BytesToRead;
            byteBuffer = new byte[intBuffer];
            serialPort.Read(byteBuffer, 0, intBuffer);
            string res = ByteArrayToString(byteBuffer);
            Console.WriteLine("Odbiór: " + res);
        }

        private string ByteArrayToString(byte[] byteBuffer)
        {
            return BitConverter.ToString(byteBuffer);
        }


        private void comboBox1_com_ports_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_open_com_Click(object sender, EventArgs e)
        {
            serialPort = new SerialPort(comboBox1_com_ports.Text);
            serialPort.DataBits = 8;
            serialPort.Parity = Parity.None;
            serialPort.StopBits = StopBits.One;
            serialPort.BaudRate = 57600;
            
            serialPort.DataReceived += new SerialDataReceivedEventHandler(Port_DataReceived);
            serialPort.Open();
            Debug.Print("Połączony z " + comboBox1_com_ports.Text);
        }

        private void button_com_close_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.Close();
                Console.WriteLine(comboBox1_com_ports.SelectedItem.ToString() + " CLOSE");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception close");
            }
        }

        private void button_send_reset_Click(object sender, EventArgs e)
        {
            try

            {
                serialPort.RtsEnable = true;
                 byte[] sendArray = { 0x02, 0x00, 0x3C, 0x3C, 0x00 };
               //byte[] sendArray = { 0x3F, 0x06, 0x02, 0x01, 0x3D, 0x00, 0x3E, 0x00 };
                serialPort.Write(sendArray, 0, sendArray.Length);
                serialPort.RtsEnable = false;
            }
            catch (Exception exc)
            {
                Console.WriteLine("Catched " + exc);
                MessageBox.Show("Nie wysłało bład transmisji ");
            }
        }
    }


}
