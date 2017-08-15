namespace UCPlotView
{
    partial class UCPlotView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainerHor = new System.Windows.Forms.SplitContainer();
            this.splitContainerVert = new System.Windows.Forms.SplitContainer();
            this.cplotView = new OxyPlot.WindowsForms.PlotView();
            this.cplotPGrid = new System.Windows.Forms.PropertyGrid();
            this.ctoolStrip = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHor)).BeginInit();
            this.splitContainerHor.Panel1.SuspendLayout();
            this.splitContainerHor.Panel2.SuspendLayout();
            this.splitContainerHor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerVert)).BeginInit();
            this.splitContainerVert.Panel1.SuspendLayout();
            this.splitContainerVert.Panel2.SuspendLayout();
            this.splitContainerVert.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerHor
            // 
            this.splitContainerHor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerHor.Location = new System.Drawing.Point(0, 0);
            this.splitContainerHor.Name = "splitContainerHor";
            this.splitContainerHor.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerHor.Panel1
            // 
            this.splitContainerHor.Panel1.Controls.Add(this.splitContainerVert);
            // 
            // splitContainerHor.Panel2
            // 
            this.splitContainerHor.Panel2.Controls.Add(this.ctoolStrip);
            this.splitContainerHor.Size = new System.Drawing.Size(546, 349);
            this.splitContainerHor.SplitterDistance = 320;
            this.splitContainerHor.TabIndex = 0;
            // 
            // splitContainerVert
            // 
            this.splitContainerVert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerVert.Location = new System.Drawing.Point(0, 0);
            this.splitContainerVert.Name = "splitContainerVert";
            // 
            // splitContainerVert.Panel1
            // 
            this.splitContainerVert.Panel1.Controls.Add(this.cplotView);
            // 
            // splitContainerVert.Panel2
            // 
            this.splitContainerVert.Panel2.Controls.Add(this.cplotPGrid);
            this.splitContainerVert.Size = new System.Drawing.Size(546, 320);
            this.splitContainerVert.SplitterDistance = 340;
            this.splitContainerVert.TabIndex = 0;
            // 
            // cplotView
            // 
            this.cplotView.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cplotView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cplotView.Location = new System.Drawing.Point(0, 0);
            this.cplotView.Name = "cplotView";
            this.cplotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.cplotView.Size = new System.Drawing.Size(340, 320);
            this.cplotView.TabIndex = 0;
            this.cplotView.Text = "plotView1";
            this.cplotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.cplotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.cplotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // cplotPGrid
            // 
            this.cplotPGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cplotPGrid.LineColor = System.Drawing.SystemColors.ControlDark;
            this.cplotPGrid.Location = new System.Drawing.Point(0, 0);
            this.cplotPGrid.Name = "cplotPGrid";
            this.cplotPGrid.Size = new System.Drawing.Size(202, 320);
            this.cplotPGrid.TabIndex = 0;
            // 
            // ctoolStrip
            // 
            this.ctoolStrip.Location = new System.Drawing.Point(0, 0);
            this.ctoolStrip.Name = "ctoolStrip";
            this.ctoolStrip.Size = new System.Drawing.Size(546, 25);
            this.ctoolStrip.TabIndex = 0;
            this.ctoolStrip.Text = "toolStrip1";
            // 
            // UCPlotView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerHor);
            this.Name = "UCPlotView";
            this.Size = new System.Drawing.Size(546, 349);
            this.splitContainerHor.Panel1.ResumeLayout(false);
            this.splitContainerHor.Panel2.ResumeLayout(false);
            this.splitContainerHor.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHor)).EndInit();
            this.splitContainerHor.ResumeLayout(false);
            this.splitContainerVert.Panel1.ResumeLayout(false);
            this.splitContainerVert.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerVert)).EndInit();
            this.splitContainerVert.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerHor;
        private System.Windows.Forms.SplitContainer splitContainerVert;
        private OxyPlot.WindowsForms.PlotView cplotView;
        private System.Windows.Forms.PropertyGrid cplotPGrid;
        private System.Windows.Forms.ToolStrip ctoolStrip;
    }
}
