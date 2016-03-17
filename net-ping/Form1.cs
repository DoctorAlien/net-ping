using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;

namespace net_ping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            listIPs.Items.Clear();
            try
            {
                //IP地址
                IPHostEntry iphost = Dns.GetHostEntry(txtInput.Text);
                foreach (IPAddress ip in iphost.AddressList) {
                    string ipaddress = ip.AddressFamily.ToString();
                    listIPs.Items.Add(ipaddress);
                    listIPs.Items.Add(" "+ip.ToString());
                }
                txtHostname.Text = iphost.HostName;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("不能连接至服务器，由于以下原因:\n"+ex.Message,"Error");
                throw;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            combNum.Items.Add("1");
            combNum.Items.Add("5");
            combNum.Items.Add("10");
            combNum.Items.Add("15");
            combNum.Items.Add("20");
            combNum.Text = combNum.Items[0].ToString();

            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            listPing.Items.Clear();
            string strNum = combNum.Text;
            int intNum = int.Parse(strNum);
            try
            {
                //Ping
                for (int i = 0; i < intNum; i++)
                {
                    Ping p1 = new Ping();
                    PingReply reply = p1.Send(txtInput.Text);
                    StringBuilder sbuilder;
                    if (reply.Status == IPStatus.Success)
                    {
                        sbuilder = new StringBuilder();
                        sbuilder.Append(string.Format("地址: {0}  ", reply.Address.ToString()));
                        sbuilder.Append(string.Format("时间: {0}ms  ", reply.RoundtripTime));
                        sbuilder.Append(string.Format("TTL: {0}  ", reply.Options.Ttl));
                        sbuilder.Append(string.Format("字节: {0}  ", reply.Buffer.Length));
                        listPing.Items.Add(sbuilder.ToString());
                    }
                    else if (reply.Status == IPStatus.TimedOut)
                    {
                        listPing.Items.Add("超时");
                    }
                    else
                    {
                        listPing.Items.Add("失败");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("瞬间爆炸！！！");
            }
        }
    }
}
