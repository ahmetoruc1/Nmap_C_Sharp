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
using System.Net.NetworkInformation;
using System.Threading;
using System.Net.Sockets;
using System.Collections;

namespace nmap2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

        }
        Thread thread = null;
        Thread thread2 = null;
        //Thread in çalışması için Threading kütüphanesini projeye import ediyoruz.


        void scan2(string subnet,string subnetn)
        {
            Ping ping;
            PingReply reply;
            ping = new Ping();
            reply = ping.Send(subnet + subnetn);

                if (reply.Status == IPStatus.Success)
                {
                    try
                    {
                    textBoxHOST.AppendText(subnet + subnetn +  Environment.NewLine);

                    }
                    catch (Exception hata)
                    {
                    MessageBox.Show(hata.Message, "Threadde Hata!");
                    }

                }
           
        }       

        public void scan(string subnet)
        {

            for (int i = 1; i < 255; i++)
            {
                string subnetn = "." + i.ToString();
                thread2 = new Thread(() => scan2(subnet, subnetn));
                thread2.Start();
            }
            MessageBox.Show("IP Tarama İşlemi Sona Erdi");

        }
        
        private void buttonoku_Click(object sender, EventArgs e)
        {
            thread = new Thread(()=>scan(textBoxIP.Text));
            thread.Start();

            if (thread.IsAlive)
            {
                buttonoku.Enabled = false;
                textBoxIP.Enabled = false;
            }
        }
       
    }
}

