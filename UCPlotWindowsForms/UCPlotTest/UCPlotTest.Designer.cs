namespace UCPlotTest
{
    partial class UCPlotTest
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
            this.ucPlotView = new UCPlotView.UCPlotView();
            this.SuspendLayout();
            // 
            // ucPlotView
            // 
            this.ucPlotView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPlotView.Location = new System.Drawing.Point(0, 0);
            this.ucPlotView.Name = "ucPlotView";
            this.ucPlotView.Size = new System.Drawing.Size(661, 424);
            this.ucPlotView.Subtitle = null;
            this.ucPlotView.TabIndex = 0;
            this.ucPlotView.Title = null;
            // 
            // UCPlotTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 424);
            this.Controls.Add(this.ucPlotView);
            this.Name = "UCPlotTest";
            this.Text = "UCPlotTest";
            this.ResumeLayout(false);

        }

        #endregion

        private UCPlotView.UCPlotView ucPlotView;
    }
}

