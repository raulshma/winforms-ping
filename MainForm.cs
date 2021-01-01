using GamePinger.Models;
using MetroFramework.Forms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace GamePinger
{
    public partial class MainForm : MetroForm
    {
        private List<RangeObj> IpRanges = new List<RangeObj>();
        private List<PingResult> dataSource = new List<PingResult>();
        public MainForm()
        {
            InitializeComponent();
            dataGridPing.AutoGenerateColumns = false;
            IpRanges = Helpers.ReadIpsFromFile();
        }



        private async void MainForm_Load(object sender, EventArgs e)
        {
            await GetPings();
        }

        private async Task GetPings()
        {
            metroProgressSpinner.Visible = true;
            var pingSender = new Ping();
            int pingCount = 0;
            long tempPing;
            foreach (var item in IpRanges)
            {
                tempPing = 0;
                for (int i = 0; i < 5; i++)
                {
                    var reply = await pingSender.SendPingAsync(item.IpText);
                    if (reply.Status == IPStatus.Success)
                    {
                        tempPing += reply.RoundtripTime;
                        pingCount += 1;
                    }
                }
                dataSource.Add(new PingResult { Location = item.LocationText, Value = $"{tempPing / pingCount}ms" });
                pingCount = 0;
                dataGridPing.DataSource = null;
                dataGridPing.DataSource = dataSource;
            }
            metroProgressSpinner.Visible = false;
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            dataSource.Clear();
            await GetPings();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            using (Settings frmSettings = new Settings())
            {
                frmSettings.ShowDialog();
                IpRanges.Clear();
                IpRanges = Helpers.ReadIpsFromFile();
                dataGridPing.DataSource = null;
                dataGridPing.DataSource = dataSource;
            }

        }
    }
}
