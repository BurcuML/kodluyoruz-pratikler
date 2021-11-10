using System;

namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Lütfen bir sayı giriniz:");
            int sayac= int.Parse(Console.ReadLine());
            for(int i=1; i<=sayac; i++){
                if(i%2==1)
                  Console.WriteLine(i);
            }

            int tekToplam=0;
            int ciftToplam=0;
            for(int i=1; i<=1000; i++){

                if(i%2==0)
                  ciftToplam+=i;
                  

                  else
                  tekToplam+=i;    
            }

            Console.WriteLine("Çift:"+ ciftToplam);
            Console.WriteLine("Tek:"+ tekToplam); */

            for(int i=1; i<=10; i++){

                if(i==4)
                  break;
                  Console.WriteLine(i);
            }

             for(int i=1; i<=10; i++){

                if(i==4)
                  continue;
                  Console.WriteLine(i);
            }

            //sonsuz döngü
             for(;;){

                if(i==4)
                  break;
                  Console.WriteLine(i);
            }
        }
    }
}
