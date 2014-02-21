using System;
using System.Windows.Forms;
using Библиотека_классов;
using System.Drawing;
using System.IO;
using ZedGraph;
namespace Визуализация
{
    public partial class Graphiks : Form
    {
        int Kol; //ряд полей класса, используемых для нескольких методов
        double MaxX, MinX, MaxY, MinY; //границы интервалов
        bool Max = false; //значения показывающие максимум или минимум
        bool Min = false;
        double[,] newpop; //популяция
        int KolIterations = 0; //количество итераций
        double[,] lastmassiv; //популяция предыдущей итерации
        bool flag = false; //флаг для проверки нажатия на кнопку предыдущая итерация
        double[] Isk = new double[2]; //массивы для максимума и минимума
        double[] Isk2 = new double[2];
        Functions.FunctionVyb Fun; //действующая функция
        GraphPane graph; //экземпляр графика
        PointPairList list = new PointPairList(); //лист точек
        FunctionGraph newForm;
        //построение осей
        public void Postroenye()
        {
            graph = zedGraph.GraphPane; //связываем с элементом на форме
            graph.Title.IsVisible = false; //прячем заголовок
            Setka(); //делаем сетку
            Points(newpop); //выводим точки
            ZnakVyvod(newpop); //выводим максимум минимум
            graph.XAxis.Title.IsVisible = false; //прячем названия осей
            graph.YAxis.Title.IsVisible = false;
            if (MinX == MaxX) //если равные координаты
            {
                graph.XAxis.Scale.Min = MinX-0.5;
                graph.XAxis.Scale.Max = MaxX+0.5;
            }
            else
            {//если неравные координаты
                graph.XAxis.Scale.Min = MinX;
                graph.XAxis.Scale.Max = MaxX;
            }
            if (MinY == MaxY)
            {//если равные координаты
                graph.YAxis.Scale.Min = MinY - 0.5;
                graph.YAxis.Scale.Max = MaxY + 0.5;
            }
            else
            {//если неравные координаты
                graph.YAxis.Scale.Min = MinY;
                graph.YAxis.Scale.Max = MaxY;
            }
            graph.XAxis.Cross = 0.0; //делаем оси пересекающимися в (0,0)
            graph.YAxis.Cross = 0.0;
            zedGraph.AxisChange(); //обновление графика и перерисовка его
            zedGraph.Invalidate();
        }
        //построение сетки для графика
        public void Setka()
        {
            // включаем отображение сетки напротив крупных рисок по оси X
            graph.XAxis.MajorGrid.IsVisible = true;
            // задаем вид пунктирной линии для крупных рисок по оси X
            graph.XAxis.MajorGrid.DashOn = 10; // длина штрихов равна 10 пикселям
            graph.XAxis.MajorGrid.DashOff = 5; //5 пикселей - пропуск
            // включаем отображение сетки напротив крупных рисок по оси Y
            graph.YAxis.MajorGrid.IsVisible = true;
            // аналогично задаем вид пунктирной линии для крупных рисок по оси Y
            graph.YAxis.MajorGrid.DashOn = 10;
            graph.YAxis.MajorGrid.DashOff = 5;
            // включаем отображение сетки напротив мелких рисок по оси X
            graph.YAxis.MinorGrid.IsVisible = true;
            // задаем вид пунктирной линии для крупных рисок по оси Y 
            graph.YAxis.MinorGrid.DashOn = 1; // длина штрихов равна одному пикселю
            graph.YAxis.MinorGrid.DashOff = 2; // затем 2 пикселя - пропуск
            // включаем отображение сетки напротив мелких рисок по оси Y
            graph.XAxis.MinorGrid.IsVisible = true;
            // аналогично задаем вид пунктирной линии для крупных рисок по оси Y
            graph.XAxis.MinorGrid.DashOn = 1;
            graph.XAxis.MinorGrid.DashOff = 2;
        }
        //метод для вывода точек
        public void Points(double[,] massiv)
        {
            graph.CurveList.Clear(); //очищаем предыдущие точки
            list.Clear(); //очищаем лист
            if (Max)
            { //если ищем максимум
                Isk = OptimizationAlgorithms.Maximum(massiv, Fun);
                Isk2 = OptimizationAlgorithms.Minimum(massiv, Fun);
                PointPairList list1 = new PointPairList();
                list1.Add(Isk[0], Isk[1]); //добавляем точки максимума-минимума в отдельные листы
                PointPairList list2 = new PointPairList();
                list2.Add(Isk2[0], Isk2[1]);
                LineItem myCurve1 = graph.AddCurve("", list1, Color.Red, SymbolType.Circle); //добавляем точку максимума
                myCurve1.Label.IsVisible = false; //прячем название у точек
                myCurve1.Symbol.Fill.Type = FillType.Solid; //определяем заливку точек
                myCurve1.Symbol.Size = 7; //определяем размер точек
                LineItem myCurve2 = graph.AddCurve("", list2, Color.Yellow, SymbolType.Circle); //добавляем точку минимума
                myCurve2.Label.IsVisible = false; //прячем название у точек
                myCurve2.Symbol.Fill.Type = FillType.Solid; //определяем заливку точек
                myCurve2.Symbol.Size = 7; //определяем размер точек
            }
            if (Min)
            { //если ищем минимум
                Isk2 = OptimizationAlgorithms.Maximum(massiv, Fun);
                Isk = OptimizationAlgorithms.Minimum(massiv, Fun);
                PointPairList list1 = new PointPairList();
                list1.Add(Isk[0], Isk[1]); //добавляем точки максимума-минимума в отдельные листы
                PointPairList list2 = new PointPairList();
                list2.Add(Isk2[0], Isk2[1]);
                LineItem myCurve1 = graph.AddCurve("", list1, Color.Red, SymbolType.Circle); //добавляем точку минимума
                myCurve1.Label.IsVisible = false; //прячем название у точек
                myCurve1.Symbol.Fill.Type = FillType.Solid; //определяем заливку точек
                myCurve1.Symbol.Size = 7; //определяем размер точек
                LineItem myCurve2 = graph.AddCurve("", list2, Color.Yellow, SymbolType.Circle); //добавляем точку максимума
                myCurve2.Label.IsVisible = false; //прячем название у точек
                myCurve2.Symbol.Fill.Type = FillType.Solid; //определяем заливку точек
                myCurve2.Symbol.Size = 7; //определяем размер точек
            }
            for (int i = 0; i < massiv.GetLength(0); i++)
            {
                double x = massiv[i, 0];
                double y = massiv[i, 1];
                list.Add(x, y); //формируем лист из точек
            }
            LineItem myCurve = graph.AddCurve("",list, Color.Green, SymbolType.Circle); //добавляем лист точек как линию
            myCurve.Label.IsVisible = false; //прячем название у точек
            myCurve.Line.IsVisible = false; //прячем линию, оставляем только точки
            myCurve.Symbol.Fill.Type = FillType.Solid; //определяем заливку точек
            myCurve.Symbol.Size = 7; //определяем размер точек
            zedGraph.AxisChange(); //обновление графика и перерисовка его
            zedGraph.Invalidate();
        }
        //метод вывода результата, когда итерации закончились
        public void ResultVyvod()  
        {
            if (Max) 
            {//если ищем максимум
                Isk = OptimizationAlgorithms.Maximum(newpop, Fun);
                string s = String.Format(@"Максимум функции:
  Координата Х: {0}
  Координата Y: {1}", Isk[0], Isk[1]); //формируем строку
                MessageBox.Show(s, "Выполнено", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            if (Min)
            {//если ищем минимум
                Isk = OptimizationAlgorithms.Minimum(newpop, Fun);
                string s = String.Format(@"Минимум функции:
  Координата Х: {0}
  Координата Y: {1}", Isk[0], Isk[1]); //формируем строку
                MessageBox.Show(s, "Выполнено", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        //метод для вывода максимума/минимума предыдущей итерации
        //аналогичен нижнему методу, только без улучшений
        public void ZnakVyvod(double[,] massiv)
        {
            if (Max)
            {
                Isk = OptimizationAlgorithms.Maximum(massiv, Fun);
                Isk2 = OptimizationAlgorithms.Minimum(massiv, Fun);
                switch ((int)KolZnakov.Value)
                {//в зависимости от количества знаков заполняем информацию об агентах
                    case 0:
                        BestX.Text = String.Format("Координата Х: {0:f0}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f0}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f0}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f0}", Isk2[1]);
                        break;
                    case 1:
                        BestX.Text = String.Format("Координата Х: {0:f1}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f1}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f1}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f1}", Isk2[1]);
                        break;
                    case 2:
                        BestX.Text = String.Format("Координата Х: {0:f2}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f2}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f2}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f2}", Isk2[1]);
                        break;
                    case 3:
                        BestX.Text = String.Format("Координата Х: {0:f3}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f3}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f3}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f3}", Isk2[1]);
                        break;
                    case 4:
                        BestX.Text = String.Format("Координата Х: {0:f4}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f4}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f4}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f4}", Isk2[1]);
                        break;
                    case 5:
                        BestX.Text = String.Format("Координата Х: {0:f5}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f5}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f5}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f5}", Isk2[1]);
                        break;
                    case 6:
                        BestX.Text = String.Format("Координата Х: {0:f6}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f6}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f6}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f6}", Isk2[1]);
                        break;
                    case 7:
                        BestX.Text = String.Format("Координата Х: {0:f7}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f7}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f7}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f7}", Isk2[1]);
                        break;
                    case 8:
                        BestX.Text = String.Format("Координата Х: {0:f8}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f8}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f8}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f8}", Isk2[1]);
                        break;
                    case 9:
                        BestX.Text = String.Format("Координата Х: {0:f9}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f9}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f9}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f9}", Isk2[1]);
                        break;
                    case 10:
                        BestX.Text = String.Format("Координата Х: {0:f10}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f10}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f10}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f10}", Isk2[1]);
                        break;
                    case 11:
                        BestX.Text = String.Format("Координата Х: {0:f11}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f11}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f11}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f11}", Isk2[1]);
                        break;
                    case 12:
                        BestX.Text = String.Format("Координата Х: {0:f12}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f12}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f12}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f12}", Isk2[1]);
                        break;
                    case 13:
                        BestX.Text = String.Format("Координата Х: {0:f13}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f13}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f13}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f13}", Isk2[1]);
                        break;
                    case 14:
                        BestX.Text = String.Format("Координата Х: {0:f14}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f14}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f14}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f14}", Isk2[1]);
                        break;
                    case 15:
                        BestX.Text = String.Format("Координата Х: {0:f15}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f15}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f15}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f15}", Isk2[1]);
                        break;
                }
            }
            if (Min)
            {
                Isk = OptimizationAlgorithms.Minimum(massiv, Fun);
                Isk2 = OptimizationAlgorithms.Maximum(massiv, Fun);
                switch ((int)KolZnakov.Value)
                {//в зависимости от количества знаков заполняем информацию об агентах
                    case 0:
                        BestX.Text = String.Format("Координата Х: {0:f0}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f0}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f0}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f0}", Isk2[1]);
                        break;
                    case 1:
                        BestX.Text = String.Format("Координата Х: {0:f1}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f1}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f1}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f1}", Isk2[1]);
                        break;
                    case 2:
                        BestX.Text = String.Format("Координата Х: {0:f2}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f2}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f2}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f2}", Isk2[1]);
                        break;
                    case 3:
                        BestX.Text = String.Format("Координата Х: {0:f3}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f3}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f3}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f3}", Isk2[1]);
                        break;
                    case 4:
                        BestX.Text = String.Format("Координата Х: {0:f4}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f4}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f4}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f4}", Isk2[1]);
                        break;
                    case 5:
                        BestX.Text = String.Format("Координата Х: {0:f5}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f5}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f5}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f5}", Isk2[1]);
                        break;
                    case 6:
                        BestX.Text = String.Format("Координата Х: {0:f6}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f6}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f6}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f6}", Isk2[1]);
                        break;
                    case 7:
                        BestX.Text = String.Format("Координата Х: {0:f7}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f7}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f7}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f7}", Isk2[1]);
                        break;
                    case 8:
                        BestX.Text = String.Format("Координата Х: {0:f8}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f8}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f8}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f8}", Isk2[1]);
                        break;
                    case 9:
                        BestX.Text = String.Format("Координата Х: {0:f9}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f9}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f9}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f9}", Isk2[1]);
                        break;
                    case 10:
                        BestX.Text = String.Format("Координата Х: {0:f10}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f10}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f10}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f10}", Isk2[1]);
                        break;
                    case 11:
                        BestX.Text = String.Format("Координата Х: {0:f11}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f11}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f11}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f11}", Isk2[1]);
                        break;
                    case 12:
                        BestX.Text = String.Format("Координата Х: {0:f12}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f12}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f12}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f12}", Isk2[1]);
                        break;
                    case 13:
                        BestX.Text = String.Format("Координата Х: {0:f13}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f13}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f13}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f13}", Isk2[1]);
                        break;
                    case 14:
                        BestX.Text = String.Format("Координата Х: {0:f14}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f14}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f14}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f14}", Isk2[1]);
                        break;
                    case 15:
                        BestX.Text = String.Format("Координата Х: {0:f15}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f15}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f15}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f15}", Isk2[1]);
                        break;
                }
            }
        }
        //метод для вывода максимума/минимума и улучшения
        public void ZnakVyvodNextIt()
        {
            if (Max)
            {//улучшение и ищем максимум-минимум
                OptimizationAlgorithms.PopulationGoodModernization(newpop, MinX, MaxX, MinY, MaxY, newpop.GetLength(0), OptimizationAlgorithms.MemeplexNumber(newpop.GetLength(0)), Fun);
                Isk = OptimizationAlgorithms.Maximum(newpop, Fun);
                Isk2 = OptimizationAlgorithms.Minimum(newpop, Fun);
                switch ((int)KolZnakov.Value)
                { //в зависимости от количества знаков заполняем информацию об агентах
                    case 0:
                        BestX.Text = String.Format("Координата Х: {0:f0}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f0}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f0}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f0}", Isk2[1]);
                        break;
                    case 1:
                        BestX.Text = String.Format("Координата Х: {0:f1}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f1}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f1}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f1}", Isk2[1]);
                        break;
                    case 2:
                        BestX.Text = String.Format("Координата Х: {0:f2}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f2}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f2}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f2}", Isk2[1]);
                        break;
                    case 3:
                        BestX.Text = String.Format("Координата Х: {0:f3}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f3}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f3}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f3}", Isk2[1]);
                        break;
                    case 4:
                        BestX.Text = String.Format("Координата Х: {0:f4}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f4}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f4}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f4}", Isk2[1]);
                        break;
                    case 5:
                        BestX.Text = String.Format("Координата Х: {0:f5}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f5}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f5}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f5}", Isk2[1]);
                        break;
                    case 6:
                        BestX.Text = String.Format("Координата Х: {0:f6}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f6}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f6}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f6}", Isk2[1]);
                        break;
                    case 7:
                        BestX.Text = String.Format("Координата Х: {0:f7}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f7}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f7}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f7}", Isk2[1]);
                        break;
                    case 8:
                        BestX.Text = String.Format("Координата Х: {0:f8}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f8}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f8}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f8}", Isk2[1]);
                        break;
                    case 9:
                        BestX.Text = String.Format("Координата Х: {0:f9}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f9}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f9}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f9}", Isk2[1]);
                        break;
                    case 10:
                        BestX.Text = String.Format("Координата Х: {0:f10}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f10}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f10}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f10}", Isk2[1]);
                        break;
                    case 11:
                        BestX.Text = String.Format("Координата Х: {0:f11}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f11}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f11}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f11}", Isk2[1]);
                        break;
                    case 12:
                        BestX.Text = String.Format("Координата Х: {0:f12}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f12}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f12}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f12}", Isk2[1]);
                        break;
                    case 13:
                        BestX.Text = String.Format("Координата Х: {0:f13}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f13}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f13}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f13}", Isk2[1]);
                        break;
                    case 14:
                        BestX.Text = String.Format("Координата Х: {0:f14}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f14}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f14}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f14}", Isk2[1]);
                        break;
                    case 15:
                        BestX.Text = String.Format("Координата Х: {0:f15}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f15}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f15}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f15}", Isk2[1]);
                        break;
                }
            }
            if (Min)
            {//улучшение и ищем максимум-минимум
                OptimizationAlgorithms.PopulationBadModernization(newpop, MinX, MaxX, MinY, MaxY, newpop.GetLength(0), OptimizationAlgorithms.MemeplexNumber(newpop.GetLength(0)), Fun);
                Isk2 = OptimizationAlgorithms.Maximum(newpop, Fun);
                Isk = OptimizationAlgorithms.Minimum(newpop, Fun);
                switch ((int)KolZnakov.Value)
                {
                    case 0:
                        BestX.Text = String.Format("Координата Х: {0:f0}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f0}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f0}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f0}", Isk2[1]);
                        break;
                    case 1:
                        BestX.Text = String.Format("Координата Х: {0:f1}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f1}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f1}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f1}", Isk2[1]);
                        break;
                    case 2:
                        BestX.Text = String.Format("Координата Х: {0:f2}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f2}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f2}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f2}", Isk2[1]);
                        break;
                    case 3:
                        BestX.Text = String.Format("Координата Х: {0:f3}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f3}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f3}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f3}", Isk2[1]);
                        break;
                    case 4:
                        BestX.Text = String.Format("Координата Х: {0:f4}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f4}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f4}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f4}", Isk2[1]);
                        break;
                    case 5:
                        BestX.Text = String.Format("Координата Х: {0:f5}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f5}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f5}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f5}", Isk2[1]);
                        break;
                    case 6:
                        BestX.Text = String.Format("Координата Х: {0:f6}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f6}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f6}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f6}", Isk2[1]);
                        break;
                    case 7:
                        BestX.Text = String.Format("Координата Х: {0:f7}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f7}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f7}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f7}", Isk2[1]);
                        break;
                    case 8:
                        BestX.Text = String.Format("Координата Х: {0:f8}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f8}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f8}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f8}", Isk2[1]);
                        break;
                    case 9:
                        BestX.Text = String.Format("Координата Х: {0:f9}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f9}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f9}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f9}", Isk2[1]);
                        break;
                    case 10:
                        BestX.Text = String.Format("Координата Х: {0:f10}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f10}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f10}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f10}", Isk2[1]);
                        break;
                    case 11:
                        BestX.Text = String.Format("Координата Х: {0:f11}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f11}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f11}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f11}", Isk2[1]);
                        break;
                    case 12:
                        BestX.Text = String.Format("Координата Х: {0:f12}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f12}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f12}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f12}", Isk2[1]);
                        break;
                    case 13:
                        BestX.Text = String.Format("Координата Х: {0:f13}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f13}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f13}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f13}", Isk2[1]);
                        break;
                    case 14:
                        BestX.Text = String.Format("Координата Х: {0:f14}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f14}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f14}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f14}", Isk2[1]);
                        break;
                    case 15:
                        BestX.Text = String.Format("Координата Х: {0:f15}", Isk[0]);
                        BestY.Text = String.Format("Координата Y: {0:f15}", Isk[1]);
                        WorstX.Text = String.Format("Координата Х: {0:f15}", Isk2[0]);
                        WorstY.Text = String.Format("Координата Y: {0:f15}", Isk2[1]);
                        break;
                }
            }
        }
        //метод копирования массива
        public void CopyLastMassiv()
        {
            for (int i = 0; i < newpop.GetLength(0); i++)
            {
                lastmassiv[i, 0] = newpop[i, 0];
                lastmassiv[i, 1] = newpop[i, 1];
            }
        }
        //конструктор формы
        public Graphiks(int KolIt, double MiX, double MaX, double MiY, double MaY, bool MaxF, bool MinF, Functions.FunctionVyb x)
        {
            Kol = KolIt;//присваиваем переданные значения из другой формы
            MaxX = MaX;
            MinX = MiX;
            MaxY = MaY;
            MinY = MiY;
            Max = MaxF;
            Min = MinF;
            Fun = x;
            InitializeComponent();
            Timer.Interval = 1000; //интервал для таймера
            lastiteration.Enabled = false; //начальные параметры доступа некоторых объектов
            Stop_button.Enabled = false;
            newpop = OptimizationAlgorithms.NewPopulation(MinX, MaxX, MinY, MaxY); //формируем новую популяцию
            lastmassiv = new double[newpop.GetLength(0), 2]; //инициализируем массив для предыдущей итерации
            Postroenye(); //строим график без точек
            zedGraph.IsShowPointValues = true;// включаем показ всплывающих подсказок при наведении курсора на график
            // для изменения формата представления координат обрабатываем событие для графика
            zedGraph.PointValueEvent += new ZedGraphControl.PointValueHandler(zedGraph_PointValueEvent);
            GraphSupport.SetToolTip(zedGraph, "Красным цветом обозначается лучший агент, желтым - худший агент, зеленым - остальные агенты"); //подсказка для графика
        }
        //нажатие на запуск автовыполнения итераций
        private void VypolnitAuto_Click(object sender, EventArgs e)
        {
            Timer.Start(); //запускаем таймер
            VypolnitAuto.Enabled = false; //меняем доступность кнопок
            Stop_button.Enabled = true;
            lastiteration.Enabled = true;
        }
        //нажатие на кнопку следующей итерации
        private void nextiteration_Click(object sender, EventArgs e)
        {
            if (!flag) //случай, если до этого не была нажата кнопка предыдущая итерация
            {
                lastiteration.Enabled = true;
                CopyLastMassiv(); //копируем предыдущий массив
                ZnakVyvodNextIt(); //производим улучшения
                newpop = OptimizationAlgorithms.PopulationShuffle(newpop); //тасуем популяцию
                Points(newpop); //выводим точки
                KolIterations++; //наращиваем количество итераций
                IterNow.Text = KolIterations.ToString();
                if (KolIterations == Kol) //если все итерации выполнены
                {
                    Timer.Stop(); //останавливаем таймер
                    ResultVyvod(); //выводим результат
                    KolIterations = 0; //обнуляем количество итераций
                    nextiteration.Enabled = false; //меняем доступность кнопок
                    Stop_button.Enabled = false;
                    VypolnitAuto.Enabled = false;
                }
            }
            else
            { //случай, если до этого была нажата кнопка предыдущая итерация
                lastiteration.Enabled = true;
                ZnakVyvod(newpop); //все аналогично предыдущему случаю без улучшений
                Points(newpop);
                KolIterations++;
                IterNow.Text = KolIterations.ToString();
                if (KolIterations == Kol)
                {
                    Timer.Stop();
                    ResultVyvod();
                    KolIterations = 0;
                    nextiteration.Enabled = false; //меняем доступность кнопок
                    Stop_button.Enabled = false;
                    VypolnitAuto.Enabled = false;
                }
                flag = false;
            }
        }
        //событие, когда закончился круг в таймере
        private void Timer_Tick(object sender, EventArgs e)
        {
            nextiteration.PerformClick(); //симулируем нажатие на следующую итерацию
            IterNow.Text = KolIterations.ToString();
            if (KolIterations == Kol)
            {
                Timer.Stop(); //останавливаем таймер
                ResultVyvod(); //выводим результат
                KolIterations = 0;
                nextiteration.Enabled = false; //меняем доступность кнопок
                Stop_button.Enabled = false;
            }
        }
        //нажатие на остановку автозапуска
        private void Stop_button_Click(object sender, EventArgs e)
        {
            Timer.Stop(); //останавливаем таймер
            VypolnitAuto.Enabled = true; //меняем доступность кнопок
            Stop_button.Enabled = false;
        }
        //изменение временного интервала автозапуска
        private void TimeTrackBar_Scroll(object sender, EventArgs e)
        {
            Timer.Interval = 1000 * TimeTrackBar.Value; //меняем интервал таймера
        }
        //нажатие на кнопку предыдущая операция
        private void lastiteration_Click(object sender, EventArgs e)
        {
            flag = true;
            nextiteration.Enabled = true; //меняем доступность кнопок
            lastiteration.Enabled = false;
            if (KolIterations != 0) //на случай если была выполнена последняя итерация
                KolIterations--;
            else
                KolIterations = Kol - 1;
            IterNow.Text = KolIterations.ToString();
            ZnakVyvod(lastmassiv); //выводим максимум/минимум 
            Points(lastmassiv); //строим точки предыдущей итерации
        }
        //нажатие на кнопку "действующая популяция" - открытие новой формы
        private void Population_Click(object sender, EventArgs e)
        {
            PopulationShow newForm = new PopulationShow(KolIterations, newpop,Fun);
            newForm.ShowDialog();
        }
        //изменение количества знаков
        private void KolZnakov_ValueChanged(object sender, EventArgs e)
        {
            ZnakVyvod(newpop);
        }
        //нажатие на кнопку формирование новой популяции
        private void NewPopulation_Click(object sender, EventArgs e)
        {
            lastiteration.Enabled = false; //начальные параметры доступа некоторых объектов
            Stop_button.Enabled = false;
            VypolnitAuto.Enabled = true;
            nextiteration.Enabled = true;
            Population.Enabled = true;
            KolZnakov.Enabled = true;
            newpop = OptimizationAlgorithms.NewPopulation(MinX, MaxX, MinY, MaxY); //формируем новую популяцию
            lastmassiv = new double[newpop.GetLength(0), 2]; //инициализируем массив для предыдущей итерации
            Postroenye(); //строим график без точек
            KolIterations = 0; //обнуляем количество итераций
            IterNow.Text = KolIterations.ToString(); //выводим на форму
        }
        //событие наведение курсора на точку
        private string zedGraph_PointValueEvent(ZedGraphControl sender, GraphPane graph, CurveItem curve, int ind)
        {
            PointPair point = curve[ind]; //получаем точку по индексу
            string result = string.Format(@"Координата X: {0}
Координата Y: {1}", point.X, point.Y); //формирование строки
            return result;
        }
        //нажатие на кнопку график функции
        private void GraphFunOpen_Click(object sender, EventArgs e)
        {
            newForm = new FunctionGraph(Fun, MinX, MaxX, MinY, MaxY);
            newForm.Show(); //показываем форму
        }
    }
}