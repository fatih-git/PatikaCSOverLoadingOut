using System;
using System.ComponentModel;

namespace Deneme2
{
    class Program
    {
        static void Main(string[] args)
        {

            string isim = "Fatih";
            int a = 7;
            yazdir(a);
            yazdir(isim);

            int x=5;
            int y = 7;
            int z;
            int sonuc;

            sonuc = toplam(x, ref y, out z);
            Console.WriteLine(sonuc);
            Console.WriteLine(x+" "+y+" "+z);

            /*
             ref ve out pointer gibi çalışır.
             ref kullanırken fonksiyona verilecek değerin bir başlangıç değeri olması gerekmektedir.
             out böyle bir şey istemez.
             out ve ref arasındaki fark budur.
             */

        }

        //Overload
        public static void yazdir(int deger)
        {
            Console.WriteLine(deger);
        }
        public static void yazdir(string deger)
        {
            Console.WriteLine(deger);
        }

        //out kullanımı
        public static int toplam(int k, ref int l, out int m)
        {
            m = 7;
            l++;
            int sum = k + l + m;

            return sum;
        }

    }
}