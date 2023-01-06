using System.Diagnostics;

namespace ColSel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateColor(ColorDisplay.BackColor);
            if (Environment.GetCommandLineArgs().Contains("/t")) DoAlwaysOnTop.Checked = true;

            // update checker
            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("User-Agent", "The ColSel Application");
                HttpResponseMessage response = client.GetAsync("https://api.github.com/repos/NM-Games/ColSel/releases/latest").Result;
                response.EnsureSuccessStatusCode();
                string responseText = response.Content.ReadAsStringAsync().Result;
                if (!responseText.Contains("\"name\":\"ColSel v" + ProductVersion + "\""))
                {
                    if (MessageBox.Show("There is a new update available for ColSel.\nWould you like to visit the download page?", "Update available", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) OpenURL("https://github.com/NM-Games/ColSel/releases");
                }
            }
            catch (Exception) { }
        }

        private void DoAlwaysOnTop_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = DoAlwaysOnTop.Checked;
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void UpdateColor(Color color)
        {
            ColorDisplay.BackColor = color;
            string hexR = "0" + color.R.ToString("X");
            string hexG = "0" + color.G.ToString("X");
            string hexB = "0" + color.B.ToString("X");
            HexValue.Text = "#" + hexR[hexR.Length - 2] + hexR[hexR.Length - 1] + hexG[hexG.Length - 2] + hexG[hexG.Length - 1] + hexB[hexB.Length - 2] + hexB[hexB.Length - 1];
            HashValue.Text = color.GetHashCode().ToString();
            OLEValue.Text = ColorTranslator.ToOle(color).ToString();
            ArgbValue.Text = color.ToArgb().ToString();
            RValue.Value = color.R;
            GValue.Value = color.G;
            BValue.Value = color.B;
            CValue.Value = 255 - color.R;
            MValue.Value = 255 - color.G;
            YValue.Value = 255 - color.B;
            HValue.Value = (int)color.GetHue();
            SValue.Value = (int)(color.GetSaturation() * 100);
            LValue.Value = (int)(color.GetBrightness() * 100);
        }

        private void SelectColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                UpdateColor(dialog.Color);
            }
        }

        private void RGBValueChanged(object sender, EventArgs e)
        {
            Color newColor = Color.FromArgb((int)RValue.Value, (int)GValue.Value, (int)BValue.Value);
            UpdateColor(newColor);
        }

        private void CMYValueChanged(object sender, EventArgs e)
        {
            Color newColor = Color.FromArgb(255 - (int)CValue.Value, 255 - (int)MValue.Value, 255 - (int)YValue.Value);
            UpdateColor(newColor);
        }

        private void HSLValueChanged(object sender, EventArgs e)
        {
            // readonly is readonly!
            HValue.Value = (int)ColorDisplay.BackColor.GetHue();
            SValue.Value = (int)(ColorDisplay.BackColor.GetSaturation() * 100);
            LValue.Value = (int)(ColorDisplay.BackColor.GetBrightness() * 100);
        }

        private void HexValueChanged(object sender, EventArgs e)
        {
            if (!IsHexString(HexValue.Text)) return;

            Color newColor = ColorTranslator.FromHtml(HexValue.Text);
            UpdateColor(newColor);
        }

        private void OLEValueChanged(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return || !IsNumber(OLEValue.Text)) return;

            Color newColor = ColorTranslator.FromOle(int.Parse(OLEValue.Text));
            UpdateColor(newColor);
        }
        
        private void ArgbValueChanged(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return || !IsNumber(ArgbValue.Text)) return;

            Color newColor = Color.FromArgb(int.Parse(ArgbValue.Text));
            UpdateColor(newColor);
        }

        private void OpenURL(string url)
        {
            ProcessStartInfo process = new ProcessStartInfo("cmd.exe", "/c start " + url);
            process.CreateNoWindow = true;
            System.Diagnostics.Process.Start(process);
        }

        private bool IsHexString(string str)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(str, @"^#[0-9a-fA-F]{6}$");
        }

        private bool IsNumber(string str)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(str, @"^(-|)\d+$");
        }
    }
}