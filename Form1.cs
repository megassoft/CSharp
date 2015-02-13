using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        static int? GetNullableInt()
        {
            return null;
        }

        static string GetStringValue()
        {
            return null;
        }

        private int deneme(){

            return default(int);

        }

        private void Form1_Load(object sender, EventArgs e)
        {


            Class_Lessons Conn = new Class_Lessons();
            Conn.test();


            //MessageBox.Show(Convert.ToString(deneme()));


            //--------------------------------------------------------------
            int x=5;
            int y=10;


            //--------------------------------------------------------------
            //string[] names={"kaya","test1"};

            //foreach (string item in names)
            //{
            //    MessageBox.Show(item);
            //}


            //--------------------------------------------------------------
            //for (int i = 0; i < 5; i++)
            //{
            //    if (i==2)
            //    {

            //        MessageBox.Show(i + " \"yok\"");
            //        continue;
                    
            //    }

            //    MessageBox.Show(Convert.ToString(i));
            //}


            //--------------------------------------------------------------
            //while (x < 10)
            //{

            //    MessageBox.Show(x.ToString());

            //    if (x == 8) break;
            //    x++;


            //}


            //--------------------------------------------------------------
            //if (x == 5 && y == 11) MessageBox.Show("Test"); else MessageBox.Show("Test2");


            //--------------------------------------------------------------
            //switch (x)
            //{

            //    case 5: case 6: case 9: case 15:
            //        MessageBox.Show("Test5-15");
            //        break;
            //    default:
            //        MessageBox.Show("Test-default");
            //        break;
            //}


            //--------------------------------------------------------------
            //try
            //{
            //    int v = 0;
            //    y = 10 / v;
                 
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //    throw;
                
                
            //}


            //--------------------------------------------------------------
            //int input = 5;
            //string classify;

            //// if-else construction.
            //if (input > 0)
            //    classify = "positive";
            //else
            //    classify = "negative";

            //// ?: conditional operator.
            //classify = (input > 0) ? "positive" : "negative";
            //MessageBox.Show(classify);


            //--------------------------------------------------------------
            //int? a = null;

            //// Set b to the value of a if a is NOT null; otherwise, 
            //// if a = null, set b to -1. 
            //int b = a ?? -1;

            //// Assign i to return value of the method if the method's result 
            //// is NOT null; otherwise, if the result is null, set i to the 
            //// default value of int. 
            //int i = GetNullableInt() ?? default(int);

            //string s = GetStringValue();
            //// Display the value of s if s is NOT null; otherwise,  
            //// display the string "Unspecified".
            //MessageBox.Show(s ?? "Unspecified");



            //--------------------------------------------------------------
            // float a = ~1;
            // Console.WriteLine ("TEST = " + a);


            //--------------------------------------------------------------
            //bool ss = false;

            //if (!ss)
            //{
            //    Console.WriteLine("1 " + ss);
            //}
            //else
            //{
            //    Console.WriteLine("2 " + ss);
            //}


            //--------------------------------------------------------------
            //return;
            Application.Exit();



        }
    }
}
