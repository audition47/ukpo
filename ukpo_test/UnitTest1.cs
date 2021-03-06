using Microsoft.VisualStudio.TestTools.UnitTesting;
using Floyd_Algorithm;

namespace ukpo_test
{
    [TestClass]
    public class FloydAlgorythmTesting
    {
        // ��������� ���� ����� ������������ �����, �������� ����������
        [TestMethod]
        public void Compare10And3()
        {
            // ���������
            int arg1 = 10;
            int arg2 = 3;
            // ��������
            int expected = arg1 < arg2 ? arg1 : arg2;
            // ����������
            int actual = Floyd_Algorithm.Program.Min(arg1, arg2);
            // ������������
            Assert.AreEqual(expected, actual);
        }

        // ��������� ���� ����� ���������� �����, �������� ����������
        [TestMethod]
        public void CompareEquals()
        {
            // ���������
            int arg1 = 11;
            int arg2 = 11;
            // ��������
            int expected = 11;
            // ����������
            int actual = Floyd_Algorithm.Program.Min(arg1, arg2);
            // ������������
            Assert.AreEqual(expected, actual);
        }

        // ��������� ���� ����� ������������ �����, �������� ����������
        [TestMethod]
        public void Compare17And54()
        {
            // ���������
            int arg1 = 17;
            int arg2 = 54;
            // ��������
            int expected = arg1 < arg2 ? arg1 : arg2;
            // ����������
            int actual = Floyd_Algorithm.Program.Min(arg1, arg2);
            // ������������
            Assert.AreEqual(expected, actual);
        }

        // ����� ���� �� ������ 0 � ����� 4, �������� ����������
        [TestMethod]
        public void findWayFrom0To4()
        {
            // ���������
            string[] args = new string[] { "input.txt", "0", "4" };
            // ��������
            int expected = 10;
            // ����������
            int actual = Floyd_Algorithm.Program.Main(args);
            // ������������
            Assert.AreEqual(expected, actual);
        }

        // ����� ���� �� ������ 2 � ����� 4, �������� ����������
        [TestMethod]
        public void findWayFrom2To4()
        {
            // ���������
            string[] args = new string[] { "input.txt", "2", "4" };
            // ��������
            int expected = 5;
            // ����������
            int actual = Floyd_Algorithm.Program.Main(args);
            // ������������
            Assert.AreEqual(expected, actual);
        }

        // ����� ���� �� ������ 3 � ����� 0, �������� ����������
        [TestMethod]
        public void findWayFrom3To0()
        {
            // ���������
            string[] args = new string[] { "input.txt", "3", "0" };
            // ��������
            int expected = 0;
            // ����������
            int actual = Floyd_Algorithm.Program.Main(args);
            // ������������
            Assert.AreEqual(expected, actual);
        }

        // ������ ������ �� �����, �������� ����������
        [TestMethod]
        public void readFile()
        {
            // ���������
            string arg1 = "input.txt";
            // ��������
            int[,] expected = new int[,]{
                {0,5,8,0,0},
                {0,0,4,3,0},
                {0,0,0,3,7},
                {0,0,0,0,2},
                {0,0,0,0,0}};
            // ����������
            int[,] actual = Floyd_Algorithm.Program.ReadFromFile(arg1);
            // ������������
            CollectionAssert.AreEqual(expected, actual);
        }

        // ������ ������ �� ��������������� �����, �������� ����������
        [TestMethod]
        public void fileNotFound()
        {
            // ���������
            string arg1 = "none.txt";
            // ��������
            int[,] expected = null;
            // ����������
            int[,] actual = Floyd_Algorithm.Program.ReadFromFile(arg1);
            // ������������
            CollectionAssert.AreEqual(expected, actual);
        }

        // ����� ���������� ����� ��������������� ��������� 0 � 5, �������� ����������
        [TestMethod]
        public void findWayFrom0To5()
        {
            // ���������
            string[] args = new string[] { "input.txt", "0", "5" };
            // ��������
            int expected = 0;
            // ����������
            int actual = Floyd_Algorithm.Program.Main(args);
            // ������������
            Assert.AreEqual(expected, actual);
        }
    }
}

