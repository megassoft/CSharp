using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Class_operator_overloading
    {

       public int deger1;
       public int deger2;
       
       public Class_operator_overloading(int deger1, int deger2) 
       {
          this.deger1 = deger1;
          this.deger2 = deger2;
       }
        
       // sınıfların bütün fieldlarının sadece aynı olanlarının toplanmasını sağlar. mesela satış sınıfı olsun ve her birinin sattığı ürün sayısı ile fiyatları olsun.
       // tüm bu sınıfların satılan ürünlerin ile fiyatların toplamını veren yöntemdir
       // aşağıdaki operator overloading ifadelerini olduğu gibi başka class ın altına taşıyabiliriz ve oradan da çalışır. adreslemesi önemli değildir. önemli olan, parametrelerinden biri ilgili overloading ifadesinin içinde yazıldığı class ın kendisi olması gerekiyor.
       public static Class_operator_overloading operator +(Class_operator_overloading c1, Class_operator_overloading c2) 
       {
           return new Class_operator_overloading(c1.deger1 + c2.deger1, c1.deger2 + c2.deger2);
       }

       public static Class_operator_overloading operator +(Class_operator_overloading c1, int sayi)
       {
           return new Class_operator_overloading(c1.deger1, c1.deger2 + sayi);
       }

       public static Class_operator_overloading operator ++(Class_operator_overloading c1)
       {
           c1.deger1++;
           return c1;
       }
       
       public static Class_operator_overloading operator -(Class_operator_overloading c1)
       {
           c1.deger1 = -c1.deger1;
           return c1;
       }

       public static bool operator <(Class_operator_overloading c1, Class_operator_overloading c2)
       {
           
           if (c1.deger1 < c2.deger1)
           {
               return true;
           }
           else
           {
               return false;
           }
       }

       public static bool operator >(Class_operator_overloading c1, Class_operator_overloading c2)
       {

           if (c1.deger1 > c2.deger1)
           {
               return true;
           }
           else
           {
               return false;
           }
       }

       public static explicit operator int(Class_operator_overloading c1)
       {

           return c1.deger1;

       }

       public static explicit operator Class_operator_overloading(int c1)
       {

           return new Class_operator_overloading(c1, c1);

       }

       public override string ToString()
       {
          return(String.Format("{0} + {1}", deger1, deger2)); 
       }


    }
}
