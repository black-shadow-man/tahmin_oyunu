using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tahmin_oyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("tahmin oyununa hosgeldiniz.\n" +
                "simdi ben bir sayi tuttum sende bu sayiyi tahmin et.");
            tahmin_oyunu();
        }
        public static void tahmin_oyunu()
        {
            Random random = new Random();
            int tutulan_sayi = random.Next(1, 10);
            int tahmin_hakki = 5;

            while (true)
            {
                
                    Console.Write("hangi sayiyi tuttum: ");
                    int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi == tutulan_sayi)
                {
                    Console.WriteLine("sayiyi dogru tahmin ettiniz. tebrikler...");
                    Console.WriteLine("tuttugum sayi: " + tutulan_sayi);
                    break;
                }
                else if (sayi > tutulan_sayi)
                {
                    tahmin_hakki--;
                    if (tahmin_hakki == 0)
                    {
                        Console.WriteLine("tahmin hakkinizi doldurdunuz...");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("tahmin hakkiniz: " + tahmin_hakki);
                    }
                    Console.WriteLine("daha kucuk bir sayi giriniz...");
                    
                }
                else if (sayi < tutulan_sayi)
                {
                    tahmin_hakki--;
                    if (tahmin_hakki == 0)
                    {
                        Console.WriteLine("tahmin hakkinizi doldurdunuz...");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("tahmin hakkiniz: " + tahmin_hakki);
                    }
                    Console.WriteLine("daha buyuk bir sayi giriniz..");
                    
                }
                
            }
            
        }
    }
}
