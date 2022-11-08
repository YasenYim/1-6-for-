using System;

namespace _1_6_for循环
{
    class Program
    {
       
        static void Main(string[] args)
        {
            // 1.计算1~100的和与积
            //int sum = 0;
            //long product = 1;
            //for (int i = 1; i <= 20; i++)
            //{
            //    sum += i;
            //    product *= i;
            //}

            //Console.WriteLine("和为" + sum);
            //Console.WriteLine("积为" + product);

            // 2.找出1-100里面13的倍数
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 13 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            // 3.打印下列列表（双重循环讲解）：
            /*  1-1 1-2 1-3 1-4 1-5
             *  2-1 2-2 2-3 2-4 2-5
             *  3-1 3-2 3-3 3-4 3-5
             *  4-1 4-2 4-3 4-4 4-5
             */
          
            for (int i = 0; i < 4; i++)   // 行
            {
                for ( int j = 0; j < 5; j++)  // 列
                {
                    Console.Write((i + 1) + "_" + (j + 1) + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
