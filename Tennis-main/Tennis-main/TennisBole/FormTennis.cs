using System;
using System.IO;
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
    public partial class FormTennis : Form
    {
        public FormTennis()
        {
            InitializeComponent();

            if(DataFilesExist())
            {
                TennisDataProcessor.ImportCSV(UTRDataFileName, ATPDataFileName);
                buttonShowData.Enabled = true;
            }
            else
                buttonUpdate.Text = "Fetch Data";

            listViewCountry.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewPlayers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private readonly string UTRDataFileName = "utr_data.csv";
        private readonly string ATPDataFileName = "atp_data.csv";
        private bool DataFilesExist()
        {
            if (File.Exists(UTRDataFileName) &&
                File.Exists(ATPDataFileName))
                return true;
            else
                return false;
        }

        private void ClearListViews()
        {
            listViewPlayers.BeginUpdate();
            listViewPlayers.Items.Clear();
            listViewPlayers.EndUpdate();

            listViewCountry.BeginUpdate();
            listViewCountry.Items.Clear();
            listViewCountry.EndUpdate();
        }

        private void buttonAgeLimits_Click(object sender, EventArgs e)
        {
            ClearListViews();

            FormAgeLimits f = new FormAgeLimits();
            f.ShowDialog();
        }

        private void buttonWeight_Click(object sender, EventArgs e)
        {
            ClearListViews();

            FormSourceWeight f = new FormSourceWeight();
            f.ShowDialog();
        }

        private void buttonShowData_Click(object sender, EventArgs e)
        {
            listViewPlayers.BeginUpdate();
            foreach (ListViewItem playerItem in TennisDataProcessor.GetPlayerListViewItems())
                listViewPlayers.Items.Add(playerItem); 
            listViewPlayers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewPlayers.EndUpdate();

            listViewCountry.BeginUpdate();
            foreach (ListViewItem countryItem in TennisDataProcessor.GetCountryListViewItems())
                listViewCountry.Items.Add(countryItem);
            listViewCountry.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewCountry.EndUpdate();


        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            ClearListViews();

            FormFetch f = new FormFetch();
            f.ShowDialog();

            buttonShowData.Enabled = true;
        }

        private void FormTennis_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
