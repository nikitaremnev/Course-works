namespace Визуализация
{
    partial class FunctionGraph
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FunctionGraph));
            Chart3DLib.LineStyle lineStyle3 = new Chart3DLib.LineStyle();
            this.FunctionGraphik = new Chart3DLib.Chart3D();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Elevation = new System.Windows.Forms.Label();
            this.PovorotElevation = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Azimuth = new System.Windows.Forms.Label();
            this.PovorotAzimuth = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PovorotElevation)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PovorotAzimuth)).BeginInit();
            this.SuspendLayout();
            // 
            // FunctionGraphik
            // 
            this.FunctionGraphik.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.FunctionGraphik.BackColor = System.Drawing.Color.White;
            this.FunctionGraphik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lineStyle1.IsVisible = true;
            lineStyle1.LineColor = System.Drawing.Color.Black;
            lineStyle1.Pattern = System.Drawing.Drawing2D.DashStyle.Solid;
            lineStyle1.PlotMethod = Chart3DLib.LineStyle.PlotLinesMethodEnum.Lines;
            lineStyle1.Thickness = 1F;
            this.FunctionGraphik.C3Axes.AxisStyle = lineStyle1;
            this.FunctionGraphik.C3Axes.XMax = 5F;
            this.FunctionGraphik.C3Axes.XMin = -5F;
            this.FunctionGraphik.C3Axes.XTick = 1F;
            this.FunctionGraphik.C3Axes.YMax = 3F;
            this.FunctionGraphik.C3Axes.YMin = -3F;
            this.FunctionGraphik.C3Axes.YTick = 1F;
            this.FunctionGraphik.C3Axes.ZMax = 6F;
            this.FunctionGraphik.C3Axes.ZMin = -6F;
            this.FunctionGraphik.C3Axes.ZTick = 3F;
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
            this.FunctionGraphik.C3DataSeries = dataSeries1;
            lineStyle3.IsVisible = true;
            lineStyle3.LineColor = System.Drawing.Color.LightGray;
            lineStyle3.Pattern = System.Drawing.Drawing2D.DashStyle.Solid;
            lineStyle3.PlotMethod = Chart3DLib.LineStyle.PlotLinesMethodEnum.Lines;
            lineStyle3.Thickness = 1F;
            this.FunctionGraphik.C3Grid.GridStyle = lineStyle3;
            this.FunctionGraphik.C3Grid.IsXGrid = true;
            this.FunctionGraphik.C3Grid.IsYGrid = true;
            this.FunctionGraphik.C3Grid.IsZGrid = true;
            this.FunctionGraphik.C3Labels.LabelFont = new System.Drawing.Font("Arial", 10F);
            this.FunctionGraphik.C3Labels.LabelFontColor = System.Drawing.Color.Black;
            this.FunctionGraphik.C3Labels.TickFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FunctionGraphik.C3Labels.TickFontColor = System.Drawing.Color.Black;
            this.FunctionGraphik.C3Labels.Title = "My 3D Chart";
            this.FunctionGraphik.C3Labels.TitleColor = System.Drawing.Color.Black;
            this.FunctionGraphik.C3Labels.TitleFont = new System.Drawing.Font("Arial Narrow", 14F);
            this.FunctionGraphik.C3Labels.XLabel = "X Axis";
            this.FunctionGraphik.C3Labels.YLabel = "Y Axis";
            this.FunctionGraphik.C3Labels.ZLabel = "Z Axis";
            this.FunctionGraphik.C3ViewAngle.Azimuth = -37.5F;
            this.FunctionGraphik.C3ViewAngle.Elevation = 30F;
            this.FunctionGraphik.Location = new System.Drawing.Point(19, 12);
            this.FunctionGraphik.Name = "FunctionGraphik";
            this.FunctionGraphik.Size = new System.Drawing.Size(491, 366);
            this.FunctionGraphik.TabIndex = 0;
            this.FunctionGraphik.Resize += new System.EventHandler(this.FunctionGraphik_Resize);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.Elevation);
            this.groupBox1.Controls.Add(this.PovorotElevation);
            this.groupBox1.Location = new System.Drawing.Point(19, 384);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 77);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поворот по вертикали";
            // 
            // Elevation
            // 
            this.Elevation.AutoSize = true;
            this.Elevation.Location = new System.Drawing.Point(434, 26);
            this.Elevation.Name = "Elevation";
            this.Elevation.Size = new System.Drawing.Size(0, 13);
            this.Elevation.TabIndex = 1;
            // 
            // PovorotElevation
            // 
            this.PovorotElevation.Location = new System.Drawing.Point(6, 26);
            this.PovorotElevation.Maximum = 90;
            this.PovorotElevation.Minimum = -90;
            this.PovorotElevation.Name = "PovorotElevation";
            this.PovorotElevation.Size = new System.Drawing.Size(427, 45);
            this.PovorotElevation.TabIndex = 1;
            this.PovorotElevation.TickFrequency = 10;
            this.PovorotElevation.Value = 30;
            this.PovorotElevation.Scroll += new System.EventHandler(this.PovorotElevation_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.Azimuth);
            this.groupBox2.Controls.Add(this.PovorotAzimuth);
            this.groupBox2.Location = new System.Drawing.Point(19, 467);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 77);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поворот по горизонтали";
            // 
            // Azimuth
            // 
            this.Azimuth.AutoSize = true;
            this.Azimuth.Location = new System.Drawing.Point(434, 25);
            this.Azimuth.Name = "Azimuth";
            this.Azimuth.Size = new System.Drawing.Size(0, 13);
            this.Azimuth.TabIndex = 1;
            // 
            // PovorotAzimuth
            // 
            this.PovorotAzimuth.Location = new System.Drawing.Point(6, 25);
            this.PovorotAzimuth.Maximum = 180;
            this.PovorotAzimuth.Minimum = -180;
            this.PovorotAzimuth.Name = "PovorotAzimuth";
            this.PovorotAzimuth.Size = new System.Drawing.Size(422, 45);
            this.PovorotAzimuth.TabIndex = 0;
            this.PovorotAzimuth.TickFrequency = 10;
            this.PovorotAzimuth.Value = -38;
            this.PovorotAzimuth.Scroll += new System.EventHandler(this.PovorotAzimuth_Scroll);
            // 
            // FunctionGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 556);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FunctionGraphik);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(545, 595);
            this.Name = "FunctionGraph";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "График функции";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PovorotElevation)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PovorotAzimuth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Chart3DLib.Chart3D FunctionGraphik;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Elevation;
        private System.Windows.Forms.TrackBar PovorotElevation;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Azimuth;
        private System.Windows.Forms.TrackBar PovorotAzimuth;
    }
}