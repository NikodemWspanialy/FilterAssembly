namespace Filter.GUI
{
    partial class Histogram
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
            RcolorPlotView = new OxyPlot.WindowsForms.PlotView();
            RblackPlotView = new OxyPlot.WindowsForms.PlotView();
            GcolorPlotView = new OxyPlot.WindowsForms.PlotView();
            GblackPlotView = new OxyPlot.WindowsForms.PlotView();
            BcolorPlotView = new OxyPlot.WindowsForms.PlotView();
            BblackPlotView = new OxyPlot.WindowsForms.PlotView();
            SuspendLayout();
            // 
            // RcolorPlotView
            // 
            RcolorPlotView.BackColor = SystemColors.ControlLightLight;
            RcolorPlotView.Location = new Point(22, 12);
            RcolorPlotView.Name = "RcolorPlotView";
            RcolorPlotView.PanCursor = Cursors.Hand;
            RcolorPlotView.Size = new Size(355, 228);
            RcolorPlotView.TabIndex = 0;
            RcolorPlotView.Text = "plotView1";
            RcolorPlotView.ZoomHorizontalCursor = Cursors.SizeWE;
            RcolorPlotView.ZoomRectangleCursor = Cursors.SizeNWSE;
            RcolorPlotView.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // RblackPlotView
            // 
            RblackPlotView.BackColor = SystemColors.ControlLightLight;
            RblackPlotView.Location = new Point(419, 12);
            RblackPlotView.Name = "RblackPlotView";
            RblackPlotView.PanCursor = Cursors.Hand;
            RblackPlotView.Size = new Size(355, 228);
            RblackPlotView.TabIndex = 1;
            RblackPlotView.Text = "plotView1";
            RblackPlotView.ZoomHorizontalCursor = Cursors.SizeWE;
            RblackPlotView.ZoomRectangleCursor = Cursors.SizeNWSE;
            RblackPlotView.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // GcolorPlotView
            // 
            GcolorPlotView.BackColor = SystemColors.ControlLightLight;
            GcolorPlotView.Location = new Point(22, 271);
            GcolorPlotView.Name = "GcolorPlotView";
            GcolorPlotView.PanCursor = Cursors.Hand;
            GcolorPlotView.Size = new Size(355, 228);
            GcolorPlotView.TabIndex = 2;
            GcolorPlotView.Text = "plotView1";
            GcolorPlotView.ZoomHorizontalCursor = Cursors.SizeWE;
            GcolorPlotView.ZoomRectangleCursor = Cursors.SizeNWSE;
            GcolorPlotView.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // GblackPlotView
            // 
            GblackPlotView.BackColor = SystemColors.ControlLightLight;
            GblackPlotView.Location = new Point(419, 271);
            GblackPlotView.Name = "GblackPlotView";
            GblackPlotView.PanCursor = Cursors.Hand;
            GblackPlotView.Size = new Size(355, 228);
            GblackPlotView.TabIndex = 3;
            GblackPlotView.Text = "plotView1";
            GblackPlotView.ZoomHorizontalCursor = Cursors.SizeWE;
            GblackPlotView.ZoomRectangleCursor = Cursors.SizeNWSE;
            GblackPlotView.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // BcolorPlotView
            // 
            BcolorPlotView.BackColor = SystemColors.ControlLightLight;
            BcolorPlotView.Location = new Point(22, 533);
            BcolorPlotView.Name = "BcolorPlotView";
            BcolorPlotView.PanCursor = Cursors.Hand;
            BcolorPlotView.Size = new Size(355, 228);
            BcolorPlotView.TabIndex = 4;
            BcolorPlotView.Text = "plotView1";
            BcolorPlotView.ZoomHorizontalCursor = Cursors.SizeWE;
            BcolorPlotView.ZoomRectangleCursor = Cursors.SizeNWSE;
            BcolorPlotView.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // BblackPlotView
            // 
            BblackPlotView.BackColor = SystemColors.ControlLightLight;
            BblackPlotView.Location = new Point(419, 533);
            BblackPlotView.Name = "BblackPlotView";
            BblackPlotView.PanCursor = Cursors.Hand;
            BblackPlotView.Size = new Size(355, 228);
            BblackPlotView.TabIndex = 5;
            BblackPlotView.Text = "plotView1";
            BblackPlotView.ZoomHorizontalCursor = Cursors.SizeWE;
            BblackPlotView.ZoomRectangleCursor = Cursors.SizeNWSE;
            BblackPlotView.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // Histogram
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 255, 204);
            ClientSize = new Size(803, 781);
            Controls.Add(BblackPlotView);
            Controls.Add(BcolorPlotView);
            Controls.Add(GblackPlotView);
            Controls.Add(GcolorPlotView);
            Controls.Add(RblackPlotView);
            Controls.Add(RcolorPlotView);
            Name = "Histogram";
            Text = "Histogram";
            ResumeLayout(false);
        }

        #endregion

        private OxyPlot.WindowsForms.PlotView RcolorPlotView;
        private OxyPlot.WindowsForms.PlotView RblackPlotView;
        private OxyPlot.WindowsForms.PlotView GcolorPlotView;
        private OxyPlot.WindowsForms.PlotView GblackPlotView;
        private OxyPlot.WindowsForms.PlotView BcolorPlotView;
        private OxyPlot.WindowsForms.PlotView BblackPlotView;
    }
}