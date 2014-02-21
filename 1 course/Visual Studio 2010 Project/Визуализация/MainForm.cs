using System;
using System.Windows.Forms;
using Библиотека_классов;
namespace Визуализация
{
    public partial class MainForm : Form
    {
        Functions.FunctionVyb Fun = Functions.Function1; //действующая функция
        int KolIt = 1; //количество итераций
        double MiX; //границы
        double MiY;
        double MaX;
        double MaY;
        int clickitem = 1; //счетчик для выбора функции
        public Graphiks newForm; //для открытия формы графика
        //конструктор формы
        public MainForm() 
        {
            InitializeComponent();
            Function.Image = Function.Image = Properties.Resources.Function1; //начальное изображение
            IterationToolTip.SetToolTip(Kol_It_TrackBar, "Количество раз, которое выполнится алгоритм.");
            MinXToolTip.SetToolTip(MinX, "Поле должно содержать рациональное число.");
            MaxXToolTip.SetToolTip(MaxX, "Поле должно содержать рациональное число, большее чем минимальная граница по Х.");
            MinYToolTip.SetToolTip(MinY, "Поле должно содержать рациональное число.");
            MaxYToolTip.SetToolTip(MaxY, "Поле должно содержать рациональное число, большее чем минимальная граница по Y");
            FuncToolTip.SetToolTip(Function, "Для выбора другой функции, кликните на функцию.");
        }         
        //проверка корректности для текстбокса - минимальной границы Х
        private void MinX_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(MinX.Text, out MiX))
                Mistake_minX.SetError(MinX, "Поле должно содержать рациональное число");
            else
                Mistake_minX.Clear(); 
        }
        //проверка корректности для текстбокса - минимальной границы Y
        private void MinY_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(MinY.Text, out MiY))
                Mistake_minY.SetError(MinY, "Поле должно содержать рациональное число");
            else
                Mistake_minY.Clear();
        }
        //проверка корректности для текстбокса - максимальной границы Х
        private void MaxX_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(MaxX.Text, out MaX))
                Mistake_minX.SetError(MaxX, "Поле должно содержать рациональное число, большее чем минимальная граница по Х");
            else
                Mistake_minX.Clear();
        }
        //проверка корректности для текстбокса - максимальной границы Y
        private void MaxY_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(MaxY.Text, out MaY))
                Mistake_maxY.SetError(MaxY, "Поле должно содержать рациональное число, большее чем минимальная граница по Y");
            else
                Mistake_maxY.Clear();
        }
        //методы для очищения ошибок - для всех текстбоксов границ
        private void MinX_Leave(object sender, EventArgs e)
        {
            if (MinX.Text == "")
                Mistake_minX.Clear();
        }
        private void MinY_Leave(object sender, EventArgs e)
        {
            if (MinY.Text == "")
                Mistake_minY.Clear();
        }
        private void MaxX_Leave(object sender, EventArgs e)
        {
            if ((MaxX.Text == "")||((double.TryParse(MinX.Text, out MiX)) &&(double.TryParse(MaxX.Text, out MaX))&&(MiX-MaX>=0)))
                Mistake_maxX.Clear();
        }
        private void MaxY_Leave(object sender, EventArgs e)
        {
            if ((MaxY.Text == "") || ((double.TryParse(MinY.Text, out MiY)) && (double.TryParse(MaxY.Text, out MaY)) && (MiY - MaY >= 0)))
                Mistake_maxY.Clear();
        }
        //нажатие на кнопку график
        private void GraphOpen_Click(object sender, EventArgs e)
        {//проверка на ошибки и полностью введены ли данные
            bool f = false;
            if (!(Maximum.Checked || Minimum.Checked))
            {
                MessageBox.Show(@"Выберите максимум или минимум!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else f = true;
            if (!(f && (Mistake_minX.GetError(MinX) == "") && (MinX.Text != "")))
            {
                MessageBox.Show(@"Неверно введена или вообще не введена минимальная граница X!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Mistake_minX.SetError(MinX, "Поле должно содержать рациональное число");
                return;
            }
            else f = false;
            if (!(!f && (Mistake_maxX.GetError(MaxX) == "") && (MaxX.Text != "")))
            {
                MessageBox.Show(@"Неверно введена или вообще не введена максимальная граница X!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Mistake_minX.SetError(MaxX, "Поле должно содержать рациональное число, большее чем минимальная граница по Х");
                return;
            }
            else f = true;
            if (!(f && (Mistake_minY.GetError(MinY) == "") && (MinY.Text != "")))
            {
                MessageBox.Show(@"Неверно введена или вообще не введена минимальная граница Y!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Mistake_minY.SetError(MinY, "Поле должно содержать рациональное число");
                return;
            }
            else f = false;
            if (!(!f && (Mistake_maxY.GetError(MaxY) == "") && (MaxY.Text != "")))
            {
                MessageBox.Show(@"Неверно введена или вообще не введена максимальная граница Y!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Mistake_maxY.SetError(MaxY, "Поле должно содержать рациональное число, большее чем минимальная граница по Y");
                return;
            }
            else f = true;
            if (!((MiX <= MaX) && f))
            {
                MessageBox.Show(@"Минимальная граница по Х больше максимальной!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Mistake_maxY.SetError(MaxX, "Поле должно содержать рациональное число, большее чем минимальная граница по Х");
                return;
            }
            else f = false;
            if (!((MiY <= MaY) && !f))
            {
                MessageBox.Show(@"Минимальная граница по Y больше максимальной!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Mistake_maxY.SetError(MaxY, "Поле должно содержать рациональное число, большее чем минимальная граница по Y");
                return;
            }
            else f = false;
            if (!f)
            { //если нет ошибок открываем новую форму
                Mistake_maxX.Clear();
                Mistake_maxY.Clear();//очищаем ошибки
                Mistake_minX.Clear();
                Mistake_minY.Clear();
                newForm = new Graphiks(KolIt, MiX, MaX, MiY, MaY, Maximum.Checked, Minimum.Checked, Fun);
                newForm.Show(); //показываем форму графиков
            }
        }
        //выбор функции
        private void Function_Click(object sender, EventArgs e)
        {
            clickitem++; //наращиваем количество нажатий
            switch (clickitem)
            {
                case 2: Function.Image = Properties.Resources.Function2;
                    Fun = Functions.Function2; //переключаем картинку и функции
                    break;
                case 3: Function.Image = Properties.Resources.Function3;
                    Fun = Functions.Function3; //переключаем картинку и функции
                    break;
                case 4: Function.Image = Properties.Resources.Function4;
                    Fun = Functions.Function4; //переключаем картинку и функции
                    break;
                case 5: Function.Image = Properties.Resources.Function5;
                    Fun = Functions.Function5; //переключаем картинку и функции
                    break;
                case 6: Function.Image = Properties.Resources.Function6;
                    Fun = Functions.Function6; //переключаем картинку и функции
                    break;
                case 7: Function.Image = Properties.Resources.Function7;
                    Fun = Functions.Function7; //переключаем картинку и функции
                    break;
                case 8: Function.Image = Properties.Resources.Function8;
                    Fun = Functions.Function8; //переключаем картинку и функции
                    break;
                default:
                    clickitem =1; //количество кликов - ставим начальное значение
                    Function.Image = Properties.Resources.Function1;
                    Fun = Functions.Function1; //переключаем картинку и функции
                    break;
            }
        }
        //выбор количества итераций на трекбаре
        private void Kol_It_TrackBar_Scroll(object sender, EventArgs e)
        {//отображаем в текстбоксе количества итераций - выбранное количество итераций
            Kol_It_Number.Text = Kol_It_TrackBar.Value.ToString();
        }
        //ввод количества итераций в текстбокс
        private void Kol_It_Number_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(Kol_It_Number.Text, out KolIt) && (KolIt > 0) && (KolIt < 1000))
            { //если данные корректны
                Kol_It_TrackBar.Value = KolIt; //на трекбаре ставим введенное количество итераций
                while (Kol_It_Number.Text[0] == '0') //убираем ведущие нули
                    Kol_It_Number.Text = KolIt.ToString();
            }
            else
            {
                if (KolIt >= 1000) //если количество итераций введено больше 1000
                {
                    KolIt = 1000;
                    Kol_It_TrackBar.Value = KolIt;
                    Kol_It_Number.Text = "1000";
                }
                else
                    if (KolIt <= 0)
                    {//если количество итераций введено меньше 1
                        KolIt = 1;
                        Kol_It_TrackBar.Value = KolIt;
                        Kol_It_Number.Text = "1";
                    }
                while (Kol_It_Number.Text[0] == '0') //убираем ведущие нули
                    Kol_It_Number.Text = KolIt.ToString();
            }
        }
        //нажатие на кнопку результат
        private void Result_Click(object sender, EventArgs e)
        {
            //проверка на ошибки и полностью введены ли данные
            bool f = false;
            if (!(Maximum.Checked || Minimum.Checked))
            {
                MessageBox.Show(@"Выберите максимум или минимум!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else f = true;
            if (!(f && (Mistake_minX.GetError(MinX) == "") && (MinX.Text != "")))
            {
                MessageBox.Show(@"Неверно введена или вообще не введена минимальная граница X!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Mistake_minX.SetError(MinX, "Поле должно содержать рациональное число");
                return;
            }
            else f = false;
            if (!(!f && (Mistake_maxX.GetError(MaxX) == "") && (MaxX.Text != "")))
            {
                MessageBox.Show(@"Неверно введена или вообще не введена максимальная граница X!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Mistake_minX.SetError(MaxX, "Поле должно содержать рациональное число, большее чем минимальная граница по Х");
                return;
            }
            else f = true;
            if (!(f && (Mistake_minY.GetError(MinY) == "") && (MinY.Text != "")))
            {
                MessageBox.Show(@"Неверно введена или вообще не введена минимальная граница Y!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Mistake_minY.SetError(MinY, "Поле должно содержать рациональное число");
                return;
            }
            else f = false;
            if (!(!f && (Mistake_maxY.GetError(MaxY) == "") && (MaxY.Text != "")))
            {
                MessageBox.Show(@"Неверно введена или вообще не введена максимальная граница Y!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Mistake_maxY.SetError(MaxY, "Поле должно содержать рациональное число, большее чем минимальная граница по Y");
                return;
            }
            else f = true;
            if (!((MiX <= MaX) && f))
            {
                MessageBox.Show(@"Минимальная граница по Х больше максимальной!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Mistake_maxY.SetError(MaxX, "Поле должно содержать рациональное число, большее чем минимальная граница по Х");
                return;
            }
            else f = false;
            if (!((MiY <= MaY) && !f))
            {
                MessageBox.Show(@"Минимальная граница по Y больше максимальной!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Mistake_maxY.SetError(MaxY, "Поле должно содержать рациональное число, большее чем минимальная граница по Y");
                return;
            }
            else f = false;
            if (!f)
            { //если нет ошибок, то в зависимости от того максимум или минимум выводим результат
                Mistake_maxX.Clear();
                Mistake_maxY.Clear();//очищаем ошибки
                Mistake_minX.Clear();
                Mistake_minY.Clear();
                if (Maximum.Checked)
                {
                    double[] ar = new double[2];
                    ar = OptimizationAlgorithms.FunctionMaximum(KolIt, MiX, MaX, MiY, MaY, Fun);
                    string s = String.Format(@"Максимум функции:
  Координата Х: {0}
  Координата Y: {1}", ar[0], ar[1]);
                    MessageBox.Show(s, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                if (Minimum.Checked)
                {
                    double[] ar = new double[2];
                    ar = OptimizationAlgorithms.FunctionMinimum(KolIt, MiX, MaX, MiY, MaY, Fun);
                    string s = String.Format(@"Минимум функции:
  Координата Х: {0}
  Координата Y: {1}", ar[0], ar[1]);
                    MessageBox.Show(s, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }   
    }
}