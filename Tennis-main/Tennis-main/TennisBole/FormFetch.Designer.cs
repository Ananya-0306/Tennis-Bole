
namespace TennisBole
{
    partial class FormFetch
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
            this.progressBarFetch = new System.Windows.Forms.ProgressBar();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelProgressPrompt = new System.Windows.Forms.Label();
            this.labelProgress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBarFetch
            // 
            this.progressBarFetch.Location = new System.Drawing.Point(29, 60);
            this.progressBarFetch.Margin = new System.Windows.Forms.Padding(20);
            this.progressBarFetch.Name = "progressBarFetch";
            this.progressBarFetch.Size = new System.Drawing.Size(290, 23);
            this.progressBarFetch.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBarFetch.TabIndex = 0;
            // 
            // buttonOK
            // 
            this.buttonOK.Enabled = false;
            this.buttonOK.Location = new System.Drawing.Point(244, 106);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelProgressPrompt
            // 
            this.labelProgressPrompt.AutoSize = true;
            this.labelProgressPrompt.Location = new System.Drawing.Point(29, 9);
            this.labelProgressPrompt.Name = "labelProgressPrompt";
            this.labelProgressPrompt.Size = new System.Drawing.Size(110, 17);
            this.labelProgressPrompt.TabIndex = 3;
            this.labelProgressPrompt.Text = "Current Progress:";
            // 
            // labelProgress
            // 
            this.labelProgress.Location = new System.Drawing.Point(145, 9);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(174, 39);
            this.labelProgress.TabIndex = 4;
            this.labelProgress.Text = "Fetching UTR and ATP data now. Please wait.";
            // 
            // FormFetch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 141);
            this.ControlBox = false;
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.labelProgressPrompt);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.progressBarFetch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormFetch";
            this.Text = "Fetch Data";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormFetch_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarFetch;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelProgressPrompt;
        private System.Windows.Forms.Label labelProgress;
    }
}