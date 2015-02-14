using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Class_this
    {

        //overloaded constructor initializer
        //default initialize
        //diyelim ki new ile instance yaratırken parametresiz tanımlarsak o zaman default olarak this ifadesi ile belirlediğimiz parametreleri overloaded olan constructor a aktaracaktır
        //bir başka avantajı new ile çağırıldığında diğer constructor ların da çalışması için çağırılan yerde satır yazmak yerine bir kere yazılıp direkt this ile yönlendirme yapılmış olur
        
        public Class_this() : this(-1, "noname")
        {

            Console.WriteLine("default constructor911");

        }

        public Class_this(int weight) : this (weight, "temp")
        {

            Console.WriteLine("Constructor1 weight = {0}", weight);

        }

        public Class_this(int weight, string name)
        {

            Console.WriteLine("Constructor2 weight = {0}, name = {1}", weight, name);

        }

        public void yeni2(int weight, string name)
        {

            Console.WriteLine("yeni2");

        }


        public void yeni3(int weight, string name)
        {

            Console.WriteLine("yeni3");

        }

        public void yeni4(int weight, string name)
        {

            Console.WriteLine("yeni4");

        }

    }

    class Net
    {
        public string Name { get; set; }

        public Net(Perl perl_sinifi)
        {
            // Use name from Perl instance.
            // this kullanılmasa da olur. Çünkü parametre adı ile lokal değişken adı aynı olmadığından gerekli değildir
            this.Name = perl_sinifi.Name;
        }
    }


    class Perl
    {
        public string Name { get; set; }

        public Perl(string name)
        {
            // this kullanılmasa da olur. Çünkü parametre adı ile lokal değişken adı aynı olmadığından gerekli değildir
            this.Name = name;

            // Pass this instance as a parameter!
            Net net = new Net(this);

            // The Net instance now has the same name.
            Console.WriteLine(net.Name);
        }
    }

}
