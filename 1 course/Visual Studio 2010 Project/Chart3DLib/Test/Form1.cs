using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Chart3DLib;

namespace Test
{
    public partial class Form1 : Form
    {
        ColorMap cm;

        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            cm = new ColorMap();
            chart3D1.C3DrawChart.CMap = cm.Cool();
            chart3D1.C3DrawChart.ChartType = DrawChart.ChartTypeEnum.SurfaceFillContour;
            chart3D1.C3ChartStyle.IsColorBar = true;
            chart3D1.C3Labels.Title = "No Title";
            chart3D1.C3DataSeries.LineStyle.IsVisible = false;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            chart3D1.C3Axes.XMin = -3;
            chart3D1.C3Axes.XMax = 3;
            chart3D1.C3Axes.YMin = -3;
            chart3D1.C3Axes.YMax = 3;
            chart3D1.C3Axes.ZMin = -8;
            chart3D1.C3Axes.ZMax = 8;
            chart3D1.C3Axes.XTick = 1;
            chart3D1.C3Axes.YTick = 1;
            chart3D1.C3Axes.ZTick = 4;

            chart3D1.C3DataSeries.XDataMin = chart3D1.C3Axes.XMin;
            chart3D1.C3DataSeries.YDataMin = chart3D1.C3Axes.YMin;
            chart3D1.C3DataSeries.XSpacing = 0.1f;
            chart3D1.C3DataSeries.YSpacing = 0.1f;
            chart3D1.C3DataSeries.XNumber = Convert.ToInt16((chart3D1.C3Axes.XMax - 
                chart3D1.C3Axes.XMin) / chart3D1.C3DataSeries.XSpacing) + 1;
            chart3D1.C3DataSeries.YNumber = Convert.ToInt16((chart3D1.C3Axes.YMax - 
                chart3D1.C3Axes.YMin) / chart3D1.C3DataSeries.YSpacing) + 1;

            Point3[,] pts = new Point3[chart3D1.C3DataSeries.XNumber, 
                chart3D1.C3DataSeries.YNumber];
            for (int i = 0; i < chart3D1.C3DataSeries.XNumber; i++)
            {
                for (int j = 0; j < chart3D1.C3DataSeries.YNumber; j++)
                {
                    float x = chart3D1.C3DataSeries.XDataMin + 
                        i * chart3D1.C3DataSeries.XSpacing;
                    float y = chart3D1.C3DataSeries.YDataMin + 
                        j * chart3D1.C3DataSeries.YSpacing;
                    double zz = 3 * Math.Pow((1 - x), 2) * Math.Exp(-x * x -
                        (y + 1) * (y + 1)) - 10 * (0.2 * x - Math.Pow(x, 3) -
                        Math.Pow(y, 5)) * Math.Exp(-x * x - y * y) -
                        1 / 3 * Math.Exp(-(x + 1) * (x + 1) - y * y);
                    float z = (float)zz;
                    pts[i, j] = new Point3(x, y, z, 1);
                }
            }
            chart3D1.C3DataSeries.PointArray = pts;
        
        }
    }
}