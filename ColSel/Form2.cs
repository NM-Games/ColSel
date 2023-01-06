using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColSel
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            VersionLabel.Text = "v" + ProductVersion;
        }

        private void WebsiteButton_Click(object sender, EventArgs e)
        {
            OpenURL("https://nm-games.eu");
        }

        private void GithubButton_Click(object sender, EventArgs e)
        {
            OpenURL("https://github.com/NM-Games/ColSel");
        }

        private void DiscordButton_Click(object sender, EventArgs e)
        {
            OpenURL("https://discord.gg/CaMaGRXDqB");
        }

        private void OpenURL(string url)
        {
            ProcessStartInfo process = new ProcessStartInfo("cmd.exe", "/c start " + url);
            process.CreateNoWindow = true;
            System.Diagnostics.Process.Start(process);
        }
    }
}
