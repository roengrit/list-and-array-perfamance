using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_and_array_performance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Int32> listInt = new List<Int32>();
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            for (int i = 0; i < 10000; i++)
            {
                listInt.Add(i);
            }

            stopWatch.Stop();
            Console.Write("Using List : " + stopWatch.ElapsedTicks + "\n");
            stopWatch.Reset();


            stopWatch.Start();
            Int32[] arr = new Int32[10000];
            for (int i = 0; i < 10000; i++)
            {
                arr[i] = i;
            }
            stopWatch.Stop();

            Console.Write("Using Array : " + stopWatch.ElapsedTicks + "\n");
            Console.ReadLine();

            //// โจทย์นี้จะวัดกันได้เมื่อรู้ขนาดของข้อมูลอยู่แล้ว เพราะฉะนั้นต้องเลือกประเภทข้อมูลให้เหมาะสมกับสถานะการ
        }
    }
}
