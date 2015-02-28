using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class MyClass_Static
    {

        //fields for object initializers
        public int deger1;
        public string deger2;
        public string deger3;

        public static int ortak_alan;

        public MyClass_Static(string isim = "(optional) default isim")
        {

            MessageBox.Show("MyClass_Static constructors\noptional argument: " + isim);

        }

        //static constructor dan sonra ikinci olarak bu constructor devreye girer ve sınıfa ait nesnenin yeni değerlerin atanmasını sağlar.
        public MyClass_Static()
        {

            deger3 = "statik";

        }
 
        //constructor aşamasında ilk olarak static olanı çalışır ve sınıfa özgü alanların (field) değerlerinin atamasını yapar. Bu statik alanlar sınıfa ait nesne oluşturulmaya bağlı olmaksızın sınıfa ait oluşturulan bütün nesneler için ortaktır.
        static MyClass_Static()
        {

            ortak_alan = 10; 

        }

        public static void test_statik()
        {

            MessageBox.Show("static method");
            
        }

        public void ref_out_method()
        {

            double deger = 5.8;

            //ref parametresi ile metodu çağırırken argümana mutlaka daha önceden bir değer atanması gerekir
            //ek not: eğer static method üzerinden çağrılsaydı o zaman çağırılan method da static olması gerekirdi
            int deger2 = (int)deger;    //cast yapılıyor

            test_ref(ref deger2);
            MessageBox.Show(Convert.ToString("ref method " + deger2));
            //-----------------------------------------------------------------------------------------------------

            //ref parametresinden tek farkı değişkene hiç değer atamadan metodu çağırıp geriye değer yolluyor
            //ek not: eğer static method üzerinden çağrılsaydı o zaman çağırılan method da static olması gerekirdi
            int deger3;

            test_ref(ref deger2, out deger3);
            MessageBox.Show(Convert.ToString("ref method " + deger2 + "\nout method " + deger3));
            //-----------------------------------------------------------------------------------------------------

        }

        public void params_methot()
        {

            //params olarak tanımlanan parametreye istenildiği kadar argument atanabilir
            //buradaki önemli olan parametrelerde sadece bir kere params tanımlanabilir ve birden fazla parametre tanımlanmışsa mutlaka en sondaki parametre olarak verilmelidir

            string[] adlar = new string[10];
            for (int i = 0, j=10; i < adlar.Length; i++, j++)
            {
                adlar[i] = "isim" + j;
            }

            test_params(adlar);
            test_params("deneme1", "deneme2", "deneme3");
            test_params(1, "test2", "test2");
            
        }


        private void test_params(params string[] name)
        {

            MessageBox.Show(name[2]);

        }

        private void test_params(int tur, params string[] name)
        {

            MessageBox.Show(tur + " " + name[1]);

        }

        private void test_ref(ref int name)
        {

            name = name + 100;
            
        }

        private void test_ref(ref int name, out int name2)
        {

            name = name + 1;
            name2 = 900;

        }

    }

    class Class_Connection
    {
        
        protected int x;
        protected int z;
        public int y;
        private int _sayiAl;

        public Class_Connection()
        {
            
            x = 10;
            _sayiAl = 500;

        }

        protected void test_protected()
        {

            MessageBox.Show("protected method");

        }
         
        
        public int sayiAl
        {
            get {
                _sayiAl++;
                return _sayiAl;
            }
            set { 
                _sayiAl = value; 
            }
        }

        //Auto-Implemented Properties
        public string isimAl { get; set; }

        public int deneme()
        {

            return 1;

        }

        public bool deneme2()
        {

            return false;

        }


    }


    class Class_Lessons: Class_Connection
    {

        int x=80;

        public Class_Lessons()
        {

            isimAl = "kaya";  //inherit edilmiş field
            MessageBox.Show(isimAl);

            Class_this test1 = new Class_this();
            Class_this test2 = new Class_this(50);
            Class_this test4 = new Class_this(10, "Sam");

            Perl test3 = new Perl("parametreye argument olarak 'this' ile bir sınıf atama testi");
        
            MyClass_Static.test_statik();

            MessageBox.Show(Convert.ToString("static constructor: " + MyClass_Static.ortak_alan));  //inherit edilmiş static constructor

            MessageBox.Show("base class x: " + Convert.ToString(base.x));
            MessageBox.Show("current class x: " + Convert.ToString(this.x));

            MyClass_Static reftest = new MyClass_Static { deger1 = 555, deger2 = "deger atama" };
            reftest.ref_out_method();
            reftest.params_methot();

            //object initializers
            MessageBox.Show("MyClass_Static class deger1: " + reftest.deger1 + "\n" + "MyClass_Static class deger2: " + reftest.deger2);

            //
            Console.WriteLine(factR(3));
            displayrev("bu bir denemedir");

        }
        
        public void test()
        {

            //zaten inheritance olarak alındığı için nesne tanımlamaya gerek yok
            //Class_Connection a = new Class_Connection();

            MessageBox.Show(Convert.ToString(x)); //inherit edilmiş class - protected değişken

            test_protected(); //inherit edilmiş class methodu - protected metod

            sayiAl = 680; //inherit edilmiş class methodu - get set property
            MessageBox.Show(Convert.ToString(sayiAl)); //inherit edilmiş class methodu - get set property


            if (!(deneme() == 1)) //inherit edilmiş class methodu
            {
                MessageBox.Show("if deneme " + "true");
            }
            else
            {
                MessageBox.Show("if deneme " + "false");
            }


            if (!deneme2()) //inherit edilmiş class methodu
            {
                MessageBox.Show("if deneme2 " + "true");
            }
            else
            {
                MessageBox.Show("if deneme2 " + "false");
            }


            //Operator Overloading------------------------------------------------------
            Class_operator_overloading num1 = new Class_operator_overloading(20, 30);
            Class_operator_overloading num2 = new Class_operator_overloading(50, 60);  
            
            Class_operator_overloading sum = num1 + num2;

            Console.WriteLine("First complex number:  {0}", num1);
            Console.WriteLine("Second complex number: {0}", num2);
            Console.WriteLine("The sum of the two numbers: {0}", sum);

            Console.WriteLine(num1++);
            Console.WriteLine(-num1);

            Class_operator_overloading sum2 = num1 + 100;
            Console.WriteLine("The sum of the two numbers: {0}", sum2);

            if (num1 < num2)
            {
                Console.WriteLine("num1 < num2");
            }
            else
            {
                Console.WriteLine("num1 > num2");
            }


            //Explicit - num1++
            Class_this num_this = new Class_this();
            Class_this num_this2 = new Class_this();

            //burada class tek başına parametre olarak aşırı yüklendiği için otomatik olarak aktarılır. ancak tek şartla o da aktarıldığı değerin değişken tipi implicit ile aynı olmalı
            //maalesef diğer overlofing olan operatorler çalıştıktan sonra (num1++ gibi) ardından tekrar implicit operatoru otomatik çalışacaktır. ama Explicit operatorü değişken dönüşümü ( requires cast ) bildirilmediği sürece ( (int)num1 gibi ) otomatik gelmez ve bu yöntem daha iyidir
            int xImplicit;
            xImplicit = num_this;

            //burada ise implicit operatorü çalışmaz çünkü implicit operatorü aşırı yüklemesinde sadece int tanımlandığı için çalışmaz ve normal class aktarılması işlemi yapılır
            num_this2 = num_this;

            Console.WriteLine("Implicit: " + xImplicit);

            //Explicit operatorü açık olarak hangi değişkene döndürülmesi gerektiği bildirilmedilir. implicit gibi değişken dönüşümü ( requires cast ) bildirilmediği sürece ( (int)num1 gibi ) otomatik devreye girmez. daha güvenlidir.
            Console.WriteLine("Explicit class to int: " + (int)num1);

            int xExplicit = 10;
            Console.WriteLine("Explicit int to class: " + (Class_operator_overloading)xExplicit);

            Class_operator_overloading explicitClass = (Class_operator_overloading)xExplicit;
            Console.WriteLine("Explicit int to class2: " + explicitClass.deger1 + " ve " + explicitClass.deger2);

            //------------------------------------------


            //-------------------------------------------------------------------------


        }

        //recursive method
        public void displayrev(string str)
        {

            if (str.Length>0)
            {

                displayrev(str.Substring(1, str.Length - 1));
                
            }
            else
            {
                
                return;

            }

            Console.Write(str[0]);

        }

        //recursive method
        public int factR(int n)
        {

            int result;

            if (n == 1) return 1;

            result = factR(n - 1) * n;

            return result;

        }

        ~Class_Lessons()
        {

            Console.WriteLine("Class_Lessons: çıkış");

        }


    }

}
