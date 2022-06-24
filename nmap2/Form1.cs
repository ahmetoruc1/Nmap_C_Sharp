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
        //Thread in çalışması için Threading kütüphanesini projeye import ediyoruz.
        

        public void scan(string subnet)
        {
            Ping ping;
            PingReply reply;
            
            for (int i = 1; i < 255; i++)
            {
                
                string subnetn = "." + i.ToString();
                ping = new Ping();
                reply = ping.Send(subnet+subnetn, 100);

                if (reply.Status==IPStatus.Success)
                {
                    try
                    {
                        textBoxHOST.AppendText(subnet + subnetn +Environment.NewLine);
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show(hata.Message,"Threadde Hata!");
                    }
                }
            }
        }

        private void buttonoku_Click(object sender, EventArgs e)
        {
            thread = new Thread(()=>scan(textBoxIP.Text));
            thread.Start();

            if (thread.IsAlive)
            {
                buttonoku.Enabled = false;
                buttonDUR.Enabled = true;
                textBoxIP.Enabled = false;
            }
        }
        private void buttonDUR_Click(object sender, EventArgs e)
        {
            thread.Suspend();
            buttonDUR.Enabled = false;
            buttonoku.Enabled = true;
            textBoxIP.Enabled = true;
        }
    }
}
