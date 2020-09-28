using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Задание 1 A

            byte vbyte = 4; // 1 byte 0 - 255
            Console.WriteLine($"byte: {vbyte}");
            sbyte vsbyte = -5; // 1 byte -128 - 127
            Console.WriteLine($"sbyte: {vsbyte}");
            short vshort = 40; // 2 byte -32768 - 32767
            Console.WriteLine($"short: {vshort}");
            ushort vushort = 10; // 2 byte 0 - 65535
            Console.WriteLine($"ushort: {vushort}");
            int vint = 20; // 4 byte  -2147483648 - 2147483647
            Console.WriteLine($"int: {vint}");
            uint vuint = 20; //4 byte 0 - 4294967295
            Console.WriteLine($"uint: {vuint}");
            long vlong = 200; //8 byte
            Console.WriteLine($"long: {vlong}");
            ulong vulong = 24124; //8 byte
            Console.WriteLine($"ulong: {vulong}");


            float vfloat = 5.421f; // 4 byte
            Console.WriteLine($"float: {vfloat}");
            double vdouble = 4.123213; // 8 byte
            Console.WriteLine($"double: {vdouble}");
            decimal vdecimal = 6.124m; // 16 byte
            Console.WriteLine($"decimal: {vdecimal}");

            char vchar = 'ф'; // 2 byte
            Console.WriteLine($"vchar: {vchar}");
            string vstring = "line";
            Console.WriteLine($"vstring: {vstring}");

            object a = 22; // 4 byte - x32 system // 8 byte - x64 system
            Console.WriteLine($"a: {a}");
            object b = 3.14;
            Console.WriteLine($"b: {b}");

            //Задание 1 B


            //Явные
            byte aa = 4;
            byte bb = (byte)(aa + 20);

            short ss = 20;
            short dd = (short)(ss - 5);

            ushort ff = 20;
            byte gg = (byte)ff;

            int hh = -20;
            sbyte ll = (sbyte)hh;

            char cc = '1';
            int rr = (int)(cc);


            //Неявные

            byte lll = 4;
            int ddd = lll;

            short sss = 29;
            int ggg = sss;

            ushort rrr = 2;
            int aaa = rrr;

            int ppp = -20000;
            long bbb = ppp;

            uint iii = 24214;
            ulong ttt = iii;

            //Задание 1 C

            int kkkk = 5;
            object pppp = kkkk;
            int zzzz = (int)pppp;

            //Задание 1 D

            var intVar = 5;

            //Задание 1 E

            int? c = 7;
            if (c != null)
            {
                Console.WriteLine($"c is {c.Value}");
            }
            else
            {
                Console.WriteLine("c does not have a value");
            }

            //Задание 1 F

            var intVar1 = 1;
            //intVar1 = 0.4;






            //Задание 2 А

            string string1 = "Строка 1";
            string string2 = "Строка 2";

            Console.WriteLine(string1 == string2);

            //Задание 2 B

            string string3 = "Строка 1 " + "Строка 2"; //Сцепление
            string string4 = String.Copy(string3);
            string string5 = string4.Substring(4, 5);

            string s = "Word word1 word2";
            string[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string string7 = "Интерполированная строка ${5}";
            Console.WriteLine(string7);

            //Задание 2 С

            string s1 = "abcd";
            string s2 = "";
            string s3 = null;

            Console.WriteLine("String s1 {0}.", Test(s1));
            Console.WriteLine("String s2 {0}.", Test(s2));
            Console.WriteLine("String s3 {0}.", Test(s3));

            String Test(string sa)
            {
                if (String.IsNullOrEmpty(sa))
                    return "is null or empty";
                else
                    return String.Format("(\"{0}\") is neither null nor empty", sa);
            }

            //Задание 2 D

            StringBuilder sb = new StringBuilder("Строка: ");
            sb.Insert(0, 'a');
            sb.Insert(sb.Length - 1, 'b');
            sb.Remove(4, 2);
            Console.WriteLine(sb);

            //Задание 3 А

            int[,] arrInt = new int[3, 3]
            {
                {1, 2, 3},
                {5, 3, 1},
                {5, 6, 1},
            };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arrInt[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.ReadLine();

            //Задание 3 B

            string[] stringArr = new string[5]
            {
                "Слово 1",
                "Слово 2",
                "Слово 3",
                "Слово 4",
                "Слово 5"
            };

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(stringArr[i]);
            }

            Console.WriteLine("Введите Номер слова, которое нужно заменить: 0-4");
            string num = Console.ReadLine();
            Console.WriteLine("Меняем на слово:");
            string nWord = Console.ReadLine();

            stringArr[int.Parse(num)] = nWord;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(stringArr[i]);
            }

            Console.WriteLine($"Длина массива: {stringArr.Length}");

            //Задание 3 С

            int[][] massivStep = new int[3][];
            massivStep[0] = new int[3];
            massivStep[1] = new int[4];
            massivStep[2] = new int[2];

            int temp;

            Console.WriteLine("Введите ступенчатый массив");


            for(int i = 0; i < 3; i++)
            {
                temp = Convert.ToInt32(Console.ReadLine());
                massivStep[0][i] = temp;
                
            }

            for (int i = 0; i < 4; i++)
            {
                temp = Convert.ToInt32(Console.ReadLine());
                massivStep[1][i] = temp;
            }

            for (int i = 0; i < 2; i++)
            {
                temp = Convert.ToInt32(Console.ReadLine());
                massivStep[2][i] = temp;
            }

            //Вывод

            for (int i = 0; i < 3; i++)
            {
                Console.Write(massivStep[0][i]);
                Console.Write(' ');
            }

            Console.WriteLine();

            for (int i = 0; i < 4; i++)
            {
                Console.Write(massivStep[1][i]);
                Console.Write(' ');
            }

            Console.WriteLine();

            for (int i = 0; i < 2; i++)
            {
                Console.Write(massivStep[2][i]);
                Console.Write(' ');
            }

            Console.WriteLine();

            Console.ReadLine();

            //Задание 3 D


            var agf = new[] { 1, 10, 100, 1000 };
            var grgr = "Line1";

            //Задание 4 А

            (int, string, char, string, ulong) t122 = (45, "Слово", 'f', "Слово2", 522);

            //Задание 4 B


            Console.WriteLine($"Tuple: {t122}");
            Console.WriteLine($"Tuple elements: {t122.Item1} {t122.Item2}");

            //Задание 4 C



            //Задание 4 D

            (int, long) t333 = (2, 299);
            (int, long) t555 = (2, 299);

            Console.WriteLine(t333 == t555);

            //Задание 5 А

            int[] massivNum = new int[5]{ 1, 2, 3, 4, 5 };
            string strokafunc = "Just line";
            (int, int, int, char) getSumOfNum(int[] num1, string stroka) {
                
                int getMax()
                {
                    int max = 0;
                    for(int i = 0; i < num1.Length; i++)
                    {
                        if (max < num1[i]) max = num1[i];
                    }

                    return max;
                }

                int getMin()
                {
                    int min = 0;
                    for(int i = 0; i < num1.Length; i++)
                    {
                        if (min > num1[i]) min = num1[i];
                    }

                    return min;
                }

                int getSum()
                {
                    int sum = 0;
                    for(int i = 0; i < num1.Length; i++)
                    {
                        sum += num1[i];
                    }

                    return sum;
                }

                (int, int, int, char) minmax = (getMax(), getMin(), getSum(), stroka[0]);


                return minmax;

            }

            Console.Write($"Результат работы функции: {getSumOfNum(massivNum, strokafunc)}");

            Console.ReadLine();

            //Задание 5 B


            //Задание 5 D



        }
    }
}
