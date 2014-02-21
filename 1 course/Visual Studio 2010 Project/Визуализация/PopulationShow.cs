using System;
using System.Windows.Forms;
using Библиотека_классов;
namespace Визуализация
{
    public partial class PopulationShow : Form
    {
        double[,] newpop; //переменные для возможности использовать вне конструктора
        Functions.FunctionVyb Fun;
        public PopulationShow(int Kol, double[,] newpop, Functions.FunctionVyb Fun)
        {//конструктор формы
            InitializeComponent();
            this.newpop = newpop;
            this.Fun = Fun; //присваивание внешним переменным
            Iteration.Text = Kol.ToString(); //задание количества итераций
            Population.RowCount = newpop.GetLength(0);
            Population.ColumnCount = 3;
            Population.Columns[0].HeaderText = "Координата Х"; //именуем столбцы
            Population.Columns[1].HeaderText = "Координата Y";
            Population.Columns[2].HeaderText = "Значение функции";
            for (int i = 0; i < newpop.GetLength(0); i++)
            { //заполняем таблицу
                switch ((int)KolZnakov.Value)
                { //в зависимости от выбранного количества знаков, заполняем таблицу
                    case 0:
                        Population[0, i].Value = string.Format("{0:f0}",newpop[i, 0]);
                        Population[1, i].Value = string.Format("{0:f0}", newpop[i, 1]);
                        Population[2, i].Value = string.Format("{0:f0}",Fun(newpop[i, 0], newpop[i, 1]));
                        Population.Rows[i].HeaderCell.Value = String.Format("{0}", i + 1);
                        break;
                    case 1:
                        Population[0, i].Value = string.Format("{0:f1}",newpop[i, 0]);
                        Population[1, i].Value = string.Format("{0:f1}", newpop[i, 1]);
                        Population[2, i].Value = string.Format("{0:f1}", Fun(newpop[i, 0], newpop[i, 1]));
                        Population.Rows[i].HeaderCell.Value = String.Format("{0}", i + 1);
                        break;
                    case 2:
                        Population[0, i].Value = string.Format("{0:f2}",newpop[i, 0]);
                        Population[1, i].Value = string.Format("{0:f2}", newpop[i, 1]);
                        Population[2, i].Value = string.Format("{0:f2}", Fun(newpop[i, 0], newpop[i, 1]));
                        Population.Rows[i].HeaderCell.Value = String.Format("{0}", i + 1);
                        break;
                    case 3:
                        Population[0, i].Value = string.Format("{0:f3}",newpop[i, 0]);
                        Population[1, i].Value = string.Format("{0:f3}", newpop[i, 1]);
                        Population[2, i].Value = string.Format("{0:f3}", Fun(newpop[i, 0], newpop[i, 1]));
                        Population.Rows[i].HeaderCell.Value = String.Format("{0}", i + 1);
                        break;
                    case 4:
                        Population[0, i].Value = string.Format("{0:f4}",newpop[i, 0]);
                        Population[1, i].Value = string.Format("{0:f4}", newpop[i, 1]);
                        Population[2, i].Value = string.Format("{0:f4}", Fun(newpop[i, 0], newpop[i, 1]));
                        Population.Rows[i].HeaderCell.Value = String.Format("{0}", i + 1);
                        break;
                    case 5:
                        Population[0, i].Value = string.Format("{0:f5}",newpop[i, 0]);
                        Population[1, i].Value = string.Format("{0:f5}", newpop[i, 1]);
                        Population[2, i].Value = string.Format("{0:f5}",Fun(newpop[i, 0], newpop[i, 1]));
                        Population.Rows[i].HeaderCell.Value = String.Format("{0}", i + 1);
                        break;
                    case 6:
                        Population[0, i].Value = string.Format("{0:f6}",newpop[i, 0]);
                        Population[1, i].Value = string.Format("{0:f6}", newpop[i, 1]);
                        Population[2, i].Value = string.Format("{0:f6}",Fun(newpop[i, 0], newpop[i, 1]));
                        Population.Rows[i].HeaderCell.Value = String.Format("{0}", i + 1);
                        break;
                    case 7:
                        Population[0, i].Value = string.Format("{0:f7}",newpop[i, 0]);
                        Population[1, i].Value = string.Format("{0:f7}", newpop[i, 1]);
                        Population[2, i].Value = string.Format("{0:f7}",Fun(newpop[i, 0], newpop[i, 1]));
                        Population.Rows[i].HeaderCell.Value = String.Format("{0}", i + 1);
                        break;
                    case 8:
                        Population[0, i].Value = string.Format("{0:f8}",newpop[i, 0]);
                        Population[1, i].Value = string.Format("{0:f8}", newpop[i, 1]);
                        Population[2, i].Value = string.Format("{0:f8}", Fun(newpop[i, 0], newpop[i, 1]));
                        Population.Rows[i].HeaderCell.Value = String.Format("{0}", i + 1);
                        break;
                    case 9:
                        Population[0, i].Value = string.Format("{0:f9}",newpop[i, 0]);
                        Population[1, i].Value = string.Format("{0:f9}", newpop[i, 1]);
                        Population[2, i].Value = string.Format("{0:f9}", Fun(newpop[i, 0], newpop[i, 1]));
                        Population.Rows[i].HeaderCell.Value = String.Format("{0}", i + 1);
                        break;
                    case 10:
                        Population[0, i].Value = string.Format("{0:f10}",newpop[i, 0]);
                        Population[1, i].Value = string.Format("{0:f10}", newpop[i, 1]);
                        Population[2, i].Value = string.Format("{0:f10}", Fun(newpop[i, 0], newpop[i, 1]));
                        Population.Rows[i].HeaderCell.Value = String.Format("{0}", i + 1);
                        break;
                    case 11:
                        Population[0, i].Value = string.Format("{0:f11}",newpop[i, 0]);
                        Population[1, i].Value = string.Format("{0:f11}", newpop[i, 1]);
                        Population[2, i].Value = string.Format("{0:f11}", Fun(newpop[i, 0], newpop[i, 1]));
                        Population.Rows[i].HeaderCell.Value = String.Format("{0}", i + 1);
                        break;
                    case 12:
                        Population[0, i].Value = string.Format("{0:f12}",newpop[i, 0]);
                        Population[1, i].Value = string.Format("{0:f12}", newpop[i, 1]);
                        Population[2, i].Value = string.Format("{0:f12}", Fun(newpop[i, 0], newpop[i, 1]));
                        Population.Rows[i].HeaderCell.Value = String.Format("{0}", i + 1);
                        break;
                    case 13:
                        Population[0, i].Value = string.Format("{0:f13}",newpop[i, 0]);
                        Population[1, i].Value = string.Format("{0:f13}", newpop[i, 1]);
                        Population[2, i].Value = string.Format("{0:f13}", Fun(newpop[i, 0], newpop[i, 1]));
                        Population.Rows[i].HeaderCell.Value = String.Format("{0}", i + 1);
                        break;
                    case 14:
                        Population[0, i].Value = string.Format("{0:f14}",newpop[i, 0]);
                        Population[1, i].Value = string.Format("{0:f14}", newpop[i, 1]);
                        Population[2, i].Value = string.Format("{0:f14}", Fun(newpop[i, 0], newpop[i, 1]));
                        Population.Rows[i].HeaderCell.Value = String.Format("{0}", i + 1);
                        break;
                    case 15:
                        Population[0, i].Value = string.Format("{0:f15}",newpop[i, 0]);
                        Population[1, i].Value = string.Format("{0:f15}", newpop[i, 1]);
                        Population[2, i].Value = string.Format("{0:f15}", Fun(newpop[i, 0], newpop[i, 1]));
                        Population.Rows[i].HeaderCell.Value = String.Format("{0}", i + 1);
                        break;
                }
            }
        }
        private void KolZnakov_ValueChanged(object sender, EventArgs e)
        { //производим изменения, при изменении количества знаков
            for (int i = 0; i < newpop.GetLength(0); i++)
            { //заполняем таблицу
                switch ((int)KolZnakov.Value)
                { //в зависимости от количества знаков заполняем таблицу
                    case 0:
                        Population[0, i].Value = string.Format("{0:f0}", newpop[i, 0]);
                        Population[1, i].Value = string.Format("{0:f0}", newpop[i, 1]);
                        Population[2, i].Value = string.Format("{0:f0}", Fun(newpop[i, 0], newpop[i, 1]));
                        Population.Rows[i].HeaderCell.Value = String.Format("{0}", i + 1);
                        break;
                    case 1:
                        Population[0, i].Value = string.Format("{0:f1}", newpop[i, 0]);
                        Population[1, i].Value = string.Format("{0:f1}", newpop[i, 1]);
                        Population[2, i].Value = string.Format("{0:f1}", Fun(newpop[i, 0], newpop[i, 1]));
                        Population.Rows[i].HeaderCell.Value = String.Format("{0}", i + 1);
                        break;
                    case 2:
                        Population[0, i].Value = string.Format("{0:f2}", newpop[i, 0]);
                        Population[1, i].Value = string.Format("{0:f2}", newpop[i, 1]);
                        Population[2, i].Value = string.Format("{0:f2}", Fun(newpop[i, 0], newpop[i, 1]));
                        Population.Rows[i].HeaderCell.Value = String.Format("{0}", i + 1);
                        break;
                    case 3:
                        Population[0, i].Value = string.Format("{0:f3}", newpop[i, 0]);
                        Population[1, i].Value = string.Format("{0:f3}", newpop[i, 1]);
                        Population[2, i].Value = string.Format("{0:f3}", Fun(newpop[i, 0], newpop[i, 1]));
                        Population.Rows[i].HeaderCell.Value = String.Format("{0}", i + 1);
                        break;
                    case 4:
                        Population[0, i].Value = string.Format("{0:f4}", newpop[i, 0]);
                        Population[1, i].Value = string.Format("{0:f4}", newpop[i, 1]);
                        Population[2, i].Value = string.Format("{0:f4}", Fun(newpop[i, 0], newpop[i, 1]));
                        Population.Rows[i].HeaderCell.Value = String.Format("{0}", i + 1);
                        break;
                    case 5:
                        Population[0, i].Value = string.Format("{0:f5}", newpop[i, 0]);
                        Population[1, i].Value = string.Format("{0:f5}", newpop[i, 1]);
                        Population[2, i].Value = string.Format("{0:f5}", Fun(newpop[i, 0], newpop[i, 1]));
                        Population.Rows[i].HeaderCell.Value = String.Format("{0}", i + 1);
                        break;
                    case 6:
                        Population[0, i].Value = string.Format("{0:f6}", newpop[i, 0]);
                        Population[1, i].Value = string.Format("{0:f6}", newpop[i, 1]);
                        Population[2, i].Value = string.Format("{0:f6}", Fun(newpop[i, 0], newpop[i, 1]));
                        Population.Rows[i].HeaderCell.Value = String.Format("{0}", i + 1);
                        break;
                    case 7:
                        Population[0, i].Value = string.Format("{0:f7}", newpop[i, 0]);
                        Population[1, i].Value = string.Format("{0:f7}", newpop[i, 1]);
                        Population[2, i].Value = string.Format("{0:f7}", Fun(newpop[i, 0], newpop[i, 1]));
                        Population.Rows[i].HeaderCell.Value = String.Format("{0}", i + 1);
                        break;
                    case 8:
                        Population[0, i].Value = string.Format("{0:f8}", newpop[i, 0]);
                        Population[1, i].Value = string.Format("{0:f8}", newpop[i, 1]);
                        Population[2, i].Value = string.Format("{0:f8}", Fun(newpop[i, 0], newpop[i, 1]));
                        Population.Rows[i].HeaderCell.Value = String.Format("{0}", i + 1);
                        break;
                    case 9:
                        Population[0, i].Value = string.Format("{0:f9}", newpop[i, 0]);
                        Population[1, i].Value = string.Format("{0:f9}", newpop[i, 1]);
                        Population[2, i].Value = string.Format("{0:f9}", Fun(newpop[i, 0], newpop[i, 1]));
                        Population.Rows[i].HeaderCell.Value = String.Format("{0}", i + 1);
                        break;
                    case 10:
                        Population[0, i].Value = string.Format("{0:f10}", newpop[i, 0]);
                        Population[1, i].Value = string.Format("{0:f10}", newpop[i, 1]);
                        Population[2, i].Value = string.Format("{0:f10}", Fun(newpop[i, 0], newpop[i, 1]));
                        Population.Rows[i].HeaderCell.Value = String.Format("{0}", i + 1);
                        break;
                    case 11:
                        Population[0, i].Value = string.Format("{0:f11}", newpop[i, 0]);
                        Population[1, i].Value = string.Format("{0:f11}", newpop[i, 1]);
                        Population[2, i].Value = string.Format("{0:f11}", Fun(newpop[i, 0], newpop[i, 1]));
                        Population.Rows[i].HeaderCell.Value = String.Format("{0}", i + 1);
                        break;
                    case 12:
                        Population[0, i].Value = string.Format("{0:f12}", newpop[i, 0]);
                        Population[1, i].Value = string.Format("{0:f12}", newpop[i, 1]);
                        Population[2, i].Value = string.Format("{0:f12}", Fun(newpop[i, 0], newpop[i, 1]));
                        Population.Rows[i].HeaderCell.Value = String.Format("{0}", i + 1);
                        break;
                    case 13:
                        Population[0, i].Value = string.Format("{0:f13}", newpop[i, 0]);
                        Population[1, i].Value = string.Format("{0:f13}", newpop[i, 1]);
                        Population[2, i].Value = string.Format("{0:f13}", Fun(newpop[i, 0], newpop[i, 1]));
                        Population.Rows[i].HeaderCell.Value = String.Format("{0}", i + 1);
                        break;
                    case 14:
                        Population[0, i].Value = string.Format("{0:f14}", newpop[i, 0]);
                        Population[1, i].Value = string.Format("{0:f14}", newpop[i, 1]);
                        Population[2, i].Value = string.Format("{0:f14}", Fun(newpop[i, 0], newpop[i, 1]));
                        Population.Rows[i].HeaderCell.Value = String.Format("{0}", i + 1);
                        break;
                    case 15:
                        Population[0, i].Value = string.Format("{0:f15}", newpop[i, 0]);
                        Population[1, i].Value = string.Format("{0:f15}", newpop[i, 1]);
                        Population[2, i].Value = string.Format("{0:f15}", Fun(newpop[i, 0], newpop[i, 1]));
                        Population.Rows[i].HeaderCell.Value = String.Format("{0}", i + 1);
                        break;
                }
            }
        }
    }
}