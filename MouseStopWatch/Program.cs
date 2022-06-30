using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MouseStopWatch
{
    internal class Program
    {
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);


        static void Main(string[] args)
        {
            while (true)
            {
                Console.Title = "クリック間隔測定";
                var sw = new System.Diagnostics.Stopwatch();

                if (GetAsyncKeyState(1) != 0)
                {
                    Console.WriteLine("LeftClick: クリックされました、測定しています。");
                    sw.Start();
                    while (true)
                    {
                        if (GetAsyncKeyState(1) == 0)
                            break;
                    }
                    sw.Stop();
                    Console.WriteLine("LeftClick: 結果: " + sw.ElapsedMilliseconds.ToString() + "ms");


                } else if (GetAsyncKeyState(5) != 0)
                {
                    Console.WriteLine("XBUTTON1: クリックされました、測定しています。");
                    sw.Start();
                    while (true)
                    {
                        if (GetAsyncKeyState(5) == 0)
                            break;
                    }
                    sw.Stop();
                    Console.WriteLine("XBUTTON1: 結果: " + sw.ElapsedMilliseconds.ToString() + "ms");


                } else if (GetAsyncKeyState(6) != 0)
                {
                    Console.WriteLine("XBUTTON2: クリックされました、測定しています。");
                    sw.Start();
                    while (true)
                    {
                        if (GetAsyncKeyState(6) == 0)
                            break;
                    }
                    sw.Stop();
                    Console.WriteLine("XBUTTON: 結果: " + sw.ElapsedMilliseconds.ToString() + "ms");


                }else if (GetAsyncKeyState(0x45) != 0)
                {
                    Console.WriteLine("E: クリックされました、測定しています。");
                    sw.Start();
                    while (true)
                    {
                        if (GetAsyncKeyState(0x45) == 0)
                            break;
                    }
                    sw.Stop();
                    Console.WriteLine("E: 結果: " + sw.ElapsedMilliseconds.ToString() + "ms");


                }





            }
        }
    }
}
