using System;
using System.IO;
namespace Floyd_Algorithm
{
    /// <summary>
    /// Главный класс программы
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Число вершин в графе
        /// </summary>
        static int Count = 0;
        /// <summary>
        /// Недостижимо большое расстояние (больше, чем любое из максимальных расстояний)
        /// </summary>
        static int UnreachWay = 0;
        // Аргументы
        
        /// <summary>
        /// Главная функция
        /// </summary>
        /// <param name="args">Массив аргументов (0 - имя входного файла)</param>
        public static int Main(string[] args)
        {

            // Чтение данных из файла
            int[,] M = ReadFromFile(args[0]);
            // Определение максимального расстояния
            UnreachWay = 0;
            for (int i1 = 0; i1 < Count; i1++)
                for (int i2 = 0; i2 < Count; i2++)
                    UnreachWay += M[i1, i2];
            UnreachWay++;

            // Корректировка матрицы расстояний - заполнение нулей недостижим большими числами
        CorrectMatrixFloyd(ref M, Count);
            // Работа алгоритма Флойда
            for (int k = 0; k < Count; ++k)
                for (int i = 0; i < Count; ++i)
                    for (int j = 0; j < Count; ++j)
                        M[i, j] = Min(M[i, k] + M[k, j], M[i, j]);

            // Очистить экран консоли
            Console.Clear();

            // Вывод результата на экран: матрица всех кратчайших расстояний
            for (int i1 = 0; i1 < Count; i1++)
            {
                for (int i2 = 0; i2 < Count; i2++)
                   
            Console.Write($"{(M[i1, i2] == UnreachWay ? "-" : M[i1,i2].ToString())}\t");
 Console.Write(Environment.NewLine);
 }
    Console.Write(Environment.NewLine);

 // Заданные пункты для отображения расстояния
 int a = Convert.ToInt32(args[1]);
    int b = Convert.ToInt32(args[2]);

    // Вывод результата на экран: Расстояние между заданными пунктами
    Console.WriteLine($"Расстояние между пунктами {a} и {b} : " + $"{((M[a, b] == UnreachWay) ? "нет пути" : M[a, b].ToString())}");

 // Ожидание действия
 Console.ReadKey();
 // Возвращаем значение
 return M[a, b] == UnreachWay? 0 : M[a, b];
 }
/// <summary>
/// Возвращает минимальное значение их двух указанных
/// </summary>
/// <param name="a">Первое значение</param>
/// <param name="b">Второе значение</param>
/// <returns>Минимальное значение из указанных</returns>
public static int Min(int a, int b) => a < b ? a : b;
/// <summary>
/// Корректировка матрицы расстояний - заполнение нулей недостижимо большими числами
 /// </summary>
 /// <param name="m">Исходная матрица</param>
 /// <param name="count">Размер матрицы</param>
public static void CorrectMatrixFloyd(ref int[,] m, int count)
{
    for (int i1 = 0; i1 < count; i1++)
        for (int i2 = 0; i2 < count; i2++)
            m[i1, i2] = m[i1, i2] == 0
            ? UnreachWay
            : m[i1, i2];
}
/// <summary>
/// Чтение данных из файла
/// </summary>
///<param name = "fileName" > input.txt </ param >;
/// <returns>Масив - матрица</returns>
public static int[,] ReadFromFile(string fileName)
{

    // Открытие файла для чтения
    FileStream fs = new FileStream(fileName, FileMode.Open);
    StreamReader sr = new StreamReader(fs);
    // Считывание числа вершин
    int.TryParse(sr.ReadLine(), out Count);
   
 // Создание массива растояний
 int[,] dist = new int[Count, Count];
    // Считывание матрицы расстояний
    for (int i1 = 0; i1 < Count; i1++)
    {
        // Считывание строки
        string[] sstr = sr.ReadLine().Split(new char[] { ' ' },
       StringSplitOptions.RemoveEmptyEntries);
        // Разбор строки на компоненты
        for (int i2 = 0; i2 < Count; i2++)
            dist[i1, i2] = Convert.ToInt32(sstr[i2]);
    }
    // Закрыть файл и потоки чтения
    sr.Close();
    fs.Close();
    // Возвращаем матрицу расстояний
    return dist;
}
 }
}