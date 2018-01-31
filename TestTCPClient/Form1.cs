using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTCPClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpClient Client;

        private void Form1_Load(object sender, EventArgs e)
        {
            Client = new SimpleTcpClient();
            Client.StringEncoder = Encoding.UTF8;

            Client.DataReceived += Client_DataReceived;  //assegno l'evento alla funzione da svolgere
            //Client.StringEncoder = Encoding.ASCII;

            
            }



        private void Client_DataReceived(object sender, SimpleTCP.Message Message)
        {
            //Update message to txtStatus
            txtStatus.Invoke((MethodInvoker)delegate ()
            {
                txtStatus.Text += Message.MessageString + Environment.NewLine;

            });
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
            //Connect to server

            Client.Connect(txtHost.Text, Convert.ToInt32(txtPort.Text));
            Client.TcpClient.ReceiveBufferSize = 1;
            Client.TcpClient.SendBufferSize = 1;
            //Client.TcpClient.NoDelay = true;
        }

        private void btnLed_ON_Click(object sender, EventArgs e)
        {
            Client.WriteLine("led_on");
        }

        private void btnLed_OFF_Click(object sender, EventArgs e)
        {
            Client.WriteLine("led_off");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var replaymessage = Client.WriteLineAndGetReply(txtSend.Text, TimeSpan.FromSeconds(3));
            //lblReply.Text = replaymessage.MessageString.ToString();


        }

        private void lblPort_Click(object sender, EventArgs e)
        {

        }

        private void txtPort_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = true;
            //Connect to server
            Client.Disconnect();
        }
    }
}
