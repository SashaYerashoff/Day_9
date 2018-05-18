using System;

namespace Day_9
{
    class Test
    {
		public int skaitlis;

        public int Saskaiti(int a, int b)
        {
			Izvadi();
			int c = Convert.ToInt32(Console.ReadLine());
			return a + b + c;
        }

		private void Izvadi()
		{
			Console.Write("Ievadi lūdzu skaitli:");
		}
    }
}
