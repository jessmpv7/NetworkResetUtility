using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkResetUtility
{
    public partial class Form1 : Form
    {
        private const int WaitSeconds = 30;
        private const int AutoCloseSeconds = 30;

        public Form1()
        {
            InitializeComponent();
            btnRedo.Enabled = false;
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            txtOutput.Clear();
            ResetProgressBars();
            await RunNetworkResetAsync();
        }

        private async void btnRedo_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            ResetProgressBars();
            btnRedo.Enabled = false;
            await RunNetworkResetAsync();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ResetProgressBars()
        {
            progressFlush.Value = 0;
            progressRelease.Value = 0;
            progressWait.Value = 0;
            progressRenew.Value = 0;

            // Reset labels text and color
            labelFlush.Text = "Flush DNS";
            labelFlush.ForeColor = Color.Black;
            labelRelease.Text = "Release IP";
            labelRelease.ForeColor = Color.Black;
            labelWait.Text = "Wait 30 sec";
            labelWait.ForeColor = Color.Black;
            labelRenew.Text = "Renew IP";
            labelRenew.ForeColor = Color.Black;

            progressFlush.Invalidate();
            progressRelease.Invalidate();
            progressWait.Invalidate();
            progressRenew.Invalidate();
        }

        private async Task RunNetworkResetAsync()
        {
            btnRedo.Enabled = false;

            try
            {
                // Step 1: Flush DNS
                await RunCommandWithProgress("ipconfig", "/flushdns", progressFlush, labelFlush, "Flushing DNS", "DNS Flushed!");

                // Step 2: Release IP
                await RunCommandWithProgress("ipconfig", "/release", progressRelease, labelRelease, "Releasing IP", "IP Released!");

                // Step 3: Wait 30 seconds
                await WaitWithProgress(progressWait, labelWait, "Waiting", WaitSeconds, "Done Waiting!");

                // Step 4: Renew IP
                await RunCommandWithProgress("ipconfig", "/renew", progressRenew, labelRenew, "Renewing IP", "IP Renewed!");

                AppendOutput("Network reset completed successfully!", Color.Green);

                // Auto-close countdown
                await StartAutoCloseCountdown();
            }
            catch (Exception ex)
            {
                AppendOutput("Network reset failed: " + ex.Message, Color.Red);
            }
            finally
            {
                btnRedo.Enabled = true;
            }
        }

        private async Task RunCommandWithProgress(string file, string args, ProgressBar progressBar, Label statusLabel, string actionText, string successText)
        {
            int adapterCount = GetActiveAdapterCount();
            double increment = 100.0 / adapterCount;

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = file,
                Arguments = args,
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };

            using (Process p = Process.Start(psi))
            {
                string line;
                while ((line = await p.StandardOutput.ReadLineAsync()) != null)
                {
                    AppendOutput(line, Color.Black);

                    if (line.StartsWith("Ethernet") || line.StartsWith("Wi-Fi") ||
                        line.StartsWith("Local Area") || line.StartsWith("Wireless"))
                    {
                        await AnimateProgress(progressBar, statusLabel, increment, actionText);
                    }
                }

                p.WaitForExit();

                progressBar.Invoke(new Action(() =>
                {
                    progressBar.Value = 100;
                    statusLabel.Text = successText;
                    statusLabel.ForeColor = Color.Green;
                }));
            }
        }

        private async Task WaitWithProgress(ProgressBar progressBar, Label statusLabel, string actionText, int seconds, string successText)
        {
            for (int i = 0; i <= seconds; i++)
            {
                int val = (i * 100) / seconds;
                progressBar.Invoke(new Action(() =>
                {
                    progressBar.Value = val;
                    statusLabel.Text = $"{actionText} {i}s";
                }));
                await Task.Delay(1000);
            }

            progressBar.Invoke(new Action(() =>
            {
                progressBar.Value = 100;
                statusLabel.Text = successText;
                statusLabel.ForeColor = Color.Green;
            }));
        }

        private async Task AnimateProgress(ProgressBar bar, Label label, double increment, string labelText)
        {
            int target = Math.Min(100, bar.Value + (int)increment);
            while (bar.Value < target)
            {
                bar.Invoke(new Action(() =>
                {
                    bar.Value += 1;
                    label.Text = $"{labelText} {bar.Value}%";
                }));
                await Task.Delay(30);
            }
        }

        private async Task StartAutoCloseCountdown()
        {
            for (int i = AutoCloseSeconds; i > 0; i--)
            {
                AppendOutput($"Application will close in {i} second(s)...", Color.DarkBlue);
                await Task.Delay(1000);
            }
            Application.Exit();
        }

        private int GetActiveAdapterCount()
        {
            int count = 0;
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "ipconfig",
                    Arguments = "/all",
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true
                };

                using (Process p = Process.Start(psi))
                {
                    string line;
                    while ((line = p.StandardOutput.ReadLine()) != null)
                    {
                        if (line.StartsWith("Ethernet") || line.StartsWith("Wi-Fi") ||
                            line.StartsWith("Local Area") || line.StartsWith("Wireless"))
                        {
                            count++;
                        }
                    }
                    p.WaitForExit();
                }
            }
            catch { }

            return Math.Max(count, 1);
        }

        private void AppendOutput(string message, Color color)
        {
            txtOutput.Invoke(new Action(() =>
            {
                txtOutput.SelectionStart = txtOutput.TextLength;
                txtOutput.SelectionLength = 0;
                txtOutput.SelectionColor = color;
                txtOutput.AppendText(message + Environment.NewLine);
                txtOutput.SelectionColor = txtOutput.ForeColor;
                txtOutput.ScrollToCaret();
            }));
        }
    }
}
