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
    public partial class FormAgeLimits : Form
    {
        public FormAgeLimits()
        {
            InitializeComponent();

            comboBoxNationality.SelectedIndex = 0;

            ImportLimitsToListView(listViewLimits);
        }

        private void ImportLimitsToListView(ListView target)
        {
            target.BeginUpdate();

            if(TennisDataProcessor.GlobalMaxAge!=TennisDataProcessor.NoGlobalMaxAge)
            {
                ListViewItem globalLimitItem = new ListViewItem(IOCConverter.CountryNameWildcard);
                globalLimitItem.SubItems.Add(TennisDataProcessor.GlobalMaxAge.ToString());
                target.Items.Add(globalLimitItem);
            }

            foreach (TennisDataProcessor.SpecificLimit limit in TennisDataProcessor.SpecificLimits)
            {
                ListViewItem limitItem = new ListViewItem(IOCConverter.CodeToCountryName(limit.Nationality));
                limitItem.SubItems.Add(limit.Age.ToString());
                target.Items.Add(limitItem);
            }

            target.EndUpdate();
        }

        private void buttonAddLimit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBoxNationality.Text))
            {
                listViewLimits.BeginUpdate();

                string nationality = comboBoxNationality.Text;
                string age = Convert.ToInt32(numericUpDownAge.Value).ToString();

                List<ListViewItem> limitItemsToRemove = new List<ListViewItem>();

                foreach(ListViewItem limitItem in listViewLimits.Items)
                {
                    if(limitItem.Text.Equals(nationality))
                        limitItemsToRemove.Add(limitItem);
                }

                foreach (ListViewItem limitItem in limitItemsToRemove)
                    listViewLimits.Items.Remove(limitItem);

                ListViewItem newLimitItem = new ListViewItem(nationality);
                newLimitItem.SubItems.Add(age);

                listViewLimits.Items.Add(newLimitItem);

                listViewLimits.EndUpdate();
            }
        }

        private void buttonRemoveLimit_Click(object sender, EventArgs e)
        {
            if(listViewLimits.SelectedItems.Count!=0)
            {
                listViewLimits.BeginUpdate();

                foreach (ListViewItem limitItem in listViewLimits.SelectedItems)
                    listViewLimits.Items.Remove(limitItem);

                listViewLimits.EndUpdate();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            listViewLimits.BeginUpdate();

            listViewLimits.Items.Clear();

            ListViewItem defaultLimitItem = new ListViewItem(IOCConverter.CountryNameWildcard);
            defaultLimitItem.SubItems.Add(TennisDataProcessor.DefaultGlobalMaxAge.ToString());
            listViewLimits.Items.Add(defaultLimitItem);

            listViewLimits.EndUpdate();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAgeLimits_FormClosed(object sender, FormClosedEventArgs e)
        {
            bool globalLimitAdded = false;
            TennisDataProcessor.SpecificLimits.Clear();

            foreach(ListViewItem limitItem in listViewLimits.Items)
            {
                if (limitItem.Text.Equals(IOCConverter.CountryNameWildcard))
                {
                    TennisDataProcessor.GlobalMaxAge = int.Parse(limitItem.SubItems[1].Text);
                    globalLimitAdded = true;
                }
                else
                {
                    TennisDataProcessor.SpecificLimit limit = new TennisDataProcessor.SpecificLimit();

                    limit.Nationality = IOCConverter.CountryNameToCode(limitItem.Text);
                    limit.Age = int.Parse(limitItem.SubItems[1].Text);

                    TennisDataProcessor.SpecificLimits.Add(limit);
                }
            }

            if (!globalLimitAdded)
                TennisDataProcessor.GlobalMaxAge = TennisDataProcessor.NoGlobalMaxAge;
        }
    }
}
