using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.InteropServices;

namespace Chat_Client
{

    public partial class Form1 : Form
    {
        preferences pref = new preferences();
        Socket sck;
        EndPoint epLocal, epRemote;
        public Form1()
        {
            InitializeComponent();

            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            textBoxCl1ip.Text = getLocalIP();

            //config file
            StreamReader configSR = new StreamReader("Config.txt");
            try
            {
                //making name show
                string name = configSR.ReadLine();
                string[] nameData = name.Split(':');
                name = nameData[1];
                textBoxName.Text = name;
            }
            catch { }
            try
            {
                //making last ip show
                string lastip = configSR.ReadLine();
                string[] latsipData = lastip.Split(':');
                lastip = latsipData[1];
                textBoxCl2ip.Text = lastip;
            }
            catch { }
            try
            {
                //making last port show
                string lastport = configSR.ReadLine();
                string[] latsportData = lastport.Split(':');
                lastport = latsportData[1];
                textBoxCl2port.Text = lastport;
                switch(lastport)
                {
                    case "80":
                        textBoxCl1port.Text = "81";
                        break;
                    case "81":
                        textBoxCl1port.Text = "80";
                        break;
                }

            }
            catch { }
            //closing connection
            configSR.Close();


        }

        private string getLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach(IPAddress ip in host.AddressList)
            {
                if(ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                epLocal = new IPEndPoint(IPAddress.Parse(textBoxCl1ip.Text), Convert.ToInt32(textBoxCl1port.Text));
                sck.Bind(epLocal);

                epRemote = new IPEndPoint(IPAddress.Parse(textBoxCl2ip.Text), Convert.ToInt32(textBoxCl2port.Text));
                sck.Connect(epRemote);

                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(messageCallBack), buffer);

                button1.Text = "Connected";
                button1.Enabled = false;
                button2.Enabled = true;
                Client1.Enabled = false;
                Client2.Enabled = false;
                groupBoxQuicksett.Enabled = false;

                textBoxMessage.Focus();

                if (textBoxName.Text != "")
                {
                    pref.setName(textBoxName.Text);
                }
                else
                {
                    pref.setName("Anonymous");
                    textBoxName.Text = "Anonymous";
                }

                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] msg = new byte[1500];
                string messageSTR = pref.getName() + "has connected!";
                msg = enc.GetBytes(messageSTR);

                listMessage.Items.Add("You have connected as: " + pref.getName());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] msg = new byte[1500];
                string messageSTR = pref.getName() + ": " + textBoxMessage.Text;
                msg = enc.GetBytes(messageSTR);

                sck.Send(msg);

                listMessage.Items.Add("You: " + textBoxMessage.Text);
                textBoxMessage.Clear();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Chat Client.exe");
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("");
        }

        //this runs when form is closing
        private void exiting(object sender, FormClosingEventArgs e)
        {
            //opening file writing connection
            StreamWriter configSW = new StreamWriter("Config.txt");

            //writing to the file
            configSW.WriteLine("name:" + textBoxName.Text);
            configSW.WriteLine("lastip:" + textBoxCl2ip.Text);
            configSW.WriteLine("port:" + textBoxCl2port.Text);

            //closing connection to save changes
            configSW.Close();
        }

        private void messageCallBack(IAsyncResult aResult)
        {
            try
            {
                int size = sck.EndReceiveFrom(aResult, ref epRemote);

                if(size > 0)
                {
                    byte[] recievedData = new byte[1464];
                    recievedData = (byte[])aResult.AsyncState;
                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    string recivedMessage = eEncoding.GetString(recievedData);

                    listMessage.Items.Add(recivedMessage);
                }

                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(messageCallBack), buffer);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

    }
    public class preferences
    {
        private string name;
        private string[] connectionName = new string[100];
        private string[] connectionOP = new string[100];

        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
    }
}
