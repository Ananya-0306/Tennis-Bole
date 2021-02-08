
namespace TennisBole
{
    partial class FormTennis
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTennis));
            this.listViewPlayers = new System.Windows.Forms.ListView();
            this.columnHeaderName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderAge = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderGender = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderNationality = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderUTR = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderATP = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderMyRank = new System.Windows.Forms.ColumnHeader();
            this.buttonAgeLimits = new System.Windows.Forms.Button();
            this.buttonShowData = new System.Windows.Forms.Button();
            this.buttonWeight = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.listViewCountry = new System.Windows.Forms.ListView();
            this.columnHeaderCountry = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderTotal = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderAvgUTR = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderAvgATP = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderAvgMyRank = new System.Windows.Forms.ColumnHeader();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelAuthors = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewPlayers
            // 
            this.listViewPlayers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderAge,
            this.columnHeaderGender,
            this.columnHeaderNationality,
            this.columnHeaderUTR,
            this.columnHeaderATP,
            this.columnHeaderMyRank});
            this.listViewPlayers.GridLines = true;
            this.listViewPlayers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewPlayers.HideSelection = false;
            this.listViewPlayers.Location = new System.Drawing.Point(212, 32);
            this.listViewPlayers.Name = "listViewPlayers";
            this.listViewPlayers.Size = new System.Drawing.Size(617, 189);
            this.listViewPlayers.TabIndex = 0;
            this.listViewPlayers.UseCompatibleStateImageBehavior = false;
            this.listViewPlayers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Name = "columnHeaderName";
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 150;
            // 
            // columnHeaderAge
            // 
            this.columnHeaderAge.Name = "columnHeaderAge";
            this.columnHeaderAge.Text = "Age";
            // 
            // columnHeaderGender
            // 
            this.columnHeaderGender.Name = "columnHeaderGender";
            this.columnHeaderGender.Text = "Gender";
            // 
            // columnHeaderNationality
            // 
            this.columnHeaderNationality.Name = "columnHeaderNationality";
            this.columnHeaderNationality.Text = "Nationality";
            this.columnHeaderNationality.Width = 150;
            // 
            // columnHeaderUTR
            // 
            this.columnHeaderUTR.Name = "columnHeaderUTR";
            this.columnHeaderUTR.Text = "UTR";
            // 
            // columnHeaderATP
            // 
            this.columnHeaderATP.Name = "columnHeaderATP";
            this.columnHeaderATP.Text = "ATP";
            // 
            // columnHeaderMyRank
            // 
            this.columnHeaderMyRank.Name = "columnHeaderMyRank";
            this.columnHeaderMyRank.Text = "MyRank";
            // 
            // buttonAgeLimits
            // 
            this.buttonAgeLimits.Location = new System.Drawing.Point(12, 12);
            this.buttonAgeLimits.Name = "buttonAgeLimits";
            this.buttonAgeLimits.Size = new System.Drawing.Size(194, 36);
            this.buttonAgeLimits.TabIndex = 1;
            this.buttonAgeLimits.Text = "Age/Country Limits Setting";
            this.buttonAgeLimits.UseVisualStyleBackColor = true;
            this.buttonAgeLimits.Click += new System.EventHandler(this.buttonAgeLimits_Click);
            // 
            // buttonShowData
            // 
            this.buttonShowData.Enabled = false;
            this.buttonShowData.Location = new System.Drawing.Point(12, 318);
            this.buttonShowData.Name = "buttonShowData";
            this.buttonShowData.Size = new System.Drawing.Size(194, 85);
            this.buttonShowData.TabIndex = 2;
            this.buttonShowData.Text = "Show Data";
            this.buttonShowData.UseVisualStyleBackColor = true;
            this.buttonShowData.Click += new System.EventHandler(this.buttonShowData_Click);
            // 
            // buttonWeight
            // 
            this.buttonWeight.Location = new System.Drawing.Point(12, 54);
            this.buttonWeight.Name = "buttonWeight";
            this.buttonWeight.Size = new System.Drawing.Size(194, 36);
            this.buttonWeight.TabIndex = 3;
            this.buttonWeight.Text = "Source Weight Setting";
            this.buttonWeight.UseVisualStyleBackColor = true;
            this.buttonWeight.Click += new System.EventHandler(this.buttonWeight_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(12, 227);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(194, 85);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "Update Data";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.Location = new System.Drawing.Point(212, 12);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(77, 17);
            this.labelPlayer.TabIndex = 5;
            this.labelPlayer.Text = "Player Data:";
            // 
            // listViewCountry
            // 
            this.listViewCountry.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCountry,
            this.columnHeaderTotal,
            this.columnHeaderAvgUTR,
            this.columnHeaderAvgATP,
            this.columnHeaderAvgMyRank});
            this.listViewCountry.GridLines = true;
            this.listViewCountry.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewCountry.HideSelection = false;
            this.listViewCountry.Location = new System.Drawing.Point(212, 246);
            this.listViewCountry.Name = "listViewCountry";
            this.listViewCountry.Size = new System.Drawing.Size(616, 157);
            this.listViewCountry.TabIndex = 6;
            this.listViewCountry.UseCompatibleStateImageBehavior = false;
            this.listViewCountry.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderCountry
            // 
            this.columnHeaderCountry.Name = "columnHeaderCountry";
            this.columnHeaderCountry.Text = "Country";
            this.columnHeaderCountry.Width = 150;
            // 
            // columnHeaderTotal
            // 
            this.columnHeaderTotal.Name = "columnHeaderTotal";
            this.columnHeaderTotal.Text = "Total Player";
            this.columnHeaderTotal.Width = 80;
            // 
            // columnHeaderAvgUTR
            // 
            this.columnHeaderAvgUTR.Name = "columnHeaderAvgUTR";
            this.columnHeaderAvgUTR.Text = "Avg UTR";
            this.columnHeaderAvgUTR.Width = 70;
            // 
            // columnHeaderAvgATP
            // 
            this.columnHeaderAvgATP.Name = "columnHeaderAvgATP";
            this.columnHeaderAvgATP.Text = "Avg ATP";
            // 
            // columnHeaderAvgMyRank
            // 
            this.columnHeaderAvgMyRank.Name = "columnHeaderAvgMyRank";
            this.columnHeaderAvgMyRank.Text = "Avg MyRank";
            this.columnHeaderAvgMyRank.Width = 100;
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(212, 226);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(87, 17);
            this.labelCountry.TabIndex = 7;
            this.labelCountry.Text = "Country Data:";
            // 
            // labelAuthors
            // 
            this.labelAuthors.AutoEllipsis = true;
            this.labelAuthors.Location = new System.Drawing.Point(12, 93);
            this.labelAuthors.Name = "labelAuthors";
            this.labelAuthors.Size = new System.Drawing.Size(194, 128);
            this.labelAuthors.TabIndex = 8;
            this.labelAuthors.Text = "Authors:\r\nTing Li, \r\nLide Zhang,\r\nRuiyang Zhou.";
            this.labelAuthors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormTennis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 414);
            this.Controls.Add(this.labelAuthors);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.listViewCountry);
            this.Controls.Add(this.labelPlayer);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonWeight);
            this.Controls.Add(this.buttonShowData);
            this.Controls.Add(this.buttonAgeLimits);
            this.Controls.Add(this.listViewPlayers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormTennis";
            this.Text = "Tennis Bole";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTennis_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewPlayers;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderAge;
        private System.Windows.Forms.ColumnHeader columnHeaderGender;
        private System.Windows.Forms.ColumnHeader columnHeaderNationality;
        private System.Windows.Forms.ColumnHeader columnHeaderUTR;
        private System.Windows.Forms.ColumnHeader columnHeaderATP;
        private System.Windows.Forms.ColumnHeader columnHeaderMyRank;
        private System.Windows.Forms.Button buttonAgeLimits;
        private System.Windows.Forms.Button buttonShowData;
        private System.Windows.Forms.Button buttonWeight;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.ListView listViewCountry;
        private System.Windows.Forms.ColumnHeader columnHeaderCountry;
        private System.Windows.Forms.ColumnHeader columnHeaderAvgUTR;
        private System.Windows.Forms.ColumnHeader columnHeaderAvgATP;
        private System.Windows.Forms.ColumnHeader columnHeaderAvgMyRank;
        private System.Windows.Forms.ColumnHeader columnHeaderTotal;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelAuthors;
    }
}

