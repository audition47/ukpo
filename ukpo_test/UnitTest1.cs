using Microsoft.VisualStudio.TestTools.UnitTesting;
using Floyd_Algorithm;

namespace ukpo_test
{
    [TestClass]
    public class FloydAlgorythmTesting
    {
        // Сравнение двух целых неодинаковых чисел, проверка результата
        [TestMethod]
        public void Compare10And3()
        {
            // Аргументы
            int arg1 = 10;
            int arg2 = 3;
            // Ожидание
            int expected = arg1 < arg2 ? arg1 : arg2;
            // Реальность
            int actual = Floyd_Algorithm.Program.Min(arg1, arg2);
            // Тестирование
            Assert.AreEqual(expected, actual);
        }

        // Сравнение двух целых одинаковых чисел, проверка результата
        [TestMethod]
        public void CompareEquals()
        {
            // Аргументы
            int arg1 = 11;
            int arg2 = 11;
            // Ожидание
            int expected = 11;
            // Реальность
            int actual = Floyd_Algorithm.Program.Min(arg1, arg2);
            // Тестирование
            Assert.AreEqual(expected, actual);
        }

        // Сравнение двух целых неодинаковых чисел, проверка результата
        [TestMethod]
        public void Compare17And54()
        {
            // Аргументы
            int arg1 = 17;
            int arg2 = 54;
            // Ожидание
            int expected = arg1 < arg2 ? arg1 : arg2;
            // Реальность
            int actual = Floyd_Algorithm.Program.Min(arg1, arg2);
            // Тестирование
            Assert.AreEqual(expected, actual);
        }

        // Поиск пути из города 0 в город 4, проверка результата
        [TestMethod]
        public void findWayFrom0To4()
        {
            // Аргументы
            string[] args = new string[] { "input.txt", "0", "4" };
            // Ожидание
            int expected = 10;
            // Реальность
            int actual = Floyd_Algorithm.Program.Main(args);
            // Тестирование
            Assert.AreEqual(expected, actual);
        }

        // Поиск пути из города 2 в город 4, проверка результата
        [TestMethod]
        public void findWayFrom2To4()
        {
            // Аргументы
            string[] args = new string[] { "input.txt", "2", "4" };
            // Ожидание
            int expected = 5;
            // Реальность
            int actual = Floyd_Algorithm.Program.Main(args);
            // Тестирование
            Assert.AreEqual(expected, actual);
        }

        // Поиск пути из города 3 в город 0, проверка результата
        [TestMethod]
        public void findWayFrom3To0()
        {
            // Аргументы
            string[] args = new string[] { "input.txt", "3", "0" };
            // Ожидание
            int expected = 0;
            // Реальность
            int actual = Floyd_Algorithm.Program.Main(args);
            // Тестирование
            Assert.AreEqual(expected, actual);
        }

        // Чтение данных из файла, проверка результата
        [TestMethod]
        public void readFile()
        {
            // Аргументы
            string arg1 = "input.txt";
            // Ожидание
            int[,] expected = new int[,]{
                {0,5,8,0,0},
                {0,0,4,3,0},
                {0,0,0,3,7},
                {0,0,0,0,2},
                {0,0,0,0,0}};
            // Реальность
            int[,] actual = Floyd_Algorithm.Program.ReadFromFile(arg1);
            // Тестирование
            CollectionAssert.AreEqual(expected, actual);
        }

        // Чтение данных из несуществующего файла, проверка результата
        [TestMethod]
        public void fileNotFound()
        {
            // Аргументы
            string arg1 = "none.txt";
            // Ожидание
            int[,] expected = null;
            // Реальность
            int[,] actual = Floyd_Algorithm.Program.ReadFromFile(arg1);
            // Тестирование
            CollectionAssert.AreEqual(expected, actual);
        }

        // Поиск расстояний между несуществующими вершинами 0 и 5, проверка результата
        [TestMethod]
        public void findWayFrom0To5()
        {
            // Аргументы
            string[] args = new string[] { "input.txt", "0", "5" };
            // Ожидание
            int expected = 0;
            // Реальность
            int actual = Floyd_Algorithm.Program.Main(args);
            // Тестирование
            Assert.AreEqual(expected, actual);
        }
    }
}

