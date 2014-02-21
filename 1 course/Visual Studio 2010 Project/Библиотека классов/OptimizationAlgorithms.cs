using System;
namespace Библиотека_классов
{//класс статических функций
    public static class OptimizationAlgorithms
    {//метод формирует новую популяцию
        public static double[,] NewPopulation(double MinIntX, double MaxIntX, double MinIntY, double MaxIntY)
        {
            Random gen = new Random();
            int populationsize = gen.Next(2, 100); //размер первоначальной популяции
            double[,] newpop = new double[populationsize, 2]; //матрица популяции
            for (int i = 0; i < populationsize; i++)
            {
                newpop[i, 0] = MinIntX + gen.NextDouble() * (MaxIntX - MinIntX);  //задаем случайно популяцию в искомом промежутке
                newpop[i, 1] = MinIntY + gen.NextDouble() * (MaxIntY - MinIntY);
            }
            return newpop;
        }
        //метод для нахождения количество элементов в мемеплексах
        public static int MemeplexNumber(int populationsize)
        {
            int n = 0; //количество элементов в мемеплексах
            Random gen = new Random();
            while (true)
            {
                n = gen.Next(1, populationsize); //полагаем, что количество элементов одинаково во всех мемеплексах
                if (populationsize % n == 0)
                    break;
            }
            return n;
        }
        //улучшения в мемеплексах для поиска максимума
        public static double[,] PopulationGoodModernization(double[,] newpop, double MinIntX, double MaxIntX, double MinIntY, double MaxIntY, int populationsize, int n, Functions.FunctionVyb Fun)
        {
            double[, ,] memeplexes = new double[(int)populationsize / n, n, 2]; //создаем матрицу-мемеплексов
            Random gen = new Random();
            double[] max = new double[2];
            max[0] = newpop[0, 0];
            max[1] = newpop[0, 1]; //глобальный максимум
            for (int i = 0; i < populationsize; i++)
                if (Fun(max[0], max[1]) < Fun(newpop[i, 0], newpop[i, 1]))
                {
                    max[0] = newpop[i, 0]; //поиск агента с максимальным значением фитнесс-функции
                    max[1] = newpop[i, 1];
                }
            for (int i = 0; i < memeplexes.GetLength(0); i++)
                for (int j = 0; j < n; j++)
                {
                    memeplexes[i, j, 0] = newpop[i + j, 0];
                    memeplexes[i, j, 1] = newpop[i + j, 1]; //задание мемеплексов 
                }
            for (int i = 0; i < memeplexes.GetLength(0); i++) //модернизируем популяцию
            {
                double[] Sbest = new double[2];
                Sbest[0] = memeplexes[i, 0, 0];
                Sbest[1] = memeplexes[i, 0, 1];
                double[] Sworst = new double[2]; //задание лучшего и худшего агентов
                Sworst[0] = memeplexes[i, 0, 0];
                Sworst[1] = memeplexes[i, 0, 1];
                int SWind = 0; //индекс худшего агента
                for (int k = 0; k < n; k++) //проходим по мемеплексу и ищем лучшего и худшего агентов в мемеплексе
                {
                    if (Fun(Sbest[0], Sworst[1]) < Fun(memeplexes[i, k, 0], memeplexes[i, k, 1]))
                    {
                        Sbest[0] = memeplexes[i, k, 0];         //ищем лучшего агента в мемеплексе
                        Sbest[1] = memeplexes[i, k, 1];
                    }
                    else
                        if (Fun(Sworst[0], Sworst[1]) > Fun(memeplexes[i, k, 0], memeplexes[i, k, 1]))
                        {
                            Sworst[0] = memeplexes[i, k, 0];     //ищем худшего агента
                            Sworst[1] = memeplexes[i, k, 1];
                            SWind = k; //задаем индекс худшего агента
                        }
                }
                //начинаем улучшать позицию худшего агента в мемеплексе
                double[] Sworsttry = new double[2];
                Sworsttry[0] = MinIntX;
                Sworsttry[1] = MinIntY;
                Sworsttry[0] = Sworst[0] + gen.NextDouble() * (Sbest[0] - Sworst[0]); //улучшение на локальном максимуме
                Sworsttry[1] = Sworst[1] + gen.NextDouble() * (Sbest[1] - Sworst[1]);
                if (Sworsttry[0] < MinIntX)
                    Sworsttry[0] = MinIntX; //если агент выходит за рамки присваиваем граничные значения
                if (Sworsttry[1] < MinIntY)
                    Sworsttry[1] = MinIntY;
                if (Sworsttry[0] > MaxIntX)
                    Sworsttry[0] = MaxIntX;
                if (Sworsttry[1] > MaxIntY)
                    Sworsttry[1] = MaxIntY;

                if (Fun(Sworsttry[0], Sworsttry[1]) > Fun(Sworst[0], Sworst[1]))
                {
                    memeplexes[i, SWind, 0] = Sworsttry[0];      //если улучшение прошло успешно, то фиксируем улучшение
                    memeplexes[i, SWind, 1] = Sworsttry[1];
                }
                else  //если улучшение не помогло, пробуем улучшить на глобальном максимуме
                {
                    Sworsttry[0] = MinIntX;
                    Sworsttry[1] = MinIntY; //задаем начальное значение
                    Sworsttry[0] = Sworst[0] + gen.NextDouble() * (max[0] - Sworst[0]); //улучшение на глобальном максимуме
                    Sworsttry[1] = Sworst[1] + gen.NextDouble() * (max[1] - Sworst[1]);
                    if (Sworsttry[0] < MinIntX)
                        Sworsttry[0] = MinIntX; //если агент выходит за рамки присваиваем граничные значения
                    if (Sworsttry[1] < MinIntY)
                        Sworsttry[1] = MinIntY;
                    if (Sworsttry[0] > MaxIntX)
                        Sworsttry[0] = MaxIntX;
                    if (Sworsttry[1] > MaxIntY)
                        Sworsttry[1] = MaxIntY;
                    if (Fun(Sworsttry[0], Sworsttry[1]) > Fun(Sworst[0], Sworst[1])) //если улучшение помогло, то фиксируем его
                    {
                        memeplexes[i, SWind, 0] = Sworsttry[0];
                        memeplexes[i, SWind, 1] = Sworsttry[1];
                    }
                    else //если и это улучшение не прошло, то генерируем агента по новой
                    {
                        memeplexes[i, SWind, 0] = MinIntX + gen.NextDouble() * (MaxIntX - MinIntX);  
                        memeplexes[i, SWind, 1] = MinIntY + gen.NextDouble() * (MaxIntY - MinIntY);
                    }
                }
            }
            for (int i = 0; i < memeplexes.GetLength(0); i++)
            {
                for (int j = 0; j < n; j++)
                {
                    newpop[i + j, 0] = memeplexes[i, j, 0]; //собираем популяцию воедино заново из измененного мемеплекса
                    newpop[i + j, 1] = memeplexes[i, j, 1];
                }
            }
            return newpop;
        }
        //улучшения в мемеплексах для поиска минимума
        public static double[,] PopulationBadModernization(double[,] newpop, double MinIntX, double MaxIntX, double MinIntY, double MaxIntY, int populationsize, int n, Functions.FunctionVyb Fun)
        {
            double[, ,] memeplexes = new double[(int)populationsize / n, n, 2]; //создаем матрицу-мемеплексов
            Random gen = new Random();
            double[] max = new double[2];
            max[0] = newpop[0, 0];
            max[1] = newpop[0, 1]; //глобальный максимум (минимальное значение)
            for (int i = 0; i < populationsize; i++)
                if (Fun(max[0], max[1]) > Fun(newpop[i, 0], newpop[i, 1]))
                {
                    max[0] = newpop[i, 0]; //поиск агента с минимальным значением фитнесс функции 
                    max[1] = newpop[i, 1]; 
                }
            for (int i = 0; i < memeplexes.GetLength(0); i++)
                for (int j = 0; j < n; j++)
                {
                    memeplexes[i, j, 0] = newpop[i + j, 0];
                    memeplexes[i, j, 1] = newpop[i + j, 1]; //задание мемеплексов 
                }
            for (int i = 0; i < memeplexes.GetLength(0); i++) //модернизируем популяцию
            {
                double[] Sbest = new double[2];
                Sbest[0] = memeplexes[i, 0, 0];
                Sbest[1] = memeplexes[i, 0, 1];
                double[] Sworst = new double[2]; //задание лучшего и худшего агентов
                Sworst[0] = memeplexes[i, 0, 0];
                Sworst[1] = memeplexes[i, 0, 1];
                int SWind = 0; //индекс худшего агента
                for (int k = 0; k < n; k++) //проходим по мемеплексу и ищем лучшего и худшего агентов в мемеплексе
                {
                    if (Fun(Sbest[0], Sworst[1]) > Fun(memeplexes[i, k, 0], memeplexes[i, k, 1]))
                    {
                        Sbest[0] = memeplexes[i, k, 0];         //ищем лучшего агента в мемеплексе
                        Sbest[1] = memeplexes[i, k, 1];
                    }
                    else
                        if (Fun(Sworst[0], Sworst[1]) < Fun(memeplexes[i, k, 0], memeplexes[i, k, 1]))
                        {
                            Sworst[0] = memeplexes[i, k, 0];     //ищем худшего агента
                            Sworst[1] = memeplexes[i, k, 1];
                            SWind = k; //задаем индекс худшего агента
                        }
                }
                //начинаем улучшать позицию худшего агента в мемеплексе
                double[] Sworsttry = new double[2];
                Sworsttry[0] = MinIntX;
                Sworsttry[1] = MinIntY;
                Sworsttry[0] = Sworst[0] + gen.NextDouble() * (Sbest[0] - Sworst[0]); //улучшение на локальном максимуме
                Sworsttry[1] = Sworst[1] + gen.NextDouble() * (Sbest[1] - Sworst[1]);
                if (Sworsttry[0] < MinIntX)
                    Sworsttry[0] = MinIntX; //если агент выходит за рамки присваиваем граничные значения
                if (Sworsttry[1] < MinIntY)
                    Sworsttry[1] = MinIntY;
                if (Sworsttry[0] > MaxIntX)
                    Sworsttry[0] = MaxIntX;
                if (Sworsttry[1] > MaxIntY)
                    Sworsttry[1] = MaxIntY;
                if (Fun(Sworsttry[0], Sworsttry[1]) < Fun(Sworst[0], Sworst[1]))
                {
                    memeplexes[i, SWind, 0] = Sworsttry[0];      //если улучшение прошло успешно, то фиксируем улучшение
                    memeplexes[i, SWind, 1] = Sworsttry[1];
                }
                else  //если улучшение неудачно, пробуем улучшить на глобальном максимуме
                {
                    Sworsttry[0] = MinIntX;
                    Sworsttry[1] = MinIntY; //задаем начальное значение
                    Sworsttry[0] = Sworst[0] + gen.NextDouble() * (max[0] - Sworst[0]); //улучшение на глобальном максимуме
                    Sworsttry[1] = Sworst[1] + gen.NextDouble() * (max[1] - Sworst[1]);
                    if (Sworsttry[0] < MinIntX)
                        Sworsttry[0] = MinIntX; //если агент выходит за рамки присваиваем граничные значения
                    if (Sworsttry[1] < MinIntY)
                        Sworsttry[1] = MinIntY;
                    if (Sworsttry[0] > MaxIntX)
                        Sworsttry[0] = MaxIntX;
                    if (Sworsttry[1] > MaxIntY)
                        Sworsttry[1] = MaxIntY;
                    if (Fun(Sworsttry[0], Sworsttry[1]) < Fun(Sworst[0], Sworst[1])) //если улучшение помогло, фиксируем
                    {
                        memeplexes[i, SWind, 0] = Sworsttry[0];
                        memeplexes[i, SWind, 1] = Sworsttry[1];
                    }
                    else //если и это улучшение не прошло, то генерируем агента по новой
                    {
                        memeplexes[i, SWind, 0] = MinIntX + gen.NextDouble() * (MaxIntX - MinIntX);  //задаем случайно популяцию - в промежутке искомом
                        memeplexes[i, SWind, 1] = MinIntY + gen.NextDouble() * (MaxIntY - MinIntY);
                    }
                }
            }
            for (int i = 0; i < memeplexes.GetLength(0); i++)
            {
                for (int j = 0; j < n; j++)
                {
                    newpop[i + j, 0] = memeplexes[i, j, 0];          //собираем популяцию воедино заново из измененного мемеплекса
                    newpop[i + j, 1] = memeplexes[i, j, 1];
                }
            }
            return newpop;
        }
        //перемешивание популяции
        public static double[,] PopulationShuffle(double[,] newpop)
        {
            Random gen = new Random();
            for (int i = newpop.GetLength(0) - 1; i > 0; i--)
            {
                int j = gen.Next(i); //генерируем номер
                double[] tmp = new double[2];
                tmp[0] = newpop[j, 0];      //проводим обмен
                tmp[1] = newpop[j, 1];
                newpop[j, 0] = newpop[i - 1, 0];
                newpop[j, 1] = newpop[i - 1, 1];
                newpop[i - 1, 0] = tmp[0];
                newpop[i - 1, 1] = tmp[1];
            }
            return newpop;
        }
        //максимум в популяции
        public static double[] Maximum(double[,] newpop, Functions.FunctionVyb Fun)
        {
            double[] max = new double[2];
            max[0] = newpop[0, 0]; 
            max[1] = newpop[0, 1];
            for (int i = 0; i < newpop.GetLength(0); i++)
            {
                if (Fun(max[0], max[1]) < Fun(newpop[i, 0], newpop[i, 1]))
                { //присваиваем, если значение больше промежуточного максимума
                    max[0] = newpop[i, 0];
                    max[1] = newpop[i, 1];
                }
            }
            return max;
        }
        //минимум в популяции
        public static double[] Minimum(double[,] newpop, Functions.FunctionVyb Fun)
        {
            double[] min = new double[2];
            min[0] = newpop[0, 0]; 
            min[1] = newpop[0, 1];
            for (int i = 0; i < newpop.GetLength(0); i++)
            {
                if (Fun(min[0], min[1]) > Fun(newpop[i, 0], newpop[i, 1]))
                { //присваиваем, если значение меньше промежуточного минимума
                    min[0] = newpop[i, 0];
                    min[1] = newpop[i, 1];
                }
            }
            return min;
        }
        //выполнение алгоритма полностью - максимум функции
        public static double[] FunctionMaximum(int kol, double MinIntX, double MaxIntX, double MinIntY, double MaxIntY, Functions.FunctionVyb Fun)
        {
            double[,] newpop = NewPopulation(MinIntX, MaxIntX, MinIntY, MaxIntY); //массив популяции
            int n=MemeplexNumber(newpop.GetLength(0));
            for (int i = 0; i < kol; i++)
            {
                PopulationGoodModernization(newpop, MinIntX, MaxIntX, MinIntY, MaxIntY, newpop.GetLength(0), n, Fun); //улучшение
                newpop = PopulationShuffle(newpop); //перемешиваем популяцию
            }
            return Maximum(newpop, Fun);
        }
        //выполнение алгоритма полностью - минимум функции
        public static double[] FunctionMinimum(int kol, double MinIntX, double MaxIntX, double MinIntY, double MaxIntY, Functions.FunctionVyb Fun)
        {
            double[,] newpop = NewPopulation(MinIntX, MaxIntX, MinIntY, MaxIntY); //массив популяции
            int n = MemeplexNumber(newpop.GetLength(0));
            for (int i = 0; i < kol; i++)
            {
                PopulationBadModernization(newpop, MinIntX, MaxIntX, MinIntY, MaxIntY, newpop.GetLength(0), n, Fun); //улучшение
                newpop = PopulationShuffle(newpop); //перемешиваем популяцию
            }
            return Minimum(newpop,Fun);
        }
    }
}