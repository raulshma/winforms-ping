using GamePinger.Models;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamePinger
{
    public partial class Settings : MetroForm
    {
        Ping pingSender = new Ping();
        private List<RangeObj> IpRanges = new List<RangeObj>();
        public Settings()
        {
            InitializeComponent();
            dataGridSettings.AutoGenerateColumns = false;
            IpRanges = Helpers.ReadIpsFromFile();
            dataGridSettings.DataSource = IpRanges;
        }

        private async void btnAddRow_Click(object sender, EventArgs e)
        {
            string location = txtLocation.Text;
            string ip = txtIp.Text;
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    var reply = await pingSender.SendPingAsync(ip);
                    if (reply.Status == IPStatus.Success)
                    {
                        RangeObj newItem = new RangeObj
                        {
                            IpText = ip,
                            LocationText = location
                        };
                        IpRanges.Add(newItem);
                        dataGridSettings.DataSource = null;
                        dataGridSettings.DataSource = IpRanges;
                        Helpers.WriteIpsToFile(IpRanges);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
