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

        public MyClass_Static(string isim = "(optional) default isim")
        {

            MessageBox.Show("MyClass_Static constructors\noptional argument: " + isim);

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

            isimAl = "kaya";
            MessageBox.Show(isimAl);

            Class_this test1 = new Class_this();
            Class_this test2 = new Class_this(50);
            Class_this test4 = new Class_this(10, "Sam");

            Perl test3 = new Perl("parametreye argument olarak 'this' ile bir sınıf atama testi");
        
            MyClass_Static.test_statik(); 

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

        //~Class_Lessons()
        //{


        //}


    }

}
