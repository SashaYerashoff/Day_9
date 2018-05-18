using System;

namespace Day_9
{
    class Program
    {
        static void Main(string[] args)
        {
			Test TestaObjekts = new Test();
			int rezultats = TestaObjekts.Saskaiti(1, 2);
			Console.WriteLine("izvade no klases: {0}", rezultats);

			Test TestaObjekts2 = new Test();
			TestaObjekts.skaitlis = 3;
			TestaObjekts2.skaitlis = 6;
            
			Console.WriteLine("izvade no TestaObjekts: {0}", TestaObjekts.skaitlis);
			Console.WriteLine("izvade no TestaObjekts2: {0}", TestaObjekts2.skaitlis);
        }
    }
}
