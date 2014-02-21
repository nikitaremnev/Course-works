using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Chart3DLib
{
    public partial class Chart3D : UserControl
    {
        private ChartStyle cs;
        private ChartStyle2D cs2d;
        private DrawChart dc;
        private DataSeries ds;
        private Axes ax;
        private ViewAngle va;
        private Grid gd;
        private ChartLabels cl;
        private ColorMap cm;
      
        public Chart3D()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            cs = new ChartStyle(this);
            cs2d = new ChartStyle2D(this);
            dc = new DrawChart(this);
            ds = new DataSeries();
            ax = new Axes(this);
            va = new ViewAngle(this);
            gd = new Grid(this);
            cl = new ChartLabels(this);
            gd.GridStyle.LineColor = Color.LightGray;
            this.BackColor = Color.White;
            cm = new ColorMap();
            dc.CMap = cm.Jet();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            cs2d.ChartArea = this.ClientRectangle;

            if (dc.ChartType == DrawChart.ChartTypeEnum.XYColor ||
                            dc.ChartType == DrawChart.ChartTypeEnum.Contour ||
                            dc.ChartType == DrawChart.ChartTypeEnum.FillContour)
            {
                cs2d.AddChartStyle2D(g, cs, ax, gd, cl);
                dc.AddColorBar(g, ds, cs, cs2d, ax, va, cl);
                dc.AddChart(g, ds, cs, cs2d, ax, va, cl);
            }
            else
            {
                cs.AddChartStyle(g, ax, va, gd, cl);
                dc.AddChart(g, ds, cs, cs2d, ax, va, cl);
            }
            g.Dispose();
        }

        [BrowsableAttribute(false)]
        public DrawChart C3DrawChart
        {
            get { return this.dc; }
            set { this.dc = value; }
        }

        [BrowsableAttribute(false)]
        public ChartStyle C3ChartStyle
        {
            get { return this.cs; }
            set {
                if (value != null)
                {
                    this.cs = value;
                }
            }
        }

        [BrowsableAttribute(false)]
        public ChartStyle2D C3ChartStyle2D
        {
            get { return this.cs2d; }
            set { this.cs2d = value; }
        }

        [BrowsableAttribute(false)]
        public DataSeries C3DataSeries
        {
            get { return this.ds; }
            set { this.ds = value; }
        }

        [DesignerSerializationVisibility(
        DesignerSerializationVisibility.Content)]
        public Axes C3Axes
        {
            get { return this.ax; }
            set
            {
                if (value != null)
                {
                    this.ax = value;
                }
            }
        }

        [DesignerSerializationVisibility(
        DesignerSerializationVisibility.Content)]
        public ViewAngle C3ViewAngle
        {
            get { return this.va; }
            set
            {
                if (value != null)
                {
                    this.va = value;
                }
            }
        }

        [DesignerSerializationVisibility(
		DesignerSerializationVisibility.Content)]
        public ChartLabels C3Labels
        {
            get { return this.cl; }
            set
            {
                if (value != null)
                {
                    this.cl = value;
                }
            }
        }

        [DesignerSerializationVisibility(
		DesignerSerializationVisibility.Content)]
        public Grid C3Grid
        {
            get { return this.gd; }
            set
            {
                if (value != null)
                {
                    this.gd = value;
                }
            }
        }
    }
}