using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int a =2;
            int b=3;
            Console.WriteLine(a+b);

            int sonuc= topla(a,b);
            Console.WriteLine(sonuc);
            
            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));

            int sonuc2= ornek.ArttirVeTopla(ref a, ref b);
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
            ornek.EkranaYazdir(Convert.ToString(a+b));
        }

        static int topla(int deger1, int deger2){
            return (deger1 + deger2);
                      
        }

    }

    class Metotlar{

        public void EkranaYazdir(string veri){

            Console.WriteLine(veri);
        }
        public int ArttirVeTopla(ref int veri1, ref int veri2){
             veri1++;
             veri2++;
             return veri1+veri2;
        }
    }
}
