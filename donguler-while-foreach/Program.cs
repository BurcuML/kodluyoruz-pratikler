using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
           //while

            //1 den başlayarak consoledan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp yazdıran program.

          /*  Console.WriteLine("Sayı giriniz:");
            int sayi=int.Parse(Console.ReadLine());
            int sayac=1;
            int toplam=0;
            while(sayac<=sayi){
                toplam+=sayac;
                sayac++;
            }
            Console.WriteLine("Toplam:" + toplam/sayi);*/

            // a'dan z'ye kadar tüm harfleri console a yazdır.

           /* char character= 'a';
            while(character<'z'){
                Console.WriteLine(character);
                character++;
            } */

            Console.Write("***** Foreach *****");

            string[] arabalar= {"BMW", "Ford", "Toyota", "Nissan"};

            foreach(var araba in arabalar){

                Console.WriteLine(araba);
            }
        }
    }
}
