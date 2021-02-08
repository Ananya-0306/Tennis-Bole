using System;
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
    public partial class FormSourceWeight : Form
    {
        public FormSourceWeight()
        {
            InitializeComponent();

            trackBarUTR.Value = TennisDataProcessor.UTRWeight;
            trackBarATP.Value = TennisDataProcessor.ATPWeight;
        }

        private void trackBarUTR_ValueChanged(object sender, EventArgs e)
        {
            labelUTRWeight.Text = string.Format("{0}%", trackBarUTR.Value);
        }

        private void trackBarATP_ValueChanged(object sender, EventArgs e)
        {
            labelATPWeight.Text = string.Format("{0}%", trackBarATP.Value);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            trackBarUTR.Value = TennisDataProcessor.DefaultWeight;
            trackBarATP.Value = TennisDataProcessor.DefaultWeight;
        }

        private void trackBarUTR_Scroll(object sender, EventArgs e)
        {
            trackBarATP.Value = trackBarATP.Maximum - trackBarUTR.Value;
        }

        private void trackBarATP_Scroll(object sender, EventArgs e)
        {
            trackBarUTR.Value = trackBarUTR.Maximum - trackBarATP.Value;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSourceWeight_FormClosed(object sender, FormClosedEventArgs e)
        {
            TennisDataProcessor.UTRWeight = trackBarUTR.Value;
            TennisDataProcessor.ATPWeight = trackBarATP.Value;
        }
    }
}
