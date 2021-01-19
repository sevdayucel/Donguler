using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //string kurs1 = "yazılım geliştirici kampı";
            //string kurs2 = "programlamaya başlangıç kursu";
            //string kurs3 = "java kursu"; 
            //aynı işlem dizi ile yapılırsa
            string[] kurslar = new string[] { "yazılım geliştirici kampı", "programlamaya başlangıç kursu", "java kursu"};

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu-footer");
        }
    }
}
