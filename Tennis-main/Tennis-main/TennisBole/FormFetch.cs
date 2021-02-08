using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TennisBole
{
    public partial class FormFetch : Form
    {
        private Process UTRFetcherProcess = new Process();
        private Process ATPFetcherProcess = new Process();
        private static readonly string UTRFetcherFileName = "utr_fetcher.exe";
        private static readonly string ATPFetcherFileName = "atp_fetcher.exe";

        private static readonly string BothRunning = "Fetching UTR and ATP data now. Please wait.";
        private static readonly string ATPDone = "ATP fetching finished. Fetching UTR data now. Please wait.";
        private static readonly string UTRDone = "UTR fetching finished. Fetching ATP data now. Please wait.";
        private static readonly string BothDone = "Fetching finished.";
        public FormFetch()
        {
            InitializeComponent();

            UTRFetcherProcess.StartInfo.FileName = UTRFetcherFileName;
            UTRFetcherProcess.StartInfo.CreateNoWindow = true;
            UTRFetcherProcess.Exited += UTRFetcherProcess_Exited;
            UTRFetcherProcess.EnableRaisingEvents = true;
            UTRFetcherProcess.Start();

            ATPFetcherProcess.StartInfo.FileName = ATPFetcherFileName;
            ATPFetcherProcess.StartInfo.CreateNoWindow = true;
            ATPFetcherProcess.Exited += ATPFetcherProcess_Exited;
            ATPFetcherProcess.EnableRaisingEvents = true;
            ATPFetcherProcess.Start();

            labelProgress.Text = BothRunning;
        }
        private void UTRFetcherProcess_Exited(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke((Action)delegate ()
                {
                    if (ATPFetcherProcess.HasExited)
                        BothProcessExited();
                    else
                        labelProgress.Text = UTRDone;
                });
            }
            else
            {
                if (ATPFetcherProcess.HasExited)
                    BothProcessExited();
                else
                    labelProgress.Text = UTRDone;
            }
        }

        private void ATPFetcherProcess_Exited(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke((Action)delegate ()
                {
                    if (UTRFetcherProcess.HasExited)
                        BothProcessExited();
                    else
                        labelProgress.Text = ATPDone;
                });
            }
            else
            {
                if (UTRFetcherProcess.HasExited)
                    BothProcessExited();
                else
                    labelProgress.Text = ATPDone;
            }
        }

        private void BothProcessExited()
        {
            labelProgress.Text = BothDone;
            progressBarFetch.Style = ProgressBarStyle.Continuous;
            progressBarFetch.Value = progressBarFetch.Maximum;
            buttonOK.Enabled = true;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormFetch_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!UTRFetcherProcess.HasExited)
                UTRFetcherProcess.Kill();
            if (!ATPFetcherProcess.HasExited)
                ATPFetcherProcess.Kill();

            UTRFetcherProcess.Close();
            ATPFetcherProcess.Close();
        }
    }
}
