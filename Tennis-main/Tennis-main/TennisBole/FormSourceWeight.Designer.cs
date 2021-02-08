
namespace TennisBole
{
    partial class FormSourceWeight
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelUTR = new System.Windows.Forms.Label();
            this.trackBarUTR = new System.Windows.Forms.TrackBar();
            this.trackBarATP = new System.Windows.Forms.TrackBar();
            this.labelATP = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelUTRWeight = new System.Windows.Forms.Label();
            this.labelATPWeight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarUTR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarATP)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUTR
            // 
            this.labelUTR.AutoSize = true;
            this.labelUTR.Location = new System.Drawing.Point(12, 9);
            this.labelUTR.Name = "labelUTR";
            this.labelUTR.Size = new System.Drawing.Size(80, 17);
            this.labelUTR.TabIndex = 0;
            this.labelUTR.Text = "UTR Weight:";
            // 
            // trackBarUTR
            // 
            this.trackBarUTR.Location = new System.Drawing.Point(12, 29);
            this.trackBarUTR.Maximum = 100;
            this.trackBarUTR.Name = "trackBarUTR";
            this.trackBarUTR.Size = new System.Drawing.Size(271, 45);
            this.trackBarUTR.TabIndex = 1;
            this.trackBarUTR.TickFrequency = 10;
            this.trackBarUTR.Value = 50;
            this.trackBarUTR.Scroll += new System.EventHandler(this.trackBarUTR_Scroll);
            this.trackBarUTR.ValueChanged += new System.EventHandler(this.trackBarUTR_ValueChanged);
            // 
            // trackBarATP
            // 
            this.trackBarATP.Location = new System.Drawing.Point(12, 96);
            this.trackBarATP.Maximum = 100;
            this.trackBarATP.Name = "trackBarATP";
            this.trackBarATP.Size = new System.Drawing.Size(271, 45);
            this.trackBarATP.TabIndex = 2;
            this.trackBarATP.TickFrequency = 10;
            this.trackBarATP.Value = 50;
            this.trackBarATP.Scroll += new System.EventHandler(this.trackBarATP_Scroll);
            this.trackBarATP.ValueChanged += new System.EventHandler(this.trackBarATP_ValueChanged);
            // 
            // labelATP
            // 
            this.labelATP.AutoSize = true;
            this.labelATP.Location = new System.Drawing.Point(14, 77);
            this.labelATP.Name = "labelATP";
            this.labelATP.Size = new System.Drawing.Size(78, 17);
            this.labelATP.TabIndex = 3;
            this.labelATP.Text = "ATP Weight:";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(208, 147);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(127, 147);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelUTRWeight
            // 
            this.labelUTRWeight.AutoSize = true;
            this.labelUTRWeight.Location = new System.Drawing.Point(240, 9);
            this.labelUTRWeight.Name = "labelUTRWeight";
            this.labelUTRWeight.Size = new System.Drawing.Size(33, 17);
            this.labelUTRWeight.TabIndex = 6;
            this.labelUTRWeight.Text = "50%";
            // 
            // labelATPWeight
            // 
            this.labelATPWeight.AutoSize = true;
            this.labelATPWeight.Location = new System.Drawing.Point(240, 77);
            this.labelATPWeight.Name = "labelATPWeight";
            this.labelATPWeight.Size = new System.Drawing.Size(33, 17);
            this.labelATPWeight.TabIndex = 7;
            this.labelATPWeight.Text = "50%";
            // 
            // FormSourceWeight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 182);
            this.Controls.Add(this.labelATPWeight);
            this.Controls.Add(this.labelUTRWeight);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelATP);
            this.Controls.Add(this.trackBarATP);
            this.Controls.Add(this.trackBarUTR);
            this.Controls.Add(this.labelUTR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormSourceWeight";
            this.Text = "Source Weight Setting";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSourceWeight_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarUTR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarATP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUTR;
        private System.Windows.Forms.TrackBar trackBarUTR;
        private System.Windows.Forms.TrackBar trackBarATP;
        private System.Windows.Forms.Label labelATP;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelUTRWeight;
        private System.Windows.Forms.Label labelATPWeight;
    }
}