using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listduplicate
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> sayilar = new List<int>();
            int kackere = 1;

            Console.WriteLine("kaç sayı gireceksiniz?");
            int kacsayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("sayıları giriniz");
            Console.WriteLine(" ");

            for (int i = 0; i < kacsayi; i++)
            {
                sayilar.Add(Convert.ToInt32(Console.ReadLine()));
            }
            sayilar.Add(999999999);
            Console.WriteLine(" ");
            sayilar.Sort();

            for(int i = 1; i < sayilar.Count; i++)
            {
                if(sayilar[i] == sayilar[i - 1])
                {
                    kackere++;
                }
                else
                {
                    Console.WriteLine(kackere + " tane " + sayilar[i-1] + " var");
                    kackere = 1;
                }
                
            }
            
            Console.ReadLine();


        }
    }
}
