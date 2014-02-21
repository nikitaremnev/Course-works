namespace Test
{
    partial class Form1
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
            Chart3DLib.LineStyle lineStyle1 = new Chart3DLib.LineStyle();
            Chart3DLib.DataSeries dataSeries1 = new Chart3DLib.DataSeries();
            Chart3DLib.BarStyle barStyle1 = new Chart3DLib.BarStyle();
            Chart3DLib.LineStyle lineStyle2 = new Chart3DLib.LineStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Chart3DLib.LineStyle lineStyle3 = new Chart3DLib.LineStyle();
            this.chart3D1 = new Chart3DLib.Chart3D();
            this.SuspendLayout();
            // 
            // chart3D1
            // 
            this.chart3D1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chart3D1.BackColor = System.Drawing.Color.White;
            this.chart3D1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lineStyle1.IsVisible = true;
            lineStyle1.LineColor = System.Drawing.Color.Black;
            lineStyle1.Pattern = System.Drawing.Drawing2D.DashStyle.Solid;
            lineStyle1.PlotMethod = Chart3DLib.LineStyle.PlotLinesMethodEnum.Lines;
            lineStyle1.Thickness = 1F;
            this.chart3D1.C3Axes.AxisStyle = lineStyle1;
            this.chart3D1.C3Axes.XMax = 5F;
            this.chart3D1.C3Axes.XMin = -5F;
            this.chart3D1.C3Axes.XTick = 1F;
            this.chart3D1.C3Axes.YMax = 3F;
            this.chart3D1.C3Axes.YMin = -3F;
            this.chart3D1.C3Axes.YTick = 1F;
            this.chart3D1.C3Axes.ZMax = 6F;
            this.chart3D1.C3Axes.ZMin = -6F;
            this.chart3D1.C3Axes.ZTick = 3F;
            barStyle1.IsBarSingleColor = false;
            barStyle1.XLength = 0.5F;
            barStyle1.YLength = 0.5F;
            barStyle1.ZOrigin = 0F;
            dataSeries1.BarStyle = barStyle1;
            lineStyle2.IsVisible = true;
            lineStyle2.LineColor = System.Drawing.Color.Black;
            lineStyle2.Pattern = System.Drawing.Drawing2D.DashStyle.Solid;
            lineStyle2.PlotMethod = Chart3DLib.LineStyle.PlotLinesMethodEnum.Lines;
            lineStyle2.Thickness = 1F;
            dataSeries1.LineStyle = lineStyle2;
            dataSeries1.Point4Array = null;
            dataSeries1.PointArray = null;
            dataSeries1.PointList = ((System.Collections.ArrayList)(resources.GetObject("dataSeries1.PointList")));
            dataSeries1.XDataMin = -5F;
            dataSeries1.XNumber = 10;
            dataSeries1.XSpacing = 1F;
            dataSeries1.YDataMin = -5F;
            dataSeries1.YNumber = 10;
            dataSeries1.YSpacing = 1F;
            dataSeries1.ZNumber = 10;
            dataSeries1.ZSpacing = 1F;
            dataSeries1.ZZDataMin = -5F;
            this.chart3D1.C3DataSeries = dataSeries1;
            lineStyle3.IsVisible = true;
            lineStyle3.LineColor = System.Drawing.Color.LightGray;
            lineStyle3.Pattern = System.Drawing.Drawing2D.DashStyle.Solid;
            lineStyle3.PlotMethod = Chart3DLib.LineStyle.PlotLinesMethodEnum.Lines;
            lineStyle3.Thickness = 1F;
            this.chart3D1.C3Grid.GridStyle = lineStyle3;
            this.chart3D1.C3Grid.IsXGrid = true;
            this.chart3D1.C3Grid.IsYGrid = true;
            this.chart3D1.C3Grid.IsZGrid = true;
            this.chart3D1.C3Labels.LabelFont = new System.Drawing.Font("Arial", 10F);
            this.chart3D1.C3Labels.LabelFontColor = System.Drawing.Color.Black;
            this.chart3D1.C3Labels.TickFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart3D1.C3Labels.TickFontColor = System.Drawing.Color.Black;
            this.chart3D1.C3Labels.Title = "My 3D Chart";
            this.chart3D1.C3Labels.TitleColor = System.Drawing.Color.Black;
            this.chart3D1.C3Labels.TitleFont = new System.Drawing.Font("Arial Narrow", 14F);
            this.chart3D1.C3Labels.XLabel = "X Axis";
            this.chart3D1.C3Labels.YLabel = "Y Axis";
            this.chart3D1.C3Labels.ZLabel = "Z Axis";
            this.chart3D1.C3ViewAngle.Azimuth = -37.5F;
            this.chart3D1.C3ViewAngle.Elevation = 30F;
            this.chart3D1.Location = new System.Drawing.Point(16, 16);
            this.chart3D1.Name = "chart3D1";
            this.chart3D1.Size = new System.Drawing.Size(384, 304);
            this.chart3D1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 340);
            this.Controls.Add(this.chart3D1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Chart3DLib.Chart3D chart3D1;










    }
}

