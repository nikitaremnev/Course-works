using System;
using System.Windows.Forms;
using Библиотека_классов;
using Chart3DLib;

namespace Визуализация
{
    public partial class FunctionGraph : Form
    {
        double minX, maxX, minY, maxY; //поля для заданных границ
        Functions.FunctionVyb Fun; //поле для функции
        Point3[,] pts = new Point3[20, 20]; //задание матрицы точек с тремя координатами для построения графика
        //конструктор формы
        public FunctionGraph(Functions.FunctionVyb Fun, double minX, double maxX, double minY, double maxY)
        {
            InitializeComponent();
            FunctionGraphik.C3DrawChart.ChartType = DrawChart.ChartTypeEnum.SurfaceFillContour; //определяем вид графика - контурный и объемный
            Azimuth.Text = PovorotAzimuth.Value.ToString(); //для поворота по горизонтали выводим в соответсвующую метку
            Elevation.Text = PovorotElevation.Value.ToString(); //для поворота по вертикали выводим в соответсвующую метку
            this.Fun = Fun; //присваиваем функцию переданную в конструктор полю
            if (minX == maxX) //присваиваем границы переданные - полям, если границы одинаковые - расширяем, чтобы график не выродился в точку
            {
                this.minX = minX-1;
                this.maxX = maxX+1;
            }
            else
            {
                this.minX = minX;
                this.maxX = maxX;
            }
            if (minY == maxY)
            {
                this.minY = minY-1;
                this.maxY = maxY+1;
            }
            else
            {
                this.minY = minY;
                this.maxY = maxY;
            }
            AddData(); //вызываем метод для построения
        }
        //метод для построения графика
        private void AddData()
        {
            FunctionGraphik.C3Axes.XMin = (float)minX; //задаем границы для графика
            FunctionGraphik.C3Axes.XMax = (float)maxX;
            FunctionGraphik.C3Axes.YMin = (float)minY;
            FunctionGraphik.C3Axes.YMax = (float)maxY;
            FunctionGraphik.C3Labels.XLabel = "Х"; //именуем оси графика
            FunctionGraphik.C3Labels.YLabel = "Y";
            FunctionGraphik.C3Labels.ZLabel = "Z";
            FunctionGraphik.C3Labels.Title = "График функции"; //заголовок для графика
            FunctionGraphik.C3Axes.XTick = (float)((FunctionGraphik.C3Axes.XMax - FunctionGraphik.C3Axes.XMin) / 4); //для осей задаем количество меток
            FunctionGraphik.C3Axes.YTick = (float)((FunctionGraphik.C3Axes.YMax - FunctionGraphik.C3Axes.YMin) / 4);
            FunctionGraphik.C3DataSeries.XDataMin = FunctionGraphik.C3Axes.XMin; //задаем минимальные границы, чтобы график при повороте не ускакивал
            FunctionGraphik.C3DataSeries.YDataMin = FunctionGraphik.C3Axes.YMin;
            FunctionGraphik.C3DataSeries.XSpacing = (float)((FunctionGraphik.C3Axes.XMax - FunctionGraphik.C3Axes.XMin) / 20); //шаг, с которым мы увеличиваем координаты
            FunctionGraphik.C3DataSeries.YSpacing = (float)((FunctionGraphik.C3Axes.YMax - FunctionGraphik.C3Axes.YMin) / 20);
            float min = (float)Fun(FunctionGraphik.C3Axes.XMin, FunctionGraphik.C3Axes.YMin); //для поиска минимума/максимума для координаты Z
            float max = (float)Fun(FunctionGraphik.C3Axes.XMin, FunctionGraphik.C3Axes.YMin);
            for (int i = 0; i < 20; i++)
            { //задаем матрицу
                float x = FunctionGraphik.C3DataSeries.XDataMin + i * FunctionGraphik.C3DataSeries.XSpacing; //изменяем координату по Х
                for (int j = 0; j < 20; j++)
                {
                    float y = FunctionGraphik.C3DataSeries.YDataMin + j * FunctionGraphik.C3DataSeries.YSpacing; //изменяем координату по Y
                    float z = (float)Fun(x, y); //задаем координату Z
                    pts[i, j] = new Point3(x, y, z, 1); //добавляем точку в матрицу
                    if (min > z) min = z; //ищем минимум
                    if (max < z) max = z; //ищем максимум
                }
            }
            FunctionGraphik.C3Axes.ZMin = (float)min; //задаем границы оси Z
            FunctionGraphik.C3Axes.ZMax = (float)max;
            FunctionGraphik.C3Axes.ZTick = (float)((max - min) / 4); //для осей задаем количество меток
            FunctionGraphik.C3ViewAngle.Elevation = PovorotElevation.Value; //задаем поворот графика
            FunctionGraphik.C3ViewAngle.Azimuth = PovorotAzimuth.Value; //задаем поворот графика
            FunctionGraphik.C3DataSeries.PointArray = pts; //"даем" графику матрицу точек
        }
        //для вертикального поворота
        private void PovorotElevation_Scroll(object sender, EventArgs e)
        {
            Elevation.Text = PovorotElevation.Value.ToString();
            AddData();
        }
        //для горизонтального поворота
        private void PovorotAzimuth_Scroll(object sender, EventArgs e)
        {
            Azimuth.Text = PovorotAzimuth.Value.ToString();
            AddData();
        }
        //перестраиваем график при увеличении размера формы
        private void FunctionGraphik_Resize(object sender, EventArgs e)
        {
            AddData();
        }        
    }
}
