using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DoubleColorBallAnalysis
{
    class Program
    {
        /*第一版本：通过取余随机生成数据
        */
        static void Main(string[] args)
        {
            GetLotteryVersionOne();
            Console.ReadLine();
        }

        /// <summary>
        /// 第一版本：通过取余随机生成数据
        /// </summary>
        public static void GetLotteryVersionOne()
        {
            int[] redArray = new int[33];
            int[] blueArray = new int[16];

            for (int i = 0; i < 33; i++)
            {
                redArray[i] = i + 1;
            }

            for (int i = 0; i < 16; i++)
            {
                blueArray[i] = i + 1;
            }

            Console.WriteLine("red:");
            for (int i = 0; i < 6; )
            {
                int value;
                while ((value = new Random().Next() % 34) == new Random().Next() % 64)
                {
                    i++;
                    Console.Write(value + " ");
                    Thread.Sleep(100);
                }
            }
            Console.WriteLine();

            Console.WriteLine("blue:");
            for (int i = 0; i < 1;)
            {
                int value;
                while ((value=new Random().Next() % 16) == new Random().Next() % 32)
                {
                    i++;
                    Console.Write(value + " ");
                    Thread.Sleep(100);
                }
            }
           
        }
    }
}
